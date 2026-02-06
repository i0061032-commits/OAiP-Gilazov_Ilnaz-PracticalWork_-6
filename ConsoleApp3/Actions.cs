using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ConsoleApp3
{
    internal class Actions : Film
    {
        public string Genre { get; set; }
        public override void Play()
        {
            Console.WriteLine($"Включается фильм: {Title} жанра {Genre}");
        }
        public new void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public new void Rewind()
        {
            Console.WriteLine("Перемотка на 10 сек");
        }
    }
}
