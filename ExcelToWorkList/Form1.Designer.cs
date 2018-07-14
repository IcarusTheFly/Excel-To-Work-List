namespace WindowsFormsApp1
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
            this.btnInput = new System.Windows.Forms.Button();
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(319, 26);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Select File";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // openExcelFile
            // 
            this.openExcelFile.FileName = "Select your Excel file";
            this.openExcelFile.Filter = "Excel document (*.xlsx)|*.xlsx";
            this.openExcelFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openExcelFile_FileOk);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 28);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(301, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "Select your file...";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 66);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output directory";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 82);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(252, 20);
            this.tbOutput.TabIndex = 3;
            this.tbOutput.Text = "Select the output path...";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(270, 80);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(124, 23);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "Select Directory";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(69, 13);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "File selected:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(270, 109);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(124, 49);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 170);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Excel file conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnGenerate;
    }
}

