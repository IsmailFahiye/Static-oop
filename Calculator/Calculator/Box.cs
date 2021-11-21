using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    class Box
    {
        public double längd { get; set; }
        public double bredd { get; set; }
        public double höjd { get; set; }

        public double getVolym()
        {
            return längd * bredd * höjd;
        }

        public double getArea()
        {
            return längd * bredd;
        }
    }
}
