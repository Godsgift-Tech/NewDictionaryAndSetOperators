
using NewDictionaryAndSetOperators;

class Program
{


    public static void Main(string[] args)

    {
        Console.WriteLine("Firt assignment=> Ten new words and meaning I have for you are");

        Console.WriteLine("***********************************************************************************************************************");

        //Creating and instance of the Words and Meaning class
        Wordsand_Meaning dictionary = new Wordsand_Meaning();

        //Printing out every word and their meaning stored in the dictionary
        dictionary.PrintWords();

        Console.WriteLine(" ");

        //Printing out ten new words and meaning using foreach

        Console.WriteLine("Second assignment=> Carrying out SetOperations on array of strings");

        Console.WriteLine("***********************************************************************************************************************");

        // Create an instance of the FoodClasses
        FoodClasses checkFood = new FoodClasses();

        // Calls out for the SetOperator Method
        checkFood.SetOperations();
        Console.WriteLine("***********************************************************************************************************************");

        Console.ReadKey();

    }
}
