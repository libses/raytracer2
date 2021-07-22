using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Ray
    {
        public LineDefault LineDefault;
        public LineParam LineParam;
        public double Intensity;
        public Color Color;
        public Ray(LineParam lineParam)
        {
            LineParam = lineParam;
        }
    }
}
