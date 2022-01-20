using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_19.Models
{
    static class LengthCircle
    {
        public static double Add(double r) => Math.Round((2 * Math.PI * r), 2);
    }
}
