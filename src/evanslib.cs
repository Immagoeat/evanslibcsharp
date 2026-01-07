namespace evanslib
{
    public class Evanslib{
    
        public static string date(){return DateTime.Now.ToString("MM/dd/yyyy");}
        public static string timeMT(){return DateTime.Now.ToString("HH:mm:ss");}
        public static string timeUT(){return DateTime.Now.ToString("hh:mm:ss tt");}
        public static string month(){return DateTime.Now.ToString("MMM");}
        public static string dateTime(){return DateTime.Now.ToString("MM/dd/yyyy" + " " + "HH:mm:ss");}

        public static void Print<T>(T value){
            if (value is Dictionary<string, string> dict){
                foreach (var values in dict){
                    Console.WriteLine($"{values.Key}: {values.Value}");
                }        
            }
    
            else {
                Console.WriteLine(value);
            }
        }

        public static string Input(){
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)){
                throw new Exception("Evanslib error: Input of 'null'");
            }
            return input;
        }


        public static Dictionary<string, string> Dict(){
            var evanslibdict = new Dictionary<string, string>();
            return evanslibdict;
        }

        public static void modifyDict(Dictionary<string, string> dict, string name, string value){
             dict [name] = value;
        }

        public static void Error(string crashreason, int number){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR " + number + ": " + crashreason);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public static void exitError(string crashreason, int number){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR " + number + ": " + crashreason);
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }

        public static void Exit(){
            Environment.Exit(0);
        }


    }
}

