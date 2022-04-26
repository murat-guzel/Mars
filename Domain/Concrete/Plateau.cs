using Mars_Rover.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Domain.Concrete
{
    public class Plateau : IPlateau
    {
        public int Height { get; set; }
        public int Width { get; set; }

    }
}
