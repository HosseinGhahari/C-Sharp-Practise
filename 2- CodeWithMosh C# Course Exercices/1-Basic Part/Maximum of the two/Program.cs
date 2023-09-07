

///2- Write a program which takes two numbers from the 
///console and displays the maximum of the two.




namespace If_and_Swtich
{
    class Exercises
    {
        static void Main(string[] args)

        {

          int num1;
          int num2;

          Console.WriteLine("Enter 1 : ");
          num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter 2 : ");
          num2 = Convert.ToInt32(Console.ReadLine());

          if (num1 > num2)
          {
              Console.WriteLine(num1 + " is bigger ");
          }
          else
          {
              Console.WriteLine(num2 + " is bigger");
          }


        }
    }
}