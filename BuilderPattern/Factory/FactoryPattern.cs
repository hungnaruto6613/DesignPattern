using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Factory
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y) 
        {
            this.x = x; this.y = y; 
        }
        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        //public static PointFactory Factory => new PointFactory();

        public static class PointFactory
        {
            // Factory method   
            public static Point NewCartersianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
}
