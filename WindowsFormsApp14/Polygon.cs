using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Polygon
    {
        public List<Vector> Points;
        public PlaneDefault PlaneDefault;
        public Polygon(List<Vector> points)
        {
            var x0 = points[0].X;
            var y0 = points[0].Y;
            var z0 = points[0].Z;
            var x1 = points[1].X;
            var y1 = points[1].Y;
            var z1 = points[1].Z;
            var x2 = points[2].X;
            var y2 = points[2].Y;
            var z2 = points[2].Z;
            var x10 = x1 - x0;
            var y10 = y1 - y0;
            var z10 = z1 - z0;
            var x20 = x2 - x0;
            var y20 = y2 - y0;
            var z20 = z2 - z0;
            var xr = y10 * z20 - z10 * y20;
            var yr = z10 * x20 - z20 * x10;
            var zr = x10 * y20 - y20 * x10;
            var plane = new PlaneDefault();
            plane.A = xr;
            plane.B = yr;
            plane.C = zr;
            plane.D = -(x0 * xr + y0 * yr + z0 * zr);
            PlaneDefault = plane;
        }
    }
}
