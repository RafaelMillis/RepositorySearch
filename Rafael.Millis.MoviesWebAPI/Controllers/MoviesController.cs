using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Rafael.Millis.Models;
using Rafael.Millis.MovieRepository;


namespace Rafael.Millis.MoviesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        public MoviesController()
        {
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Movie> Search(string searchWord = "")
        {
           //should be adding some validation for best practice 

           Repository repo = new Repository();
           return repo.GetMovies(searchWord);
        }

    }
}
