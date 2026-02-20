using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ConsoleApp3
{
    public class Actions : Film
    {
        public string Genre { get; set; }
        public int Duration { get; set; } 
        public override void Play()
        {
            Console.WriteLine($"Начало фильма '{Title}' жанра {Genre} Длительность: {Duration}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Фильм остановлен '{Title}' остановлено. Жанр: {Genre}");
        }
        public new void Pause()
        {
            Console.WriteLine($"Фильм '{Title}' на паузе. Нажмите любую клавишу для продолжения...");
        }

        public new void Rewind()
        {
            Console.WriteLine($"Перемотка фильма '{Title}' с учётом жанра {Genre} на 20 секунд вперёд");
        }
        public void ShowGenreAndDuration()
        {
            Console.WriteLine($"Жанр: {Genre}, Длительность: {Duration} минут");
        }
    }
}

