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

            lstFilePick.Items.Clear();
            string sourceDirectory = NewPath;
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory);
                var txtDirectories = Directory.EnumerateDirectories(sourceDirectory);

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    lstFilePick.Items.Add(currentFile);

                }

                foreach (string currentDirectory in txtDirectories)
                {
                    string fileName = currentDirectory.Substring(sourceDirectory.Length + 1);
                    lstFilePick.Items.Add(currentDirectory);

                }
            }
            catch (Exception f)
            {
                MessageBox.Show("Comprueba que el fichero o directorio existe y vuelvelo a intentar.");
            }

        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (checkIfFolder())
            {
                DirectoryInfo thisDirectory = new DirectoryInfo(lstFilePick.SelectedItem.ToString());

                string texto = "Los atributos del directorio " + lstFilePick.SelectedItem.ToString() + " son : ";

                texto = texto + "La creación del directorio se efectuó el: " + thisDirectory.CreationTime.ToString();

                texto = texto + " última modificación fue: " + thisDirectory.LastAccessTime.ToString();

                if (chkSave.Checked)
                {
                    // si no existe el fichero lo crea y si existe sobreescribe el contenido

                    File.WriteAllText(NewPath + "/log.txt", texto);

                }

                MessageBox.Show(texto);
            }
            else
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
            


        }


        private Boolean checkIfFolder()
        {
            FileInfo thisFile = new FileInfo(lstFilePick.SelectedItem.ToString());

            if (thisFile.Attributes.HasFlag(FileAttributes.Directory))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dltFolder_Click(object sender, EventArgs e)
        {
            if (checkIfFolder())
            {
                DialogResult result = MessageBox.Show("¿quieres eliminarlo junto a todo su contenido?", "Estás eliminando un directorio", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                    {
                            try
                            {
                                Directory.Delete(lstFilePick.SelectedItem.ToString(), true);
                                MessageBox.Show("Ha sido eliminado con éxito");
                            }
                            catch (Exception f)
                            {
                                MessageBox.Show("Ha habido un error");
                            }
                            
                            break;
                    }
                    case DialogResult.No:
                    {
                            MessageBox.Show("No ha sido eliminado");
                            break;
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿seguro/a de que quieres eliminarlo?", "Estás eliminando un fichero", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            try
                            {
                                File.Delete(lstFilePick.SelectedItem.ToString());
                                MessageBox.Show("Ha sido eliminado con éxito");
                            }
                            catch (Exception f)
                            {
                                MessageBox.Show("Ha habido un error, comprueba que no estás usando el fichero");
                            }

                            break;
                        }
                    case DialogResult.No:
                        {
                            MessageBox.Show("No ha sido eliminado");
                            break;
                        }
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (checkIfFolder())
            {
                txtDirectory.Text = lstFilePick.SelectedItem.ToString();
                

            }
            else
            {
                MessageBox.Show("Selecciona un directorio y no un fichero para realizar esta operación.");
            }
        }

        private void modifyFolder_Click(object sender, EventArgs e)
        {

        }

        private void createFolder_Click(object sender, EventArgs e)
        {

        }
    }
}
