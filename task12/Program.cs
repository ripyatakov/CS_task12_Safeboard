using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/ripyatakov
namespace Kaspersky.SafeBoard
{
    class Program
    {
        public enum DataType
        {
            None = 0,
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4
        }
        static List<string> array = new List<string>( new string[] { "None", "First", "Second", "Third", "Fourth", "0", "1", "2", "3", "4" } );
        static void Main(string[] args)
        {
            int k;
            string input = Console.ReadLine();
            if ( input == null || input == "" )
            {
                Console.WriteLine( "No data" );
                return;
            }
            int[] count = new int[5] { 0, 0, 0, 0, 0 };
            string errors = "";
            var arr = input.Split( ',' );
            foreach ( var w in arr )
            {
                int index = array.IndexOf( w );
                if ( index >= 0 )
                {
                    index %= 5;
                    count[index]++;
                }
                else
                {
                    if ( errors == "" )
                    {
                        errors += w;

                    }
                    else
                        errors += "," + w;
                }

            }
            Console.WriteLine(
                "Input data types:\n" +
                $"None(0)-{count[0]}\n" +
                $"First(1)-{count[1]}\n" +
                $"Second(2)-{count[2]}\n" +
                $"Third(3)-{count[3]}\n" +
                $"Fourth(4)-{count[4]}\n" +
                "Errors:\n" +
                "Not valid input strings: " + errors );
            Console.ReadLine();

        }
    }
}
