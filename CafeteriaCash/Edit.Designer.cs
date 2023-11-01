namespace CafeteriaCash
{
    partial class Edit
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
            this.tabelinha = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.painelSenha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txts = new System.Windows.Forms.TextBox();
            this.painelSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelinha
            // 
            this.tabelinha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tabelinha.HideSelection = false;
            this.tabelinha.Location = new System.Drawing.Point(0, -9);
            this.tabelinha.Name = "tabelinha";
            this.tabelinha.Size = new System.Drawing.Size(798, 447);
            this.tabelinha.TabIndex = 0;
            this.tabelinha.UseCompatibleStateImageBehavior = false;
            this.tabelinha.View = System.Windows.Forms.View.Details;
            this.tabelinha.SelectedIndexChanged += new System.EventHandler(this.tabelinha_SelectedIndexChanged);
            this.tabelinha.DoubleClick += new System.EventHandler(this.tabelinha_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 159;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numero";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Senha";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 159;
            // 
            // painelSenha
            // 
            this.painelSenha.Controls.Add(this.txts);
            this.painelSenha.Controls.Add(this.button1);
            this.painelSenha.Controls.Add(this.label1);
            this.painelSenha.Location = new System.Drawing.Point(218, 144);
            this.painelSenha.Name = "painelSenha";
            this.painelSenha.Size = new System.Drawing.Size(347, 100);
            this.painelSenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha de administrador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(40, 39);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(262, 20);
            this.txts.TabIndex = 2;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelSenha);
            this.Controls.Add(this.tabelinha);
            this.Name = "Edit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.painelSenha.ResumeLayout(false);
            this.painelSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tabelinha;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel painelSenha;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}