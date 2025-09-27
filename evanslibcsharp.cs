using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace evanslib{

    public class Evanslib{


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

        public static void createWindow(string windowname){
            var nativeSettings = new NativeWindowSettings() {
            Size = new Vector2i(800, 600),
            Title = "Hello OpenTK!"
        };

        using var window = new GameWindow(GameWindowSettings.Default, nativeSettings);
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