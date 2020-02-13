namespace _6.SumBigNumbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            var secondNumber = Console.ReadLine().TrimStart(new char[] { '0' });

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }
            
            int sumOfDigits = 0;
            int numberInMind = 0;
            int remainder = 0;
            var result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sumOfDigits = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString()) + numberInMind;
                numberInMind = sumOfDigits / 10;
                remainder = sumOfDigits % 10;
                result.Append(remainder);

                if (i == 0 && numberInMind > 0)
                {
                    result.Append(numberInMind);
                }
            }

            var resultToCharArray = result.ToString().ToCharArray();

            for (int i = resultToCharArray.Length - 1; i >= 0; i--)
            {
                Console.Write(resultToCharArray[i]);
            }
            Console.WriteLine();

            //Array.Reverse(resultToCharArray);
            //Console.WriteLine(new string (resultToCharArray));
        }
    }
}
