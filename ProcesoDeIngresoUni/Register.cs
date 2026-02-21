using System; 
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading; 


namespace ProcesoIngreso
{
    public static class Register
    {
        public static bool SingUp()
        {
            //Establecemos información para el usuario
            Console.WriteLine("=============="); 
            Console.WriteLine("Va a emepzar el proceso de inscripción...");
            Thread.Sleep(3000); 
            Console.WriteLine("==============");  

            while (true)
            {
                //Establecemos entradas para el usuario
                Console.Write("Ingresa tu Nombre Completo: "); 
                Program.userName = Console.ReadLine(); 

                Console.Write("Ingresa tu tarjeta de identidad: "); 
                var userId = Console.ReadLine(); 

                Console.Write("Ingresa tu tarjeta contraseña: "); 
                Program.userPassword = Console.ReadLine(); 

                //creamos una variable que almacena la cantidad de caracteres que tiene el userId
                int cantidadNumerosId = userId.ToString().Length; 
                

                if (int.TryParse(userId, out int id)  && cantidadNumerosId <= 10)
                {
                    //Agregamos la infromación a la lista
                    Program.UserPasswsword.Add(Program.userPassword); 
                    Program.UserName.Add(Program.userName);
                    Program.UserId.Add(id);

                    //agregamos algunos estados
                    Program.IsAdmited.Add(false); 
                    Program.IsAprobbed.Add(false); 
                    Program.IsEnrolled.Add(false); 
                    Program.IsRegister.Add(false);

                    if (CargarDocuemntos(Program.userName, Program.userPassword))
                    {
                        return Program.IsRegister.Contains(true);
                    }  

                } 
                else
                {
                    Console.WriteLine("Ingresa bien tu tarjeta de identidad!"); 
                }
            }


        }
        public static bool CargarDocuemntos(string userName, string userPassword)
        {
            while(true){
                        
                //Le decimos al estudiante que carge sus docuementos
                Console.WriteLine("Ingrese los sigueintes docuemtos");
                string[] documents = {"1. Recibo de pago de Matricula", "2. Pruebas Saber", "3. Formulario de Inscripción lleno"}; 
                
                //imprimimos las opciones
                for (int i = 0; i < documents.Length; i++)
                {
                    Console.WriteLine(documents[i],"\t"); 
                }
                Thread.Sleep(3000); 

                Console.WriteLine("Ingresa tu recibo de Matricula (pagada o no pagada)");
                string userInvoice = Console.ReadLine().ToLower(); 

                Console.WriteLine("Ingresa el resultado de tu prueba saber");
                Program.userIcfes = Console.ReadLine().ToLower(); 

                Console.WriteLine("Ingresa formulario (lleno o no completado)");
                string userForm = Console.ReadLine().ToLower(); 

                Thread.Sleep(3000); 

                Console.WriteLine("\n==========================\n"); 
                // Mostramos las carreras disponibles
                Console.WriteLine("Ingresa una de las sigueintes carreras: \n");
                
                
                //Mostramos las facultades y las carreras disponibles
                foreach(var facultad in Program.Carreras)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Facultad: {facultad.Key}");
                    foreach(var carrera in facultad.Value)
                    {
                        Console.ForegroundColor= ConsoleColor.DarkGray;
                        Console.WriteLine($"- {carrera}"); 
                    } 
                }

                Console.WriteLine("\n==========================\n"); 

                //le pedimos al usuario que ingrese una carrera
                Console.Write("Ingresa una facultad: "); 
                Program.userFaculty = Console.ReadLine(); 

                Console.Write("\nIngresar una carrera: ");
                Program.userCarrer = Console.ReadLine(); 

                Console.WriteLine("\n======================\n");
                //Verificamos que el usuario ingrese los docuemntos
                if (userInvoice == "pagada" && userForm == "lleno" && Program.userIcfes != null)
                    {
                        Console.WriteLine("Completaste tu registro!\n");
                        Console.Write($"Tú usario es: ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen; 
                        Console.Write(userName.ToUpper());

                        Console.ResetColor();  
                        Console.Write("tu contraseña es: "); 

                        Console.ForegroundColor = ConsoleColor.DarkGreen; 
                        Console.Write(Program.userPassword.ToUpper()); 

                        Program.UserBasicInfo.Add(userName, new List<string> {userForm, Program.userIcfes, userInvoice, Program.userFaculty, Program.userCarrer, userPassword});
                        return true;   
                    }   
                else
                {
                    Console.WriteLine("Debes de agregar todos los docuemtos"); 
                }
                
            }

        }  
    }
}