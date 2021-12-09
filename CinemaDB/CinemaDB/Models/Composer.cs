using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB.Models
{
    public class Composer
    {
        public int ComposerId { get; set; }
        public string ComposerFirstName { get; set; }
        public string ComposerLastName { get; set; }
        public string ComposerMiddleName { get; set; }
        public Movie Movies { get; set; }
    }
}
