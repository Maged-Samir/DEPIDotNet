using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class StateController : Controller
    {
        #region TempData
        //State/ FirstAction
        public IActionResult FirstAction()
        {
            TempData["msg"] = "data from First Action";
            return Content("FirstAction");
        }

        //State/SecondAction
        public IActionResult SecondAction()
        {
            //string incomingData =  TempData["msg"].ToString();
            string incomingData = TempData.Peek("msg").ToString();
            return Content($"SecondAction & incomingData :{incomingData} ");
        }
        //State/ThirdAction
        public IActionResult ThirdAction()
        {
            string incomingData = TempData["msg"].ToString();
            return Content($"ThirdAction & incomingData :{incomingData} ");
        }
        #endregion
        #region Session
        //Session
        public IActionResult SetSession()
        {
            string name = "Maged";
            int age = 200;

            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);

            return Content("Session Created ....");
        }
        public IActionResult GetSession()
        {
            string userName = HttpContext.Session.GetString("Name");
            int? userAge = HttpContext.Session.GetInt32("Age");

            return Content($"Your Session Data : {userName} - {userAge}");
        }

        #endregion    
        //Cookie

        public IActionResult SetCookie()
        {
             CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Append("Name", "Maged",options);
            Response.Cookies.Append("Age", "150");               

            return Content("Cookie Created ...");
        }
        public IActionResult GetCookie()
        {
           string name = Request.Cookies["Name"];
           string age = Request.Cookies["Age"];


            return Content($"Cookie Data : {name} - {age} ...");
        }
    }
}
