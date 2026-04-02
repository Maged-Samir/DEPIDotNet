using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        //Student/DisplayContent
        public ContentResult DisplayContent()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "This is our Simple Content";
            //return result;
            return Content("This is our Simple Content");
        }
        //Student/DisplayJson
        public JsonResult DisplayJson()
        {
            //JsonResult j = new JsonResult(new { Id = 101, Name = "Esraa" });
            //return j;
            return Json(new { Id = 101, Name = "Esraa" });
        }
        //Student/DisplayView
        public ViewResult DisplayView()
        {
            //ViewResult result = new ViewResult();
            //result.ViewName = "myView";
            //return result;
            return View("myView");
        }
        public IActionResult Display()
        {
            if (DateTime.Now.Month == 2)
            {
                return View("myView");
            }
            else
            {
                return Json(new { Id = 101, Name = "Esraa" });
            }
        }
        //Student/DisplayData
        public IActionResult DisplayData()
        {
            return View("myView");
        }

    }
}
