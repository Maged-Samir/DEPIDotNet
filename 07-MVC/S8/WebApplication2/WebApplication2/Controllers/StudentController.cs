using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        //Student/DisplayContent
        public IActionResult DisplayContent()
        {
            //ContentResult c = new ContentResult();
            //c.Content = "Hello World!";
            //return c;

            return Content("Hello World !");
        }
        //Student/DisplayJson
        public IActionResult DisplayJson()
        {
            //JsonResult j = new JsonResult(new { Id=101,Name="Ahmed" });
            //return j;
            return Json(new { Id = 101, Name = "Ahmed" });
        }
        //Student/DisplayView
        public IActionResult DisplayView()
        {
            //ViewResult v = new ViewResult();
            //v.ViewName = "myView";
            //return v;

            return View("myView");
        }

        public IActionResult Display()
        {
            if(DateTime.Now.Month < 2)
            {
                return View("myView");
            } else
            {
                return Json(new { Id = 101, Name = "Ahmed" });
            }
        }

        //Student/DisplayData
        public IActionResult DisplayData()
        {
            return View("displayData");
        }

    }
}
