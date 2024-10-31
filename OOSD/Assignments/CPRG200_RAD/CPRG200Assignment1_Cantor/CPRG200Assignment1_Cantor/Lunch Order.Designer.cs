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
            lblPizza = new Label();
            pizzaNum = new TextBox();
            lblSalad = new Label();
            saladNum = new TextBox();
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
            // lblPizza
            // 
            lblPizza.AutoSize = true;
            lblPizza.Location = new Point(141, 140);
            lblPizza.Name = "lblPizza";
            lblPizza.Size = new Size(92, 20);
            lblPizza.TabIndex = 3;
            lblPizza.Tag = "lblPizza";
            lblPizza.Text = "Pizza - $5.95";
            // 
            // pizzaNum
            // 
            pizzaNum.Location = new Point(88, 138);
            pizzaNum.Name = "pizzaNum";
            pizzaNum.Size = new Size(30, 27);
            pizzaNum.TabIndex = 4;
            pizzaNum.Tag = "pizzaNum";
            pizzaNum.Text = "0";
            pizzaNum.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSalad
            // 
            lblSalad.AutoSize = true;
            lblSalad.Location = new Point(141, 185);
            lblSalad.Name = "lblSalad";
            lblSalad.Size = new Size(95, 20);
            lblSalad.TabIndex = 5;
            lblSalad.Tag = "lblSalad";
            lblSalad.Text = "Salad - $4.95";
            // 
            // saladNum
            // 
            saladNum.Location = new Point(88, 182);
            saladNum.Name = "saladNum";
            saladNum.Size = new Size(30, 27);
            saladNum.TabIndex = 6;
            saladNum.Tag = "lblSalad";
            saladNum.Text = "0";
            saladNum.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saladNum);
            Controls.Add(lblSalad);
            Controls.Add(pizzaNum);
            Controls.Add(lblPizza);
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
        private Label lblPizza;
        private TextBox pizzaNum;
        private Label lblSalad;
        private TextBox saladNum;
    }
}
