using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;


namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.Username;
                ViewBag.email= newUser.Email;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match! Try again!";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }


        }
    }
}
