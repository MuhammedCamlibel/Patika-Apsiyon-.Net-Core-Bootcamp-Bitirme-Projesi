using BitirmeProjesi.Business.Abstract;
using BitirmeProjesi.Entity;
using BitirmeProjesi.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly ICircleService _circleService;
        private readonly IInvoiceService _invoiceService;
        private readonly IMessageService _messageService;
        private readonly IPaidBillsService _paidBillsService;

        public AdminController(UserManager<User> userManager, ICircleService circleService, IInvoiceService invoiceService, IMessageService messageService, IPaidBillsService paidBillsService)
        {
            _userManager = userManager;
            _circleService = circleService;
            _invoiceService = invoiceService;
            _messageService = messageService;
            _paidBillsService = paidBillsService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                var result = await _userManager.CreateAsync(new Entity.User { 
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    TCNO = model.TCNO,
                    Phone = model.Phone,
                    UserName=model.UserName,
                    CarPlate=model.CarPlate,
                    Email = model.Email
                },$"{model.UserName}_123");

                if (result.Succeeded) return RedirectToAction("Index", "Home");
            } 
            return View(model);
        }

        public IActionResult GetAllUser()
        {
            List<UserViewModel>  users = _userManager.Users.Select(u=> new UserViewModel{FirstName = u.FirstName,LastName=u.LastName,Id=u.Id}).ToList();
            
            return View(users);
        }

        public async  Task<IActionResult> GetUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }

        [HttpPost]
        public async  Task<IActionResult> DeleteUser(string Id) 
        {
            var user = await _userManager.FindByIdAsync(Id);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("GetAllUser");
        }

        public IActionResult CreateCircle() 
        {
            return View();
        }

        [HttpPost]
        public   IActionResult CreateCircle(CircleCreateViewModel model) 
        {
            //var user = await _userManager.GetUserAsync(User); ,User=user
            if (ModelState.IsValid) 
            {
                _circleService.Create(new Circle { Block = model.Block, Floor = model.Floor, Status = model.Status, Type = model.Type, Number = model.Number,UserType=model.UserType });
                return RedirectToAction("Index", "Home");
            }
            return View(model);
            
            
        } 

        public IActionResult GetAllCircle() 
        {
            var circles = _circleService.GetAll();
            return View(circles);
        }

        public IActionResult GetCircle(int id) 
        {
            var circle = _circleService.GetByIdWithUser(id);
            if(circle.User == null) 
            {
                ViewBag.CircleUser = "Daireye Kullanıcı Atanmamış";
                return View(circle);
            }
            ViewBag.CircleUser  = circle.User.UserName;
            return View(circle);
        }

        [HttpPost]
        public IActionResult DeleteCircle(int id) 
        {
            //
            var circle = _circleService.GetById(id);
            _circleService.Delete(circle);
            return RedirectToAction("GetAllCircle");
        }

        public async Task<IActionResult> UpdateUser(string id) 
        {
            ViewBag.UserId = id;
            var user = await _userManager.FindByIdAsync(id);
            var model = new UserCreateViewModel()
            {
                CarPlate = user.CarPlate,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                TCNO = user.TCNO,
                UserName = user.UserName
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserCreateViewModel model,string UserId) 
        {
            var user = await _userManager.FindByIdAsync(UserId);
            if (ModelState.IsValid) 
            {
                user.CarPlate = model.CarPlate;
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Phone = model.Phone;
                user.TCNO = model.TCNO;
                user.UserName = model.UserName;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded) 
                {
                    return RedirectToAction("GetAllUser");
                }
                return View(model);

            }
            return View(model);
        }

        public IActionResult UpdateCircle(int id) 
        {
            ViewBag.CircleId = id;
            var circle = _circleService.GetById(id);
            var model = new CircleCreateViewModel()
            {
                Block = circle.Block,
                Floor = circle.Floor,
                Number = circle.Number,
                Status = circle.Status,
                Type = circle.Type,
                UserType = circle.UserType
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateCircle(CircleCreateViewModel model,int CircleID) 
        {
            var circle = _circleService.GetById(CircleID);
            if (ModelState.IsValid) 
            {
                circle.Block = model.Block;
                circle.Floor = model.Floor;
                circle.Number = model.Number;
                circle.Status = model.Status;
                circle.Type = model.Type;
                circle.UserType = model.UserType;
                _circleService.Update(circle);
                return RedirectToAction("GetAllCircle");
            }
            return View(model);
        }

        public IActionResult AddUserToCircle(int id) 
        {
            ViewBag.CircleId = id;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> AddUserToCircle(string username,int CircleId)
        {
            var user = await _userManager.FindByNameAsync(username);
            var circle = _circleService.GetById(CircleId);

            if(user != null)
            {
                circle.User = user;
               _circleService.Update(circle);
                return RedirectToAction("GetAllCircle");
            }

            ViewBag.CircleId = CircleId;
            ModelState.AddModelError("", "Eklemek istediğiniz kullanıcı mevcut değil !");
  
            return View();

        }

        public IActionResult AddInvoiceToCircle(int id) 
        {
            ViewBag.CircleId = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddInvoiceToCircle(int CircleId,InvoiceCreateViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                var circle = _circleService.GetById(CircleId);

                 _invoiceService.Create(new Invoice 
                 {
                     Dues = model.Dues,
                     ElectricityBill = model.ElectricityBill,
                     GasBill = model.GasBill,
                     WaterBill = model.WaterBill,
                     Month=model.Month,
                     Circle=circle
                 });

                
                return RedirectToAction("GetAllCircle");

            }
            ViewBag.CircleId = CircleId;
            return View(model);
        }

        public IActionResult GetAllInvoice()
        {
            var invoices = _invoiceService.GetAllInvoiceByCircle();
            var groupbyModel = invoices.GroupBy(i => i.Month); 
            return View(groupbyModel);
        }

        public IActionResult GetAllMessage() 
        {
            var messages = _messageService.GetAllMessageByUser();
            return View(messages);
        }

        public IActionResult GetAllPaidBills() 
        {
            var model = _paidBillsService.GetAllPaidBillsWithUser();
            return View(model);
        }





    }
}
