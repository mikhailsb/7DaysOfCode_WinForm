using System;

namespace CatAsService
{
    partial class frm_BuscarRacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BuscarRacas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_RacasGato = new System.Windows.Forms.ComboBox();
            this.lbl_ResultDescricao = new System.Windows.Forms.Label();
            this.lbl_ResultOrigem = new System.Windows.Forms.Label();
            this.lbl_ResultTemperamento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_favoritar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encontre sua Raça Favorita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilize a caixa de seleção de raças para buscar características sobre determinado" +
    " \r\ngatinho e descobrir qual é a sua raça favorita.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_RacasGato);
            this.groupBox1.Controls.Add(this.lbl_ResultDescricao);
            this.groupBox1.Controls.Add(this.lbl_ResultOrigem);
            this.groupBox1.Controls.Add(this.lbl_ResultTemperamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_favoritar);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(20, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 708);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Raças";
            // 
            // cbx_RacasGato
            // 
            this.cbx_RacasGato.FormattingEnabled = true;
            this.cbx_RacasGato.Location = new System.Drawing.Point(158, 15);
            this.cbx_RacasGato.Name = "cbx_RacasGato";
            this.cbx_RacasGato.Size = new System.Drawing.Size(121, 24);
            this.cbx_RacasGato.TabIndex = 10;
            // 
            // lbl_ResultDescricao
            // 
            this.lbl_ResultDescricao.AutoSize = true;
            this.lbl_ResultDescricao.Location = new System.Drawing.Point(155, 134);
            this.lbl_ResultDescricao.Name = "lbl_ResultDescricao";
            this.lbl_ResultDescricao.Size = new System.Drawing.Size(72, 17);
            this.lbl_ResultDescricao.TabIndex = 9;
            this.lbl_ResultDescricao.Text = "Resultado";
            // 
            // lbl_ResultOrigem
            // 
            this.lbl_ResultOrigem.AutoSize = true;
            this.lbl_ResultOrigem.Location = new System.Drawing.Point(155, 94);
            this.lbl_ResultOrigem.Name = "lbl_ResultOrigem";
            this.lbl_ResultOrigem.Size = new System.Drawing.Size(72, 17);
            this.lbl_ResultOrigem.TabIndex = 8;
            this.lbl_ResultOrigem.Text = "Resultado";
            // 
            // lbl_ResultTemperamento
            // 
            this.lbl_ResultTemperamento.AutoSize = true;
            this.lbl_ResultTemperamento.Location = new System.Drawing.Point(155, 59);
            this.lbl_ResultTemperamento.Name = "lbl_ResultTemperamento";
            this.lbl_ResultTemperamento.Size = new System.Drawing.Size(72, 17);
            this.lbl_ResultTemperamento.TabIndex = 7;
            this.lbl_ResultTemperamento.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Origem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Temperamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raça do Gato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_favoritar
            // 
            this.btn_favoritar.Location = new System.Drawing.Point(366, 15);
            this.btn_favoritar.Name = "btn_favoritar";
            this.btn_favoritar.Size = new System.Drawing.Size(75, 23);
            this.btn_favoritar.TabIndex = 1;
            this.btn_favoritar.Text = "Favoritar";
            this.btn_favoritar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(285, 16);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frm_BuscarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 829);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BuscarRacas";
            this.Text = "frm_BuscarRacas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_favoritar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_RacasGato;
        private System.Windows.Forms.Label lbl_ResultDescricao;
        private System.Windows.Forms.Label lbl_ResultOrigem;
        private System.Windows.Forms.Label lbl_ResultTemperamento;
    }
}