using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Film
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Фильм: {Title}, Год: {Year}");
        }
        public virtual void Play()
        {
            Console.WriteLine($"Идёт фильм: {Title}");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Rewind()
        {
            Console.WriteLine("Перемотка на 10 сек");
        }
    }
}
