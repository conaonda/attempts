// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="GeometryFactory.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    GeometryFactory.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace Geometry
{
    using NumericHelper;

    /// <summary>도형 생성기</summary>
    /// <typeparam name="T">값의 유형</typeparam>
    /// <typeparam name="THelper">연산 기능 확장 클래스</typeparam>
    public class GeometryFactory<T, THelper>
        where THelper : INumericHelper<T>, new()
    {
        /// <summary>사각형을 생성</summary>
        /// <param name="startx">시작 X 좌표</param>
        /// <param name="starty">시작 Y 좌표</param>
        /// <param name="endx">끝 X 좌표</param>
        /// <param name="endy">끝 Y 좌표</param>
        /// <returns>사각형 인터페이스</returns>
        public static IRectangle<T> CreateRectangle(T startx, T starty, T endx, T endy)
        {
            return new Rectangle<T, THelper>(startx, starty, endx, endy);
        }

        /// <summary>영역 정보 관리 객체를 생성</summary>
        /// <returns>영역 정보 관리 객체</returns>
        public static IEnvelope<T> CreatEnvelope()
        {
            return new Envelope<T, THelper>();
        }
    }
}