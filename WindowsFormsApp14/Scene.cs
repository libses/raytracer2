using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Scene
    {
        public List<ISurface> Surfaces = new List<ISurface>();
        public Camera Camera;
        public List<LightPanel> LightPanels = new List<LightPanel>();
    }
}
