using System;
using System.Collections.Generic;

namespace ttt.Models
{
    public class GenresList
    {
        public List<Genre> Genres { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
