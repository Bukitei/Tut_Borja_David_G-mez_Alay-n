namespace Tut_Borja_David_Gómez_Alayón
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.directoryLbl = new System.Windows.Forms.Label();
            this.directoryTxt = new System.Windows.Forms.TextBox();
            this.typeCmb = new System.Windows.Forms.ComboBox();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(60, 47);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Nombre:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(60, 80);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(84, 13);
            this.typeLbl.TabIndex = 1;
            this.typeLbl.Text = "Tipo de archivo:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(161, 40);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(303, 20);
            this.nameTxt.TabIndex = 2;
            // 
            // directoryLbl
            // 
            this.directoryLbl.AutoSize = true;
            this.directoryLbl.Location = new System.Drawing.Point(60, 117);
            this.directoryLbl.Name = "directoryLbl";
            this.directoryLbl.Size = new System.Drawing.Size(55, 13);
            this.directoryLbl.TabIndex = 4;
            this.directoryLbl.Text = "Directorio:";
            // 
            // directoryTxt
            // 
            this.directoryTxt.Location = new System.Drawing.Point(161, 114);
            this.directoryTxt.Name = "directoryTxt";
            this.directoryTxt.Size = new System.Drawing.Size(303, 20);
            this.directoryTxt.TabIndex = 5;
            // 
            // typeCmb
            // 
            this.typeCmb.FormattingEnabled = true;
            this.typeCmb.Location = new System.Drawing.Point(161, 80);
            this.typeCmb.Name = "typeCmb";
            this.typeCmb.Size = new System.Drawing.Size(148, 21);
            this.typeCmb.TabIndex = 6;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(233, 204);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 7;
            this.create.Text = "Crear";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(347, 204);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 317);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.typeCmb);
            this.Controls.Add(this.directoryTxt);
            this.Controls.Add(this.directoryLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label directoryLbl;
        private System.Windows.Forms.TextBox directoryTxt;
        private System.Windows.Forms.ComboBox typeCmb;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
    }
}