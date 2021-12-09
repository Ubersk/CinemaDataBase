using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Director> Directors { get; set; }
        public List<Composer> Composers { get; set; }
        public User Users { get; set; }
        public DateTime DateSession { get; set; }



    }
}
