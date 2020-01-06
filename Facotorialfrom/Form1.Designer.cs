namespace Facotorialfrom
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.b_calc = new System.Windows.Forms.Button();
            this.l_result = new System.Windows.Forms.Label();
            this.c_showphi = new System.Windows.Forms.CheckBox();
            this.l_phi = new System.Windows.Forms.Label();
            this.B_writeData = new System.Windows.Forms.Button();
            this.B_readData = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(144, 315);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(626, 44);
            this.numericUpDown1.TabIndex = 0;
            // 
            // b_calc
            // 
            this.b_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_calc.Location = new System.Drawing.Point(262, 163);
            this.b_calc.Name = "b_calc";
            this.b_calc.Size = new System.Drawing.Size(411, 113);
            this.b_calc.TabIndex = 1;
            this.b_calc.Text = "Calculate";
            this.b_calc.UseVisualStyleBackColor = true;
            this.b_calc.Click += new System.EventHandler(this.B_calc_Click);
            // 
            // l_result
            // 
            this.l_result.AutoSize = true;
            this.l_result.BackColor = System.Drawing.Color.Red;
            this.l_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_result.Location = new System.Drawing.Point(363, 63);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(220, 52);
            this.l_result.TabIndex = 2;
            this.l_result.Text = "Fib Result";
            this.l_result.Click += new System.EventHandler(this.L_result_Click);
            // 
            // c_showphi
            // 
            this.c_showphi.AutoSize = true;
            this.c_showphi.Location = new System.Drawing.Point(791, 107);
            this.c_showphi.Name = "c_showphi";
            this.c_showphi.Size = new System.Drawing.Size(187, 24);
            this.c_showphi.TabIndex = 4;
            this.c_showphi.Text = "Show Fib and Phi List";
            this.c_showphi.UseVisualStyleBackColor = true;
            this.c_showphi.CheckedChanged += new System.EventHandler(this.C_showphi_CheckedChanged);
            // 
            // l_phi
            // 
            this.l_phi.AutoSize = true;
            this.l_phi.BackColor = System.Drawing.Color.Red;
            this.l_phi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_phi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_phi.Location = new System.Drawing.Point(730, 163);
            this.l_phi.Name = "l_phi";
            this.l_phi.Size = new System.Drawing.Size(222, 52);
            this.l_phi.TabIndex = 5;
            this.l_phi.Text = "Phi Result";
            // 
            // B_writeData
            // 
            this.B_writeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.B_writeData.ForeColor = System.Drawing.Color.Black;
            this.B_writeData.Location = new System.Drawing.Point(12, 163);
            this.B_writeData.Name = "B_writeData";
            this.B_writeData.Size = new System.Drawing.Size(180, 55);
            this.B_writeData.TabIndex = 6;
            this.B_writeData.Text = "Save Data";
            this.B_writeData.UseVisualStyleBackColor = false;
            this.B_writeData.Click += new System.EventHandler(this.B_writeData_Click);
            // 
            // B_readData
            // 
            this.B_readData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.B_readData.Location = new System.Drawing.Point(12, 72);
            this.B_readData.Name = "B_readData";
            this.B_readData.Size = new System.Drawing.Size(180, 55);
            this.B_readData.TabIndex = 7;
            this.B_readData.Text = "Write Data";
            this.B_readData.UseVisualStyleBackColor = false;
            this.B_readData.Click += new System.EventHandler(this.B_readData_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(172, 486);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(574, 294);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(913, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "data.txt";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.B_readData);
            this.Controls.Add(this.B_writeData);
            this.Controls.Add(this.l_phi);
            this.Controls.Add(this.c_showphi);
            this.Controls.Add(this.l_result);
            this.Controls.Add(this.b_calc);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button b_calc;
        private System.Windows.Forms.Label l_result;
        private System.Windows.Forms.CheckBox c_showphi;
        private System.Windows.Forms.Label l_phi;
        private System.Windows.Forms.Button B_writeData;
        private System.Windows.Forms.Button B_readData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

