

// 2- Write a program and ask the user to enter a few numbers 
// separated by a hyphen. If the user simply presses Enter,
// without supplying an input, exit immediately; otherwise, 
// check to see if there are duplicates. If so, display "Duplicate" on the console.






namespace Working_With_Text
{
    public class Exercises
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter some Number separated by (-)");
            var Input = Console.ReadLine();

            var list = new List<int>();

            if (Input == "")
            {
                Console.WriteLine("Programe is Closed");
                return;
            }

            else
            {
                foreach (var i in Input.Split('-'))
                {
                    list.Add(Convert.ToInt32(i));
                }
                list.Sort();
            }

            bool test = true;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    test = false;
                    break;
                }
            }

            if (test)
            {
                Console.WriteLine("its ok");
            }
            else
            {
                Console.WriteLine("it's Dupplicated");
            }
            


        }

    }

}