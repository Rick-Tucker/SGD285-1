/********************************************************************
	created:	2017/01/28
	created:	28:1:2017   17:09
	filename: 	Main.cs
	file path:	SGD285-1
	file base:	Main
	file ext:	cs
	author:		Bahram Dahi
	
	purpose:	This program is a simple C# app that displays 
                quotes from the students' favorite authors.

    Last Update: 
                . Added the UserQuote for Bahram Dahi
*********************************************************************/
using System;

public class SGD285_1
{
    // Do not modify this structure
    public struct UserQuote
    {
        public string Name;
        public string Quote;
        public UserQuote(string name, string quote)
        {
            Name = name;
            Quote = quote;
        }
    }

    // Main method
    public static void Main()
    {
        UserQuote[] userQuotes = new UserQuote[] {
            new UserQuote("Bahram Dahi", "I have never let my schooling interfere with my education. - [attributed to] Mark Twain"),
			new UserQuote("Ryan Douglass", "If there is no struggle there is no progress. - Frederick Douglass"),
				new UserQuote("Baylen Smith", "Whatever happens, happens. - Spike Spiegel"),
					new UserQuote("Jennifer Ethridge", "I have found a desire within myself that no experience in this world can satisfy; the most probable explanation is that I was made for another world."),
                    new UserQuote("Haley Sessions", "No road is long with good company. - Turkish Proverb"),
                    new UserQuote("Paola Gonzalez", "The roots of education are bitter, but the fruit is sweet. - Aristotle"),
                    new UserQuote("Dylan Zuniga", "All the love as always. H - Harry Styles")						
            // add the next user here using the formula above, don't forget the comma to separate the items in the initialization list. 
            // IMPORTANT: If there is a conflict, you MUST fix it, compile to make sure 
            // your program compiles and runs locally, then push to the git repository on GitHub.
        };

        // Do not modify below this line
        foreach (UserQuote item in userQuotes)
        {
            Console.WriteLine("My name is {0} and my favorite quote is: '{1}'", item.Name, item.Quote);
        }
        Console.WriteLine("\n");
    }
}
