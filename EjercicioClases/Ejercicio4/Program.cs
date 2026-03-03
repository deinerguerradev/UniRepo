using System; 

namespace UserDiscountDataBase
{
    class Program 
    {
        //definimos con los datos que vamos a trabajar
        private static int[] UsersDoc = {1119394928, 1119394927, 1119394925}; 
        private static bool[] HasMembership = {true, false, true}; 
        private static int[] UsersAge = {27, 65, 70}; 
        private static string [] UsersName = {"Deiner", "Samuel", "Yeider"}; 

        static void Main (string[] args) 
        {
            UserCredencial(); 
        }

        static void UserCredencial ()
        {
            Console.Write("Ingrese su numero de cedula: ");
            var doc = Console.ReadLine(); 

            if (int.TryParse(doc, out int userDoc))
            {
                for (int i = 0; i<UsersDoc.Length; i++)
                {
                    if (userDoc == UsersDoc[i])
                    {
                        HasDiscount(i); 
                    }
                    if (userDoc != UsersDoc[i])
                    {
                        Console.WriteLine("Usuario no esta en la base de datos");
                        break;  
                    }
                }
            }
            else
            {
                Console.WriteLine("Ingresa un valor valido"); 
            }
        }

        static void HasDiscount (int number)
        {
            if (UsersAge[number] > 60 && HasMembership[number])
            {
                Console.WriteLine($"El usuario {UsersName[number]} tiene acceso al descuento"); 
            }
            else
            {
                Console.WriteLine($"El usuario {UsersName[number]} no tiene acceso al descuento"); 
            }
        }

        
    }
}