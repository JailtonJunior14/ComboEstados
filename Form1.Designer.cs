namespace ComboEstados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.cboCentro = new System.Windows.Forms.ComboBox();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.countEstados = new System.Windows.Forms.Label();
            this.countSudeste = new System.Windows.Forms.Label();
            this.CountCentro = new System.Windows.Forms.Label();
            this.countNorte = new System.Windows.Forms.Label();
            this.countSul = new System.Windows.Forms.Label();
            this.btnRemoverAdd = new System.Windows.Forms.Button();
            this.btnRemoverNordeste = new System.Windows.Forms.Button();
            this.btnRemoverCentro = new System.Windows.Forms.Button();
            this.btnRemoverNorte = new System.Windows.Forms.Button();
            this.btnRemoverSudeste = new System.Windows.Forms.Button();
            this.btnRemoverSul = new System.Windows.Forms.Button();
            this.countNordeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Centro-Oeste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sul:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Acre",
            "Amazonas",
            "Pará",
            "Roraima",
            "Rondônia",
            "Tocantins",
            "Amapá",
            "Alagoas",
            "Bahia",
            "Ceará",
            "Maranhão",
            "Paraíba",
            "Pernambuco",
            "Piauí",
            "Rio Grande do Norte",
            "Distrito Federal",
            "Goiás",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Espírito Santo",
            "Minas Gerais",
            "Rio de Janeiro",
            "São Paulo",
            "Paraná",
            "Santa Catarina",
            "Rio Grande do Sul"});
            this.cboEstados.Location = new System.Drawing.Point(229, 38);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 21);
            this.cboEstados.TabIndex = 6;
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(229, 484);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(121, 21);
            this.cboSul.TabIndex = 7;
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(229, 362);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(121, 21);
            this.cboSudeste.TabIndex = 8;
            // 
            // cboCentro
            // 
            this.cboCentro.FormattingEnabled = true;
            this.cboCentro.Location = new System.Drawing.Point(229, 267);
            this.cboCentro.Name = "cboCentro";
            this.cboCentro.Size = new System.Drawing.Size(121, 21);
            this.cboCentro.TabIndex = 9;
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(229, 197);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(121, 21);
            this.cboNordeste.TabIndex = 10;
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(229, 127);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(121, 21);
            this.cboNorte.TabIndex = 11;
            // 
            // countEstados
            // 
            this.countEstados.AutoSize = true;
            this.countEstados.Location = new System.Drawing.Point(473, 45);
            this.countEstados.Name = "countEstados";
            this.countEstados.Size = new System.Drawing.Size(0, 13);
            this.countEstados.TabIndex = 12;
            // 
            // countSudeste
            // 
            this.countSudeste.AutoSize = true;
            this.countSudeste.Location = new System.Drawing.Point(467, 370);
            this.countSudeste.Name = "countSudeste";
            this.countSudeste.Size = new System.Drawing.Size(0, 13);
            this.countSudeste.TabIndex = 13;
            // 
            // CountCentro
            // 
            this.CountCentro.AutoSize = true;
            this.CountCentro.Location = new System.Drawing.Point(473, 275);
            this.CountCentro.Name = "CountCentro";
            this.CountCentro.Size = new System.Drawing.Size(0, 13);
            this.CountCentro.TabIndex = 14;
            // 
            // countNorte
            // 
            this.countNorte.AutoSize = true;
            this.countNorte.Location = new System.Drawing.Point(473, 135);
            this.countNorte.Name = "countNorte";
            this.countNorte.Size = new System.Drawing.Size(0, 13);
            this.countNorte.TabIndex = 15;
            // 
            // countSul
            // 
            this.countSul.AutoSize = true;
            this.countSul.Location = new System.Drawing.Point(473, 492);
            this.countSul.Name = "countSul";
            this.countSul.Size = new System.Drawing.Size(0, 13);
            this.countSul.TabIndex = 16;
            // 
            // btnRemoverAdd
            // 
            this.btnRemoverAdd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverAdd.Location = new System.Drawing.Point(397, 37);
            this.btnRemoverAdd.Name = "btnRemoverAdd";
            this.btnRemoverAdd.Size = new System.Drawing.Size(30, 23);
            this.btnRemoverAdd.TabIndex = 17;
            this.btnRemoverAdd.Text = "-";
            this.btnRemoverAdd.UseVisualStyleBackColor = true;
            this.btnRemoverAdd.Click += new System.EventHandler(this.btnRemoverAdd_Click);
            // 
            // btnRemoverNordeste
            // 
            this.btnRemoverNordeste.Location = new System.Drawing.Point(397, 200);
            this.btnRemoverNordeste.Name = "btnRemoverNordeste";
            this.btnRemoverNordeste.Size = new System.Drawing.Size(30, 23);
            this.btnRemoverNordeste.TabIndex = 18;
            this.btnRemoverNordeste.Text = "-";
            this.btnRemoverNordeste.UseVisualStyleBackColor = true;
            this.btnRemoverNordeste.Click += new System.EventHandler(this.btnRemoverNordeste_Click);
            // 
            // btnRemoverCentro
            // 
            this.btnRemoverCentro.Location = new System.Drawing.Point(397, 265);
            this.btnRemoverCentro.Name = "btnRemoverCentro";
            this.btnRemoverCentro.Size = new System.Drawing.Size(30, 23);
            this.btnRemoverCentro.TabIndex = 19;
            this.btnRemoverCentro.Text = "-";
            this.btnRemoverCentro.UseVisualStyleBackColor = true;
            this.btnRemoverCentro.Click += new System.EventHandler(this.btnRemoverCentro_Click);
            // 
            // btnRemoverNorte
            // 
            this.btnRemoverNorte.Location = new System.Drawing.Point(397, 122);
            this.btnRemoverNorte.Name = "btnRemoverNorte";
            this.btnRemoverNorte.Size = new System.Drawing.Size(30, 23);
            this.btnRemoverNorte.TabIndex = 20;
            this.btnRemoverNorte.Text = "-";
            this.btnRemoverNorte.UseVisualStyleBackColor = true;
            this.btnRemoverNorte.Click += new System.EventHandler(this.btnRemoverNorte_Click);
            // 
            // btnRemoverSudeste
            // 
            this.btnRemoverSudeste.Location = new System.Drawing.Point(397, 362);
            this.btnRemoverSudeste.Name = "btnRemoverSudeste";
            this.btnRemoverSudeste.Size = new System.Drawing.Size(30, 23);
            this.btnRemoverSudeste.TabIndex = 21;
            this.btnRemoverSudeste.Text = "-";
            this.btnRemoverSudeste.UseVisualStyleBackColor = true;
            this.btnRemoverSudeste.Click += new System.EventHandler(this.btnRemoverSudeste_Click);
            // 
            // btnRemoverSul
            // 
            this.btnRemoverSul.Location = new System.Drawing.Point(397, 482);
            this.btnRemoverSul.Name = "btnRemoverSul";
            this.btnRemoverSul.Size = new System.Drawing.Size(30, 23);
            this.btnRemoverSul.TabIndex = 22;
            this.btnRemoverSul.Text = "-";
            this.btnRemoverSul.UseVisualStyleBackColor = true;
            this.btnRemoverSul.Click += new System.EventHandler(this.btnRemoverSul_Click);
            // 
            // countNordeste
            // 
            this.countNordeste.AutoSize = true;
            this.countNordeste.Location = new System.Drawing.Point(466, 200);
            this.countNordeste.Name = "countNordeste";
            this.countNordeste.Size = new System.Drawing.Size(0, 13);
            this.countNordeste.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 835);
            this.Controls.Add(this.countNordeste);
            this.Controls.Add(this.btnRemoverSul);
            this.Controls.Add(this.btnRemoverSudeste);
            this.Controls.Add(this.btnRemoverNorte);
            this.Controls.Add(this.btnRemoverCentro);
            this.Controls.Add(this.btnRemoverNordeste);
            this.Controls.Add(this.btnRemoverAdd);
            this.Controls.Add(this.countSul);
            this.Controls.Add(this.countNorte);
            this.Controls.Add(this.CountCentro);
            this.Controls.Add(this.countSudeste);
            this.Controls.Add(this.countEstados);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.cboCentro);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.ComboBox cboCentro;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.Label countEstados;
        private System.Windows.Forms.Label countSudeste;
        private System.Windows.Forms.Label CountCentro;
        private System.Windows.Forms.Label countNorte;
        private System.Windows.Forms.Label countSul;
        private System.Windows.Forms.Button btnRemoverAdd;
        private System.Windows.Forms.Button btnRemoverNordeste;
        private System.Windows.Forms.Button btnRemoverCentro;
        private System.Windows.Forms.Button btnRemoverNorte;
        private System.Windows.Forms.Button btnRemoverSudeste;
        private System.Windows.Forms.Button btnRemoverSul;
        private System.Windows.Forms.Label countNordeste;
    }
}

