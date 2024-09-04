namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n9 = new Button();
            n8 = new Button();
            n0 = new Button();
            ndot = new Button();
            bc = new Button();
            bad = new Button();
            bsub = new Button();
            bmult = new Button();
            bdiv = new Button();
            bequal = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Courier New", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(8, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(255, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // n1
            // 
            n1.BackColor = SystemColors.GradientActiveCaption;
            n1.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n1.ForeColor = SystemColors.ControlText;
            n1.Location = new Point(9, 88);
            n1.Name = "n1";
            n1.Size = new Size(59, 41);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = SystemColors.GradientActiveCaption;
            n2.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n2.ForeColor = SystemColors.ControlText;
            n2.Location = new Point(74, 88);
            n2.Name = "n2";
            n2.Size = new Size(59, 41);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.BackColor = SystemColors.GradientActiveCaption;
            n3.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n3.ForeColor = SystemColors.ControlText;
            n3.Location = new Point(139, 88);
            n3.Name = "n3";
            n3.Size = new Size(59, 41);
            n3.TabIndex = 1;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n4
            // 
            n4.BackColor = SystemColors.GradientActiveCaption;
            n4.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n4.ForeColor = SystemColors.ControlText;
            n4.Location = new Point(8, 150);
            n4.Name = "n4";
            n4.Size = new Size(59, 41);
            n4.TabIndex = 1;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.BackColor = SystemColors.GradientActiveCaption;
            n5.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n5.ForeColor = SystemColors.ControlText;
            n5.Location = new Point(74, 150);
            n5.Name = "n5";
            n5.Size = new Size(59, 41);
            n5.TabIndex = 5;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.BackColor = SystemColors.GradientActiveCaption;
            n6.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n6.ForeColor = SystemColors.ControlText;
            n6.Location = new Point(139, 150);
            n6.Name = "n6";
            n6.Size = new Size(59, 41);
            n6.TabIndex = 1;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n7
            // 
            n7.BackColor = SystemColors.GradientActiveCaption;
            n7.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n7.ForeColor = SystemColors.ControlText;
            n7.Location = new Point(8, 213);
            n7.Name = "n7";
            n7.Size = new Size(59, 41);
            n7.TabIndex = 1;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n9
            // 
            n9.BackColor = SystemColors.GradientActiveCaption;
            n9.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n9.ForeColor = SystemColors.ControlText;
            n9.Location = new Point(139, 213);
            n9.Name = "n9";
            n9.Size = new Size(59, 41);
            n9.TabIndex = 1;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // n8
            // 
            n8.BackColor = SystemColors.GradientActiveCaption;
            n8.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n8.ForeColor = SystemColors.ControlText;
            n8.Location = new Point(74, 213);
            n8.Name = "n8";
            n8.Size = new Size(59, 41);
            n8.TabIndex = 1;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n0
            // 
            n0.BackColor = SystemColors.GradientActiveCaption;
            n0.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n0.ForeColor = SystemColors.ControlText;
            n0.Location = new Point(74, 270);
            n0.Name = "n0";
            n0.Size = new Size(59, 41);
            n0.TabIndex = 1;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // ndot
            // 
            ndot.BackColor = SystemColors.GradientActiveCaption;
            ndot.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ndot.ForeColor = SystemColors.ControlText;
            ndot.Location = new Point(9, 270);
            ndot.Name = "ndot";
            ndot.Size = new Size(59, 41);
            ndot.TabIndex = 1;
            ndot.Text = ".";
            ndot.UseVisualStyleBackColor = false;
            ndot.Click += ndot_Click;
            // 
            // bc
            // 
            bc.BackColor = SystemColors.GradientActiveCaption;
            bc.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bc.ForeColor = SystemColors.ControlText;
            bc.Location = new Point(139, 270);
            bc.Name = "bc";
            bc.Size = new Size(59, 41);
            bc.TabIndex = 1;
            bc.Text = "C";
            bc.UseVisualStyleBackColor = false;
            bc.Click += bc_Click;
            // 
            // bad
            // 
            bad.BackColor = SystemColors.GradientActiveCaption;
            bad.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bad.ForeColor = SystemColors.ControlText;
            bad.Location = new Point(205, 88);
            bad.Name = "bad";
            bad.Size = new Size(59, 41);
            bad.TabIndex = 1;
            bad.Text = "+";
            bad.UseVisualStyleBackColor = false;
            bad.Click += bad_Click;
            // 
            // bsub
            // 
            bsub.BackColor = SystemColors.GradientActiveCaption;
            bsub.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bsub.ForeColor = SystemColors.ControlText;
            bsub.Location = new Point(205, 150);
            bsub.Name = "bsub";
            bsub.Size = new Size(59, 41);
            bsub.TabIndex = 1;
            bsub.Text = "-";
            bsub.UseVisualStyleBackColor = false;
            bsub.Click += bsub_Click;
            // 
            // bmult
            // 
            bmult.BackColor = SystemColors.GradientActiveCaption;
            bmult.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bmult.ForeColor = SystemColors.ControlText;
            bmult.Location = new Point(205, 213);
            bmult.Name = "bmult";
            bmult.Size = new Size(59, 41);
            bmult.TabIndex = 1;
            bmult.Text = "*";
            bmult.UseVisualStyleBackColor = false;
            bmult.Click += bmult_Click;
            // 
            // bdiv
            // 
            bdiv.BackColor = SystemColors.GradientActiveCaption;
            bdiv.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdiv.ForeColor = SystemColors.ControlText;
            bdiv.Location = new Point(205, 270);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(59, 41);
            bdiv.TabIndex = 1;
            bdiv.Text = "/";
            bdiv.UseVisualStyleBackColor = false;
            bdiv.Click += bdiv_Click;
            // 
            // bequal
            // 
            bequal.BackColor = SystemColors.GradientActiveCaption;
            bequal.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bequal.ForeColor = SystemColors.ControlText;
            bequal.Location = new Point(85, 326);
            bequal.Name = "bequal";
            bequal.Size = new Size(95, 41);
            bequal.TabIndex = 1;
            bequal.Text = "=";
            bequal.UseVisualStyleBackColor = false;
            bequal.Click += bequal_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 372);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(272, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = SystemColors.WindowFrame;
            toolStripStatusLabel1.Margin = new Padding(30, 3, 0, 2);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(172, 17);
            toolStripStatusLabel1.Text = "Created by Md. Zohirul Islam";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 15);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(272, 394);
            Controls.Add(statusStrip1);
            Controls.Add(bdiv);
            Controls.Add(bmult);
            Controls.Add(bsub);
            Controls.Add(bad);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n8);
            Controls.Add(ndot);
            Controls.Add(bc);
            Controls.Add(bequal);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n7);
            Controls.Add(n4);
            Controls.Add(n1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n9;
        private Button n8;
        private Button n0;
        private Button ndot;
        private Button bc;
        private Button bad;
        private Button bsub;
        private Button bmult;
        private Button bdiv;
        private Button bequal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
