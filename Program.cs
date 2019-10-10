using System;

namespace ice_cream_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
       int numberoftries = 3;
            int f;
            bool allPeopleSaidYes = false;
            string[] differentflavours = new string[3];
            do
            {            
                int n = 0;
                while (n < 3)
                {

                    Console.WriteLine("Please select your favourite flavour ice cream by pressing the corresponding number: \n 1) Strawberry \n 2) Neapolitan \n 3) Chocolate");

                    int selection = Convert.ToInt32(Console.ReadLine());
                    switch (selection)
                    {
                        case 1:
                            differentflavours[n] = "Strawberry";
                            break;
                        case 2:
                            differentflavours[n] = "Neapolitan";
                            break;
                        case 3:
                            differentflavours[n] = "Chocolate";
                            break;
                    }
                    n++;
                }
                allPeopleSaidYes = false;
                for ( f = 1; f <differentflavours.Length; f++)
                {
                    if (differentflavours[0] == differentflavours[f])
                        continue;
                    else
                        break;
                }
                if (f== differentflavours.Length)
                {
                    allPeopleSaidYes = true;
                }
                  
                numberoftries--;
                if (numberoftries < 3)
                {
                    Console.WriteLine("You have failed too many times to get the same flavour \n The program is now closing");
          
                }

            } while (!allPeopleSaidYes);
            
            Console.WriteLine("All of the participents have picked {0}", differentflavours[0]);

            Console.ReadKey(true);
           
        }
    }
}
