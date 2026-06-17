using System.Web.Mvc;
using MVCVoter.Models;

namespace MVCVoter.Controllers
{
    public class VoterController : Controller
    {
        // GET: Voter/Register — show the registration form
        public ActionResult Register()
        {
            return View();
        }

        // POST: Voter/Register — handle form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Voter voter)
        {
            if (ModelState.IsValid)
            {
                // Store voter in TempData to pass to Display view
                TempData["Voter"] = voter;
                return RedirectToAction("Display");
            }
            // Validation failed — return to form with errors
            return View(voter);
        }

        // GET: Voter/Display — show submitted voter details
        public ActionResult Display()
        {
            Voter voter = TempData["Voter"] as Voter;
            if (voter == null)
                return RedirectToAction("Register");
            return View(voter);
        }
    }
}
