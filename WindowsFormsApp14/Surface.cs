using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public interface ISurface
    {
        Vector Reflect(Vector v);
        Color Color { get; set; }
        double Reflectiveness { get; set; }
        double GetT(LineParam line);
    }
}
