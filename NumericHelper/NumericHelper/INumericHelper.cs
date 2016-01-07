// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="INumericHelper.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    INumericHelper.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace NumericHelper
{
    /// <summary>값 연산 기능 클래스</summary>
    /// <typeparam name="T">값의 유형</typeparam>
    public interface INumericHelper<T>
    {
        /// <summary>값의 최대치를 가져옴</summary>
        /// <value>값의 최대치</value>
        T MaxValue { get; }

        /// <summary>값의 최소치를 가져옴</summary>
        /// <value>값의 최소치</value>
        T MinValue { get; }

        /// <summary>두 값을 합함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>합한 결과 값</returns>
        T Sum(T a, T b);

        /// <summary>첫 번째 값에서 두 번째 값을 뺌</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>뺀 결과 값</returns>
        T Subtract(T a, T b);

        /// <summary>첫 번째 값에 두 번째 값을 곱함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>곱한 결과 값</returns>
        T Multiply(T a, T b);

        /// <summary>첫 번째 값에서 두 번째 값을 나눔</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>나눈 결과 값</returns>
        T Subdivision(T a, T b);

        /// <summary>두 값 중에서 작은 값을 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>두 값 중에서 작은 값</returns>
        T Min(T a, T b);

        /// <summary>두 값 중에서 큰 값을 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>두 값 중에서 큰 값</returns>
        T Max(T a, T b);
    }
}