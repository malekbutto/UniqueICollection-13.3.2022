using System;
using System.Collections;
public class UniqueCollectionPractice
{
    public static void Main()
    {
        UniqueCollection<string> gUniqueCollecList = new UniqueCollection<string>();
        string input = showOptions();
        while (input != "q")
        {
            switch (input)
            {
                case "a":   //Add
                    {
                        Console.Write("Enter new value to add to the List: ");
                        string newValue = Console.ReadLine();
                        while (!validInput(newValue))
                            newValue = Console.ReadLine();
                        if (gUniqueCollecList.Contains(newValue))
                            throw new Exception("\"" + newValue + "\" is already exists!");
                        try
                        {
                            gUniqueCollecList.Add(newValue);
                        }
                        catch (FormatException e)
                        {
                            throw new Exception("\"" + newValue + "\" is already exists!" + e.Message);
                        }
                        Console.WriteLine("\"{0} ", newValue + "\" added successfully.");
                        break;
                    }
                case "d":   //Remove
                    {
                        Console.Write("Enter the value you want to remove: ");
                        string delVal = Console.ReadLine();
                        while (!validInput(delVal))
                            delVal = Console.ReadLine();
                        while (gUniqueCollecList.Contains(delVal))
                        {
                            Console.WriteLine("\"{0} ", delVal + "\" doesn't exist in the List");
                        }
                        if (gUniqueCollecList.Remove(delVal))
                            Console.WriteLine("\"{0} ", delVal + "\" deleted successfully.");
                        break;
                    }
                case "e":   //Enumerate
                    {
                        gUniqueCollecList.Enumerate();
                        break;
                    }
                case "b":   //Contains
                    {
                        Console.Write("Enter a value to check if it's exist in List: ");
                        string existVal = Console.ReadLine();
                        while (!validInput(existVal))
                            existVal = Console.ReadLine();
                        try
                        {
                            if (gUniqueCollecList.Contains(existVal))
                                Console.WriteLine("Yes, The List contains: " + existVal);
                            else
                                Console.WriteLine("No, The List doesn't contain: " + existVal);
                        }
                        catch (FormatException e)
                        {
                            throw new Exception("Input must be INT, " + e.Message);
                        }
                        break;
                    }
                case "c":   //Clear
                    {
                        gUniqueCollecList.Clear();
                        Console.WriteLine("The List cleared successfully");
                        break;
                    }
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            input = showOptions();
        }
        Console.WriteLine("Thank you, Good bye!");
    }
    public static string showOptions()
    {
        string USER_INPUT =
        @"
        Choose an option from the following list:
            a - Add
            d - Remove
            e - Enumerate
            b - Contains 
            c - Clear
            q - Quit
        Your option?";
        Console.WriteLine(USER_INPUT);
        return Console.ReadLine().Trim().ToLower(); ;
    }
    public static bool validInput(string val) //No Null input
    {
        if (val == "" || val == " ")
        {
            Console.WriteLine("Invalid input, no empty value");
            return false;
        }
        return true;
    }
}