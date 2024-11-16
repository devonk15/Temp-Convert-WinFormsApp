namespace WinFormsApp1
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
            label1 = new Label();
            txtAns1 = new TextBox();
            q1 = new Label();
            sub1 = new Button();
            sub2 = new Button();
            q2 = new Label();
            txtAns2 = new TextBox();
            sub3 = new Button();
            q3 = new Label();
            txtAns3 = new TextBox();
            para = new Label();
            para2 = new Label();
            para3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 0;
            label1.Text = "Questions";
            // 
            // txtAns1
            // 
            txtAns1.Location = new Point(27, 75);
            txtAns1.Name = "txtAns1";
            txtAns1.Size = new Size(178, 23);
            txtAns1.TabIndex = 1;
            // 
            // q1
            // 
            q1.AutoSize = true;
            q1.Font = new Font("Segoe UI", 15F);
            q1.Location = new Point(12, 44);
            q1.Name = "q1";
            q1.Size = new Size(320, 28);
            q1.TabIndex = 2;
            q1.Text = "Welcome! What are we converting?";
            // 
            // sub1
            // 
            sub1.AutoSize = true;
            sub1.Location = new Point(211, 75);
            sub1.Name = "sub1";
            sub1.Size = new Size(84, 25);
            sub1.TabIndex = 3;
            sub1.Text = "Submit";
            sub1.UseVisualStyleBackColor = true;
            sub1.Click += sub1_Click;
            // 
            // sub2
            // 
            sub2.AutoSize = true;
            sub2.Location = new Point(211, 165);
            sub2.Name = "sub2";
            sub2.Size = new Size(84, 25);
            sub2.TabIndex = 6;
            sub2.Text = "Submit";
            sub2.UseVisualStyleBackColor = true;
            sub2.Visible = false;
            sub2.Click += sub2_Click;
            // 
            // q2
            // 
            q2.AutoSize = true;
            q2.Font = new Font("Segoe UI", 15F);
            q2.Location = new Point(12, 134);
            q2.Name = "q2";
            q2.Size = new Size(320, 28);
            q2.TabIndex = 5;
            q2.Text = "Welcome! What are we converting?";
            q2.Visible = false;
            // 
            // txtAns2
            // 
            txtAns2.Location = new Point(27, 165);
            txtAns2.Name = "txtAns2";
            txtAns2.Size = new Size(178, 23);
            txtAns2.TabIndex = 4;
            txtAns2.Visible = false;
            // 
            // sub3
            // 
            sub3.AutoSize = true;
            sub3.Location = new Point(211, 257);
            sub3.Name = "sub3";
            sub3.Size = new Size(84, 25);
            sub3.TabIndex = 9;
            sub3.Text = "Submit";
            sub3.UseVisualStyleBackColor = true;
            sub3.Visible = false;
            sub3.Click += sub3_Click;
            // 
            // q3
            // 
            q3.AutoSize = true;
            q3.Font = new Font("Segoe UI", 15F);
            q3.Location = new Point(12, 226);
            q3.Name = "q3";
            q3.Size = new Size(320, 28);
            q3.TabIndex = 8;
            q3.Text = "Welcome! What are we converting?";
            q3.Visible = false;
            // 
            // txtAns3
            // 
            txtAns3.Location = new Point(27, 257);
            txtAns3.Name = "txtAns3";
            txtAns3.Size = new Size(178, 23);
            txtAns3.TabIndex = 7;
            txtAns3.Visible = false;
            // 
            // para
            // 
            para.AutoSize = true;
            para.Location = new Point(21, 104);
            para.Name = "para";
            para.Size = new Size(0, 15);
            para.TabIndex = 10;
            // 
            // para2
            // 
            para2.AutoSize = true;
            para2.Location = new Point(21, 194);
            para2.Name = "para2";
            para2.Size = new Size(0, 15);
            para2.TabIndex = 11;
            // 
            // para3
            // 
            para3.AutoSize = true;
            para3.Location = new Point(21, 284);
            para3.Name = "para3";
            para3.Size = new Size(0, 15);
            para3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 366);
            Controls.Add(para3);
            Controls.Add(para2);
            Controls.Add(para);
            Controls.Add(sub3);
            Controls.Add(q3);
            Controls.Add(txtAns3);
            Controls.Add(sub2);
            Controls.Add(q2);
            Controls.Add(txtAns2);
            Controls.Add(sub1);
            Controls.Add(q1);
            Controls.Add(txtAns1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Names";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAns1;
        private Label q1;
        private Button sub1;
        private Button sub2;
        private Label q2;
        private TextBox txtAns2;
        private Button sub3;
        private Label q3;
        private TextBox txtAns3;
        private Label para;
        private Label para2;
        private Label para3;
    }
}
