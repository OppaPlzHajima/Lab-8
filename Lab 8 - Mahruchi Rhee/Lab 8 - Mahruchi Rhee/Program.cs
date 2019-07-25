using System;

namespace Lab_8___Mahruchi_Rhee
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numcheck = true;
            Console.WriteLine("Which student would you like to learn about? (0-3)");
            char x = char.Parse(Console.ReadLine());
            

            while (numcheck = true)
            {

                numcheck = FormatException(x);

                if (numcheck == false)
                {
                    Console.WriteLine("You have entered an incorrect response.");
                    Console.WriteLine("Please try again.");
                }

                else
                {
                    break;
                }
            }


            Console.WriteLine(GetName(;
          Console.WriteLine()
       

           /* switch (name)
            {
                case "0":
                    return "Student number " + name + names[0];
                    break;

                case "1":
                    return "Student number " + name + names[1];
                    break;

                case "2":
                    return "Student number " + name + names[2];
                    break;

                default:
                    return "That student doesn't exist within our records please try again";
            }
            return name;  */


        }
        public static string GetName(string name)
        {
            string[] names = new string[4];
            names[0] = " James Dockery";
             names[1] =" Maricela Rivera";
             names[2] = " Tommy Waalkes";

            string[] homeTowns = new string[4];
            homeTowns[0] = "Grand Rapids, USA";
            homeTowns[1]=  "Morelia, Mexico";
            homeTowns[2] = "Raleigh, USA";

            string[] foods = new string[4];
            foods[0] = "Cheeseburgers/Fries";
            foods [1] = "Tacos";
             foods [2] =  "Indian Style Chicken Curry";



          

        }

        public static bool FormatException(char num)
        {
            bool output = char.IsNumber(num);
            return output;
        }

        public static bool IndexOutofRange(char num)
        {
            int input = Convert.ToInt16(num);
            if (input < 2)
            {
                bool check = false;
                return check;
            }
        }




    }
}
