//////////////////////////////// Driving License Test App ///////////////////////////////////
// اگر 3 تا غلط زد تو تست شما قبول نشدید


namespace practise;

class program
{

    public static void Main(string[] args)
    {

        int Score = 0;
        string N;
        string AnswerA = "a";
        string AnswerB = "b";
        string AnswerC = "c";
        string AnswerD = "d";

        Console.WriteLine("Welcome To Driver License Test");
        Console.WriteLine("\n");


        Console.WriteLine("1- Highest Speed in High Way ? ");
        Console.WriteLine("(a) : 110 Km " + "     " + "(b) : 90 Km" + "      " + "\n" + "(c) : 140 Km " + "     " + "(d) : 120 Km ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {
            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("1- Highest Speed in High Way ? ");
            Console.WriteLine("(a) : 110 Km " + "     " + "(b) : 90 Km" + "      " + "\n" + "(c) : 140 Km " + "     " + "(d) : 120 Km ");
            N = Convert.ToString(Console.ReadLine());
        }

        switch (N)

        {
            case "d":
                Score = Score + 10;
                break;
        }


        Console.WriteLine("\n");
        Console.WriteLine("2- when driver take his left hand up , what is that mean ? ");
        Console.WriteLine("(a) : going to left " + "     " + "(b) : trying to stop " + "      " + "\n" + "(c) : going to right " + "     " + "(d) : danger sign ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {
            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("2- when driver take his left hand up , what is that mean ? ");
            Console.WriteLine("(a) : going to left " + "     " + "(b) : trying to stop " + "      " + "\n" + "(c) : going to right " + "     " + "(d) : danger sign ");
            N = Convert.ToString(Console.ReadLine());
        }

        switch (N)
        {
            case "a":
                Score = Score + 10;
                break;
        }






        Console.WriteLine("\n");
        Console.WriteLine("3- lowest speed in alley ? ");
        Console.WriteLine("(a) : 60 Km " + "     " + "(b) : 30 Km " + "      " + "\n" + "(c) : 20 Km " + "     " + "(d) : 15Km ");
        N = Convert.ToString(Console.ReadLine());


        while (N != "b" && N != "a" && N != "c" && N != "d")
        {

            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("3- lowest speed in alley ? ");
            Console.WriteLine("(a) : 60 Km " + "     " + "(b) : 30 Km " + "      " + "\n" + "(c) : 20 Km " + "     " + "(d) : 15Km ");
            N = Convert.ToString(Console.ReadLine());

        }
        switch (N)
        {

            case "b":
                Score = Score + 10;
                break;
        }



        Console.WriteLine("\n");
        Console.WriteLine("4- witch one does not cold the car ? ");
        Console.WriteLine("(a) : Thermostat " + "     " + "(b) : Radiator " + "      " + "\n" + "(c) : Crankshaft " + "     " + "(d) : Fan ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {

            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("4- witch one does not cold the car ? ");
            Console.WriteLine("(a) : Thermostat " + "     " + "(b) : Radiator " + "      " + "\n" + "(c) : Crankshaft " + "     " + "(d) : Fan ");
            N = Convert.ToString(Console.ReadLine());

        }

        switch (N)
        {
            case "c":
                Score = Score + 10;
                break;
        }



        Console.WriteLine("\n");
        Console.WriteLine("5- Handbrake as ..... and foot brake as ...... ? ");
        Console.WriteLine("(a) : Speed - Power " + "     " + "(b) : primary - secondary " + "      " + "\n" + "(c) : Power - Speed " + "     " + "(d) : Secondary - Primary ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {
            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("5- Handbrake as ..... and foot brake as ...... ? ");
            Console.WriteLine("(a) : Speed - Power " + "     " + "(b) : primary - secondary " + "      " + "\n" + "(c) : Power - Speed " + "     " + "(d) : Secondary - Primary ");
            N = Convert.ToString(Console.ReadLine());
        }

        switch (N)
        {
            case "d":
                Score = Score + 10;
                break;
        }



        Console.WriteLine("\n");
        Console.WriteLine("6- when car want to turn around to left how much distance should he use Signal Light ");
        Console.WriteLine("(a) : 250 meter " + "     " + "(b) : 100 meter " + "      " + "\n" + "(c) : 300 meter " + "     " + "(d) : 50 meter ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {
            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("6- when car want to turn around to left how much distance should he use Signal Light ");
            Console.WriteLine("(a) : 250 meter " + "     " + "(b) : 100 meter " + "      " + "\n" + "(c) : 300 meter " + "     " + "(d) : 50 meter ");
            N = Convert.ToString(Console.ReadLine());
        }

        switch (N)
        {
            case "b":
                Score = Score + 10;
                break;
        }



        Console.WriteLine("\n");
        Console.WriteLine("7- The task of generating electricity in car");
        Console.WriteLine("(a) : Fan " + "     " + "(b) : Suspension " + "      " + "\n" + "(c) : dynamo " + "     " + "(d) : All of them ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {

            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("7- The task of generating electricity in car");
            Console.WriteLine("(a) : Fan " + "     " + "(b) : Suspension " + "      " + "\n" + "(c) : dynamo " + "     " + "(d) : All of them ");
            N = Convert.ToString(Console.ReadLine());

        }

        switch (N)
        {
            case "c":
                Score = Score + 10;
                break;
        }



        Console.WriteLine("\n");
        Console.WriteLine("8- It is forbidden to overtake from a distance of several meters ?");
        Console.WriteLine("(a) : 50 meter  " + "(b) : 250 meter    " + "\n" + "(c) : 100 meter   " + "(d) : 80 meter");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {

            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("8- It is forbidden to overtake from a distance of several meters ?");
            Console.WriteLine("(a) : 50 meter  " + "(b) : 250 meter    " + "\n" + "(c) : 100 meter   " + "(d) : 80 meter");
            N = Convert.ToString(Console.ReadLine());
        }

        switch (N)
        {
            case "a":
                Score = Score + 10;
                break;
        }





        Console.WriteLine("\n");
        Console.WriteLine("9- Using colorful and flashing lights in the car? ");
        Console.WriteLine("(a) : it's ok  " + "(b) : it's ban    " + "\n" + "(c) : you can use it sometimes   " + "(d) : it's ban , if you have rights to use");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {

            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("9- Using colorful and flashing lights in the car? ");
            Console.WriteLine("(a) : it's ok  " + "(b) : it's ban    " + "\n" + "(c) : you can use it sometimes   " + "(d) : it's ban , if you have rights to use");
            N = Convert.ToString(Console.ReadLine());

        }

        switch (N)
        {
            case "d":
                Score = Score + 10;
                break;
        }




        Console.WriteLine("\n");
        Console.WriteLine("10- Duty of brake oil ?");
        Console.WriteLine("(a) : Brake cooling  " + "(b) : Brake lubrication   " + "\n" + "(c) : power transmission   " + "(d) : All if coreect ");
        N = Convert.ToString(Console.ReadLine());

        while (N != "b" && N != "a" && N != "c" && N != "d")
        {

            Console.WriteLine("\n");
            Console.WriteLine("wrong text");
            Console.WriteLine("\n");
            Console.WriteLine("10- Duty of brake oil ?");
            Console.WriteLine("(a) : Brake cooling  " + "(b) : Brake lubrication   " + "\n" + "(c) : power transmission   " + "(d) : All if coreect ");
            N = Convert.ToString(Console.ReadLine());

        }

        switch (N)
        {
            case "c":
                Score = Score + 10;
                break;
        }




        if (Score <= 80)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You did not pass , sorry , see you next time" + "\n" + "you score is : " + Score);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Congrat you passed " + "\n" + "you score is : " + Score);
            Console.WriteLine("\n");
        }


    }
}













