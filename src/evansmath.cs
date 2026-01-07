using System.Numerics;

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
                
            char[] delimeters = ['+', '-', '*', '/'];

            string withoutspaces = equasion.Replace(" ", "");

            string[] firstsplit = equasion.Split("=");
            string oldleft = firstsplit[0];
            string oldright = firstsplit[1];

            for (int i = 0; i < 5; i++)
            {
                
            }

            return withoutspaces;
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