namespace Tut_Borja_David_Gómez_Alayón
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExamine = new System.Windows.Forms.Button();
            this.lstFilePick = new System.Windows.Forms.ComboBox();
            this.chkFileLength = new System.Windows.Forms.CheckBox();
            this.chkLastAccess = new System.Windows.Forms.CheckBox();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.dltFolder = new System.Windows.Forms.Button();
            this.separatorFolder = new System.Windows.Forms.Label();
            this.modifyFolder = new System.Windows.Forms.Button();
            this.createFolder = new System.Windows.Forms.Button();
            this.Ficheros = new System.Windows.Forms.Label();
            this.createFile = new System.Windows.Forms.Button();
            this.modifyFile = new System.Windows.Forms.Button();
            this.dltFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(40, 45);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(378, 20);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.Text = "Directorio";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(343, 211);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExamine
            // 
            this.btnExamine.Location = new System.Drawing.Point(343, 240);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(75, 23);
            this.btnExamine.TabIndex = 2;
            this.btnExamine.Text = "Examinar";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            // 
            // lstFilePick
            // 
            this.lstFilePick.FormattingEnabled = true;
            this.lstFilePick.Location = new System.Drawing.Point(40, 71);
            this.lstFilePick.Name = "lstFilePick";
            this.lstFilePick.Size = new System.Drawing.Size(378, 21);
            this.lstFilePick.Sorted = true;
            this.lstFilePick.TabIndex = 3;
            this.lstFilePick.Text = "Seleccione un archivo";
            // 
            // chkFileLength
            // 
            this.chkFileLength.AutoSize = true;
            this.chkFileLength.Checked = true;
            this.chkFileLength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileLength.Location = new System.Drawing.Point(296, 98);
            this.chkFileLength.Name = "chkFileLength";
            this.chkFileLength.Size = new System.Drawing.Size(122, 17);
            this.chkFileLength.TabIndex = 4;
            this.chkFileLength.Text = "Longitud del archivo";
            this.chkFileLength.UseVisualStyleBackColor = true;
            // 
            // chkLastAccess
            // 
            this.chkLastAccess.AutoSize = true;
            this.chkLastAccess.Checked = true;
            this.chkLastAccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLastAccess.Location = new System.Drawing.Point(284, 121);
            this.chkLastAccess.Name = "chkLastAccess";
            this.chkLastAccess.Size = new System.Drawing.Size(134, 17);
            this.chkLastAccess.TabIndex = 5;
            this.chkLastAccess.Text = "Hora del último acceso";
            this.chkLastAccess.UseVisualStyleBackColor = true;
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(303, 144);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(115, 17);
            this.chkSave.TabIndex = 6;
            this.chkSave.Text = "Guardar resultados";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // dltFolder
            // 
            this.dltFolder.Location = new System.Drawing.Point(343, 299);
            this.dltFolder.Name = "dltFolder";
            this.dltFolder.Size = new System.Drawing.Size(75, 23);
            this.dltFolder.TabIndex = 7;
            this.dltFolder.Text = "Eliminar";
            this.dltFolder.UseVisualStyleBackColor = true;
            this.dltFolder.Click += new System.EventHandler(this.dltFolder_Click);
            // 
            // separatorFolder
            // 
            this.separatorFolder.AutoSize = true;
            this.separatorFolder.Location = new System.Drawing.Point(370, 266);
            this.separatorFolder.Name = "separatorFolder";
            this.separatorFolder.Size = new System.Drawing.Size(44, 13);
            this.separatorFolder.TabIndex = 8;
            this.separatorFolder.Text = "Carpeta";
            // 
            // modifyFolder
            // 
            this.modifyFolder.Location = new System.Drawing.Point(262, 299);
            this.modifyFolder.Name = "modifyFolder";
            this.modifyFolder.Size = new System.Drawing.Size(75, 23);
            this.modifyFolder.TabIndex = 9;
            this.modifyFolder.Text = "Modificar";
            this.modifyFolder.UseVisualStyleBackColor = true;
            // 
            // createFolder
            // 
            this.createFolder.Location = new System.Drawing.Point(181, 299);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(75, 23);
            this.createFolder.TabIndex = 10;
            this.createFolder.Text = "Crear";
            this.createFolder.UseVisualStyleBackColor = true;
            // 
            // Ficheros
            // 
            this.Ficheros.AutoSize = true;
            this.Ficheros.Location = new System.Drawing.Point(367, 325);
            this.Ficheros.Name = "Ficheros";
            this.Ficheros.Size = new System.Drawing.Size(47, 13);
            this.Ficheros.TabIndex = 11;
            this.Ficheros.Text = "Ficheros";
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(181, 359);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(75, 23);
            this.createFile.TabIndex = 14;
            this.createFile.Text = "Crear";
            this.createFile.UseVisualStyleBackColor = true;
            // 
            // modifyFile
            // 
            this.modifyFile.Location = new System.Drawing.Point(262, 359);
            this.modifyFile.Name = "modifyFile";
            this.modifyFile.Size = new System.Drawing.Size(75, 23);
            this.modifyFile.TabIndex = 13;
            this.modifyFile.Text = "Modificar";
            this.modifyFile.UseVisualStyleBackColor = true;
            // 
            // dltFile
            // 
            this.dltFile.Location = new System.Drawing.Point(343, 359);
            this.dltFile.Name = "dltFile";
            this.dltFile.Size = new System.Drawing.Size(75, 23);
            this.dltFile.TabIndex = 12;
            this.dltFile.Text = "Eliminar";
            this.dltFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.modifyFile);
            this.Controls.Add(this.dltFile);
            this.Controls.Add(this.Ficheros);
            this.Controls.Add(this.createFolder);
            this.Controls.Add(this.modifyFolder);
            this.Controls.Add(this.separatorFolder);
            this.Controls.Add(this.dltFolder);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.chkLastAccess);
            this.Controls.Add(this.chkFileLength);
            this.Controls.Add(this.lstFilePick);
            this.Controls.Add(this.btnExamine);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.ComboBox lstFilePick;
        private System.Windows.Forms.CheckBox chkFileLength;
        private System.Windows.Forms.CheckBox chkLastAccess;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.Button dltFolder;
        private System.Windows.Forms.Label separatorFolder;
        private System.Windows.Forms.Button modifyFolder;
        private System.Windows.Forms.Button createFolder;
        private System.Windows.Forms.Label Ficheros;
        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.Button modifyFile;
        private System.Windows.Forms.Button dltFile;
    }
}

