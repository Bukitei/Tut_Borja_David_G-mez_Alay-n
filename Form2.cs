using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut_Borja_David_Gómez_Alayón
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

         private void Form2_Load(object sender, EventArgs e)
        {
            directoryTxt.Text = Directory.GetCurrentDirectory();
            typeCmb.Items.Add("Directorio");
            typeCmb.Items.Add("Fichero");
        }

        private void create_Click(object sender, EventArgs e)
        {
            String name = nameTxt.Text;
            String directory = directoryTxt.Text;
            //if

        }
    }
}
