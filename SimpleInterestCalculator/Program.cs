using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculator
{
    static class Program
    {
        /// Simple interest calculator
        /// Calculating interest by i = p * r * t
        /// Written because I was bored, and this formula is used in my business class. My code is messy too, so shush about it.
        /// All of the code can be found in the button click handler.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
