using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Color
    {
        public double R;
        public double G;
        public double B;
        public Color(double R, double G, double B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }
        public static Color operator *(Color color, double t)
        {
            return new Color(color.R * t, color.G * t, color.B * t);
        }
    }
}
