using Lib.ShapesFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ShapesFactory.Shapes
{
    public sealed class Circle : BaseShape
    {
        private CircleModel circleModel;
        public Circle(CircleModel model) 
        {
            circleModel = model;
        }
        public override double CalculateArea()
            => Math.PI * Math.Pow(circleModel.Radius, 2);
    }
}
