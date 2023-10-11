namespace trabalho_SEMESTREprog
{
    partial class aba_cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.nome_usu = new System.Windows.Forms.Label();
            this.lplaca = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.modelo_carro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.confirmar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "cadastre-se";
            // 
            // nome_usu
            // 
            this.nome_usu.AutoSize = true;
            this.nome_usu.Location = new System.Drawing.Point(75, 166);
            this.nome_usu.Name = "nome_usu";
            this.nome_usu.Size = new System.Drawing.Size(39, 13);
            this.nome_usu.TabIndex = 1;
            this.nome_usu.Text = "NOME";
            // 
            // lplaca
            // 
            this.lplaca.AutoSize = true;
            this.lplaca.Location = new System.Drawing.Point(75, 105);
            this.lplaca.Name = "lplaca";
            this.lplaca.Size = new System.Drawing.Size(41, 13);
            this.lplaca.TabIndex = 2;
            this.lplaca.Text = "PLACA";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(75, 217);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(27, 13);
            this.cpf.TabIndex = 3;
            this.cpf.Text = "CPF";
            // 
            // modelo_carro
            // 
            this.modelo_carro.AutoSize = true;
            this.modelo_carro.Location = new System.Drawing.Point(75, 269);
            this.modelo_carro.Name = "modelo_carro";
            this.modelo_carro.Size = new System.Drawing.Size(45, 13);
            this.modelo_carro.TabIndex = 4;
            this.modelo_carro.Text = "CARRO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.confirmar.Location = new System.Drawing.Point(177, 350);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(124, 33);
            this.confirmar.TabIndex = 9;
            this.confirmar.Text = "SALVAR";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.editar.Location = new System.Drawing.Point(177, 400);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(124, 32);
            this.editar.TabIndex = 44;
            this.editar.Text = "EDITAR";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(925, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(173, 149);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Carro";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.delete.Location = new System.Drawing.Point(177, 450);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(124, 33);
            this.delete.TabIndex = 46;
            this.delete.Text = "DELETAR";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // aba_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 604);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modelo_carro);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.lplaca);
            this.Controls.Add(this.nome_usu);
            this.Controls.Add(this.label1);
            this.Name = "aba_cadastro";
            this.Text = "aba_cadastro";
            this.Load += new System.EventHandler(this.aba_cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nome_usu;
        private System.Windows.Forms.Label lplaca;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label modelo_carro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button delete;
    }
}