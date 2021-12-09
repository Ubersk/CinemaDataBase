using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public float MovieDuration { get; set; }

        public List<Session> Songs { get; set; }
        public List<Director> Albums { get; set; }
        public List<Composer> Composers { get; set; }
    }
}
