namespace Prog_120_S23_L13_Arrays_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

// What is an array?
// An array is like a variable that allows you to group multiple of the same type of variable together by a single name, but seperated by a number ( the index )

// How do you create an array?
// Format: type[] name = new type[number of elements]; // You can pass in ANY type ( string, int, Random, anything )
// string[] _collectionOfStrings = new string[10]; // Creates an array of strings that can hold 10 elements

// How do you create an array loaded with elements?
// type[] _collectionFilledWithItems = new type[] { item1, item2, item3 };

// What is the number that you put in the square brackets?
// Thats number is called the "index". It is one of the most important numbers in all programming. 
// You use it to access the different values in different elements
// _collection[index] = value
// _collection[0] // Interacts with the very first element

// What is the first number in the array?
// Your index ALWAYS starts at 0