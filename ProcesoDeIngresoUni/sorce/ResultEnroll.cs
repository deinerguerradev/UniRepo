using System; 
using System.Collections.Generic; 

namespace Process
{
    class AdmiteResult
    {
        public static void User(int icfes, string career)
        {
            if (icfes >= 300)
            {
                if (career == "civil" && icfes >= 310){Console.WriteLine("Has sido Admitido a Civil, tienes que presentar una prueba!");}
                else if (career == "sistemas" && icfes >= 307){Console.WriteLine("Has sido Admitido a Sistemas, tienes que presentar una prueba ahora");}
                else if (career == "industrial" && icfes >= 320){Console.WriteLine("Has sido admirtido a Industrial");}
            }
            else
            {
                Console.WriteLine("No pasaste :("); 
            }
        }
    }
}