using ConsoleApp3;
using static System.Net.WebRequestMethods;
using System;
class Program
{
    static void Main(string[] args)
    {
        Actions film = new Actions();
        Film baseFilm = film;
        film.Title = "Гарри Поттер и Дарыы Смерти";
        film.Year = 2010;
        film. Genre = "Фэнтези";

        film.ShowInfo(); 
        film.Play();     
        film.Pause();    
        film.Rewind();   
        baseFilm.Pause();  
        baseFilm.Rewind(); 
    }
}