// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IRectangle.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    IRectangle.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace Tester
{
    /// <summary>사각형 정보 관리 인터페이스</summary>
    /// <typeparam name="T">사각형의 위치, 크기에 대한 자료형</typeparam>
    public interface IRectangle<T>
    {
        /// <summary>시작 X 위치</summary>
        T StartX { get; set; }

        /// <summary>시작 Y 위치</summary>
        T StartY { get; set; }

        /// <summary>끝 X 위치</summary>
        T EndX { get; set; }

        /// <summary>끝 Y 위치</summary>
        T EndY { get; set; }

        /// <summary>가로 크기</summary>
        T Width { get; }

        /// <summary>세로 크기</summary>
        T Height { get; }
    }
}