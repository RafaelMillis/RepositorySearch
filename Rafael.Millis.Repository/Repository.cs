using Newtonsoft.Json;
using Rafael.Millis.Models;
using Rafael.Millis.Models.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace Rafael.Millis.MovieRepository
{
    public class Repository : IRepository
    {
        /// <summary>
        /// Get All Movies
        /// </summary>
        public IEnumerable<Movie> GetMovies(string word) {
            //add task await
            string json = System.IO.File.ReadAllText(FullFilePath);
            movieJson = JsonConvert.DeserializeObject<MovieJson>(json);

            return Filter(word);
        }

        /// <summary>
        /// Filter Movie List
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public IEnumerable<Movie> Filter(string word)
        {
            if( !string.IsNullOrEmpty(word))
                return movieJson.Movies.Where(x => x.Name.Contains(word, StringComparison.OrdinalIgnoreCase));
            return movieJson.Movies;
        }

        private string FullFilePath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) +
                        "/data/movies.json";
            }
        }

        private MovieJson movieJson;
    }
}
