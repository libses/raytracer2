using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Camera
    {
        public Vector Position;
        public Vector Direction;
        public double FOV;
        public int XRes;
        public int YRes;
        public Color[,] matrix;
        public Camera(int xRes, int yRes)
        {
            matrix = new Color[xRes, yRes];
            XRes = xRes;
            YRes = yRes;
        }
    }
}
