using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class LineParam
    {
        public Vector Direction { get; set; }
        public Vector Point { get; set; }

        public LineParam() { }
        public LineParam(Vector v1, Vector v2)
        {
            Direction = (Vector)(v2 - v1);
            Point = v1;
        }
        public Vector WithPolygon(Polygon poly)
        {
            throw new NotImplementedException();
        }
        public double WithPlaneT(PlaneDefault plane)
        {
            return -((plane.A * Point.X + plane.B * Point.Y + plane.C * Point.Z + plane.D) /
                     (plane.A * Direction.X + plane.B * Direction.Y + plane.C * Direction.Z));
        }
    }
}
