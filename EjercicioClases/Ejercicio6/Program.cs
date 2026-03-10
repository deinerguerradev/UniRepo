using System; 
using System.Collections.Generic; 

namespace Cafeteria
{
    class Program
    {
        private static string[] studentsNames = {"deiner", "cristian", "miguel", "samuel", "sebastian", "mariano"};
        private static float[] menuPrice = {12000, 23000, 45000}; 
        private static string[] studentCareers = {"sistemas", "diseño", "derecho", "medicina", "administración"}; 

        private static string studetName = ""; 
        private static int studentIndex = 0; 

        static void Main ()
        {
           AppBegin(); 
        }

        static void AppBegin()
        {
            Console.WriteLine(" =========================  "); 
            Console.WriteLine("     CAFETERIA UNIGUAJIRA    "); 
            Console.WriteLine(" =========================   "); 
            
            while (true){

                RequestUserCredential(); 

                Console.WriteLine("¿Quieres salir de la aplicación (S/N)?");
                string option = Console.ReadLine().ToLower(); 

                if (option == "s"){
                    Console.WriteLine("Saliendo de la aplicación..."); 
                    break; 
                } 
            }
        }

        static void RequestUserCredential()
        {
            Console.Write("ingresa tu nombre: "); 
            studetName = Console.ReadLine(); 

            if (studentsNames.Contains(studetName))
            {
                for (int student = 0; student < studentsNames.Length; student++)
                {
                    if (studentsNames[student] == studetName)
                    {
                        studentIndex = student; 
                        break; 
                    }
                }

                StudentSelection(studentIndex); 

            }
            else {
                Console.WriteLine("No estas en el sistema!"); 
            }
             
        }

        static void StudentSelection(int student)
        {
            string name = studentsNames[student]; 
            string career = studentCareers[student]; 

            Console.WriteLine($"Bienvenido {name}, que te gustaria comer hoy?");
            Console.WriteLine("1. Carne con arroz de coco + juego natural\n2. pescado con arroz blanco + jugo natural\n3. arroz de pollo + aguapanela");

            int option = int.Parse(Console.ReadLine());
            float discount = 0; 

            switch (option)
            {
                case 1:
                    discount = StudetCareerVerification(career, option); 
                    Console.WriteLine($"{name}, debido a que eres estudiante de {career} tienes un descuento, esto es lo que tienes que pagar: {menuPrice[0] - discount}"); 
                    break; 
                case 2:
                    discount = StudetCareerVerification(career, option); 
                    Console.WriteLine($"{name}, debido a que eres estudiante de {career} tienes un descuento, esto es lo que tienes que pagar: {menuPrice[0] - discount}");
                    break; 
                case 3:
                    discount = StudetCareerVerification(career, option); 
                    Console.WriteLine($"{name}, debido a que eres estudiante de {career} tienes un descuento, esto es lo que tienes que pagar: {menuPrice[0] - discount}");
                    break;
                default: 
                    Console.WriteLine("Ingresa un valor valido!");
                    break;   
            }   
        }

        static float StudetCareerVerification(string career, int option)
        {
            float discount = 0; 

            switch (career)
            {
                case "sistemas":
                    if (option == 1){discount = menuPrice[0] * 0.25f; }
                    else if (option == 2){discount = menuPrice[1] * 0.25f;}
                    else if (option == 3){discount = menuPrice[2] * 0.25f; }
                   return discount; 
                case "diseño":
                    if (option == 1){discount = menuPrice[0] * 0.25f;}
                    if (option == 2){discount = menuPrice[1] * 0.25f;}
                    if (option == 3){discount = menuPrice[2] * 0.25f;}
                    return discount;
                case "administración":
                    if (option == 1){discount = menuPrice[0] * 0.25f;}
                    if (option == 2){discount = menuPrice[1] * 0.25f;}
                    if (option == 3){discount = menuPrice[2] * 0.25f;}
                    return discount;
                case "medicina":
                    if (option == 1){discount = menuPrice[0] * 0.25f;}
                    if (option == 2){discount = menuPrice[1] * 0.25f;}
                    if (option == 3){discount = menuPrice[2] * 0.25f;}
                   return discount;
                case "derecho":
                    if (option == 1){discount = menuPrice[0] * 0.25f;}
                    if (option == 2){discount = menuPrice[1] * 0.25f;}
                    if (option == 3){discount = menuPrice[2] * 0.25f;}
                    return discount;
                default: 
                    return discount; 
                 
            }
        }
    }
}

