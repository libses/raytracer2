using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Wall : ISurface
    {
        public Vector Reflect(Vector v)
        {
            throw new NotImplementedException();
        }
        public Color Color { get; set; }
        public double Reflectiveness { get; set; }

        public Polygon Polygon;
    }
}
