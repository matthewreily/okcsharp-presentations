//Show removing unused usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace LiveCodeAnalysisDemo
{
    //Show rename
    public class SweetClass
    {
        public String MyString { get; set; }
        public string anotherString { get;set; }

        public void DoWork(params int[] args)
        {
            //Show Introduce local
            var newNumber = Convert.ToDouble(args[0]) + Convert.ToDouble(args[0]);

            //show in-line temporary variable
            var firstArgument = args[0];
            Console.WriteLine(firstArgument);

            //Show rename
            var icntType = 100;
            for (int i = 0; i < icntType; i++)
            {
                Write(i);
            }
        }
    }
}
