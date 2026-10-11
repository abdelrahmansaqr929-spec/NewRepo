namespace Advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer01
            List<int> grades = new List<int>();
            grades.Add(85);
            grades.Add(92);
            grades.Add(78);
            grades.Add(95);
            grades.Add(88);
            grades.Add(70);
            grades.Add(100);
            grades.Add(65);

            Console.WriteLine("All grades:");
            foreach (int g in grades)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First: " + grades[0]);
            Console.WriteLine("Last: " + grades[grades.Count - 1]);

            grades.Sort();
            Console.WriteLine("\nSorted grades:");
            foreach (int g in grades)
            {
                Console.WriteLine(g);
            }

            foreach (int g in grades)
            {
                if (g > 90)
                {
                    Console.WriteLine("\nFirst grade above 90: " + g);
                    break;
                }
            }

            List<int> failing = new List<int>();
            foreach (int g in grades)
            {
                if (g < 75)
                {
                    failing.Add(g);
                }
            }
            Console.WriteLine("\nFailing grades:");
            foreach (int g in failing)
            {
                Console.WriteLine(g);
            }

            foreach (int g in failing)
            {
                grades.Remove(g);
            }
            Console.WriteLine("\nAfter removing failing grades:");
            foreach (int g in grades)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("\nContains 100? " + grades.Contains(100));

            List<string> gradeTexts = new List<string>();
            foreach (int g in grades)
            {
                gradeTexts.Add("Grade: " + g);
            }
            Console.WriteLine();
            foreach (string text in gradeTexts)
            {
                Console.WriteLine(text);
            }
            #endregion

        }
    }
}
