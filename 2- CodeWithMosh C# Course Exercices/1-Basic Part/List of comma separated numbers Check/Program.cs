

// 5- Write a program and ask the user to supply a list of comma
// separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty
// or includes less than 5 numbers, display "Invalid List" and
// ask the user to re-try; otherwise, display the 3 smallest numbers in the list.




namespace Arrays_and_Lists
{
    class Exercises
    {

        static void Main(string[] args)
        {

            string[] Elements;
            while (true)
            {
                Console.WriteLine("Enter some numbers spearated with comma : ");
                var input = Console.ReadLine();
                Elements = input.Split(',');


                if (Elements.Length == 0 || Elements.Length <= 4)
                {
                    Console.WriteLine("Invalid , Plz Try Again ");
                    continue;
                }

                var Test = new List<int>();

                foreach (var i in Elements)
                {
                    Test.Add(Convert.ToInt32(i));
                    Test.Sort();
                }

                Test.RemoveRange(3, 2);
                Console.Write("Smallest Numbers are : ");
                foreach (int b in Test)
                {
                    Console.Write(b);
                }
                break;
            }
            

        }
    }
}
