using System;

namespace ArraysDemo
{
    public class Arrays
    {
        public static void Main()
        {
            //var numbers = new int[5];
            //numbers[2] = 43;
            //numbers[4] = 67;
            //int secondNumber = numbers[2];
            //Console.WriteLine(numbers[2]);

            //string text = " abc ";
            //Console.WriteLine(text.Trim());

            //var numbers = new string[5];
            //numbers[2] = " abc ";
            //Console.WriteLine(numbers[2].Trim());

            //INPUT NUMBER:
            //var numberOfElements = int.Parse(Console.ReadLine());
            //var numbers = new int[numberOfElements];

            ////saving values
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //}

            //reading values
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Examples
            //var index = 100;
            //
            //Console.WriteLine(numbers[numbers.Length] - 1);
            //numbers[index] = 5000;
            //
            //if (index >= 0 && index < numbers.Length )
            //{
            //    numbers[index] = 1000;
            //    Console.WriteLine(numbers[index]);
            //}


            ///////   Value VS Reference Types   //////

            /////1.Value Types:   

            //string text = "asasasa";
            //ValueVsReferenceTypes(text);
            //Console.WriteLine(text);    //RESULT = asasasa //

            //int number = 5;
            //ValueVsReferenceTypes(number);
            //Console.WriteLine(number);    // RESULT = 5 //

            //char symbol = 'a';
            //ValueVsReferenceTypes(symbol);
            //Console.WriteLine(symbol);   // RESULT = a //

            /////2.Reference Types:

            //var numbers = new int[5];
            //numbers[2] = 100;
            //ValueVsReferenceTypes(numbers);
            //Console.WriteLine(numbers[2]); // RESULT = 250 // !!



            //advancedExamples:

            //ReversedNumbersArray();
            //StringTextNumbersToIntegerNumbers();
            //EnglishAlphabet();
            //RemovingSomeSymbolsFromTextSPLIT();
            // DaysOfWeek();
            //JoinStringToIntegers();
            //MoreExamples();
           

        }

        public static void ReversedNumbersArray()
        {
            //var numberOfElements = int.Parse(Console.ReadLine());

            //var numbers = new int[numberOfElements];

            //for (int i = 0; i < numbers.Length; i++) //or numberOfElements instead of numbers.Length
            //{
            //    var currentNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = currentNumber;
            //}

            ////Printing numbers in Array's elements in reversed way
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            /////// Other Example:
            //int n = int.Parse(Console.ReadLine());
            //var numbers = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //var reverseNumbers = new int[numbers.Length];

            //for (int i = 0; i < n; i++)
            //{
            //    reverseNumbers[i] = numbers[numbers.Length - i - 1];
            //    Console.WriteLine(reverseNumbers[i]);
            //}



            /////More Optimized Solution for the same example:
            //int n = int.Parse(Console.ReadLine());
            //var numbers = new int[n];

            //var reverseNumbers = new int[numbers.Length];

            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    reverseNumbers[numbers.Length - i - 1] = numbers[i];
            //}



            ////Reverse numbers other examples:
            //var numbers = new int[] { 1, 2, 3, 4 };
            //var reversed = numbers.Reverse();
            //Console.WriteLine(string.Join(",", reversed));

            ////Min / Max number etc.
            //var numbers = new int[] { 1, 2, 3, 4 };
            //var reversed = numbers.Where(x => x % 2 == 0);  //// numbers.Max()  //// numbers.Average ////Четни: numbers.Where(x => x % 2 == 0); ///
            //Console.WriteLine(string.Join(",", reversed));    
            ////and//// Console.WriteLine(reversed);




            ////Another Reversing 
            //var numbers = new int[] { 5, 4, 3, 2, 1 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var temp = numbers[i];
            //    var reverseIndex = numbers.Length - 1 - i;
            //    numbers[i] = numbers[reverseIndex];
            //    numbers[reverseIndex] = temp;

            //}


            var n = int.Parse(Console.ReadLine());
            var jumps = int.Parse(Console.ReadLine());
            var solution = jumps % n;
            Console.WriteLine(solution);
        }

