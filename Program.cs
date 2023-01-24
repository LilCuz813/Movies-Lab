using Movies_Lab;

List<Movie> movies = new List<Movie>()
{
    new Movie("Spider-Man: Into the Spider-Verse", "Animation", 2018),
    new Movie("Dragon Ball Super: Super Hero", "Animation", 2022),
    new Movie("One Piece Film: Red", "Action", 2022),
    new Movie("Demon Slayer: Kimestsu no Yaiba - The Movie: Mugen Train", "Action", 2020),
    new Movie("Boruto: Naruto the Moive", "Action", 2015),
    new Movie("M3GAN", "Horror", 2022),
    new Movie("Tokyo Ghoul", "Horror", 2017),
    new Movie("Friday", "Comedy", 1995),
    new Movie("Norbit", "Comedy", 2007),
    new Movie("Fat Albert", "Comedy", 2004),
};

Console.WriteLine("Welcome to the Movie Lister!");
//movies.Sort((x, y) => string.Compare(x.Title, y.Category));
movies = movies.OrderBy(m => m.Title).ToList();
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please choose a option:");
    Console.WriteLine("1. View All");
    Console.WriteLine("2. Show Movies by Name");
    Console.WriteLine("3. Show Movies by Category");
    Console.WriteLine("4. Show Movies by Year");
    Console.WriteLine("5. End");
    
    int choice = int.Parse(Console.ReadLine());

    if(choice == 1)
    {
        foreach(Movie m in movies)
        {
            Console.WriteLine(m.GetDetails());
        }
    }
    else if(choice == 2)
    {
        Console.WriteLine("What is the name of the movie you want to view?");
        string title = Console.ReadLine().ToLower().Trim();
        foreach(Movie m in movies.Where(s => s.Title.ToLower() == title))
        {
            Console.WriteLine(m.GetDetails());
        }
    }
    else if(choice == 3)
    {
        Console.WriteLine("What is the category of the movie you want to view?");
        string category = Console.ReadLine().ToLower().Trim();
        foreach(Movie m in movies.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(m.GetDetails());
        }
    }
    else if(choice == 4)
    {
        Console.WriteLine("What year was the movie made in?");
        int year = int.Parse(Console.ReadLine());
        foreach(Movie m in movies.Where(s => s.Year == year))
        {
            Console.WriteLine(m.GetDetails());
        }
    }
    else if(choice == 5)
    {
        runProgram = false;
        Console.WriteLine("Thanks for viewing!");
    }
}