using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TerraformSimCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Init the background, and all the pictureboxes, as well as the progress bar and buttons
               picturebox1 holds the map for the planet.  Each pixel is some region that is being terraformed
               picturebox2 holds the pixel data, but shows it per layer
               progressbar shows how close planet is to being terraformed
               time shows elapsed years
               start, stop, save, load, new = std buttons
               load chart and break up pixeldata into individual threads for faster computation
             */
            this.BackColor = Color.Black;
            this.planetMap.BackColor = Color.Black;
            //this.pictureBox1.BorderStyle = BorderStyle.FixedSingle.Equals(10px);

            this.planetLayers.BackColor = Color.PowderBlue;

            //progress bar
            this.terraformProgress.ForeColor = Color.Green;
            this.terraformProgress.BackColor = Color.Red;

            //add data
            Bitmap surfacemap = new Bitmap(planetMap.Height, planetMap.Width);
            //add graphics

            //hook up timer
            
        }
    }
}
