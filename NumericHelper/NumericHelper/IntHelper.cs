// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IntHelper.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    IntHelper.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace NumericHelper
{
    /// <summary>int 값 연산 기능 클래스</summary>
    public class IntHelper : INumericHelper<int>
    {
        /// <summary>값의 최대치를 가져옴</summary>
        /// <value>값의 최대치</value>
        public int MaxValue => int.MaxValue;

        /// <summary>값의 최소치를 가져옴</summary>
        /// <value>값의 최소치</value>
        public int MinValue => int.MinValue;

        /// <summary>두 값을 합함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>합한 결과 값</returns>
        public int Sum(int a, int b) => a + b;

        /// <summary>첫 번째 값에서 두 번째 값을 뺌</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>뺀 결과 값</returns>
        public int Subtract(int a, int b) => a - b;

        /// <summary>첫 번째 값에 두 번째 값을 곱함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>곱한 결과 값</returns>
        public int Multiply(int a, int b) => a* b;

        /// <summary>첫 번째 값에서 두 번째 값을 나눔</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>나눈 결과 값</returns>
        public int Subdivision(int a, int b) => a / b;
    }
}