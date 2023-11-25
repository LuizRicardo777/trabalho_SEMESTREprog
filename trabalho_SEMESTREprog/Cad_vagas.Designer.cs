namespace trabalho_SEMESTREprog
{
    partial class Cad_vagas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbt_vaga = new System.Windows.Forms.TextBox();
            this.tbt_status = new System.Windows.Forms.TextBox();
            this.tbt_placa = new System.Windows.Forms.TextBox();
            this.SALVAR3 = new System.Windows.Forms.Button();
            this.EDITAR3 = new System.Windows.Forms.Button();
            this.REMOVER3 = new System.Windows.Forms.Button();
            this.lv_vagas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(191, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(645, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(191, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLACA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbt_vaga
            // 
            this.tbt_vaga.Location = new System.Drawing.Point(197, 174);
            this.tbt_vaga.Name = "tbt_vaga";
            this.tbt_vaga.Size = new System.Drawing.Size(170, 22);
            this.tbt_vaga.TabIndex = 3;
            // 
            // tbt_status
            // 
            this.tbt_status.Location = new System.Drawing.Point(651, 174);
            this.tbt_status.Name = "tbt_status";
            this.tbt_status.Size = new System.Drawing.Size(175, 22);
            this.tbt_status.TabIndex = 4;
            // 
            // tbt_placa
            // 
            this.tbt_placa.Location = new System.Drawing.Point(197, 414);
            this.tbt_placa.Name = "tbt_placa";
            this.tbt_placa.Size = new System.Drawing.Size(170, 22);
            this.tbt_placa.TabIndex = 5;
            // 
            // SALVAR3
            // 
            this.SALVAR3.Location = new System.Drawing.Point(651, 328);
            this.SALVAR3.Name = "SALVAR3";
            this.SALVAR3.Size = new System.Drawing.Size(175, 51);
            this.SALVAR3.TabIndex = 6;
            this.SALVAR3.Text = "SALVAR";
            this.SALVAR3.UseVisualStyleBackColor = true;
            this.SALVAR3.Click += new System.EventHandler(this.SALVAR3_Click);
            // 
            // EDITAR3
            // 
            this.EDITAR3.Location = new System.Drawing.Point(651, 385);
            this.EDITAR3.Name = "EDITAR3";
            this.EDITAR3.Size = new System.Drawing.Size(175, 51);
            this.EDITAR3.TabIndex = 7;
            this.EDITAR3.Text = "EDITAR";
            this.EDITAR3.UseVisualStyleBackColor = true;
            this.EDITAR3.Click += new System.EventHandler(this.EDITAR3_Click);
            // 
            // REMOVER3
            // 
            this.REMOVER3.Location = new System.Drawing.Point(651, 442);
            this.REMOVER3.Name = "REMOVER3";
            this.REMOVER3.Size = new System.Drawing.Size(175, 51);
            this.REMOVER3.TabIndex = 8;
            this.REMOVER3.Text = "REMOVER";
            this.REMOVER3.UseVisualStyleBackColor = true;
            this.REMOVER3.Click += new System.EventHandler(this.REMOVER3_Click);
            // 
            // lv_vagas
            // 
            this.lv_vagas.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_vagas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_vagas.HideSelection = false;
            this.lv_vagas.Location = new System.Drawing.Point(947, 87);
            this.lv_vagas.Name = "lv_vagas";
            this.lv_vagas.Size = new System.Drawing.Size(266, 349);
            this.lv_vagas.TabIndex = 9;
            this.lv_vagas.UseCompatibleStateImageBehavior = false;
            this.lv_vagas.View = System.Windows.Forms.View.Details;
            this.lv_vagas.SelectedIndexChanged += new System.EventHandler(this.lv_vagas_SelectedIndexChanged);
            this.lv_vagas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_vagas_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vaga";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Placa";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // Cad_vagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 710);
            this.Controls.Add(this.lv_vagas);
            this.Controls.Add(this.REMOVER3);
            this.Controls.Add(this.EDITAR3);
            this.Controls.Add(this.SALVAR3);
            this.Controls.Add(this.tbt_placa);
            this.Controls.Add(this.tbt_status);
            this.Controls.Add(this.tbt_vaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cad_vagas";
            this.Text = "Cad_vagas";
            this.Load += new System.EventHandler(this.Cad_vagas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbt_vaga;
        private System.Windows.Forms.TextBox tbt_status;
        private System.Windows.Forms.TextBox tbt_placa;
        private System.Windows.Forms.Button SALVAR3;
        private System.Windows.Forms.Button EDITAR3;
        private System.Windows.Forms.Button REMOVER3;
        private System.Windows.Forms.ListView lv_vagas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}