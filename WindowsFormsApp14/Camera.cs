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
        public Color[,] GetLight(Scene scene)
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
                    var ray = new Ray(line);
                    ISurface minSurface = null;
                    double minTs = double.MaxValue;
                    foreach (var surface in scene.Surfaces)
                    {
                        var tempT = surface.GetT(line);
                        if (tempT < minTs && tempT > 0)
                        {
                            minSurface = surface;
                            minTs = tempT;
                        }
                    }
                    LightPanel minLight = null;
                    double minTl = double.MaxValue;
                    foreach (var light in scene.LightPanels)
                    {
                        var tempT = light.GetT(line);
                        if (tempT > 0 && tempT < minTl)
                        {
                            minLight = light;
                            minTl = tempT;
                        }
                    }
                    if (minTl < minTs)
                    {
                        //xM and yM is not defined
                        var xM = 0;
                        var yM = 0;
                        matrix[xM, yM] = minLight.Color;
                    } 
                    else
                    {
                        var tempV = minSurface.Reflect(ray.LineParam.Direction);
                        var newParamLine = new LineParam();
                        newParamLine.Direction = tempV;
                        newParamLine.Point = line.Point + line.Direction * minTs;
                        var newRay = new Ray(newParamLine);
                        newRay.Color = ray.Color * minSurface.Reflectiveness;
                    }
                }
            }
            throw new NotImplementedException();
        }
    }
}
