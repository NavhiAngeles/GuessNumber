namespace GuessNumber
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
            label1 = new Label();
            GuessBox = new TextBox();
            AnswerBox = new TextBox();
            enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 218);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 0;
            label1.Text = "The answer is:";
            // 
            // GuessBox
            // 
            GuessBox.BackColor = SystemColors.InactiveCaption;
            GuessBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessBox.Location = new Point(70, 77);
            GuessBox.Name = "GuessBox";
            GuessBox.Size = new Size(182, 50);
            GuessBox.TabIndex = 2;
            GuessBox.TextChanged += GuessBox_TextChanged;
            // 
            // AnswerBox
            // 
            AnswerBox.BackColor = SystemColors.InactiveCaption;
            AnswerBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerBox.Location = new Point(70, 282);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(182, 50);
            AnswerBox.TabIndex = 3;
            // 
            // enter
            // 
            enter.BackColor = SystemColors.InactiveCaption;
            enter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enter.Location = new Point(112, 133);
            enter.Name = "enter";
            enter.Size = new Size(97, 39);
            enter.TabIndex = 4;
            enter.Text = "ENTER";
            enter.UseVisualStyleBackColor = false;
            enter.Click += enter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(329, 420);
            Controls.Add(enter);
            Controls.Add(AnswerBox);
            Controls.Add(GuessBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox GuessBox;
        private TextBox AnswerBox;
        private Button enter;
    }
}
