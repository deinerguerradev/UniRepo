using System;
using System.Collections.Generic;
using System.Threading;

namespace CourseAverage
{
    class AverageProgram
    {
        public static string[] ProfesorsNames = {"adanud", "maria", "smith", "pablo"};
        public static string [] ProfesorPassword = {"unipas", "soft45", "123desa", "p4bl9"};
        public static Dictionary <string, List<double>> StudentsInfo = new Dictionary<string, List<double>>{
            {"Deiner Guerra", new List<double> {4.0, 4.0, 4.0}}, 
            {"Joan Garzia", new List<double> {4.0, 4.0, 4.0}}, 
            {"isabella mejia", new List<double> {4.0, 4.0, 4.0}}, 
            {"Leidys Guerra", new List<double> {4.0, 4.0, 4.0}}, 
            {"Yeider Griego", new List<double> {2.5, 3.5, 5.0}}, 
            {"Cristiano Ronaldo", new List<double> {5.0, 5.0, 5.0}}
        };   
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
                string [] options = {"1. Ver estudiantes", "2. ver un estudiante en especifico", "3. Estadisticas de Curso", "4. salir"}; 

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(options[i]); 
                }

                Console.Write("\nIngresa una de las opciones anteriores: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 4)
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
                    AllStudentsDetails(); 
                    break; 
                case 2: 
                    StudentDetails();
                    break; 
                case 3: 
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

            double corte1 = 0; 
            double corte2 = 0; 
            double corte3 = 0; 

            double pesoCorte1 = 0.30; 
            double pesoCorte2 = 0.35; 
            double pesoCorte3 = 0.35; 

            double PromedioTotal = 0; 

            foreach (var student in StudentsInfo)
            {
                List<double> notas = student.Value; 

                corte1 = notas[0] * pesoCorte1;
                corte2 = notas[1] * pesoCorte2;  
                corte3 = notas[2] * pesoCorte3; 

                PromedioTotal = corte1 + corte2 + corte3; 

            }

            Console.WriteLine($"Promedio del primer corte: {corte1}");
            Console.WriteLine($"Promedio del segundo corte: {corte2}");
            Console.WriteLine($"Promedio del tercer corte: {corte3}");

            Console.WriteLine($"Promedio total: {PromedioTotal}");    
           
        }

        static void AllStudentsDetails ()
        {
            Console.WriteLine("======================"); 
            Console.WriteLine("INFORMACIÓN DE TODOS LOS ESTUDIANTE"); 
            Console.WriteLine("======================"); 

            int numberScore = 1; 
            foreach(var studetName in StudentsInfo)
            {
                Console.WriteLine($"Estudiante: {studetName.Key}");
                foreach(var scores in studetName.Value)
                {
                    Console.WriteLine($"Corte {numberScore}: {scores} ");
                    numberScore++;  
                } 
            }
            
        }

        static void StudentDetails ()
        {
            Console.WriteLine("======================"); 
            Console.WriteLine("INFORMACIÓN DE ESTUDIANTE EN ESPECIFICO"); 
            Console.WriteLine("======================"); 

            MotionAnimation(); 

            Console.Write("Ingresa el Nombre del estudiante: ");
            string nameStudent = Console.ReadLine(); 

            int i = 1; 
            
            if (StudentsInfo.ContainsKey(nameStudent))
            {
                Console.WriteLine("Notas: ");
                foreach (double score in StudentsInfo[nameStudent])
                {
                    
                    Console.WriteLine($"corte {i}: {score}"); 
                    i++; 
                } 
            }
            
        }
    }
}
