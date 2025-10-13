using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata.Ecma335;

namespace evanslib{

    public class Evanslib{
    
        public static string date = DateTime.Now.ToString("MM/dd/yyyy");
        public static string timeMT = DateTime.Now.ToString("HH:mm:ss");
        public static string timeUT = DateTime.Now.ToString("hh:mm:ss tt");
        public static string month = DateTime.Now.ToString("MMM");
        public static string dateTime = DateTime.Now.ToString("MM/dd/yyyy" + " " + "HH:mm:ss");


        public static void Print<T>(T value){
            if (value is Dictionary<string, string> dict){
                foreach (var values in dict){
                    Console.WriteLine($"{values.Key}: {values.Value}");
                }        
            }

            
            else{
                Console.WriteLine(value);
            }
        }

        public static string Input(){
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)){
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EVANSLIB ERROR (1): Input of 'null' (ELER1)");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);
                return "";
            }
            return input;
        }

        public static Dictionary<string, string> Dict(){
            var evanslibdict = new Dictionary<string, string>();
            return evanslibdict;
        }

        public static void modifyDict(Dictionary<string, string> dict, string name, string value){
            dict[name] = value;
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