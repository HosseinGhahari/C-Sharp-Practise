

// Write a program and ask the user to enter a few words separated by a space. Use the words to 
// create a variable name with PascalCase convention. For example, if the user types: 
// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
// "NumberOfStudents". If the user doesn't supply any words, display "Error".



namespace Working_With_Text
{
    public class Exercises
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Words : ");
            var input = Console.ReadLine();
            var Names = input.Split(' ');

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            foreach (var name in input.Split(' '))
            {
                Console.Write(char.ToUpper(name[0]) + name.ToLower().Substring(1));
            }


        }
    }
}