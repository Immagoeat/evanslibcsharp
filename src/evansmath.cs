using System.Numerics;
using System.Text.RegularExpressions;
using evanslib;


namespace evansmath
{
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



        public static string FindX(string equasion){

            //Debug mode (dev use)

            double a = 0;
            double b = 0;
            double side = 1;

            foreach (var part in equasion.Replace(" ", "").Split("="))
            {
                foreach (Match match in Regex.Matches(part, @"[+-]?\d*x|[+-]?\d+"))
                {
                    string str = match.Value;
                    if (str.EndsWith("x"))
                    {
                        str = str.Replace("x", "");
                        double value = (str == "" || str == "+") ? 1 : (str == "-") ? -1 : double.Parse(str);
                        a += value * side;
                    }
                    else b += double.Parse(str) * side;
                }
                side = -1;
            }
            if (a == 0) return b == 0 ? "Infinite solutions" : "No solutions";
            return $"x = {-b / a}"; 
        }

        public static string PercentOf(string equasion)
        {
                //8% of 12
                string[] splitequasion = equasion.Split("of");
                string percent = splitequasion[0];
                string totalvalue = splitequasion[1];
                

                percent = percent.Replace("%", "");

                try
                {
                    double test1 = double.Parse(percent);
                    double test2 = double.Parse(totalvalue);
                }

                catch
                {
                    throw new Exception("Evansmath error: Equasion is inputted incorrectly");
                }

                double part1 = double.Parse(percent);
                double part2 = double.Parse(totalvalue);
                return (part1 * part2 / 100).ToString();
        }

        public static string PercentIncrease(double start, double end)
        {
            double bob = ((end - start)/start) * 100;
            if (bob >= 0)
            {
                string ans = bob.ToString() + "% (increase)";
                return ans;
            }

            else if (bob < 0)
            {
                string ans = bob.ToString() + "% (decrease)";
                return ans;
            }

            else
            {
                return "";
            }
            
        }

    }
}