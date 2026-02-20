using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Film
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Фильм: {Title}, Год: {Year}, Режиссёр: {Director}, Рейтинг: {Rating}");
        }

        public void ShowRating()
        {
            Console.WriteLine($"Рейтинг фильма '{Title}': {Rating}/10");
        }
        public virtual void Play()
        {
            Console.WriteLine($"Начало фильма: {Title}");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"Остановка фильма: {Title}");
        }
        public void Pause()
        {
            Console.WriteLine($"Фильм '{Title}' на паузе");
        }
        public void Rewind()
        {
            Console.WriteLine($"Перемотка фильма '{Title}' на 10 секунд");
        }
    }
}
