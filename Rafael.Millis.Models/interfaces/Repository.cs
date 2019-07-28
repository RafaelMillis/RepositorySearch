using System;
using System.Collections.Generic;
using System.Text;

namespace Rafael.Millis.Models.interfaces
{
    public interface IRepository
    {
        IEnumerable<Movie> GetMovies(string word);
        IEnumerable<Movie> Filter(string word);
    }
}
