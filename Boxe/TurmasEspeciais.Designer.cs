namespace Boxe
{
    partial class TurmasEspeciais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurmasEspeciais));
            this.cbTurmasEspeciais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurmasEspeciais = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmasEspeciais)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTurmasEspeciais
            // 
            this.cbTurmasEspeciais.FormattingEnabled = true;
            this.cbTurmasEspeciais.Items.AddRange(new object[] {
            "Turma infantil ",
            "Turma para idosos",
            "PcD"});
            this.cbTurmasEspeciais.Location = new System.Drawing.Point(406, 71);
            this.cbTurmasEspeciais.Name = "cbTurmasEspeciais";
            this.cbTurmasEspeciais.Size = new System.Drawing.Size(226, 21);
            this.cbTurmasEspeciais.TabIndex = 0;
            this.cbTurmasEspeciais.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECIONE A TURMA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvTurmasEspeciais
            // 
            this.dgvTurmasEspeciais.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvTurmasEspeciais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmasEspeciais.Location = new System.Drawing.Point(6, 19);
            this.dgvTurmasEspeciais.Name = "dgvTurmasEspeciais";
            this.dgvTurmasEspeciais.Size = new System.Drawing.Size(1011, 396);
            this.dgvTurmasEspeciais.TabIndex = 2;
            this.dgvTurmasEspeciais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgvTurmasEspeciais);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 421);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TURMAS ESPECIAIS:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TurmasEspeciais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTurmasEspeciais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TurmasEspeciais";
            this.Text = "Boxe UC12";
            this.Load += new System.EventHandler(this.TurmasEspeciais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmasEspeciais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTurmasEspeciais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurmasEspeciais;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}