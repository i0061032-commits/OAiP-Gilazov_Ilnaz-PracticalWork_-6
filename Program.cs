using ConsoleApp3;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {
        Actions film = new Actions
        {
            Title = "Гарри Поттер и Дары Смерти",
            Year = 2010,
            Director = "Дэвид Йейтс",
            Rating = 7.9,
            Genre = "Фэнтези",
            Duration = 146
        };


        Film baseFilm = film;  
        film.ShowInfo();           
        film.ShowRating();       
        film.ShowGenreAndDuration(); 
        film.Play();             
        film.Stop();          
        film.Pause();           
        film.Rewind();            
        baseFilm.ShowInfo();   
        baseFilm.ShowRating();   
        baseFilm.Play();         
        baseFilm.Stop();        
        baseFilm.Pause();      
        baseFilm.Rewind();    
        film.Pause();          
        baseFilm.Pause();     
        film.Play();         
        baseFilm.Play(); 
    }
}