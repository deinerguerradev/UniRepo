using System; 
using System.Threading; 
using System.Collections.Generic; 

namespace ProcesoIngreso 
{
    public static class Program 
    {
        public static string userName = ""; 
        public static string userIcfes = "";
        public static string userCarrer = ""; 
        public static string userFaculty = "";  
        public static List<string> UserName = new List<string>(); 
        public static List<string> UserPasswsword = new List<string>();
        public static Dictionary<string, List<string>> UserBasicInfo = new Dictionary<string, List<string>>(); 
        public static List <int> UserId = new List<int>(); 
        public static List<bool> IsRegister = new List<bool>(); 
        public static List<bool> IsAdmited = new List<bool>(); 
        public static List<bool> IsAprobbed = new List<bool>(); 
        public static List<bool> IsEnrolled = new List<bool>(); 
      
        public static void Main (string [] args) 
        {
            //Desplegamos una bienvenida para el usuario
            Console.WriteLine("==========================================="); 
            Console.WriteLine("\nBienvenido a Uniguajira");
            Console.WriteLine("Esta es la plataforma para controlar tu proceso\n"); 
            Console.WriteLine("===========================================");

            Thread.Sleep(3000); 

            //establecemos el bucle principal de nuestro programa 
            
            while (true)
            {
                
                //Establecemos los procesos que puede realizar el aspirante 
                List<string> accionesDelUsuario = new List<string>{"1. Inscribirse", "2. Revisar El estado De Aspirante", "3. Presentar la prueba", "4. Resvisar los resultados de la prueba", "5. Subir Docuementos Para Matricula", "6. Estado de Matricula", "7. Salir"};
                Console.WriteLine("Puedes hacer las siguientes Acciónes");

                //imprimimos las opciones para el usuario
                foreach(var acciones in accionesDelUsuario)
                {
                    Console.WriteLine(acciones); 
                }

                //Le pedimos al usario que ingrese una opcion
                Console.WriteLine("Ingresa una de las opciones anteriores, (1, 2, 3, 4, 5 o 7)"); 
                var opcion = Console.ReadLine(); 

                //Procesamos la entrada del usuario
                if(int.TryParse(opcion, out int accion))
                {
                    if (accion == 7)
                    {
                        Console.WriteLine("Esta saliendo de la aplicación");
                        Thread.Sleep(3000);  
                        return; 
                    }
                    Thread.Sleep(2000); 
                    ProcesarAccion(accion); 
                }
                else
                {
                    //le decimos al usuario que no a ingresado una entrada valida
                    Console.WriteLine("Ingresa una entrada valida (1, 2, 3, 4, 5, 6 o 7)"); 
                }
                  
            }

        }
        private static void ProcesarAccion(int accion)
        {
            switch (accion)
            {
                case 1: 
                    SingUp(); 
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 2: 
                    
                    for (int n = 0; n>UserName.Count; n++)
                    {
                        
                        if (UserName[n] == userName) 
                        {
                            
                        }
                    }
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 3: 
                    Console.WriteLine("presentar la prueba");
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 4: 
                    Console.WriteLine("Revisar los resultados de la prueba");
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 5: 
                    Console.WriteLine("subir docuemtos para la matricula");
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 6: 
                    Console.WriteLine("Revisar estado de Matricula");
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break;  
                default: 
                    Console.WriteLine("Ingresa una entrada valida");
                    break;         
            }
        }
        private static bool SingUp()
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
                userName = Console.ReadLine(); 

                Console.Write("Ingresa tu tarjeta de identidad: "); 
                var userId = Console.ReadLine(); 

                Console.Write("Ingresa tu tarjeta contraseña: "); 
                string userPasswsword = Console.ReadLine(); 

                //creamos una variable que almacena la cantidad de caracteres que tiene el userId
                int cantidadNumerosId = userId.ToString().Length; 
                

                if (int.TryParse(userId, out int id)  && cantidadNumerosId <= 10)
                {
                    //Agregamos la infromación a la lista
                    UserPasswsword.Add(userPasswsword); 
                    UserName.Add(userName);
                    UserId.Add(id);

                    //agregamos algunos estados
                    IsAdmited.Add(false); 
                    IsAprobbed.Add(false); 
                    IsEnrolled.Add(false); 
                    IsRegister.Add(false);

                    if (CargarDocuemntos(userName, userPasswsword))
                    {
                        return IsRegister.Contains(true);   
                    }

                } 
                else
                {
                    Console.WriteLine("Ingresa bien tu tarjeta de identidad!"); 
                }
            }


        }
        private static bool CargarDocuemntos(string userName, string userPassword)
        {
            while(true){
                
                foreach (var n in UserName)
                {
                    if (n == userName)
                    {
                        Console.WriteLine("Ya estas registrado en la plataforma, por favor siga con el sigueinte proceso (revisar el estado del aspirante)");
                        break;  
                    }
                    else
                    {
                        //Le decimos al estudiante que carge sus docuementos
                        Console.WriteLine("Ingrese los sigueintes docuemtos");
                        string[] documents = {"1. Recibo de pago de Matricula", "2. Pruebas Saber", "3. Formulario de Inscripción lleno"}; 

                        //imprimimos las opciones
                        for (int i = 0; i>3; i++)
                        {
                            Console.WriteLine(documents[i]); 
                        }

                        Console.WriteLine("Ingresa tu recibo de Matricula (pagada o no pagada)");
                        string userInvoice = Console.ReadLine().ToLower(); 

                        Console.WriteLine("Ingresa el resultado de tu prueba saber");
                        userIcfes = Console.ReadLine().ToLower(); 

                        Console.WriteLine("Ingresa formulario (lleno o no completado)");
                        string userForm = Console.ReadLine().ToLower(); 

                        // Mostramos las carreras disponibles
                        Console.WriteLine("Ingresa una de las sigueintes carreras: ");
                        Dictionary <string, List<string>> carreras = new Dictionary<string, List<string>>
                        {

                            {"Carreras de Ingenieria", new List<string> {"Ingenieria civil", "Ingenieria de Sistemas", "Ingenieria Ambiental", "Ingenieria Industrial", "Ingenieria Mecanica", "Arquitectura"}},
                            {"Carreas de Ciencias Basicas", new List<string> {"Biología", "Quimica", "Arqueología"}}, 
                            {"Carreras de Humanidades", new List<string> {"trabajo Social", "Psicología","Comunicación Social" }},

                        }; 

                        foreach(var facultad in carreras)
                        {
                            Console.WriteLine($"Facultad: {facultad.Key}");
                            foreach(var carrera in carreras)
                            {
                                Console.WriteLine($"{carrera.Value}"); 
                            } 
                        }

                        //le pedimos al usuario que ingrese una carrera
                        Console.Write("\nIngresa una facultad: "); 
                        userFaculty = Console.ReadLine(); 

                        Console.Write("\nIngresar una carrera: ");
                        userCarrer = Console.ReadLine(); 

                        //Verificamos que el usuario ingrese los docuemntos
                        if (userInvoice == "pagada" && userForm == "lleno" && userIcfes != null)
                        {
                            Console.WriteLine("Completaste tu registro!");
                            Console.WriteLine($"Tú usario es: {userName}, tu contraseña es: {userPassword}");
                            UserBasicInfo.Add(userName, new List<string> {userForm, userIcfes, userInvoice, userFaculty, userCarrer});
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
    }
}
