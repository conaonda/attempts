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

    using NumericHelper;

    /// <summary>
    /// NumericHelper 테스트 프로그램
    /// </summary>
    public class Program
    {
        /// <summary>메인 함수</summary>
        private static void Main()
        {
            var rect = new Rectangle<int, IntHelper>(0, 0, 1, 1);
            Console.WriteLine("width = {0}", rect.Width);
            Console.WriteLine("height = {0}", rect.Height);

            Console.Read();
        }
    }
}