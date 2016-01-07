// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Envelope.cs" company="Conaonda">
//    Copyright (C) 2016 Conaonda
//  </copyright>
//  <summary>
//    Envelope.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace Geometry
{
    using NumericHelper;

    /// <summary>사각형 형태 영역 정보 관리 클래스</summary>
    /// <typeparam name="T">값의 유형</typeparam>
    /// <typeparam name="THelper">연산 기능 확장 클래스</typeparam>
    internal class Envelope<T, THelper> : Rectangle<T, THelper>, IEnvelope<T>
        where THelper : INumericHelper<T>, new()
    {
        /// <summary>기본 생성자</summary>
        public Envelope()
            : base(helper.MaxValue, helper.MaxValue, helper.MinValue, helper.MinValue)
        {
        }

        /// <summary>다른 영역 객체를 포함하도록 영역을 확장</summary>
        /// <param name="other">다른 영역 객체</param>
        public void Expand(IRectangle<T> other)
        {
            this.StartX = helper.Min(this.StartX, other.StartX);
            this.StartY = helper.Min(this.StartY, other.StartY);

            this.EndX = helper.Max(this.EndX, other.EndX);
            this.EndY = helper.Max(this.EndY, other.EndY);
        }
    }
}