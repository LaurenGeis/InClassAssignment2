using System;

namespace InClassAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumber = 345790;

            var characterArray = decimalNumber.ToString().ToCharArray();
            var result = 0;
            var maxpower = characterArray.Length;
            var counter = 0;

            foreach (var item in characterArray)
            {

                var digit = int.Parse(item.ToString()) * 10 ^ (maxpower - 1);
                var power = Math.Pow(10, maxpower - ++counter);
                result = result + (int)(digit * power);

                Console.WriteLine(item);

            }
            Console.WriteLine(result);
        }
    }
}
