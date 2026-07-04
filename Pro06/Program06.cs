using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Pro06
{
    public interface IHoge
    {
        void Log(string msg)
        {
            Console.WriteLine($"Log: {msg}");
        }
    }

    public class Hoge : IHoge
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Hoge: {msg}");
        }
    }
    

    internal class LockBasic
    {
        static void Main(string[] args)
        {
            var h = new Hoge();
            ((IHoge)h).Log("任意のメッセージ");
            h.Log("クラスのメッセージ");
        }
    }   
}
