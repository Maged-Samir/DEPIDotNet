using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StateController : Controller
    {
        #region TempData
        // State/FirstAction
        public IActionResult FirstAction()
        {
            TempData["msg"] = "data from from First Action";
            return Content("First Action");
        }
        // State/SecondAction
        public IActionResult SecondAction()
        {
            //string incomingData = TempData["msg"].ToString();
            string incomingData = TempData.Peek("msg").ToString();
            return Content($"Second Action .... {incomingData}");
        }
        public IActionResult ThirdAction()
        {
            string incomingData = TempData["msg"].ToString();
            return Content($"Third Action .... {incomingData}");
        }
        #endregion

        #region Session
        public IActionResult SetSession()
        {
            string name = "Maged";
            int age = 50;

            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);

            return Content("Session Created ...");
        }

        public IActionResult GetSession()
        {
            string userName = HttpContext.Session.GetString("Name");
            int? userAge = HttpContext.Session.GetInt32("Age");

            return Content($"Your Session => {userName} - {userAge}");
        }
        #endregion

        #region Cookie
        public IActionResult SetCookie()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Append("Name", "Maged", options);
            Response.Cookies.Append("Age", "22");

            return Content("Cookie Created ...");
        }

        public IActionResult GetCookie()
        {
            string userName = Request.Cookies["Name"];
            string userAge = Request.Cookies["Age"];


            return Content($"Cookie Data => {userName} - {userAge}");
        }
        #endregion

        //Data Binding   (View to Action)

        //State/PassingData/101         //Route
        //State/PassingData?id=101         //query string
        //State/PassingData/ahmed       XXXXX
        //State/PassingData?name=Ahmed  //QueryString
        //State/PassingData?name=Ahmed&age=22  //QueryString
        //State/PassingData/101?name=ahmed&age=50

        //public IActionResult PassingData(int id ,string name,int age)
        //{
        //    return Content("Test");
        //}


        //State/PassingData?id=20&name=ITI&location=Giza
        public IActionResult PassingData(Department dept)
        {
            return Content("Test");
        }

    }
}
