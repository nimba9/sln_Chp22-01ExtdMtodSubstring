using System;
using System.Text;

public static class ExtensionMethodForStringBuilder

{
    // extension methods are defined with static within a common static class
    // they allow us to extend functionality to to an already existing type
    // the first argument is the class or interface they extend preceded with "this"
    static StringBuilder Substring(this StringBuilder str, int index, int length)
    {
        StringBuilder buildStr = new StringBuilder();
        try
        {
            // getting the substring from given given and the length of the substring
            for (int i = index; i < index + length; i++)
            {
                buildStr.Append(str[i]);
            }
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Your input is an empty string");
        }
        return buildStr;
    }

    public static void CheckValidity(StringBuilder textInput)
    {
        //StringBuilder textInput = new StringBuilder();

        while (textInput.Length < 1)
        {
            Console.WriteLine("Enter a string to subtract from : ");

            textInput.Append(Console.ReadLine());
            if (textInput.Length < 1)
            {

                Console.WriteLine("Your input is an empty string");
            }
        }

        int starPosition = 0;
        bool validStartPos = false;

        while (!validStartPos)
        {
            Console.WriteLine("Please enter start possition: ");

            validStartPos = int.TryParse(Console.ReadLine(), out starPosition);

            if (!validStartPos || starPosition > textInput.Length)
            {
                validStartPos = false;
                Console.WriteLine("You have entered invalid possition.");
            }
        }

        int length = 0;
        bool validLength = false;

        while (!validLength)

        {
            Console.WriteLine("Please enter subtraction length: ");

            validLength = int.TryParse(Console.ReadLine(), out length);

            if (!validLength || length > textInput.Length - starPosition)

            {
                Console.WriteLine("You have entered invalid length.");

                validLength = false;
            }
        }

        string changedString = textInput.Substring(starPosition, length).ToString();

        Console.WriteLine(changedString);
    }

    public class MainProgram
    {
        public static void Main(string[] args)
        {
            StringBuilder teststr = new StringBuilder();
            CheckValidity(teststr);
        }
    }
}


    

