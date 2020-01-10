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
    public partial class Form1 : Form
    {
        
        String NewPath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDirectory.Text = Directory.GetCurrentDirectory();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NewPath = " NewPath holds the path the user has entered.";
            NewPath = txtDirectory.Text;
            string ErrorMessage = null;
            try
            {
                Directory.SetCurrentDirectory(NewPath);
            }catch(DirectoryNotFoundException f)
            {
                ErrorMessage = "You must enter a valid path. If trying to access a different drive, remember to include the drive letter.";
            }
            catch
            { //' This checks to make sure the path is not blank.
                ErrorMessage = "You must enter a path.";
            }
            finally
            {
                //' Display the error message only if one exists.
                if (ErrorMessage != null)
                    MessageBox.Show(ErrorMessage);

            }

            string sourceDirectory = NewPath;

            var txtFiles = Directory.EnumerateFiles(sourceDirectory);
            foreach (string currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                lstFilePick.Items.Add(currentFile);

            }



        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            FileInfo thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());

            string texto = "Los atributos del fichero " + lstFilePick.SelectedItem.ToString() + " son : ";
            if (chkFileLength.Checked)
            {
                texto = texto + " La Longitud del fichero es : " +
               thisFile.Length.ToString();
            }
            if (chkLastAccess.Checked)
            {
                texto = texto + " última modificación fue : " +
               thisFile.LastAccessTime.ToString();
            }

            if (chkSave.Checked)
            {
                // si no existe el fichero lo crea y si existe sobreescribe el contenido

                File.WriteAllText(NewPath + "/log.txt", texto);

            }

            MessageBox.Show(texto);


        }

        private void dltFolder_Click(object sender, EventArgs e)
        {
            
            FileInfo thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());

            if(thisFile.Attributes.HasFlag(FileAttributes.Directory)){

            }
            else
            {

            }
        }
    }
}
