using System;
using System.Collections.Generic;
using System.Threading;

namespace CourseAverage
{
    class AverageProgram
    {
        public static string[] ProfesorsNames = {"adanud", "maria", "smith", "pablo"};
        public static string [] ProfesorPassword = {"unipas", "soft45", "123desa", "p4bl9"};
        public static string[] StudentNames = {"Deiner", "Gabriel", "Antonio", "Emanuel", "Arley", "Cristian", "Yeider", "Esteban", "Emily", "Maria"};
        public static float[] StudentScore = {3.3f, 3.0f, 4.0f, 4.0f,4.0f,4.0f,4.0f, 4.0f,4.0f,4.5f, };   
        static void Main (string[] args)
        {
            Console.WriteLine("======================");
            Console.WriteLine("CONTROL ESTUDIANTIL"); 
            Console.WriteLine("======================");

            ProfessorBegin();
             
        }

        static void ProfessorBegin()
        {
           

            Console.WriteLine("======================");
            Console.WriteLine("Bienvenido, Estimado Docente Ingrese sus credenciales");
            Console.WriteLine("======================\n");

            Console.Write("Ingresa tu Nombre: ");
            string name = Console.ReadLine(); 

            Console.Write("Ingresa tu contraseña: ");
            string password = Console.ReadLine(); 

            for (int i = 0; i < ProfesorsNames.Length; i++)
            {
                if (ProfesorsNames[i] == name && ProfesorPassword[i] == password)
                {
                    Console.WriteLine("Inicio de Sesión exitoso");
                    MotionAnimation(); 

                    DisplayOption(name);
                    return;  

                }
                else
                {
                    Console.WriteLine("Ingresa las credenciales correctas"); 
                }

            }


        }
        static void MotionAnimation ()
        {
            for (int i = 0; i <3; i++)
            {
                Console.Write("===");
                Thread.Sleep(1000); 
            }
            Console.WriteLine(""); 
        }

        static void DisplayOption (string name)
        {
            
            while(true){

                Console.WriteLine($"Bienvenido profesor(a) {name}, Puedes hacer las sigueintes acciones");
                string [] options = {"1. Estadisticas de Curso", "2. salir"}; 

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(options[i]); 
                }

                Console.Write("\nIngresa una de las opciones anteriores: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 2)
                {
                    Console.WriteLine("saliendo del programa");
                    break; 
                }
                else {
                    SelectOption(option); 
                }
                
            }

        }

        static void SelectOption(int option)
        {  
             switch (option)
            { 
                case 1: 
                    ClassDetails();
                    break; 
                default:
                    Console.WriteLine("ingresa una acción valida");
                    break;  
                
            } 
        }

        static void ClassDetails ()
        {
            Console.WriteLine("=================");
            Console.WriteLine("INFORMACIÓN DE CURSO"); 
            Console.WriteLine("=================");

            float maxNum = StudentScore[0]; 
            string studentName = ""; 

            //revisaremos quien es el que tiene mayor calificación
            for (int i = 0; i < StudentScore.Length; i++)
            {
                if (StudentScore[i] > maxNum)
                {
                    maxNum = StudentScore[i];
                    studentName = StudentNames[i];  
                     
                }
            }

            Console.WriteLine($"El estudiante {studentName} es el que mayor Promedio tiene con {maxNum}"); 

            //revisamos quien es el de menor calificación 

            float minScore = StudentScore[0]; 
            string studentName2 = StudentNames[0];  

            for (int i = 1; i < StudentScore.Length; i++)
            {
                if (minScore > StudentScore[i])
                {
                    minScore = StudentScore[i]; 
                    studentName2 = StudentNames[i]; 
                }
                
            }

            Console.WriteLine($"El estudiante {studentName2} es el que menor Promedio tiene con {minScore}");

            //imprimimos la media del curso
            Console.WriteLine($"La media del curso es: {StudentScore.Average()}"); 

           
        }



    }
}
