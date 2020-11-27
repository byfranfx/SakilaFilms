using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaFilms
{
    public class FilmModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Title}, {Description}, {Length}'.";
        }
    }
}
