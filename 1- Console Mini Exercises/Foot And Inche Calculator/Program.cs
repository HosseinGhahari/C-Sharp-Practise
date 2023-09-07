

public class ourprogram
{

    static int foot,inche;
    static double footTometer, footTocm, incheTometer, incheTocm;
    

    static void read()
    {
        Console.WriteLine("Enter Foot : ");
        foot = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Inche : ");    
        inche = Convert.ToInt32(Console.ReadLine());
    }

    static void calculate()
    {
        footTometer = foot * 0.3048;
        footTocm = foot * 30.48;

        incheTometer = inche * 0.0254;
        incheTocm = inche * 2.54;

    }

    static void write()
    {
        Console.WriteLine("\n");
        Console.WriteLine(" the " + foot + " foot is " + footTometer + " meter ");
        Console.WriteLine(" the " + foot + " foot is " + footTocm + " centimeter ");
   
        Console.WriteLine(" the " + inche + " inche is " + incheTometer + " meter ");
        Console.WriteLine(" the " + inche + " inche is " + incheTocm + " centimeter ");
    }
    
    static void Main()
    {
        read();
        calculate();
        write();
    }



}




