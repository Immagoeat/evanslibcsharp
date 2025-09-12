using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace evanslib{

    class Evanslib{


        public static void Print<T>(T value){
            if (value is Dictionary<string, object> dict){
                foreach (var kvp in dict){
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }        
            }
            
            else{
                Console.WriteLine(value);
            }
        }

        public static string Input(){
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)){
                
                exitError("Input value of 'null'");
                return "";
            }
            return input;
        }

        public static void currentDate(){
            DateTime date = DateTime.Now.Date;
            Print(date.ToString("MM/dd/yyyy"));
        }

        public static void currentTimeMT(){
            DateTime time = DateTime.Now;
            Print(time.ToString("HH:mm:ss"));
        }

        public static void currentTimeUT(){
            DateTime time = DateTime.Now;
            Print(time.ToString("hh:mm:ss tt"));
        }

        public static void currentDT(){
            DateTime dt = DateTime.Now;
            Print(dt);
        }

        public static void currentMonth(){
            DateTime dt = DateTime.Now;

            Print(dt.ToString("MMM"));
        }

        public static Dictionary<string, string> Dict(){
            var evanslibdict = new Dictionary<string, string>();
            return evanslibdict;
        }

        public static void ModifyDict(Dictionary<string, string> dict, string name, string value){
            dict[name] = value;
        }

        public static void Error(string crashreason){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Evanslib ERROR: " + crashreason);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void exitError(string crashreason){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Evanslib ERROR: " + crashreason);
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }

        public static void Exit(){
            Environment.Exit(0);
        }


    }

}