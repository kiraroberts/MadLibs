using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form() {return View(); } 

        [Route("/output")]
        public ActionResult Output(string noun, string adjective, string verb, string adverb) 
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