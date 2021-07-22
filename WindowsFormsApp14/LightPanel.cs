using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class LightPanel
    {
        public double lightAmount { get; set; }
        public Polygon Polygon;
        public Color Color;
        public LightPanel(Polygon polygon, double LA)
        {
            lightAmount = LA;
            Polygon = polygon;
        }
        public double GetT(LineParam line)
        {
            return line.WithPlaneT(Polygon.PlaneDefault);
        }
    }
}
