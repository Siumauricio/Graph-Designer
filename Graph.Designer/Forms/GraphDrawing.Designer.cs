
namespace Graph.Designer.Forms
{
    partial class GraphDrawing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btEncontrar = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ComboBox();
            this.lst1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btEncontrar);
            this.panel1.Controls.Add(this.lst2);
            this.panel1.Controls.Add(this.lst1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(974, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 731);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AccessibleDescription = "S";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AccessibleDescription = "S";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ciclos:";
            // 
            // btEncontrar
            // 
            this.btEncontrar.Location = new System.Drawing.Point(59, 365);
            this.btEncontrar.Name = "btEncontrar";
            this.btEncontrar.Size = new System.Drawing.Size(94, 29);
            this.btEncontrar.TabIndex = 9;
            this.btEncontrar.Text = "Encontrar";
            this.btEncontrar.UseVisualStyleBackColor = true;
            this.btEncontrar.Click += new System.EventHandler(this.btEncontrar_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(123, 303);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(70, 28);
            this.lst2.TabIndex = 8;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(11, 303);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(70, 28);
            this.lst1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "S";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Solicitar camino";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "S";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "S";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Grado menor del grafo:";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "S";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "S";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Suma de los grados:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grado del grafo:";
            // 
            // GraphDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1214, 930);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GraphDrawing";
            this.Text = "GraphDrawing";
            this.Load += new System.EventHandler(this.GraphDrawing_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphDrawing_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEncontrar;
        private System.Windows.Forms.ComboBox lst2;
        private System.Windows.Forms.ComboBox lst1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}