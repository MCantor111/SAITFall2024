namespace CPRG200Assignment1_Cantor
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
            lblMainCourse = new Label();
            hamburgerNum = new TextBox();
            lblHamburger = new Label();
            SuspendLayout();
            // 
            // lblMainCourse
            // 
            lblMainCourse.AutoSize = true;
            lblMainCourse.Location = new Point(88, 51);
            lblMainCourse.Name = "lblMainCourse";
            lblMainCourse.Size = new Size(91, 20);
            lblMainCourse.TabIndex = 0;
            lblMainCourse.Text = "Main Course";
            // 
            // hamburgerNum
            // 
            hamburgerNum.Location = new Point(88, 94);
            hamburgerNum.Name = "hamburgerNum";
            hamburgerNum.Size = new Size(30, 27);
            hamburgerNum.TabIndex = 1;
            hamburgerNum.Tag = "hamburgerNum";
            hamburgerNum.Text = "0";
            hamburgerNum.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHamburger
            // 
            lblHamburger.AutoSize = true;
            lblHamburger.Location = new Point(141, 97);
            lblHamburger.Name = "lblHamburger";
            lblHamburger.Size = new Size(134, 20);
            lblHamburger.TabIndex = 2;
            lblHamburger.Text = "Hamburger - $6.95";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHamburger);
            Controls.Add(hamburgerNum);
            Controls.Add(lblMainCourse);
            Name = "Form1";
            Text = "Lunch Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainCourse;
        private TextBox hamburgerNum;
        private Label lblHamburger;
    }
}
