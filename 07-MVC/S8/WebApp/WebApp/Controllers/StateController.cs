using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StateController : Controller
    {
        #region TempData
        public IActionResult FirstAction()
        {
            TempData["msg"] = "data from first Action";
            return Content("First Action");
        }
        public IActionResult SecondAction()
        {
            //string incomingData = TempData["msg"].ToString();
            string incomingData = TempData.Peek("msg").ToString();
            return Content($"SecondAction & {incomingData}");
        }
        public IActionResult ThirdAction()
        {
            string incomingData = TempData["msg"].ToString();
            return Content($"ThirdAction & {incomingData}");
        }
        #endregion

        #region Session
        public IActionResult SetSession()
        {
            string name = "Mohamed";
            int age = 20;

            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);

            return Content("Session Created...");
        }

        public IActionResult GetSession()
        {
            string userName = HttpContext.Session.GetString("Name");
            int? userAge = HttpContext.Session.GetInt32("Age");

            return Content($"Your Data is => {userName} - {userAge} ");
        }
        #endregion

        #region Cookie
        public IActionResult SetCookie()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Append("Name", "Ahmed", options);
            Response.Cookies.Append("Age", "20");

            return Content("Cokkie Created ...");
        }
        public ActionResult GetCookie()
        {
            string name = Request.Cookies["Name"];
            string age = Request.Cookies["Age"];

            return Content($"Cokkie Created ... => {name} - {age}");
        }
        #endregion

        //Data Binding
        //View to Action
        //State/PassingData/99            //Route
        //State/PassingData?id=99         //QueryString
        //State/PassingData/Ahmed        //XXXXXXX
        //State/PassingData?name=Ahmed   //QueryString
        //State/PassingData/90?name=Ahmed&age=20    //Route&QueryString


        //public IActionResult PassingData(int id,string name,int age)
        //{
        //    return Content("Test...");
        //}

        [Route("Static/Depi")]
        public IActionResult PassingData(Department dept)
        {
            return Content("Test...");
        }

    }
}
