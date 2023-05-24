namespace Prog_120_S23_L13_Arrays_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hi Class



        } // Main



        public static void Demonstration()
        {
            string[] _names = new string[]
            {
                "Benel",
                "Mo",
                "David",
                "Nancy",
                "Ivan",
                "Will"
            };

            int index = 0;

            while(index < _names.Length)
            {
                Console.WriteLine(_names[index]);
                index++;
            } // End Whiles
        }

        public static void PopulatingAnArray()
        {
            Console.Write("Enter a number: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] numArray = new int[numberOfElements];

            int index = 0;

            while(index < numArray.Length)
            {
                numArray[index] = ( index + 1)  * 2;
                index++;
            }

            index = 0;
            while(index < numArray.Length)
            {
                Console.WriteLine(numArray[index]);
                index++;
            }
        }

    } // class

} // namespace

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

// How do I get the number of ELEMENTS in the array, and why is this important?
// You can get the number of elements by using arrayName.Length. This will return how many items are in the list
// [5,2,2,1,3,4,5] // This has 7 elements, the index is 0 thru 6

// This is important because when you are looping through your array you almost always use the condition
// currentIndex < arrayName.Length
// 

// What error do you get if your index goes out of bounds?
// IndexOutOfBoundsError
// This just means you want to check your loops and code and make sure your not trying to pass in an index that is too high or low
// _names = new string[] {"Will", "Sam", "Frank"};
// Will is at index 0
// Sam at index 1
// Frank index 2
// _names[4] - This throws an error because our array only contains 3 elements. It would have to be made with a size of atleast 5 to have an index 4