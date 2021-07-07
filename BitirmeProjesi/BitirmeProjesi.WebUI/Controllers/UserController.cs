using BitirmeProjesi.Business.Abstract;
using BitirmeProjesi.CreditCardService.Model;
using BitirmeProjesi.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.WebUI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly IMessageService _messageService;
        private readonly UserManager<User> _userManager;
        private readonly ICircleService _circleService;
        private readonly IInvoiceService _invoiceService;
        private readonly ICreditCardService _creditCardService;
        private readonly IPaidBillsService _paidBillsService;
        public UserController(IMessageService messageService, UserManager<User> userManager, ICircleService circleService, IInvoiceService invoiceService, ICreditCardService creditCardService, IPaidBillsService paidBillsService)
        {
            _messageService = messageService;
            _userManager = userManager;
            _circleService = circleService;
            _invoiceService = invoiceService;
            _creditCardService = creditCardService;
            _paidBillsService = paidBillsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMessageToAdmin() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessageToAdmin(string Message) 
        {
            var user = await _userManager.GetUserAsync(User);
            _messageService.Create(new Entity.Message { User = user, UserMessage = Message });
            return View();
        }

        public async Task<IActionResult> GetAllInvoiceByUserId() 
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            var circles = _circleService.GetByUserIdWithUserAndInvoice(userId);
            return View(circles);
        }

        public IActionResult PayBill(int id) 
        {
            var invoice = _invoiceService.GetByIdWithUser(id);
            ViewBag.Invoice = invoice;
            ViewBag.TotalBill = invoice.Dues + invoice.ElectricityBill + invoice.GasBill + invoice.WaterBill;
            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> PayBill(CreditCardViewModel model,int InvoiceId) 
        {
            
            var invoice = _invoiceService.GetByIdWithUser(InvoiceId);
            if (ModelState.IsValid)
            {
                
                var result = await _creditCardService.WithdrawMoney(model);
                if (result == true)
                {
                    // silmeden önce ödenenler veritabanına al 
                    _paidBillsService.Create(new PaidBills 
                    { 
                        User = invoice.Circle.User,
                        Circle = invoice.Circle,
                        TotalBill = (int)(invoice.Dues + invoice.ElectricityBill + invoice.GasBill + invoice.WaterBill),
                        Dues = invoice.Dues,
                        ElectricityBill = invoice.ElectricityBill,
                        GasBill = invoice.GasBill,
                        WaterBill = invoice.WaterBill,
                        Month = invoice.Month
                        
                    });
                    _invoiceService.Delete(invoice);
                    return RedirectToAction("Index", "Home");

                }
            }


            // hata mesajı yolla
            ModelState.AddModelError("", "Kredi kartı bilgilerinizi kontrol ediniz veya bakiyenizi kontrol edin");
            ViewBag.TotalBill = invoice.Dues + invoice.ElectricityBill + invoice.GasBill + invoice.WaterBill;
            ViewBag.Invoice = invoice;
            return View();
        }

        
        
        

    }
}
