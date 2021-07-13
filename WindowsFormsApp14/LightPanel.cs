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
        public LightPanel(Polygon polygon, double LA)
        {
            lightAmount = LA;
            Polygon = polygon;
        }
    }
}
