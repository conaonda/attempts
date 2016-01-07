// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    Program.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace Tester
{
    using System;

    using Geometry;

    using NumericHelper;

    /// <summary>
    /// NumericHelper 테스트 프로그램
    /// </summary>
    public class Program
    {
        /// <summary>메인 함수</summary>
        private static void Main()
        {
            var rect1 = GeometryFactory<int, IntHelper>.CreateRectangle(-10, 0, 1, 20);
            var rect2 = GeometryFactory<int, IntHelper>.CreateRectangle(-20, 10, 5, 15);
            var env = GeometryFactory<int, IntHelper>.CreatEnvelope();
            env.Expand(rect1);
            env.Expand(rect2);

            Console.WriteLine("min : {0}, {1}", env.StartX, env.StartY);
            Console.WriteLine("max : {0}, {1}", env.EndX, env.EndY);

            Console.Read();
        }
    }
}