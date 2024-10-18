namespace PAtividade7
{
    partial class frmExercicio1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rchTxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacosBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtFrase
            // 
            this.rchTxtFrase.Location = new System.Drawing.Point(213, 63);
            this.rchTxtFrase.Name = "rchTxtFrase";
            this.rchTxtFrase.Size = new System.Drawing.Size(337, 139);
            this.rchTxtFrase.TabIndex = 0;
            this.rchTxtFrase.Text = "";
            // 
            // btnEspacosBranco
            // 
            this.btnEspacosBranco.Location = new System.Drawing.Point(102, 289);
            this.btnEspacosBranco.Name = "btnEspacosBranco";
            this.btnEspacosBranco.Size = new System.Drawing.Size(137, 65);
            this.btnEspacosBranco.TabIndex = 1;
            this.btnEspacosBranco.Text = "Espaços em Branco";
            this.btnEspacosBranco.UseVisualStyleBackColor = true;
            this.btnEspacosBranco.Click += new System.EventHandler(this.btnEspacosBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(323, 289);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(137, 65);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Letras R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnParLetra
            // 
            this.btnParLetra.Location = new System.Drawing.Point(537, 289);
            this.btnParLetra.Name = "btnParLetra";
            this.btnParLetra.Size = new System.Drawing.Size(137, 65);
            this.btnParLetra.TabIndex = 3;
            this.btnParLetra.Text = "Mesmo par de letras";
            this.btnParLetra.UseVisualStyleBackColor = true;
            this.btnParLetra.Click += new System.EventHandler(this.btnParLetra_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetra);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacosBranco);
            this.Controls.Add(this.rchTxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "Exercício 1";
            this.Load += new System.EventHandler(this.frmExercicio1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rchTxtFrase;
        private System.Windows.Forms.Button btnEspacosBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnParLetra;
    }
}