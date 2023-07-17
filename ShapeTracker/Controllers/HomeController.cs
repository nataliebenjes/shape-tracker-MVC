using ShapeTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShapeTracker.Controllers
// namespace ShapeController
{
    public class ShapeController: Controller
    {
        // get a form to get inputs, then on submit take user to next view which will show the type of triangle

        [Route("/basepage")]
        // [Get("/")]

        // ActivePage 
        public ActionResult BasePage()
        {
            // should be a form to gather the sides
            Triangle newTriange = new Triangle(1,2,3);
            return View(newTriange);
        }

        [Route("/yo")]
        // [Get("/")]

        // ActivePage 
        public string hi()
        {
            return "hi";
        }
    }
}