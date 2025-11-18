using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace evanslib{

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

    public class Evansmath{
        
    public static double Add(double first, double second){
        double ans = first + second;
        return ans;
    }
    
    public static double Subtract(double first, double second){
        double ans = first - second;
        return ans;
    }
    
    public static double Multiply(double first, double second){
        double ans = first * second;
        return ans;
    }
    
    public static double Divide(double first, double second){
        double ans = first / second;
        return ans;
    }

    public static string FindX(string equasion)
        {
            string[] split = equsion.Split('=');
            string firsthalf = split[0];
            string secondhalf = split[1];

            string[] firsthalfsplit = firsthalf.Split(' ');
            string xvalue = firsthalfsplit[0];
            xvalue = xvalue.Replace("x", "");
            string whattodo = firsthalfsplit[1];
            string otheritem = firsthalfsplit[2];
            string equalsvalue = secondhalf;

            try{
                double x = double.Parse(xvalue);
                double addvalue = double.Parse(othreitem);
                double equals = double.Parse(equalsvalue);
            }
        
            double ans = equals - addvalue;
            return ans;
        }

    public static string FindMultiX(string equasion)
        {
            //Initial split
            string[] equasionsplit = equasion.Split('=');
            string firsthalf = equasionsplit[0];
            string secondhalf = equasionsplit[1];

            //Split into chars
            string[] splitfirsthalf = firsthalf.Split('+', '-', '*', '/');
            string[] splitsecondhalf = secondhalf.Split('+', '-', '*', '/');
            string one = splitfirsthalf[0];
            string two = splitfirsthalf[1];
            string three = splitsecondhalf[0];
            string four = splitsecondhalf[1];

            //Replace 'x' to not get issues
            one = one.Replace("x", "");
            three = three.Replace("x", "");

            //Try-catch to make sure that no errors
            try
            {
                double test1 = double.Parse(one);
                double test2 = double.Parse(two);
                double test3 = double.Parse(three);
                double test4 = double.Parse(four);
            }

            catch
            {
                Evanslib.exitError("Can't use strings in equasion except for 'x'", 1);
            }

            //Parse
            double ax = double.Parse(one);
            double b = double.Parse(two);
            double cx = double.Parse(three);
            double d = double.Parse(four);

            //Setup equasion
            double anspt1 = b - d;
            double anspt2 = ax - cx;
            double ans = anspt2 / anspt1;

            //Coonvert equasion to string
            string answer = ans.ToString();

            return answer;

        }
}
}