        public static void StringTextNumbersToIntegerNumbers()
        {
            //1,2,3,4,5

            //string text = "1 2 3 4";
            //string[] arrayOfNumbers = text.Split(' ');   // string[] or var


            //Examples За вадене на всеки отделен символ от "12345"
            //
            //string text = "12345";
            //var textArray = new char[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    textArray[i] = text[i];
            //}


            //Example
            //
            //string text = "1235";
            //Console.WriteLine(text[2]);


            // Първи начин: Превръщане на текст с числа(string) в истински числа (int)
            //string text = "1,2,3,4,5";
            //var splitText = text.Split(',');

            //var numbers = new int[splitText.Length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var currentText = splitText[i];
            //    var currentNumber = int.Parse(currentText);
            //    numbers[i] = currentNumber;
            //}



            //Втори начин: Превръщане на текст с числа(String) в истински числа(int)

            //string text = "1,2,3,4,5";
            //var splitText = text.Split(',').Select(int.Parse).ToArray();

        }

        public static void EnglishAlphabet()
        {
            // Първи вариант
            //var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();

            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    Console.WriteLine(alphabet[i]);
            //}


            //Втори вариант
            //var alphabet = new char[26];

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    alphabet[i - 'a'] = i;
            //}
            //Console.WriteLine(alphabet);
        }

        public static void RemovingSomeSymbolsFromTextSPLIT()
        {
            //Създаване на масив със влагане на самите му елементи, а не бройката им.
            //var numbers = new int[] { 1, 2, 3, 4 };  //or// int[] numbers = { 1, 2, 3, 4 }; //
            //var separators = new char[] { ',', '!', '.', ' ' };


            //Example:
            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //Split example:
            //var text = "Zdrasti, Az sym Nikolai! I sym na lekcia za masivi.";
            //var separators = new char[] { ',', '!', '.', ' ' };
            //var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);  //or// var words = text.Split(',', '!', '.', ' ');   //
            //or//var words = text.Split(new char[] { ',', '!', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //Този for-цикъл върши същата работа като foreach отгоре.
            //for (int i = 0; i < words.Length; i++)
            //{
            //    var word = words[i];
            //    Console.Write(word);
            //}


            //More Examples:
            //var text = "abcd".ToCharArray();
            //text[2] = 't';
            //var secondText = new string(text);  //Ще стане: "abtd" //

        }

        public static void DaysOfWeek()
        {
            //string[] days =
            //{
            //    "Mon",
            //    "Tue",
            //    "Wed",
            //    "Thu",
            //    "Fri",
            //    "Sat",
            //    "Sun"
            //};

            //int index = int.Parse(Console.ReadLine());
            //if (index < 1 || index > days.Length )
            //{
            //    Console.WriteLine("No such day!");
            //}
            //else
            //{
            //Console.WriteLine(days[index - 1]);
            //}
        }

        public static void ValueVsReferenceTypes(int[] n)// Value Types: (string n) или (int n) или (char n) //
        {
            //Value Types (със String):
            //n = "Changed";

            //Value Types (със int):
            //n = 100;

            //Value Type (със Char):
            //n = 'b';

            //Reference Type (Array Int[]):
            //n[2] = 250;


            //Other Examples of VALUE vs REFERENCE TYPE:
            //var a = 5;
            //var b = a;
            //b = 100;
            //Console.WriteLine(a);    // РЕЗУЛТАТА = 5  ( а -> запазва себе си)

            //var a = new int[5];
            //var b = a;
            //b[3] = 100;
            //Console.WriteLine(a[3]);  // РЕЗУЛТАТА = 100   //
        }

        public static void JoinStringToIntegers()
        {
            // 1 2 3 4

            var numbers = new int[] { 1, 2, 3, 4 };

            var result = string.Join(", ", numbers);    //За нов ред: Environment.Newline// or// "\n"

            Console.Write(result);
        }

        public static void MoreExamples()
        {
            var numbers = new int[10];

            var secondNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                secondNumbers[i] = numbers[i];
            }
        }

    }
}
