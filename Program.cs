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
            #region answer02
   
            var board = new SortedDictionary<int, string>();
            board.Add(500, "Ahmed");
            board.Add(200, "Sara");
            board.Add(800, "Ali");
            board.Add(350, "Mona");

            foreach (var p in board)
                Console.WriteLine(p.Key + " = " + p.Value);

            Console.WriteLine("First key: " + board.Keys.First());
            Console.WriteLine("First value: " + board.Values.First());

            Console.WriteLine(board.ContainsKey(500));

            if (board.TryGetValue(999, out var name))
                Console.WriteLine(name);
            else
                Console.WriteLine("Not found");

            board.Remove(200);
            foreach (var p in board)
                Console.WriteLine(p.Key + " = " + p.Value);
            #endregion
            #region answer03
       
            var phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Ahmed", "0100000001");
            phoneBook.Add("Sara", "0100000002");
            phoneBook.Add("Ali", "0100000003");
            phoneBook.Add("Mona", "0100000004");

            phoneBook["Omar"] = "0100000005";

            try
            {
                phoneBook.Add("Ahmed", "0111111111");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            bool added = phoneBook.TryAdd("Ahmed", "0111111111");
            Console.WriteLine("TryAdd succeeded? " + added);

            Console.WriteLine("Contains Zed? " + phoneBook.ContainsKey("Zed"));

            Console.WriteLine("Zed: " + phoneBook.GetValueOrDefault("Zed", "Not Found"));

            Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
            Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            #endregion
            #region answer04
            var emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine("Count: " + emails.Count);

            var a = new HashSet<int> { 1, 2, 3, 4, 5 };
            var b = new HashSet<int> { 4, 5, 6, 7, 8 };

            var union = new HashSet<int>(a);
            union.UnionWith(b);
            Console.WriteLine("Union: " + string.Join(", ", union));

            var intersect = new HashSet<int>(a);
            intersect.IntersectWith(b);
            Console.WriteLine("Intersect: " + string.Join(", ", intersect));

            var except = new HashSet<int>(a);
            except.ExceptWith(b);
            Console.WriteLine("Except: " + string.Join(", ", except));
            var small = new HashSet<int> { 1, 2 };
            Console.WriteLine("Is {1,2} a subset of A? " + small.IsSubsetOf(a));
            #endregion 

        }
    }
}
