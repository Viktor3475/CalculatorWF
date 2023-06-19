namespace WindowsFormsApp1
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
            this.po = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.stepen = new System.Windows.Forms.Button();
            this.sredno = new System.Windows.Forms.Button();
            this.deleno = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // po
            // 
            this.po.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.po.ForeColor = System.Drawing.Color.Black;
            this.po.Location = new System.Drawing.Point(212, 75);
            this.po.Name = "po";
            this.po.Size = new System.Drawing.Size(80, 30);
            this.po.TabIndex = 0;
            this.po.Text = "A*B";
            this.po.UseVisualStyleBackColor = true;
            this.po.Click += new System.EventHandler(this.button1_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.ForeColor = System.Drawing.Color.Black;
            this.minus.Location = new System.Drawing.Point(115, 75);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 30);
            this.minus.TabIndex = 1;
            this.minus.Text = "A-B";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // stepen
            // 
            this.stepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepen.ForeColor = System.Drawing.Color.Black;
            this.stepen.Location = new System.Drawing.Point(115, 104);
            this.stepen.Name = "stepen";
            this.stepen.Size = new System.Drawing.Size(80, 30);
            this.stepen.TabIndex = 2;
            this.stepen.Text = "A^B";
            this.stepen.UseVisualStyleBackColor = true;
            this.stepen.Click += new System.EventHandler(this.button3_Click);
            // 
            // sredno
            // 
            this.sredno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sredno.ForeColor = System.Drawing.Color.Black;
            this.sredno.Location = new System.Drawing.Point(212, 104);
            this.sredno.Name = "sredno";
            this.sredno.Size = new System.Drawing.Size(80, 30);
            this.sredno.TabIndex = 3;
            this.sredno.Text = "AVE";
            this.sredno.UseVisualStyleBackColor = true;
            this.sredno.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleno
            // 
            this.deleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleno.ForeColor = System.Drawing.Color.Black;
            this.deleno.Location = new System.Drawing.Point(12, 104);
            this.deleno.Name = "deleno";
            this.deleno.Size = new System.Drawing.Size(80, 30);
            this.deleno.TabIndex = 4;
            this.deleno.Text = "A/B";
            this.deleno.UseVisualStyleBackColor = true;
            this.deleno.Click += new System.EventHandler(this.deleno_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ForeColor = System.Drawing.Color.Black;
            this.plus.Location = new System.Drawing.Point(12, 75);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 30);
            this.plus.TabIndex = 5;
            this.plus.Text = "A+B";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(157, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "B:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(141, 164);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(29, 24);
            this.result.TabIndex = 8;
            this.result.Text = "Р:";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Click += new System.EventHandler(this.label3_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(177, 28);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(44, 20);
            this.num2.TabIndex = 9;
            this.num2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(76, 28);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(45, 20);
            this.num1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 200);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.deleno);
            this.Controls.Add(this.sredno);
            this.Controls.Add(this.stepen);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.po);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калкулатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button po;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button stepen;
        private System.Windows.Forms.Button sredno;
        private System.Windows.Forms.Button deleno;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
    }
}

