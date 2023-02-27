using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;


namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
           [Route("/")]
        public ActionResult Madlibs()
        {
            MadlibsVariable myMadLibsVariable = new MadlibsVariable();
            myMadLibsVariable.FirstNoun = "john";
            myMadLibsVariable.FirstVerb = "trevir";
            return View(myMadLibsVariable);
        }
        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/MadLibsStory")]
        public ActionResult MadlibsStory(string firstNoun, string firstVerb, string adjective)
        {
            MadlibsVariable myMadLibsVariable = new MadlibsVariable();
            myMadLibsVariable.Adjective = adjective;
            myMadLibsVariable.FirstNoun = firstNoun;
            myMadLibsVariable.FirstVerb = firstVerb;
            return View(myMadLibsVariable);
        }

  }
}