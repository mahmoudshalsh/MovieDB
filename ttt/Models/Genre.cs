using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ttt.Models
{
    public class GenresList
    {
        public List<Genre> Genres { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre() { }
        public Genre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
