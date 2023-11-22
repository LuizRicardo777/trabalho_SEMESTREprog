namespace trabalho_SEMESTREprog
{
    partial class aba_usuario
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
            this.NOME2 = new System.Windows.Forms.Label();
            this.HORÁRIO = new System.Windows.Forms.Label();
            this.SALVAR2 = new System.Windows.Forms.Button();
            this.tbt_nome = new System.Windows.Forms.TextBox();
            this.tbt_senha = new System.Windows.Forms.TextBox();
            this.SENHA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NOME2
            // 
            this.NOME2.AutoSize = true;
            this.NOME2.Location = new System.Drawing.Point(79, 57);
            this.NOME2.Name = "NOME2";
            this.NOME2.Size = new System.Drawing.Size(39, 13);
            this.NOME2.TabIndex = 1;
            this.NOME2.Text = "NOME";
            // 
            // HORÁRIO
            // 
            this.HORÁRIO.AutoSize = true;
            this.HORÁRIO.Location = new System.Drawing.Point(76, 232);
            this.HORÁRIO.Name = "HORÁRIO";
            this.HORÁRIO.Size = new System.Drawing.Size(10, 13);
            this.HORÁRIO.TabIndex = 2;
            this.HORÁRIO.Text = " ";
            this.HORÁRIO.Click += new System.EventHandler(this.label3_Click);
            // 
            // SALVAR2
            // 
            this.SALVAR2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SALVAR2.Location = new System.Drawing.Point(183, 285);
            this.SALVAR2.Name = "SALVAR2";
            this.SALVAR2.Size = new System.Drawing.Size(155, 42);
            this.SALVAR2.TabIndex = 3;
            this.SALVAR2.Text = "SALVAR";
            this.SALVAR2.UseVisualStyleBackColor = false;
            this.SALVAR2.Click += new System.EventHandler(this.SALVAR2_Click);
            // 
            // tbt_nome
            // 
            this.tbt_nome.Location = new System.Drawing.Point(82, 86);
            this.tbt_nome.Name = "tbt_nome";
            this.tbt_nome.Size = new System.Drawing.Size(229, 20);
            this.tbt_nome.TabIndex = 7;
            // 
            // tbt_senha
            // 
            this.tbt_senha.Location = new System.Drawing.Point(79, 186);
            this.tbt_senha.Name = "tbt_senha";
            this.tbt_senha.Size = new System.Drawing.Size(232, 20);
            this.tbt_senha.TabIndex = 8;
            // 
            // SENHA
            // 
            this.SENHA.AutoSize = true;
            this.SENHA.Location = new System.Drawing.Point(82, 142);
            this.SENHA.Name = "SENHA";
            this.SENHA.Size = new System.Drawing.Size(44, 13);
            this.SENHA.TabIndex = 9;
            this.SENHA.Text = "SENHA";
            // 
            // aba_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SENHA);
            this.Controls.Add(this.tbt_senha);
            this.Controls.Add(this.tbt_nome);
            this.Controls.Add(this.SALVAR2);
            this.Controls.Add(this.HORÁRIO);
            this.Controls.Add(this.NOME2);
            this.Name = "aba_usuario";
            this.Text = "aba_usuario";
            this.Load += new System.EventHandler(this.aba_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NOME2;
        private System.Windows.Forms.Label HORÁRIO;
        private System.Windows.Forms.Button SALVAR2;
        private System.Windows.Forms.TextBox tbt_nome;
        private System.Windows.Forms.TextBox tbt_senha;
        private System.Windows.Forms.Label SENHA;
    }
}