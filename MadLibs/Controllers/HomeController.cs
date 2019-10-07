using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form() {return View(); } 

         [Route("/output")]
        public ActionResult Puppy(string noun, string adjective, string verb, string adverb, string prompt) 
        {
            WordHolder words = new WordHolder();
            words.Noun = noun;
            words.Adjective = adjective;
            words.Verb = verb;
            words.Adverb = adverb;
            // words.Prompt = prompt;
            if (prompt == "puppy")
            {
                return View("~/Views/Home/Puppy.cshtml", words);
            }
            else if (prompt == "RV")
            {
                return View("~/Views/Home/RV.cshtml", words);
            }
            return View(words);
        }


        [Route("/puppy")]
        public ActionResult Puppy(string noun, string adjective, string verb, string adverb) 
        {
            WordHolder words = new WordHolder();
            words.Noun = noun;
            words.Adjective = adjective;
            words.Verb = verb;
            words.Adverb = adverb;
            return View(words);
        }
        [Route("/rv")]
        public ActionResult RV(string noun, string adjective, string verb, string adverb) 
        {
            WordHolder words = new WordHolder();
            words.Noun = noun;
            words.Adjective = adjective;
            words.Verb = verb;
            words.Adverb = adverb;
            return View(words);
        }
    }
}