using ShapeTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShapeTracker.Controllers
// namespace ShapeController
{
    public class ShapeController : Controller
    {
        // get a form to get inputs, then on submit take user to next view which will show the type of triangle

        [Route("/basepage")]
        // [Get("/")]

        // ActivePage 
        public ActionResult BasePage(int side1, int side2, int side3)
        {
            // should be a form to gather the sides
            Triangle newTriange = new Triangle(side1, side2, side3);
            return View(newTriange);
        }
        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/")]
        public string Hi()
        {
            return "sample home";
        }
        [Route("/HeyYou")]
        public string Hey()
        {
            return "Hey You";
        }
    }
}