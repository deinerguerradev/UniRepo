using System; 
class Program {
    class Student
    {
        private static Dictionary<int, List<string>> StudentDataBase = new Dictionary<int, List<string>>
        {
            {123456, new List<string> {"deiner guerra", "17", "true" }},
            {123457, new List<string> {"Simo Garcia", "19", "false" }}
        }; 
        private static float boletaEstudianteValor = 6000.0f; 

        public Student(int code)
        {
            if (StudentDataBase.ContainsKey(code))
            {
                MakeOrder(code); 
            }
            else 
                Console.WriteLine("No se encontro en la base de datos!"); 
                return; 
        }

        private static bool HasValidId (int code)
        {
            
            string id = StudentDataBase[code][2]; 
            bool IsValidId = bool.Parse(id);

            if (IsValidId)
            {
                return true; 
            } 
            else
            {
                return false; 
            }

        }

        public static void MakeOrder (int code)
        {

            if (HasValidId(code))
            {
                for (int i = 0; i < StudentDataBase.Count; i++)
                {
                    if (StudentDataBase.ContainsKey(code))
                    {
                        Sucsesfull(code); 
                        break; 
                    }
                }
            
            }   
            else
            {
                Console.WriteLine("No puede comprar!"); 
                //agregar proceso para estudiantes con tarjetas no validas
            } 

        }

        public static void Sucsesfull (int code)
        {
            string name = StudentDataBase[code][0]; 
            
            Console.WriteLine($"Bienvenido {name}, Cuantas Boletas Necesitas?");
            string boletas = Console.ReadLine(); 

            if(int.TryParse(boletas, out int boletasEstudiante))
            {
                CalculateTotal(boletasEstudiante, name); 
            }
            
            static void CalculateTotal (int boletasEstudiante, string name)
            {
                if (boletasEstudiante > 3)
                {
                    Console.WriteLine($"Querido estudiante {name}, debido a que has comprado {boletasEstudiante} se te dara una gratis y tienes que pagar ${boletaEstudianteValor * boletasEstudiante} COP");
                    return;  
                }
                else
                {
                    Console.WriteLine($"Querido estudiante {name}, tienes que pagar ${boletaEstudianteValor * boletasEstudiante} COP");
                    return;  
                }
            } 
        }

    }



    class Incapacitado
    {
        private static string input; 

        private static float boletaValor = 3000.0f; 

        public Incapacitado (string name)
        {
            MakeOrder(name); 
        }
        static void MakeOrder(string name)
        {
            Console.WriteLine($"Bienvenido {name}, Cuantos boletas Vas a Comprar?");
            input = Console.ReadLine(); 

            if (int.TryParse(input, out int tickets))
            {
                if (tickets > 1)
                {
                    Console.WriteLine($"Estimado {name}, has comprado {tickets} boletas, y en total tienes que pagar ${boletaValor*tickets}");
                }
                else 
                    Console.WriteLine($"Estimado {name}, has comprado {tickets} boleta, y en total tienes que pagar ${boletaValor*tickets} COP"); 
            } 
            else
            {
                Console.WriteLine("Ingresa un valor valido"); 
            }
        }


    }

    class Person
    {
        private static string input; 
        private static float boletaValorNormal = 7000.0f; 
        private static float boletanino = 4000.0f; 
        private static float boletaAdulto = 9000.0f;
        private static float boletaAdultoMayor = 5000.0f; 

        public Person (string name, int age)
        {
            MakeOrder(name, age); 
        }
        static void MakeOrder (string name, int age)
        {
            Console.WriteLine("Ingrese la cantidad de Boletas a comprar");
            input = Console.ReadLine(); 

            if(int.TryParse(input, out int Tickets))
            {
                if (Tickets > 0)
                {
                    if (age < 12)
                    {
                        if (Tickets > 1)
                            Console.WriteLine($"Querido {name}, has comprado {Tickets} boletas, y tienes que pagar {boletanino * Tickets}");
                        else 
                           Console.WriteLine($"Querido {name}, has comprado {Tickets} boleta, y tienes que pagar {boletanino * Tickets}");  

                    }
                    if (age > 12 && age < 18)
                    {
                        if (Tickets > 1)
                            Console.WriteLine($"Querido {name}, has comprado {Tickets} boletas, y tienes que pagar {boletaValorNormal * Tickets}");
                        else 
                           Console.WriteLine($"Querido {name}, has comprado {Tickets} boleta, y tienes que pagar {boletaValorNormal * Tickets}");  

                    }
                    if (age >= 18 && age <= 60)
                    {
                        if (Tickets > 1)
                            Console.WriteLine($"Querido {name}, has comprado {Tickets} boletas, y tienes que pagar {boletaAdulto * Tickets}");
                        else 
                           Console.WriteLine($"Querido {name}, has comprado {Tickets} boleta, y tienes que pagar {boletaAdulto * Tickets}");  

                    }
                    if (age > 60 )
                    {
                        if (Tickets > 1)
                            Console.WriteLine($"Querido {name}, has comprado {Tickets} boletas, y tienes que pagar {boletaAdultoMayor * Tickets}");
                        else 
                           Console.WriteLine($"Querido {name}, has comprado {Tickets} boleta, y tienes que pagar {boletaAdultoMayor * Tickets}");  

                    }
                }
                else
                {
                    Console.WriteLine("Esta cantidad es invalida!"); 
                }
            } 
        }


    }

    
    static void Main()
    {
        BeginApp(); 

    }

    static void BeginApp ()
    {
        Console.WriteLine("Cinema Uniguajira");

        Console.WriteLine("Eres estudiante o no? (s/n)");
        string input = Console.ReadLine().ToLower();  

        ActionInput(input); 

    }

    public static void ActionInput(string input)
    {
       switch (input)
        {
            case "s": 
                Console.Clear(); 
                BeginStudent(); 
                break; 
            case "n":
                Beginperson(); 
                break;
            default: 
                Console.WriteLine("Ingresa un valor valido");
                break;   
        }
    }

    public static void BeginStudent ()
    {
        Console.Write("Ingrese su codigo estudiantil: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int code))
        {
            Student student = new Student(code); 

            Console.WriteLine(student); 

        }
        else
        {
            Console.WriteLine("Ingresa un valor adecuado"); 
        }
              
    }

    public static void Beginperson()
    {
        Console.Write("Ingrese su nombre: ");
        string name = Console.ReadLine();

       
        
        Console.Write("Ingrese su edad: ");
        string age = Console.ReadLine(); 

        if (int.TryParse(age, out int userAge))
        {
            if (userAge > 0)
            {
                Console.WriteLine("Tienes Alguna Discapacidad? (s/n)");
                string input = Console.ReadLine().ToLower(); 

                switch (input)
                {
                    case "s":
                        Incapcitada(name);  
                        break; 
                    case "n": 
                        NormalPerson(name, userAge);  
                        break; 
                    default: 
                        Console.WriteLine("Solo debes de ingresar S o N");
                        break;  
                }
            } 
            else
            {
                Console.WriteLine("Ingresa una edad valida"); 
            }
        } 
        else 
            Console.WriteLine("Debes de ingresar un valor valido!"); 
     

        static void Incapcitada (string name)
        {
            Incapacitado incapacitado = new Incapacitado(name); 

            Console.WriteLine(incapacitado); 
        }

        static void NormalPerson (string name, int age)
        {
            Person persona = new Person(name, age); 

            Console.WriteLine(persona); 
        }


    }
    
    

}
