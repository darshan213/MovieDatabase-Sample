using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDatabase.Service
{
    public class DataService
    {
        public string GetMovieConfirmation(string movie)
        {
            List<string> movie_list = new List<string>();
            movie_list.Add("Inception");
            movie_list.Add("Sultan");
            movie_list.Add("MissionImpossible");

            if (movie_list.Contains(movie))
            {
                return "exists";
            }
            else
            {
                return "Does not Exist";
            }

        }
    }
}