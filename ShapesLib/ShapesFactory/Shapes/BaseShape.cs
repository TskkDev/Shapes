using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ShapesFactory.Shapes
{
    public abstract class BaseShape : IShape
    {

        public virtual double CalculateArea()
            => 0;
    }
}
