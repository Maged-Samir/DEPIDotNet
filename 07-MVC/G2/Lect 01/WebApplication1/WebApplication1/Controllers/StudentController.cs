using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        //  Student/DisplayText
        //public string DisplayText()
        //{
        //    return $"Simple Text";
        //}

        // Student/DisplayContent
        public IActionResult DisplayContent()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Ahmed Mohamed";
            //return result;

            return Content("Ahmed Mohamed");
        }

        public IActionResult DisplayJson()
        {
            //JsonResult result = new JsonResult(new { Id = 1, Name = "Ahmed" });
            //return result;

            return Json(new { Id = 1, Name = "Ahmed" });
        }

        //Student/DisplayView
        public IActionResult DisplayView()
        {
            //ViewResult result = new ViewResult();
            //result.ViewName = "myView";
            //return result;

            return View("myView");
        }

        //Student/GetData
        public IActionResult GetData()
        {
            return View("GetData");
        }

    }
}
