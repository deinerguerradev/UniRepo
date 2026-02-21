using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Threading; 

namespace ProcesoIngreso
{
    public static class InputManagment
    {
        public static void ProcesarAccion(int accion)
        {
            switch (accion)
            {
                case 1: 
                    Register.SingUp();  
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                case 2: 
                {
                    Result.AdmissionResult(); 
                    Console.WriteLine("Acción Exitosa, espere un momento..."); 
                    Thread.Sleep(3000); 
                    break; 
                }
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
