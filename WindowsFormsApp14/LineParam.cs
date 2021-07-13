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
        
        public LineParam(Vector v1, Vector v2)
        {
            Direction = (Vector)(v2 - v1);
            Point = v1;
        }
        public Vector WithPolygon(Polygon poly)
        {
            throw new NotImplementedException();
        }
    }
}
