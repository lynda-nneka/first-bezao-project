using System;


public class LibraryManagementsystemfunction
{
    public void RunLibraryManagementsystem()
    {


        Console.WriteLine($"Choose any letter below \nc\no\nd\ne");
        string letter = Console.ReadLine();
        string lowerCase = letter.ToLower();

        switch (letter)
        {
            case "c":
                Console.WriteLine("c# books");
                break;

            case "o":
                Console.WriteLine(".Net core books");
                break;

            case "d":
                Console.WriteLine("Cleaning code books");
                break;

            case "e":
                Console.WriteLine("EFcore books");
                break;

            default:
                Console.WriteLine("Try Again");
                break;

        }
    }
}


