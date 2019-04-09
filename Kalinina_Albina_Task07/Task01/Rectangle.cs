using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle ... Height = {Height} Width ={Width} ");
            base.Draw();
        }           
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    
    }
}
