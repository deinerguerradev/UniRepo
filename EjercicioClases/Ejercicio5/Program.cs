using System; 
using System.Collections.Generic; 

namespace Scholarship {

    class Program {

        //definimos los datos con los que vamos a trabajar
        public static string[] StudentsName = {"Deiner Guerra", "Yeider Peralta", "Dair Gomez"}; 
        public static float[] StudentScore = {4,5, 3,5, 4,7}; 
        public static bool[] isSystemStudent = {true, true, false}; 
        public static int[] StudentsId = {1119394928, 1119394927, 1119394926};

        static void Main (string[] agrs){

            PrincipalMenu(); 

        }

        static void PrincipalMenu()
        {
            Console.WriteLine("==================="); 
            Console.WriteLine("PROCESO DE VERIFICACIÓN PARA BECA UNIVERSITARIA");
            Console.WriteLine("===================");

            while (true)
            {
                Console.Write("Ingresa tu documento de identidad: "); 
                var userId = Console.ReadLine(); 

                if (int.TryParse(userId, out int id))
                {
                    for (int i = 0; i<StudentsId.Length; i++)
                    {
                        int student = i; 
                        if (id == StudentsId[student])
                        {
                            Console.WriteLine("¡Inicio de sesión exitoso!");
                            HaScholarship(student);
                            break; 
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un valor valido"); 
                }

                Console.WriteLine("Deseas salir de la aplicación (S/N)?");
                string option = Console.ReadLine().ToLower(); 

                if (option == "s"){return;} 


            }


        }   
        public static void HaScholarship (int student)
        {
            if (isSystemStudent[student] && StudentScore[student] >= 4.5)
            {
                Console.WriteLine($"¡Felicitaciones {StudentsName[student]} te ganaste una beca!"); 
            }
            else
            {
                Console.WriteLine($"Lo sentimos {StudentsName[student]}, pero no tienes la beca"); 
            }
        }

    }
}
