

// 4- Your job is to write a program for a speed camera.
// For simplicity, ignore the details such as camera, sensors,
// etc and focus purely on the logic. Write a program that asks
// the user to enter the speed limit. Once set, the program asks
// for the speed of a car. If the user enters a value less than the
// speed limit, program should display Ok on the console. If the value
// is above the speed limit, the program should calculate the number of
// demerit points. For every 5km/hr above the speed limit, 1 demerit points
// should be incurred and displayed on the console. If the number of demerit
// points is above 12, the program should display License Suspended.



namespace If_and_Swtich
{
    class Exercises
    {
        static void Main(string[] args)

        {

            int SpeedLimit;
            int CarSpeed;
            int demerit = 1;
            int result;
            Console.WriteLine("Enter Speed Limit : ");
            SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Speed of the car : ");
            CarSpeed = Convert.ToInt32(Console.ReadLine());

            if (CarSpeed < SpeedLimit)
            {
                Console.WriteLine("Nice Driving");
            }

            else if (CarSpeed > SpeedLimit)
            {

                result = CarSpeed - SpeedLimit;
                demerit = result / 5;
                Console.WriteLine("Number of Demerit is : " + demerit);

            }

            if (demerit > 12)
            {
                Console.WriteLine("Your license is Suspended");
            }

        }
    }
}