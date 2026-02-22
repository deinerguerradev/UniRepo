using System;
using System.Collections.Generic;
using System.Threading;

namespace ProcesoIngreso
{
    public static class Upload {

        public static void Docuemnts ()
        {
            //le pedimos al usuario que ingrese sus datos
            Console.WriteLine("==========================\n"); 

            Console.Write("Ingresa tu Nombre Completo: "); 
            string name = Console.ReadLine().ToLower();

            Console.Write("Ingresa tu tarjeta de identidad: ");
            int id = Convert.ToInt16(Console.ReadLine()); 

            Console.Write("Ingresa tu contraseña: "); 
            string password = Console.ReadLine(); 

            Console.WriteLine("==========================\n");

            //Procesamos las entradas para verificar que el usuario este en el sistema
            int index = Program.UserBasicInfo.Keys.ToList().IndexOf(name);

            if (Program.UserName[index] == name && Program.UserId[index] == id && Program.UserPasswsword[index] == password)
            {
                Console.WriteLine("Inicio de sección exitoso");
                Console.WriteLine("Espere unos momentos"); 

                Motion(); 
                
                Console.Write("Ingresa la fotocopía de tu tarjeta de identidad, Presiona la tecla T: ");
                ConsoleKeyInfo teclaT = Console.ReadKey(); 
                bool isUploadId = teclaT.Key == ConsoleKey.C; 

                Motion(); 

                Console.Write("Ingresa una fotocopia de un recibo de la Luz, Presiona la tecla R: "); 
                ConsoleKeyInfo teclaR = Console.ReadKey(); 
                bool isUploadReceipt = teclaR.Key == ConsoleKey.R;

                Motion();  

                Console.Write("Ingresa una carta de identificación cultural, I: "); 
                ConsoleKeyInfo teclaI = Console.ReadKey(); 
                bool isUpdloadIdCulture = teclaI.Key == ConsoleKey.I; 

                Motion(); 

                Console.Write("Ingresa una foto 3*4 fondo azul, Presiona F");
                ConsoleKeyInfo teclaF = Console.ReadKey(); 
                bool isUpdloadPhoto = teclaF.Key == ConsoleKey.F; 

                Motion(); 

                if ((isUploadReceipt && isUploadId && isUpdloadPhoto) || isUpdloadIdCulture)
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Motion(); 
                    Console.WriteLine("Se han agregado todos los documentos!"); 
                    Console.ResetColor(); 
                } 
                else
                {
                    Console.WriteLine("Ingresa todos los documentos"); 
                }



            }
        }
        public static void Motion ()
        {
            for (int i = 0; i<7; i++)
            {
                Console.Write("=="); 
                Thread.Sleep(1000); 
            }

        }

    }

}