namespace torricelli_point_simulation
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.iterationCount = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.isCircle = new System.Windows.Forms.RadioButton();
            this.isRectangle = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.y3 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.iterationCount);
            this.panel1.Controls.Add(this.btnSolve);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.isCircle);
            this.panel1.Controls.Add(this.isRectangle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.epsilon);
            this.panel1.Controls.Add(this.btnSimulate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.y3);
            this.panel1.Controls.Add(this.y2);
            this.panel1.Controls.Add(this.y1);
            this.panel1.Controls.Add(this.x3);
            this.panel1.Controls.Add(this.x2);
            this.panel1.Controls.Add(this.x1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 400);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Iteration Count";
            // 
            // iterationCount
            // 
            this.iterationCount.Location = new System.Drawing.Point(130, 331);
            this.iterationCount.Name = "iterationCount";
            this.iterationCount.Size = new System.Drawing.Size(152, 20);
            this.iterationCount.TabIndex = 18;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSolve.Location = new System.Drawing.Point(130, 272);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(152, 24);
            this.btnSolve.TabIndex = 17;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.Solve);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(15, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 3);
            this.panel3.TabIndex = 16;
            // 
            // isCircle
            // 
            this.isCircle.AutoSize = true;
            this.isCircle.Enabled = false;
            this.isCircle.Location = new System.Drawing.Point(12, 334);
            this.isCircle.Name = "isCircle";
            this.isCircle.Size = new System.Drawing.Size(51, 17);
            this.isCircle.TabIndex = 15;
            this.isCircle.Text = "Circle";
            this.isCircle.UseVisualStyleBackColor = true;
            // 
            // isRectangle
            // 
            this.isRectangle.AutoSize = true;
            this.isRectangle.Checked = true;
            this.isRectangle.Location = new System.Drawing.Point(12, 311);
            this.isRectangle.Name = "isRectangle";
            this.isRectangle.Size = new System.Drawing.Size(74, 17);
            this.isRectangle.TabIndex = 14;
            this.isRectangle.TabStop = true;
            this.isRectangle.Text = "Rectangle";
            this.isRectangle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Epsilon";
            // 
            // epsilon
            // 
            this.epsilon.Location = new System.Drawing.Point(59, 275);
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(65, 20);
            this.epsilon.TabIndex = 12;
            // 
            // btnSimulate
            // 
            this.btnSimulate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSimulate.Location = new System.Drawing.Point(12, 357);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(270, 40);
            this.btnSimulate.TabIndex = 11;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = false;
            this.btnSimulate.Click += new System.EventHandler(this.Simulate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Point 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Point 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Point 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(111, 168);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(47, 20);
            this.y3.TabIndex = 5;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(111, 142);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(47, 20);
            this.y2.TabIndex = 4;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(111, 116);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(47, 20);
            this.y1.TabIndex = 3;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(58, 168);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(47, 20);
            this.x3.TabIndex = 2;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(58, 142);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(47, 20);
            this.x2.TabIndex = 1;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(58, 116);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(47, 20);
            this.x1.TabIndex = 0;
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDraw.Location = new System.Drawing.Point(301, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(400, 400);
            this.panelDraw.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 427);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Torricelli Point Simulation";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton isCircle;
        private System.Windows.Forms.RadioButton isRectangle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iterationCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

