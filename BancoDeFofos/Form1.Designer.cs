namespace BancoDeFofos
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
            this.components = new System.ComponentModel.Container();
            this.btn_Pessoas = new System.Windows.Forms.Button();
            this.dGVPessoa = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eucaliptoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eucaliptoDataSet = new BancoDeFofos.EucaliptoDataSet();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eucaliptoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eucaliptoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pessoas
            // 
            this.btn_Pessoas.Location = new System.Drawing.Point(723, 284);
            this.btn_Pessoas.Name = "btn_Pessoas";
            this.btn_Pessoas.Size = new System.Drawing.Size(136, 49);
            this.btn_Pessoas.TabIndex = 0;
            this.btn_Pessoas.Text = "Pessoas";
            this.btn_Pessoas.UseVisualStyleBackColor = true;
            this.btn_Pessoas.Click += new System.EventHandler(this.btn_Pessoas_Click);
            // 
            // dGVPessoa
            // 
            this.dGVPessoa.AllowUserToDeleteRows = false;
            this.dGVPessoa.AutoGenerateColumns = false;
            this.dGVPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVPessoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.DataNascimento,
            this.Telefone});
            this.dGVPessoa.DataSource = this.eucaliptoDataSetBindingSource;
            this.dGVPessoa.Location = new System.Drawing.Point(0, 0);
            this.dGVPessoa.Name = "dGVPessoa";
            this.dGVPessoa.ReadOnly = true;
            this.dGVPessoa.Size = new System.Drawing.Size(859, 278);
            this.dGVPessoa.TabIndex = 1;
            this.dGVPessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPessoa_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 59;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 96;
            // 
            // DataNascimento
            // 
            this.DataNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Width = 199;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 120;
            // 
            // eucaliptoDataSetBindingSource
            // 
            this.eucaliptoDataSetBindingSource.DataSource = this.eucaliptoDataSet;
            this.eucaliptoDataSetBindingSource.Position = 0;
            // 
            // eucaliptoDataSet
            // 
            this.eucaliptoDataSet.DataSetName = "EucaliptoDataSet";
            this.eucaliptoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(581, 284);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(136, 49);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 345);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dGVPessoa);
            this.Controls.Add(this.btn_Pessoas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eucaliptoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eucaliptoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Pessoas;
        private System.Windows.Forms.DataGridView dGVPessoa;
        private System.Windows.Forms.BindingSource eucaliptoDataSetBindingSource;
        private EucaliptoDataSet eucaliptoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

