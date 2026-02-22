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
            while(true){
                switch (accion)
                {
                    case 1: 
                        Register.SingUp();  
                        Console.WriteLine("Acción Exitosa, espere un momento..."); 
                        Upload.Motion(); 
                        break; 
                    case 2: 
                    {
                        Result.AdmissionResult(); 
                        Console.WriteLine("Acción Exitosa, espere un momento..."); 
                        Upload.Motion();  
                        break; 
                    }
                    case 3: 
                        Test.TestProgram();
                        Console.WriteLine("Acción Exitosa, espere un momento..."); 
                        Upload.Motion(); 
                        break; 
                    case 4: 
                        Test.DisplayResult();
                        Console.WriteLine("Acción Exitosa, espere un momento..."); 
                        Upload.Motion(); 
                        break; 
                    case 5: 
                        Console.WriteLine("subir docuemtos para la matricula");
                        Console.WriteLine("Acción Exitosa, espere un momento..."); 
                        Upload.Motion(); 
                        break; 
                    case 6: 
                        Console.WriteLine("Revisar estado de Matricula");
                        Console.WriteLine("Acción Exitosa, espere un momento..."); 
                        Upload.Motion(); 
                        break;  
                    case 7: 
                        AdminFunctions.SingUp(); 
                        break; 
                    case 8: 
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine(); 
                        Console.ResetColor(); 
                        break; 
                    default: 
                        Console.WriteLine("Ingresa una entrada valida");
                        Upload.Motion(); 
                        break;         
                }
            }
        }
    }
}
