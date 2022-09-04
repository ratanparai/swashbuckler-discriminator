using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscriminatorPoc;
using Swashbuckle.AspNetCore.Annotations;

namespace DiscriminatorPoc
{
    public abstract class Shape
    {
        public ShapeType  ShapeType { get; set; }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
    }
}