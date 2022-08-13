namespace MinhaTelaFofinha
{
    partial class TelaAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dGVAlunos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 397);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(213, 89);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dGVAlunos
            // 
            this.dGVAlunos.AllowDrop = true;
            this.dGVAlunos.AllowUserToAddRows = false;
            this.dGVAlunos.AllowUserToDeleteRows = false;
            this.dGVAlunos.AllowUserToResizeColumns = false;
            this.dGVAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Idade,
            this.Serie,
            this.Nota1,
            this.Nota2,
            this.Nota3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVAlunos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVAlunos.Location = new System.Drawing.Point(12, 12);
            this.dGVAlunos.Name = "dGVAlunos";
            this.dGVAlunos.RowHeadersWidth = 51;
            this.dGVAlunos.RowTemplate.Height = 24;
            this.dGVAlunos.Size = new System.Drawing.Size(1076, 382);
            this.dGVAlunos.TabIndex = 1;
            this.dGVAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAlunos_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 40;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 115;
            // 
            // Idade
            // 
            this.Idade.Frozen = true;
            this.Idade.HeaderText = "Idade";
            this.Idade.MinimumWidth = 40;
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Width = 111;
            // 
            // Serie
            // 
            this.Serie.Frozen = true;
            this.Serie.HeaderText = "Serie";
            this.Serie.MinimumWidth = 40;
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 106;
            // 
            // Nota1
            // 
            this.Nota1.Frozen = true;
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.MinimumWidth = 40;
            this.Nota1.Name = "Nota1";
            this.Nota1.ReadOnly = true;
            this.Nota1.Width = 123;
            // 
            // Nota2
            // 
            this.Nota2.Frozen = true;
            this.Nota2.HeaderText = "Nota 2";
            this.Nota2.MinimumWidth = 40;
            this.Nota2.Name = "Nota2";
            this.Nota2.ReadOnly = true;
            this.Nota2.Width = 123;
            // 
            // Nota3
            // 
            this.Nota3.Frozen = true;
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.MinimumWidth = 40;
            this.Nota3.Name = "Nota3";
            this.Nota3.ReadOnly = true;
            this.Nota3.Width = 123;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnAdd.Location = new System.Drawing.Point(231, 397);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(216, 89);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Adicionar Aluno";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSave.Location = new System.Drawing.Point(869, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 89);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            this.label1.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNome.Location = new System.Drawing.Point(289, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(625, 38);
            this.txtNome.TabIndex = 1;
            this.txtNome.Visible = false;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtIdade.Location = new System.Drawing.Point(289, 112);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(625, 38);
            this.txtIdade.TabIndex = 2;
            this.txtIdade.Visible = false;
            this.txtIdade.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(188, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade";
            this.label2.Visible = false;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSerie.Location = new System.Drawing.Point(289, 156);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(625, 38);
            this.txtSerie.TabIndex = 3;
            this.txtSerie.Visible = false;
            this.txtSerie.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(188, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serie";
            this.label3.Visible = false;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNota1.Location = new System.Drawing.Point(289, 200);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(625, 38);
            this.txtNota1.TabIndex = 4;
            this.txtNota1.Visible = false;
            this.txtNota1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(188, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nota 1";
            this.label4.Visible = false;
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNota2.Location = new System.Drawing.Point(289, 244);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(625, 38);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.Visible = false;
            this.txtNota2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(188, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota 2";
            this.label5.Visible = false;
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNota3.Location = new System.Drawing.Point(289, 288);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(625, 38);
            this.txtNota3.TabIndex = 6;
            this.txtNota3.Visible = false;
            this.txtNota3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(188, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nota 3";
            this.label6.Visible = false;
            // 
            // TelaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 498);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dGVAlunos);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaAlunos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TelaAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dGVAlunos;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
    }
}