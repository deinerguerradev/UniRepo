using System; 

class Program {

    class Student
    {
        private static Dictionary<int, List<string>> StudentDataBase = new Dictionary<int, List<string>>
        {
            {123456, new List<string> {"deiner guerra", "17", "true", "" }},
            {123457, new List<string> {"Simo Garcia", "19", "false", "" }}
        }; 
        private static float boletaEstudianteValor = 5000.0f; 
        

        public Student(int code)
        {
            if (StudentDataBase.ContainsKey(code))
            {
                MakeOrder(code); 
            }
            else 
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
        public static string name; 
        public static bool TieneIncapacidad;
        public static int boleta; 
    }

    class Person
    {
        public static string name; 
        public static int age; 
        public static int boleta;   
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
    
    

}
