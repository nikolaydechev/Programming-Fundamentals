namespace _7.MultiplyBigNumber
{
    using System;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string bigNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            var num = int.Parse(Console.ReadLine());

            if (bigNumber == "0" || num == 0 || bigNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            var productOfDigits = 0;
            var remainder = 0;
            var numberInMind = 0;
            var result = new StringBuilder();

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                productOfDigits = int.Parse(bigNumber[i].ToString()) * num + numberInMind;
                numberInMind = productOfDigits / 10;
                remainder = productOfDigits % 10;
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
        }
    }
}