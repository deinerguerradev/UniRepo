using System; 
using System.Threading; 

namespace ProcesoIngreso 
{
    class Program 
    {
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
                    Console.WriteLine("Inscribirse");
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 2: 
                    Console.WriteLine("Estado De Aspirante");
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
    }
}
