// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Rectangle.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    Rectangle.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace Tester
{
    using NumericHelper;

    public class Rectangle<T, THelper> : IRectangle<T>
        where THelper : INumericHelper<T>, new()
    {
        private static readonly THelper helper = new THelper();

        public Rectangle(T startx, T starty, T endx, T endy)
        {
            this.StartX = startx;
            this.StartY = starty;
            this.EndX = endx;
            this.EndY = endy;
        }

        public T StartX { get; set; }

        public T StartY { get; set; }

        public T EndX { get; set; }

        public T EndY { get; set; }

        public T Width => helper.Subtract(this.EndX, this.StartX);

        public T Height => helper.Subtract(this.EndY, this.StartY);
    }
}