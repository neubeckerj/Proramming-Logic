using System;


namespace JNeubecker_1050_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string verify = "";
            while(verify != "yes")
            {
                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("What is your middle initial?");
                char middleInitial = char.Parse(Console.ReadLine());
                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();
                string fullName = firstName + " " + middleInitial + ". " + lastName;

                Console.Clear();

                Console.WriteLine("Hello" + " " + fullName + "!" + " " + "How old are you?");
                int age = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("How tall are you?");
                Console.WriteLine("Feet:");
                int heightFeet = int.Parse(Console.ReadLine());
                Console.WriteLine("Inches:");
                double heightInches = double.Parse(Console.ReadLine());
                double totalHeightCM = 2.54 * ((heightFeet * 12) + heightInches);

                Console.Clear();

                Console.WriteLine("Are you a citizen?");
                string citizenResponse = "";
                bool isCitizen = false;

                while (citizenResponse != "yes" && citizenResponse != "no")
                {
                    citizenResponse = Console.ReadLine();

                    if (citizenResponse == "yes")
                    {
                        isCitizen = true;
                    }
                    else if (citizenResponse == "no")
                    {
                        isCitizen = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please respond yes or no.");
                    }
                }

                bool canVote = isCitizen && age >= 18;

                Console.Clear();  

                Console.WriteLine("Is this correct?");
                Console.WriteLine();
                Console.WriteLine("Name: " + fullName);
                Console.WriteLine("Height: " + totalHeightCM + "cm");
                Console.WriteLine("Can Vote: " + canVote);
                Console.WriteLine();

                verify = " ";
                while (verify != "yes" && verify != "no")
                {
                    verify = Console.ReadLine();
                    if (verify == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Yay!");
                    }
                    else if (verify == "no")
                    {
                        Console.Clear();
                        Console.WriteLine("Boo! Try Again!.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please respond yes or no.");
                    }
                }
            } 

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();           




            


        }
    }
}
