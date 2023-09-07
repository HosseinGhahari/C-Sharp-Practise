

// این برنامه اعداد قدر مطلق عدد را برمیگرداند - با استفاده از متد
//
// this practise calculate and display the absolute value of a number



namespace BasicPractise
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Absolute Number is : " + Absolute(Number));
        }


        public static int Absolute(int Number)
        {
            int count = 0;
            if (Number > 0)
            {
                return Number;
            }
            else
            {
                for (int i = Number; i < 0; i++)
                {
                    count++;
                }
            }
            return count;


        }



    }
}

