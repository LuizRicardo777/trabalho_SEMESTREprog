namespace trabalho_SEMESTREprog
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visu_vagas = new System.Windows.Forms.Button();
            this.cad_carros = new System.Windows.Forms.Button();
            this.cad_funcionario = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CAD_VAGAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Location = new System.Drawing.Point(769, 47);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(407, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(593, 487);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // visu_vagas
            // 
            this.visu_vagas.BackColor = System.Drawing.SystemColors.Info;
            this.visu_vagas.Location = new System.Drawing.Point(32, 871);
            this.visu_vagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.visu_vagas.Name = "visu_vagas";
            this.visu_vagas.Size = new System.Drawing.Size(239, 42);
            this.visu_vagas.TabIndex = 36;
            this.visu_vagas.Text = "visualizar vagas";
            this.visu_vagas.UseVisualStyleBackColor = false;
            this.visu_vagas.Click += new System.EventHandler(this.visu_vagas_Click);
            // 
            // cad_carros
            // 
            this.cad_carros.Location = new System.Drawing.Point(32, 219);
            this.cad_carros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cad_carros.Name = "cad_carros";
            this.cad_carros.Size = new System.Drawing.Size(235, 46);
            this.cad_carros.TabIndex = 37;
            this.cad_carros.Text = "CARROS";
            this.cad_carros.UseVisualStyleBackColor = true;
            this.cad_carros.Click += new System.EventHandler(this.cad_carros_Click);
            // 
            // cad_funcionario
            // 
            this.cad_funcionario.Location = new System.Drawing.Point(32, 294);
            this.cad_funcionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cad_funcionario.Name = "cad_funcionario";
            this.cad_funcionario.Size = new System.Drawing.Size(235, 43);
            this.cad_funcionario.TabIndex = 38;
            this.cad_funcionario.Text = "USUÁRIO";
            this.cad_funcionario.UseVisualStyleBackColor = true;
            this.cad_funcionario.Click += new System.EventHandler(this.cad_funcionario_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 362);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 386);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "vaga1 ",
            "vaga2"});
            this.comboBox1.Location = new System.Drawing.Point(769, 294);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(407, 24);
            this.comboBox1.TabIndex = 82;
            // 
            // CAD_VAGAS
            // 
            this.CAD_VAGAS.Location = new System.Drawing.Point(1491, 63);
            this.CAD_VAGAS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CAD_VAGAS.Name = "CAD_VAGAS";
            this.CAD_VAGAS.Size = new System.Drawing.Size(293, 55);
            this.CAD_VAGAS.TabIndex = 83;
            this.CAD_VAGAS.Text = "CAD_VAGAS";
            this.CAD_VAGAS.UseVisualStyleBackColor = true;
            this.CAD_VAGAS.Click += new System.EventHandler(this.CAD_VAGAS_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1844, 1026);
            this.Controls.Add(this.CAD_VAGAS);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cad_funcionario);
            this.Controls.Add(this.cad_carros);
            this.Controls.Add(this.visu_vagas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "livre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button visu_vagas;
        private System.Windows.Forms.Button cad_carros;
        private System.Windows.Forms.Button cad_funcionario;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CAD_VAGAS;
    }
}

