using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraformSimCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static int Save()
        {
            //save the file, return 0 on success, 1 on failure
            return 1;
        }

/*        static <something> Load()
        {
            //returns loaded file to put into bitmap
        }
*/
        static void New()
        {
            //new game
            //eventually have difficulty levels Easy, Medium, Hard, Random
            //Size resolution is important as well
            int granularity;
            //display granularity on buttons

            granularity = 10;  //width&height|granularity = size of rectangles

        }
    }

    public class Simulation {
        /*<summary>
           First, get the location, in x,y,z and see if location and all next to it are empty
         * If so, update temperature, and if air, O2, et al levels, then done with cell.
           If no, do above, plus see if life spills over or grows.
             Update toxicity, soil type, water, et al.
           Do this for all pixels and all layers.
           Sync data across threads.  Even if timer ticks, continue where left off.
           Update progress bar, year, pixel color.
           </summary>*/
        public void TerraformSimulation()
        { }
    }
}
