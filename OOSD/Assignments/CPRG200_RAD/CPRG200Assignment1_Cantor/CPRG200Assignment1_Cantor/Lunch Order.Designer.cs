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
            lblAddOn = new Label();
            toppings = new CheckedListBox();
            condiments = new CheckedListBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblMainCourse
            // 
            lblMainCourse.AutoSize = true;
            lblMainCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMainCourse.Location = new Point(88, 80);
            lblMainCourse.Name = "lblMainCourse";
            lblMainCourse.Size = new Size(96, 20);
            lblMainCourse.TabIndex = 0;
            lblMainCourse.Text = "Main Course";
            // 
            // hamburgerNum
            // 
            hamburgerNum.Location = new Point(88, 114);
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
            lblHamburger.Location = new Point(141, 117);
            lblHamburger.Name = "lblHamburger";
            lblHamburger.Size = new Size(134, 20);
            lblHamburger.TabIndex = 2;
            lblHamburger.Text = "Hamburger - $6.95";
            // 
            // lblPizza
            // 
            lblPizza.AutoSize = true;
            lblPizza.Location = new Point(141, 143);
            lblPizza.Name = "lblPizza";
            lblPizza.Size = new Size(92, 20);
            lblPizza.TabIndex = 3;
            lblPizza.Tag = "lblPizza";
            lblPizza.Text = "Pizza - $5.95";
            lblPizza.Click += lblPizza_Click;
            // 
            // pizzaNum
            // 
            pizzaNum.Location = new Point(88, 140);
            pizzaNum.Name = "pizzaNum";
            pizzaNum.Size = new Size(30, 27);
            pizzaNum.TabIndex = 4;
            pizzaNum.Tag = "pizzaNum";
            pizzaNum.Text = "0";
            pizzaNum.TextAlign = HorizontalAlignment.Right;
            pizzaNum.TextChanged += this.pizzaNum_TextChanged;
            // 
            // lblSalad
            // 
            lblSalad.AutoSize = true;
            lblSalad.Location = new Point(141, 170);
            lblSalad.Name = "lblSalad";
            lblSalad.Size = new Size(95, 20);
            lblSalad.TabIndex = 5;
            lblSalad.Tag = "lblSalad";
            lblSalad.Text = "Salad - $4.95";
            lblSalad.Click += lblSalad_Click;
            // 
            // saladNum
            // 
            saladNum.Location = new Point(88, 168);
            saladNum.Name = "saladNum";
            saladNum.Size = new Size(30, 27);
            saladNum.TabIndex = 6;
            saladNum.Tag = "lblSalad";
            saladNum.Text = "0";
            saladNum.TextAlign = HorizontalAlignment.Right;
            saladNum.TextChanged += this.saladNum_TextChanged;
            // 
            // lblAddOn
            // 
            lblAddOn.AutoSize = true;
            lblAddOn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddOn.Location = new Point(348, 80);
            lblAddOn.Name = "lblAddOn";
            lblAddOn.Size = new Size(239, 20);
            lblAddOn.TabIndex = 7;
            lblAddOn.Tag = "lblAddOn";
            lblAddOn.Text = "Add-On Items ($0.75 per Group)";
            // 
            // toppings
            // 
            toppings.FormattingEnabled = true;
            toppings.Items.AddRange(new object[] { "Lettuce", "Tomato", "Fried Onion" });
            toppings.Location = new Point(348, 119);
            toppings.Name = "toppings";
            toppings.Size = new Size(122, 70);
            toppings.TabIndex = 8;
            toppings.Tag = "toppings";
            // 
            // condiments
            // 
            condiments.FormattingEnabled = true;
            condiments.Items.AddRange(new object[] { "Ketchup", "Mustard", "Mayo" });
            condiments.Location = new Point(489, 119);
            condiments.Name = "condiments";
            condiments.Size = new Size(108, 70);
            condiments.TabIndex = 9;
            condiments.Tag = "condiments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 10;
            label1.Tag = "lblAuthor";
            label1.Text = "# Author :: η℩.cαηtor ↈ";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Mini-Fries" });
            checkedListBox1.Location = new Point(348, 201);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(122, 26);
            checkedListBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(141, 247);
            button1.Name = "button1";
            button1.Size = new Size(171, 29);
            button1.TabIndex = 12;
            button1.Text = "▶ Add to Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(condiments);
            Controls.Add(toppings);
            Controls.Add(lblAddOn);
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
        private Label lblAddOn;
        private CheckedListBox toppings;
        private CheckedListBox condiments;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
    }
}
