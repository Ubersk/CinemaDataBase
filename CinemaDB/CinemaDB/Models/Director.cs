using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public string DirectorMiddleName { get; set; }
        public Movie Movies { get; set; }
    }
}
