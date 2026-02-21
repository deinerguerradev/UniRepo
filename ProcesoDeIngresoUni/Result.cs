using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Threading; 

namespace ProcesoIngreso
{
    public static class Result
    {
        public static void AdmissionResult()
        {
            //le pedimos al usuario que ingrese sus credenciales
            Console.Write("Cual es tu nombre de usuario: "); 
            Program.userName = Console.ReadLine();
            Console.Write("Cual es tu contraseña"); 
            Program.userPassword = Console.ReadLine(); 

            for (int n = 0; n>Program.UserName.Count; n++)
            {
                            
                if (Program.UserName[n] == Program.userName && Program.UserPasswsword[n] == Program.userPassword) 
                {
                    Console.WriteLine("Iniciaste sección"); 
                    Thread.Sleep(3000);

                    string icfesResult = Program.UserBasicInfo[Program.userName][1]; 
                    AdmissionProgram(icfesResult); 
                    break; 
                }
            }

        }
        private static void AdmissionProgram(string icfes)
        {
            string facultyUser = Program.UserBasicInfo[Program.userName][3]; 
            string careerUser = Program.UserBasicInfo[Program.userName][4]; 
            int.TryParse(icfes, out int number); 

            if (Program.UserBasicInfo["Ingenieria"].Contains(facultyUser))
            {
                if (number >= 307)
                {
                    Console.WriteLine("La facultad aprovo Tú Admisión, ahora veamos el resultado del program...");
                    Thread.Sleep(3000); 

                    switch (careerUser)
                    {
                        case "Ingenieria civil":
                        {
                            if(number >= 310){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Ingenieria de Sistemas":
                        {
                            if(number >= 315){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Ingenieria Ambiental":
                        {
                            if(number >= 320){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Ingenieria Industrial":
                        {
                            if(number >= 307){Console.WriteLine("EL programa te ah Admitido!");Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Ingenieria Mecanica":
                        {
                            if(number >= 307){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Arquitectura":
                        {
                            if(number >= 307){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                    } 
                }
            }
            else if (Program.UserBasicInfo["Humanidades"].Contains(facultyUser))
            {
                if (number >= 250)
                {
                    Console.WriteLine("La facultad aprovo Tú Admisión, ahora veamos el resultado del program...");
                    Thread.Sleep(3000); 

                   switch (careerUser)
                    {
                        case "Trabajo Social":
                        {
                            if(number >= 250){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Psicología":
                        {
                            if(number >= 280){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Comunicación Social":
                        {
                            if(number >= 270){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        default: 
                            Console.WriteLine("No se encontro la carrera");
                            Console.WriteLine("Comunicate con Soporte técnico");
                            break; 
                          
                    }  
                }
            }
            else if (Program.UserBasicInfo["Ciencias"].Contains(facultyUser))
            {
                if (number >= 320)
                {
                    Console.WriteLine("La facultad aprovo Tú Admisión, ahora veamos el resultado del program...");
                    Thread.Sleep(3000); 

                    switch (careerUser)
                    {
                        case "Biología":
                        {
                            if(number >= 320){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Quimica":
                        {
                            if(number >= 330){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                        case "Arqueología":
                        {
                            if(number >= 310){Console.WriteLine("EL programa te ah Admitido!"); Program.IsAdmited.Add(true);}
                            else {Console.WriteLine("El Programa no te ah Admitido");}
                            break; 
                        }
                
                    }      
                }
            }
            

        }
            
    }
}