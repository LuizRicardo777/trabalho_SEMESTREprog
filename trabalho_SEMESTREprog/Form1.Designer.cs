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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.visu_vagas = new System.Windows.Forms.Button();
            this.cad_carros = new System.Windows.Forms.Button();
            this.cad_funcionario = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OCUP1 = new System.Windows.Forms.RadioButton();
            this.DESO1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CAD_VAGAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(577, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(965, 622);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(363, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // visu_vagas
            // 
            this.visu_vagas.BackColor = System.Drawing.SystemColors.Info;
            this.visu_vagas.Location = new System.Drawing.Point(12, 775);
            this.visu_vagas.Name = "visu_vagas";
            this.visu_vagas.Size = new System.Drawing.Size(188, 34);
            this.visu_vagas.TabIndex = 36;
            this.visu_vagas.Text = "visualizar vagas";
            this.visu_vagas.UseVisualStyleBackColor = false;
            this.visu_vagas.Click += new System.EventHandler(this.visu_vagas_Click);
            // 
            // cad_carros
            // 
            this.cad_carros.Location = new System.Drawing.Point(24, 178);
            this.cad_carros.Name = "cad_carros";
            this.cad_carros.Size = new System.Drawing.Size(176, 37);
            this.cad_carros.TabIndex = 37;
            this.cad_carros.Text = "CARROS";
            this.cad_carros.UseVisualStyleBackColor = true;
            this.cad_carros.Click += new System.EventHandler(this.cad_carros_Click);
            // 
            // cad_funcionario
            // 
            this.cad_funcionario.Location = new System.Drawing.Point(24, 239);
            this.cad_funcionario.Name = "cad_funcionario";
            this.cad_funcionario.Size = new System.Drawing.Size(176, 35);
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
            this.listView1.Location = new System.Drawing.Point(24, 294);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 314);
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
            // OCUP1
            // 
            this.OCUP1.AutoSize = true;
            this.OCUP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OCUP1.Location = new System.Drawing.Point(39, 17);
            this.OCUP1.Name = "OCUP1";
            this.OCUP1.Size = new System.Drawing.Size(120, 28);
            this.OCUP1.TabIndex = 64;
            this.OCUP1.Text = "OCUPADA";
            this.OCUP1.UseVisualStyleBackColor = true;
            this.OCUP1.CheckedChanged += new System.EventHandler(this.OCUP1_CheckedChanged);
            // 
            // DESO1
            // 
            this.DESO1.AutoSize = true;
            this.DESO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DESO1.Location = new System.Drawing.Point(39, 51);
            this.DESO1.Name = "DESO1";
            this.DESO1.Size = new System.Drawing.Size(158, 28);
            this.DESO1.TabIndex = 65;
            this.DESO1.Text = "DESOCUPADA";
            this.DESO1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OCUP1);
            this.panel1.Controls.Add(this.DESO1);
            this.panel1.Location = new System.Drawing.Point(620, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 81;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "vaga1 ",
            "vaga2"});
            this.comboBox1.Location = new System.Drawing.Point(577, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 82;
            // 
            // CAD_VAGAS
            // 
            this.CAD_VAGAS.Location = new System.Drawing.Point(1118, 51);
            this.CAD_VAGAS.Name = "CAD_VAGAS";
            this.CAD_VAGAS.Size = new System.Drawing.Size(220, 45);
            this.CAD_VAGAS.TabIndex = 83;
            this.CAD_VAGAS.Text = "CAD_VAGAS";
            this.CAD_VAGAS.UseVisualStyleBackColor = true;
            this.CAD_VAGAS.Click += new System.EventHandler(this.CAD_VAGAS_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1383, 834);
            this.Controls.Add(this.CAD_VAGAS);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cad_funcionario);
            this.Controls.Add(this.cad_carros);
            this.Controls.Add(this.visu_vagas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "livre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button visu_vagas;
        private System.Windows.Forms.Button cad_carros;
        private System.Windows.Forms.Button cad_funcionario;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton OCUP1;
        private System.Windows.Forms.RadioButton DESO1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CAD_VAGAS;
    }
}

