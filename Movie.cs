using System;
namespace Movies_Lab
{
	public class Movie
	{
		//Properties
		public string Title { get; set; }
		public string Category { get; set; }
		public int Year { get; set; }
		//Conductors
		public Movie(string _title, string _category, int _year)
		{
			Title = _title;
			Category = _category;
			Year = _year;
		}

        //Methods
		public string GetDetails()
		{
			return $"Title: {Title} Category: {Category} Year: {Year} ";
		}
    }
}

