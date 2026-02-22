using System;
using System.Collections.Generic;
using System.Threading; 
using System.Linq; 

namespace ProcesoIngreso
{
    public static class Test
    {
        public static void TestProgram()
        {
            //Le explicamos al estudiante como funcionara esta etapa
            Console.WriteLine("Se realizaran 2 Preguntas las cuales debera de responder con V (verdadero) F(falso)."); 
            Console.WriteLine("1 pregunta realizada por la facultada y 1 pregunta redactada por el programa, los resultados se daran en la proxima etapa, Exitos!");
            Console.WriteLine("Estamos preparando tu prueba...");
            Thread.Sleep(5000);

            //Procesamos algunas variables para determinar las preguntas
            string facultyUser = Program.UserBasicInfo[Program.userName][3]; 
            string careerUser = Program.UserBasicInfo[Program.userName][4];  

            if (Program.Carreras["Ingenieria"].Contains(facultyUser))
            {
                EngineerTest(careerUser); 
            }
            else if (Program.Carreras["Humanidades"].Contains(facultyUser))
            {
                HumanitiesTest(careerUser); 
            }
            else if (Program.Carreras["Ciencias"].Contains(facultyUser))
            {
                ScienceTest(careerUser); 
            }
            else 
            {
                Console.WriteLine("Comuniquese con Soporte técnico");
            }

        }
        public static void DisplayResult()
        {
            //Le peidmos al usuario que ingrese sus credenciales
            Console.Write("Ingresa tu nombre: ");
            string name = Console.ReadLine(); 

            Console.Write("Ingresa tu constraseña: ");  
            string passwrod = Console.ReadLine();

            //Procesamos las entradas y verificamos si esta en el sistema
            if (Program.UserBasicInfo.ContainsKey(name) && Program.UserBasicInfo[name].Contains(passwrod))
            {
                int index = Program.UserBasicInfo.Keys.ToList().IndexOf(name); 

                if (index != -1)
                {
                    if (Program.IsAprobbed[index])
                    {
                        Console.WriteLine("Felicitaciones!, pasate la prueba!");
                        Console.ForegroundColor = ConsoleColor.Green;  
                        Console.WriteLine("Bienvenido a la Universidad de La Guajira"); 
                        Console.ResetColor(); 
                    }
                    else
                    {
                        Console.WriteLine("No pasaste la prueba, No te desanimes!. Puedes volverlo intentar el Proximo Semestre"); 
                    }
                }
                else
                {
                    Console.WriteLine("Comunicate con servicio tecnico"); 
                }
            }
        }
        private static void EngineerTest(string career)
        {
            switch (career)
            {
                case "Ingenieria civil": 
                {
                    Console.WriteLine("La ingeniería integra conocimientos de ciencias básicas, tecnología y gestión para diseñar soluciones en múltiples campos de la sociedad. (V/F)"); 
                    char a = Console.ReadKey().KeyChar;

                    Console.WriteLine("El concreto está compuesto únicamente de agua y arena. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;

                    AnswerResult(a, b); 
                    break; 
                }
                case "Ingenieria de Sistemas": 
                {
                    Console.WriteLine("La ingeniería integra conocimientos de ciencias básicas, tecnología y gestión para diseñar soluciones en múltiples campos de la sociedad. (V/F)"); 
                    char a = Console.ReadKey().KeyChar;

                    Console.WriteLine("Un compilador convierte directamente código fuente en lenguaje humano.(V/F)"); 
                    char b = Console.ReadKey().KeyChar;

                    AnswerResult(a, b); 
                    break; 
                }
                case "Ingenieria Ambiental": 
                {
                    Console.WriteLine("La ingeniería integra conocimientos de ciencias básicas, tecnología y gestión para diseñar soluciones en múltiples campos de la sociedad. (V/F)"); 
                    char a = Console.ReadKey().KeyChar;

                    Console.WriteLine("El efecto invernadero es causado únicamente por el oxígeno. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;

                    AnswerResult(a, b); 
                    break; 
                }
                case "Ingenieria Industrial": 
                {
                    Console.WriteLine("La ingeniería integra conocimientos de ciencias básicas, tecnología y gestión para diseñar soluciones en múltiples campos de la sociedad. (V/F)"); 
                    char a = Console.ReadKey().KeyChar;

                    Console.WriteLine("El método de las 5S busca reducir costos financieros sin relación con la organización del trabajo. (V/F) "); 
                    char b = Console.ReadKey().KeyChar;

                    AnswerResult(a, b); 
                    break; 
                }
                case "Ingenieria Mecanica": 
                {
                    Console.WriteLine("La ingeniería integra conocimientos de ciencias básicas, tecnología y gestión para diseñar soluciones en múltiples campos de la sociedad. (V/F)"); 
                    char a = Console.ReadKey().KeyChar;

                    Console.WriteLine("La primera ley de Newton afirma que la fuerza es igual a masa por aceleración. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;

                    AnswerResult(a, b); 
                    break; 
                }
                case "Arquitectura": 
                {
                    Console.WriteLine("La ingeniería integra conocimientos de ciencias básicas, tecnología y gestión para diseñar soluciones en múltiples campos de la sociedad. (V/F)"); 
                    char a = Console.ReadKey().KeyChar;

                    Console.WriteLine("Un plano arquitectónico solo sirve para decorar y no tiene valor técnico. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;

                    AnswerResult(a, b); 
                    break; 
                }
            }
        }
        private static void HumanitiesTest(string career)
        {
            switch (career)
            {
                case "trabajo Social": 
                {
                    Console.WriteLine(" Las humanidades estudian al ser humano desde perspectivas culturales, sociales y filosóficas. (V/F)");
                    char a = Console.ReadKey().KeyChar; 

                    Console.WriteLine("El trabajo social consiste solo en entregar ayudas materiales, sin intervención comunitaria. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;
                    AnswerResult(a,b);
                    break; 
                }
                case "Psicología": 
                {
                    Console.WriteLine(" Las humanidades estudian al ser humano desde perspectivas culturales, sociales y filosóficas. (V/F)");
                    char a = Console.ReadKey().KeyChar; 

                    Console.WriteLine("La psicología estudia únicamente los sueños y no otros procesos mentales. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;
                    AnswerResult(a,b);
                    break; 
                }
                case "Comunicación Social": 
                {
                    Console.WriteLine(" Las humanidades estudian al ser humano desde perspectivas culturales, sociales y filosóficas. (V/F)");
                    char a = Console.ReadKey().KeyChar; 

                    Console.WriteLine("La comunicación social se limita únicamente a transmitir noticias sin analizar su impacto. (V/F)"); 
                    char b = Console.ReadKey().KeyChar;
                    AnswerResult(a,b);
                    break; 
                }
            }
            
        }
        private static void ScienceTest(string career)
        {
            switch (career)
            {
                case "Arqueología": 
                {
                    Console.WriteLine("Las ciencias buscan explicar fenómenos naturales mediante la observación, la experimentación y el razonamiento lógico. (V/F)");
                    char a = Console.ReadKey().KeyChar; 

                    Console.WriteLine(" La arqueología se dedica exclusivamente a estudiar fósiles de dinosaurios. (V/F)");  
                    char b = Console.ReadKey().KeyChar; 
                    AnswerResult(a, b); 
                    break; 
                }
                case "Quimica": 
                {
                    Console.WriteLine("Las ciencias buscan explicar fenómenos naturales mediante la observación, la experimentación y el razonamiento lógico. (V/F)");
                    char a = Console.ReadKey().KeyChar; 

                    Console.WriteLine("La química se limita solo a mezclar sustancias sin analizar sus propiedades ni reacciones. (V/F)");  
                    char b = Console.ReadKey().KeyChar; 
                    AnswerResult(a, b); 
                    break; 
                }
                case "Biología": 
                {
                    Console.WriteLine("Las ciencias buscan explicar fenómenos naturales mediante la observación, la experimentación y el razonamiento lógico. (V/F)");
                    char a = Console.ReadKey().KeyChar; 

                    Console.WriteLine("La biología estudia únicamente a los animales, sin incluir plantas ni microorganismos. (V/F)");  
                    char b = Console.ReadKey().KeyChar; 
                    AnswerResult(a, b); 
                    break; 
                }
            }
        }
        private static void AnswerResult(char a, char b)
        {
            if (a =='V' && b == 'F')
            {
                Program.IsAprobbed.Add(true); 
            }
            else
            {
                Program.IsAprobbed.Add(false); 
            }
        }
    }
}