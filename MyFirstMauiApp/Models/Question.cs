using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiApp.Models {
    public class Question {
        public string Description { get; set; }
        public bool Done { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
