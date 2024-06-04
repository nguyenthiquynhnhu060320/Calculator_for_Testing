namespace Calculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nub1 = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.nub2 = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.btsubtract = new System.Windows.Forms.Button();
            this.btequal = new System.Windows.Forms.Button();
            this.btmutl = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình máy tính đơn giản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 1:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số thứ 2:";
            // 
            // nub1
            // 
            this.nub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nub1.Location = new System.Drawing.Point(222, 106);
            this.nub1.Name = "nub1";
            this.nub1.Size = new System.Drawing.Size(377, 30);
            this.nub1.TabIndex = 4;
            // 
            // result1
            // 
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.Location = new System.Drawing.Point(222, 226);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(377, 30);
            this.result1.TabIndex = 5;
            // 
            // nub2
            // 
            this.nub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nub2.Location = new System.Drawing.Point(222, 164);
            this.nub2.Name = "nub2";
            this.nub2.Size = new System.Drawing.Size(377, 30);
            this.nub2.TabIndex = 6;
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(137, 302);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(101, 50);
            this.btadd.TabIndex = 7;
            this.btadd.Text = "+";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btsubtract
            // 
            this.btsubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubtract.Location = new System.Drawing.Point(263, 302);
            this.btsubtract.Name = "btsubtract";
            this.btsubtract.Size = new System.Drawing.Size(101, 50);
            this.btsubtract.TabIndex = 11;
            this.btsubtract.Text = "-";
            this.btsubtract.UseVisualStyleBackColor = true;
            // 
            // btequal
            // 
            this.btequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btequal.Location = new System.Drawing.Point(648, 302);
            this.btequal.Name = "btequal";
            this.btequal.Size = new System.Drawing.Size(101, 50);
            this.btequal.TabIndex = 12;
            this.btequal.Text = "=";
            this.btequal.UseVisualStyleBackColor = true;
            // 
            // btmutl
            // 
            this.btmutl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmutl.Location = new System.Drawing.Point(391, 302);
            this.btmutl.Name = "btmutl";
            this.btmutl.Size = new System.Drawing.Size(101, 50);
            this.btmutl.TabIndex = 13;
            this.btmutl.Text = "x";
            this.btmutl.UseVisualStyleBackColor = true;
            // 
            // btdiv
            // 
            this.btdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiv.Location = new System.Drawing.Point(521, 302);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(101, 50);
            this.btdiv.TabIndex = 14;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btmutl);
            this.Controls.Add(this.btequal);
            this.Controls.Add(this.btsubtract);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.nub2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.nub1);
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
        private System.Windows.Forms.TextBox nub1;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox nub2;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btsubtract;
        private System.Windows.Forms.Button btequal;
        private System.Windows.Forms.Button btmutl;
        private System.Windows.Forms.Button btdiv;
    }
}

