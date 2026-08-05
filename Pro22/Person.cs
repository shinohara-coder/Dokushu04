using System;
using System.Collections.Generic;
using System.Text;

namespace Pro22
{
    /// <summary>
    /// 人物の情報を表す
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// 人物の苗字
        /// </summary>
        public string? firstName;

        /// <summary>
        /// 人物の名前
        /// </summary>
        public string? lastName;

        /// <summary>
        /// 氏名を表示する
        /// </summary>
        /// <param name="Age">年齢</param>
        /// <returns>氏名と年齢に基づいて整形された文字列</returns>
        public string Show(int Age)
        {
            return $"名前は{lastName}{firstName}、{Age}歳です。";

        }
    }
}
