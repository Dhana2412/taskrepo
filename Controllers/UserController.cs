using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>
        {
           new User(){UserId=1,UserName="sam",UserPwd="sam@123",UserEmail="sam@gmail.com"},
              new User(){UserId=2,UserName="Ram",UserPwd="ram@123",UserEmail="ram@gmail.com"},
                new User(){UserId=3,UserName="Raj",UserPwd="raj@123",UserEmail="raj@gmail.com"},
                  new User(){UserId=4,UserName="sandra",UserPwd="san@123",UserEmail="sandra@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
            }
            return RedirectToAction("Index");
        }
       
    }
    }
       
    

    

