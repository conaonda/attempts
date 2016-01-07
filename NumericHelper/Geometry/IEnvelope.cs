// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IEnvelope.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    IEnvelope.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace Geometry
{
    /// <summary>사각형 형태 영역 정보 관리 인터페이스</summary>
    /// <typeparam name="T">영역의 위치, 크기에 대한 자료형</typeparam>
    public interface IEnvelope<T> : IRectangle<T>
    {
        /// <summary>다른 영역 객체를 포함하도록 영역을 확장</summary>
        /// <param name="other">다른 영역 객체</param>
        void Expand(IRectangle<T> other);
    }
}