using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieDatabase.Service;

namespace MovieDatabase.Controllers
{
    public class HttpController : Controller
    {
        [HttpPost]
        public JsonResult InsertMovie(string MovieName, string MovieYear, string MovieTime, string MovieLanguage, string MovieRelease, string 
            MovieCountry, string Actors, string Directors)//string are connecting from the index.html. We are also getting this infromation when we click on the button.
        {

            Console.WriteLine(MovieName, MovieYear, MovieTime, MovieLanguage, MovieRelease, MovieCountry, Actors, Directors);

            return Json("NA", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public string CheckMovie(string MovieName)//string are connecting from the index.html. We are also getting this infromation when we click on the button.
        {
            DataService DataService = new DataService();
            string message = DataService.GetMovieConfirmation(MovieName);
            return message;
        }
    }
}