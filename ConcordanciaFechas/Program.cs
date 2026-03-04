using System; 
using System.Threading; 

namespace DateKnow
{
    
    class Program {

        static void Main (string[] args)
        {
            PrincipalMenu(); 
        }

        public static void PrincipalMenu()
        {
            do
            {
                //le indicamos al usuario que puede hacer
                Console.WriteLine("Puedes realizar las sigueintes acciones");
                Console.WriteLine("1. Revisar el día en base a un número\n2. Revisar el mes en base a un numero\n3. Salir");

                Animation(); 

                //Creamos un campo para almacenar la elección del usuario
                Console.Write("\nIngresa una opción: "); 
                var option = Console.ReadLine();

                //Procesamos las entradas para verificar que el usuario haya ingresado un valor valido
                if (int.TryParse(option, out int userOption) && option != null)
                {
                    if (userOption == 3){return;}

                    switch (userOption)
                    {
                        case 1: 
                            Day(); 
                            break; 
                        case 2: 
                            Moth();
                            break; 
                        default: 
                            Console.WriteLine("ingresa una entrada valida"); 
                            break; 
                         
                    }
                }
                else
                {
                    Console.WriteLine("======================"); 
                    Console.WriteLine("Ingresa un valor valido"); 
                    Console.WriteLine("======================"); 
                    Animation(); 
                }

            }while(true); 
        }

        public static int UserInformation()
        {
            //le pedimos que ingrese el numero 
            Console.Write("Ingresa un número: ");
            var number = Console.ReadLine(); 

            //Procesamos que la entrada sea la correcta y además realizamos la accion de evaluación de entrada
            if (int.TryParse(number, out int userNumber))
            {
                return userNumber; 
            } 
            else
            {
                Console.WriteLine("La entrada es invalida"); 
                return 0; 
            }
        }

        public static void Day()
        {
            int userNumber = UserInformation(); 
            EvaluateDay(userNumber); 
        }

        public static void EvaluateDay(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("======================");
                    Console.WriteLine("Lunes");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 2:
                    Console.WriteLine("======================");
                    Console.WriteLine("Martes");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 3:
                    Console.WriteLine("======================");
                    Console.WriteLine("Miercoles");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 4:
                    Console.WriteLine("======================");
                    Console.WriteLine("Jueves"); 
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 5:
                    Console.WriteLine("======================");
                    Console.WriteLine("Viernes");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 6:
                    Console.WriteLine("======================");
                    Console.WriteLine("Sabado");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 7:
                    Console.WriteLine("======================");
                    Console.WriteLine("Domingo");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                default:
                    Console.WriteLine("Ingresa una valor valido 1-7"); 
                    Animation(); 
                    break; 
            }
        }

        public static void Moth()
        {
            int userNumber = UserInformation(); 
            EvaluateMoth(userNumber); 

        }

        public static void EvaluateMoth(int number)
        {
            switch (number)
            {
                case 1:
                    Animation(); 
                    Console.WriteLine("======================"); 
                    Console.WriteLine("Enero");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 2:
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Febrero");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 3:
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Marzo");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 4:
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Abril"); 
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 5:
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Mayo");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 6:
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Junio");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 7:
                    Console.WriteLine("======================");
                    Console.WriteLine("Julio");
                    Console.WriteLine("======================");
                    break; 
                case 8:
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Agosto");
                    Console.WriteLine("======================");
                    Animation(); 
                    break;
                case 9: 
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Septiembre");
                    Console.WriteLine("======================"); 
                    Animation(); 
                    break; 
                case 10: 
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Octubre"); 
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 11: 
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Noviembre");
                    Console.WriteLine("======================");
                    Animation(); 
                    break; 
                case 12: 
                    Animation(); 
                    Console.WriteLine("======================");
                    Console.WriteLine("Diciembre");
                    Console.WriteLine("======================");
                    Animation(); 
                    break;   
                default:
                    Console.WriteLine("Ingresa una valor valido 1-12"); 
                    break; 
            }
        }
        
        public static void Animation()
        {
            for (int i = 0; i<5; i++)
            {
                Console.Write("="); 
                Thread.Sleep(1500); 
            }
            Console.WriteLine(); 
        }

    }

}
