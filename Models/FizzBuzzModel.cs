using System.Collections.Generic;

namespace YourNamespace.Models
{
    public class FizzBuzzModel
    {
        public List<string> Numbers { get; set; }

        public FizzBuzzModel()
        {
            Numbers = new List<string>();
            GenerateFizzBuzz();
        }

        private void GenerateFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Numbers.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Numbers.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Numbers.Add("Buzz");
                }
                else
                {
                    Numbers.Add(i.ToString());
                }
            }
        }
    }
}