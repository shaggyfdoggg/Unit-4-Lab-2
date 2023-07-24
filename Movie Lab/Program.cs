using Movie_Lab;

List<Movie> MovieList = new List<Movie>()
{
    new Movie("Die Hard", "action"),
    new Movie("Mad Max", "action"),
    new Movie("The Lion King", "animation"),
    new Movie("Toy Story", "animation"),
    new Movie("Monty Python and the Holy Grail", "comedy"),
    new Movie("Blazing Saddles", "comedy"),
    new Movie("Gone with the Wind", "drama"),
    new Movie("The Godfather", "drama"),
    new Movie("Star Wars", "scifi"),
    new Movie("Alien", "scifi"),
};

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 10 movies on this list.");
bool runProgram = true;
while (runProgram == true)
{
    Console.WriteLine("What category are you interested in?");
    string input = Console.ReadLine().Trim().ToLower();
    if (input == "action")
    {
        List<Movie> actionList = MovieList.Where(m => m.Category == "action").ToList();
        foreach (Movie a in actionList)
        {
            Console.WriteLine(a.MovieDetails());
        }
    }
    else if (input == "animation")
    {
        List<Movie> animationList = MovieList.Where(m => m.Category == "animation").ToList();
        foreach (Movie a in animationList)
        {
            Console.WriteLine(a.MovieDetails());
        }
    }
    else if (input == "comedy")
    {
        List<Movie> comedyList = MovieList.Where(m => m.Category == "comedy").ToList();
        foreach (Movie a in comedyList)
        {
            Console.WriteLine(a.MovieDetails());
        }
    }
    else if (input == "drama")
    {
        List<Movie> dramaList = MovieList.Where(m => m.Category == "drama").ToList();
        foreach (Movie a in dramaList)
        {
            Console.WriteLine(a.MovieDetails());
        }
    }
    else if (input == "scifi")
    {
        List<Movie> scifiList = MovieList.Where(m => m.Category == "scifi").ToList();
        foreach (Movie a in scifiList)
        {
            Console.WriteLine(a.MovieDetails());
        }
    }
    else
    {
        Console.WriteLine("Category not available. Please try again");
        continue;
    }
    while (true)
    {
        Console.WriteLine("Continue? y/n");
        string input2 = Console.ReadLine().Trim().ToLower();
        if (input2 == "y")
    {
            runProgram = true;
            break;
        }
        else if (input2 == "n")
        {
            Console.WriteLine("Goodbye");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid response. Please try again");
        }
    }
}