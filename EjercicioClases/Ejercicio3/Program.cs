using System; 
using System.Collections.Generic; 

namespace DiscountVerification
{
    class Program
    {
        
        static void Main (string[] args)
        {
            App(); 
        }

        static void App ()
        {

            do{

                UserCredential(); 

                Console.WriteLine("Seguira evaluando Clientes (S/N)?"); 
                string option = Console.ReadLine().ToLower(); 

                switch (option)
                {
                    case "s": 
                        UserCredential(); 
                        break; 
                    case "n": 
                        return; 
                    default: 
                        Console.WriteLine("Ingresa los valores correspondientes s o n");
                        break;  
                }
                
            }
            while (true); 

            
        }
        static void UserCredential()
        {
            Console.WriteLine("Ingrese la edad del cliente");
            var age = Console.ReadLine();

            if (int.TryParse(age, out int userAge))
            {
                Console.WriteLine("Es un cliente con suscripción (S/N)?"); 
                string selection = Console.ReadLine().ToLower(); 

                if (selection == "s")
                {   
                HasDiscount(userAge); 
                }
                else
                {
                    Console.WriteLine("El cliente no esta suscrito, por lo que no tiene descuento"); 
                }
            }
            
        }

        static void HasDiscount(int age)
        {
            if (age > 60 )
            {
                Console.WriteLine("Tiene un Descuento"); 
            }
            else
            {
                Console.WriteLine("El cliente no cumple con la norma de edad, por lo que no aplica para el descuento"); 
            }
        }

    }
}
