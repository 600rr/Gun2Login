namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.topla = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.Alg1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decide1 = new System.Windows.Forms.TextBox();
            this.decide = new System.Windows.Forms.Button();
            this.decide2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Alg1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "sayi 2";
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(75, 83);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(75, 23);
            this.topla.TabIndex = 4;
            this.topla.Text = "Topla";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(50, 26);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 20);
            this.sayi1.TabIndex = 5;
            this.sayi1.TextChanged += new System.EventHandler(this.sayi1_TextChanged);
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(50, 57);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 20);
            this.sayi2.TabIndex = 6;
            this.sayi2.TextChanged += new System.EventHandler(this.sayi2_TextChanged);
            // 
            // Alg1
            // 
            this.Alg1.Controls.Add(this.sayi1);
            this.Alg1.Controls.Add(this.topla);
            this.Alg1.Controls.Add(this.sayi2);
            this.Alg1.Controls.Add(this.label1);
            this.Alg1.Controls.Add(this.label2);
            this.Alg1.Location = new System.Drawing.Point(12, 12);
            this.Alg1.Name = "Alg1";
            this.Alg1.Size = new System.Drawing.Size(163, 122);
            this.Alg1.TabIndex = 7;
            this.Alg1.TabStop = false;
            this.Alg1.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decide1);
            this.groupBox1.Controls.Add(this.decide);
            this.groupBox1.Controls.Add(this.decide2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(181, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // decide1
            // 
            this.decide1.Location = new System.Drawing.Point(62, 23);
            this.decide1.Name = "decide1";
            this.decide1.Size = new System.Drawing.Size(100, 20);
            this.decide1.TabIndex = 5;
            this.decide1.TextChanged += new System.EventHandler(this.decide1_TextChanged);
            // 
            // decide
            // 
            this.decide.Location = new System.Drawing.Point(88, 83);
            this.decide.Name = "decide";
            this.decide.Size = new System.Drawing.Size(75, 23);
            this.decide.TabIndex = 4;
            this.decide.Text = "Decide";
            this.decide.UseVisualStyleBackColor = true;
            this.decide.Click += new System.EventHandler(this.button1_Click);
            // 
            // decide2
            // 
            this.decide2.Location = new System.Drawing.Point(63, 57);
            this.decide2.Name = "decide2";
            this.decide2.Size = new System.Drawing.Size(100, 20);
            this.decide2.TabIndex = 6;
            this.decide2.TextChanged += new System.EventHandler(this.decide2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decide 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Decide 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Alg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Alg1.ResumeLayout(false);
            this.Alg1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.GroupBox Alg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox decide1;
        private System.Windows.Forms.Button decide;
        private System.Windows.Forms.TextBox decide2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

