using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Camera
    {
        public int Res;
        public Color[,] matrix;
        public Camera(int res)
        {
            matrix = new Color[res, res];
            Res = res;
        }
        public Color[,] GetLight()
        {
            for (double a = -0.78; a <= 0.78; a = a + 0.01)
            {
                for (double b = 0.78; b < 2.35; b = b + 0.01)
                {
                    var x = Math.Sin(a) * Math.Cos(b);
                    var y = Math.Sin(a) * Math.Sin(b);
                    var z = Math.Cos(a);
                    var v = new Vector(x,y,z);
                    var line = new LineParam(new Vector(0, 0, 0), v);
                }
            }
            throw new NotImplementedException();
        }
    }
}
