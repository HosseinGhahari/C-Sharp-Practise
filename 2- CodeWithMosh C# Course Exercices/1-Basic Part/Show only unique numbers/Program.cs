

/// 3- Write a program and ask the user to enter 5 numbers.
/// If a number has been previously entered, display an 
/// error message and ask the user to re-try. Once the user 
/// successfully enters 5 unique numbers, sort them and display 
/// the result on the console.



namespace Arrays_and_Lists
{
    class Exercises
    {

        static void Main(string[] args)
        {

            int Count = 0;   
            var Remain = 5;
            var NameList = new List<int>();

            while (Count < 5)
            {
                Console.WriteLine("Enter Numbers -- " + Remain + " Numbers Left : ");
                var Numbers = Convert.ToInt32(Console.ReadLine());
                
                if (NameList.Contains(Numbers))
                {                  
                    Console.WriteLine("You Already Enter " + Numbers);
                    Console.WriteLine("\n");
                    continue;
                }
                NameList.Add(Numbers);
                NameList.Sort();
                Count++;
                Remain--;
            }

            Console.Write("Numbers are : ");
            foreach (int i in NameList)
            {
                Console.Write(i);
            }

        }
    }
}
