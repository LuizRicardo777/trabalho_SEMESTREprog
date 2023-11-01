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
            this.CÓDIGO_USER = new System.Windows.Forms.Label();
            this.NOME2 = new System.Windows.Forms.Label();
            this.HORÁRIO = new System.Windows.Forms.Label();
            this.SALVAR2 = new System.Windows.Forms.Button();
            this.EDITAR2 = new System.Windows.Forms.Button();
            this.DELETAR2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.HORARIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CÓDIGO_USER
            // 
            this.CÓDIGO_USER.AutoSize = true;
            this.CÓDIGO_USER.Location = new System.Drawing.Point(73, 60);
            this.CÓDIGO_USER.Name = "CÓDIGO_USER";
            this.CÓDIGO_USER.Size = new System.Drawing.Size(126, 13);
            this.CÓDIGO_USER.TabIndex = 0;
            this.CÓDIGO_USER.Text = "CÓDIGO FUNCIONÁRIO";
            // 
            // NOME2
            // 
            this.NOME2.AutoSize = true;
            this.NOME2.Location = new System.Drawing.Point(76, 149);
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
            this.SALVAR2.Location = new System.Drawing.Point(307, 269);
            this.SALVAR2.Name = "SALVAR2";
            this.SALVAR2.Size = new System.Drawing.Size(75, 23);
            this.SALVAR2.TabIndex = 3;
            this.SALVAR2.Text = "SALVAR";
            this.SALVAR2.UseVisualStyleBackColor = false;
            // 
            // EDITAR2
            // 
            this.EDITAR2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EDITAR2.Location = new System.Drawing.Point(307, 312);
            this.EDITAR2.Name = "EDITAR2";
            this.EDITAR2.Size = new System.Drawing.Size(75, 23);
            this.EDITAR2.TabIndex = 4;
            this.EDITAR2.Text = "EDITAR";
            this.EDITAR2.UseVisualStyleBackColor = false;
            // 
            // DELETAR2
            // 
            this.DELETAR2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DELETAR2.Location = new System.Drawing.Point(307, 356);
            this.DELETAR2.Name = "DELETAR2";
            this.DELETAR2.Size = new System.Drawing.Size(75, 23);
            this.DELETAR2.TabIndex = 5;
            this.DELETAR2.Text = "DELETAR";
            this.DELETAR2.UseVisualStyleBackColor = false;
            this.DELETAR2.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // HORARIO
            // 
            this.HORARIO.AutoSize = true;
            this.HORARIO.Location = new System.Drawing.Point(79, 232);
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.Size = new System.Drawing.Size(57, 13);
            this.HORARIO.TabIndex = 9;
            this.HORARIO.Text = "HORÁRIO";
            // 
            // aba_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HORARIO);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DELETAR2);
            this.Controls.Add(this.EDITAR2);
            this.Controls.Add(this.SALVAR2);
            this.Controls.Add(this.HORÁRIO);
            this.Controls.Add(this.NOME2);
            this.Controls.Add(this.CÓDIGO_USER);
            this.Name = "aba_usuario";
            this.Text = "aba_usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CÓDIGO_USER;
        private System.Windows.Forms.Label NOME2;
        private System.Windows.Forms.Label HORÁRIO;
        private System.Windows.Forms.Button SALVAR2;
        private System.Windows.Forms.Button EDITAR2;
        private System.Windows.Forms.Button DELETAR2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label HORARIO;
    }
}