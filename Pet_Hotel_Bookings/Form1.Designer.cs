namespace Pet_Hotel_Bookings
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
            this.tabControlCheckOut = new System.Windows.Forms.TabControl();
            this.tabPageDog = new System.Windows.Forms.TabPage();
            this.btn_Dog_Book = new System.Windows.Forms.Button();
            this.txt_Dog_Age = new System.Windows.Forms.TextBox();
            this.txt_Dog_Breed = new System.Windows.Forms.TextBox();
            this.txt_Dog_Name = new System.Windows.Forms.TextBox();
            this.lbl_Dog_Age = new System.Windows.Forms.Label();
            this.lbl_Dog_Breed = new System.Windows.Forms.Label();
            this.lbl_Dog_Name = new System.Windows.Forms.Label();
            this.tabPageCat = new System.Windows.Forms.TabPage();
            this.btn_Cat_Book = new System.Windows.Forms.Button();
            this.txt_Cat_Age = new System.Windows.Forms.TextBox();
            this.txt_Cat_breed = new System.Windows.Forms.TextBox();
            this.txt_Cat_name = new System.Windows.Forms.TextBox();
            this.lbl_Cat_age = new System.Windows.Forms.Label();
            this.lbl_Cat_breed = new System.Windows.Forms.Label();
            this.lbl_Cat_Name = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDog = new System.Windows.Forms.CheckBox();
            this.checkBoxCat = new System.Windows.Forms.CheckBox();
            this.lbl_Checkout_Name = new System.Windows.Forms.Label();
            this.lbl_checkout_breed = new System.Windows.Forms.Label();
            this.lbl_checkout_Age = new System.Windows.Forms.Label();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.txt_checkOut_Name = new System.Windows.Forms.TextBox();
            this.txt_checkOut_Breed = new System.Windows.Forms.TextBox();
            this.txt_checkOut_Age = new System.Windows.Forms.TextBox();
            this.tabControlCheckOut.SuspendLayout();
            this.tabPageDog.SuspendLayout();
            this.tabPageCat.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCheckOut
            // 
            this.tabControlCheckOut.Controls.Add(this.tabPageDog);
            this.tabControlCheckOut.Controls.Add(this.tabPageCat);
            this.tabControlCheckOut.Controls.Add(this.tabPage1);
            this.tabControlCheckOut.Location = new System.Drawing.Point(1, 2);
            this.tabControlCheckOut.Name = "tabControlCheckOut";
            this.tabControlCheckOut.SelectedIndex = 0;
            this.tabControlCheckOut.Size = new System.Drawing.Size(803, 442);
            this.tabControlCheckOut.TabIndex = 0;
            // 
            // tabPageDog
            // 
            this.tabPageDog.Controls.Add(this.btn_Dog_Book);
            this.tabPageDog.Controls.Add(this.txt_Dog_Age);
            this.tabPageDog.Controls.Add(this.txt_Dog_Breed);
            this.tabPageDog.Controls.Add(this.txt_Dog_Name);
            this.tabPageDog.Controls.Add(this.lbl_Dog_Age);
            this.tabPageDog.Controls.Add(this.lbl_Dog_Breed);
            this.tabPageDog.Controls.Add(this.lbl_Dog_Name);
            this.tabPageDog.Location = new System.Drawing.Point(4, 25);
            this.tabPageDog.Name = "tabPageDog";
            this.tabPageDog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDog.Size = new System.Drawing.Size(795, 413);
            this.tabPageDog.TabIndex = 0;
            this.tabPageDog.Text = "Dog";
            this.tabPageDog.UseVisualStyleBackColor = true;
            // 
            // btn_Dog_Book
            // 
            this.btn_Dog_Book.Location = new System.Drawing.Point(270, 281);
            this.btn_Dog_Book.Name = "btn_Dog_Book";
            this.btn_Dog_Book.Size = new System.Drawing.Size(156, 23);
            this.btn_Dog_Book.TabIndex = 6;
            this.btn_Dog_Book.Text = "Book";
            this.btn_Dog_Book.UseVisualStyleBackColor = true;
            this.btn_Dog_Book.Click += new System.EventHandler(this.btn_Dog_Book_Click);
            // 
            // txt_Dog_Age
            // 
            this.txt_Dog_Age.Location = new System.Drawing.Point(270, 191);
            this.txt_Dog_Age.Name = "txt_Dog_Age";
            this.txt_Dog_Age.Size = new System.Drawing.Size(156, 22);
            this.txt_Dog_Age.TabIndex = 5;
            // 
            // txt_Dog_Breed
            // 
            this.txt_Dog_Breed.Location = new System.Drawing.Point(270, 120);
            this.txt_Dog_Breed.Name = "txt_Dog_Breed";
            this.txt_Dog_Breed.Size = new System.Drawing.Size(156, 22);
            this.txt_Dog_Breed.TabIndex = 4;
            // 
            // txt_Dog_Name
            // 
            this.txt_Dog_Name.Location = new System.Drawing.Point(270, 45);
            this.txt_Dog_Name.Name = "txt_Dog_Name";
            this.txt_Dog_Name.Size = new System.Drawing.Size(156, 22);
            this.txt_Dog_Name.TabIndex = 3;
            // 
            // lbl_Dog_Age
            // 
            this.lbl_Dog_Age.AutoSize = true;
            this.lbl_Dog_Age.Location = new System.Drawing.Point(163, 191);
            this.lbl_Dog_Age.Name = "lbl_Dog_Age";
            this.lbl_Dog_Age.Size = new System.Drawing.Size(38, 16);
            this.lbl_Dog_Age.TabIndex = 2;
            this.lbl_Dog_Age.Text = "Age :";
            // 
            // lbl_Dog_Breed
            // 
            this.lbl_Dog_Breed.AutoSize = true;
            this.lbl_Dog_Breed.Location = new System.Drawing.Point(163, 120);
            this.lbl_Dog_Breed.Name = "lbl_Dog_Breed";
            this.lbl_Dog_Breed.Size = new System.Drawing.Size(50, 16);
            this.lbl_Dog_Breed.TabIndex = 1;
            this.lbl_Dog_Breed.Text = "Breed :";
            // 
            // lbl_Dog_Name
            // 
            this.lbl_Dog_Name.AutoSize = true;
            this.lbl_Dog_Name.Location = new System.Drawing.Point(163, 45);
            this.lbl_Dog_Name.Name = "lbl_Dog_Name";
            this.lbl_Dog_Name.Size = new System.Drawing.Size(50, 16);
            this.lbl_Dog_Name.TabIndex = 0;
            this.lbl_Dog_Name.Text = "Name :";
            this.lbl_Dog_Name.Click += new System.EventHandler(this.lbl_Dog_Name_Click);
            // 
            // tabPageCat
            // 
            this.tabPageCat.Controls.Add(this.btn_Cat_Book);
            this.tabPageCat.Controls.Add(this.txt_Cat_Age);
            this.tabPageCat.Controls.Add(this.txt_Cat_breed);
            this.tabPageCat.Controls.Add(this.txt_Cat_name);
            this.tabPageCat.Controls.Add(this.lbl_Cat_age);
            this.tabPageCat.Controls.Add(this.lbl_Cat_breed);
            this.tabPageCat.Controls.Add(this.lbl_Cat_Name);
            this.tabPageCat.Location = new System.Drawing.Point(4, 25);
            this.tabPageCat.Name = "tabPageCat";
            this.tabPageCat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCat.Size = new System.Drawing.Size(795, 413);
            this.tabPageCat.TabIndex = 1;
            this.tabPageCat.Text = "Cat";
            this.tabPageCat.UseVisualStyleBackColor = true;
            // 
            // btn_Cat_Book
            // 
            this.btn_Cat_Book.Location = new System.Drawing.Point(373, 313);
            this.btn_Cat_Book.Name = "btn_Cat_Book";
            this.btn_Cat_Book.Size = new System.Drawing.Size(156, 23);
            this.btn_Cat_Book.TabIndex = 13;
            this.btn_Cat_Book.Text = "Book";
            this.btn_Cat_Book.UseVisualStyleBackColor = true;
            this.btn_Cat_Book.Click += new System.EventHandler(this.btn_Cat_Book_Click);
            // 
            // txt_Cat_Age
            // 
            this.txt_Cat_Age.Location = new System.Drawing.Point(373, 223);
            this.txt_Cat_Age.Name = "txt_Cat_Age";
            this.txt_Cat_Age.Size = new System.Drawing.Size(156, 22);
            this.txt_Cat_Age.TabIndex = 12;
            // 
            // txt_Cat_breed
            // 
            this.txt_Cat_breed.Location = new System.Drawing.Point(373, 152);
            this.txt_Cat_breed.Name = "txt_Cat_breed";
            this.txt_Cat_breed.Size = new System.Drawing.Size(156, 22);
            this.txt_Cat_breed.TabIndex = 11;
            // 
            // txt_Cat_name
            // 
            this.txt_Cat_name.Location = new System.Drawing.Point(373, 77);
            this.txt_Cat_name.Name = "txt_Cat_name";
            this.txt_Cat_name.Size = new System.Drawing.Size(156, 22);
            this.txt_Cat_name.TabIndex = 10;
            // 
            // lbl_Cat_age
            // 
            this.lbl_Cat_age.AutoSize = true;
            this.lbl_Cat_age.Location = new System.Drawing.Point(266, 223);
            this.lbl_Cat_age.Name = "lbl_Cat_age";
            this.lbl_Cat_age.Size = new System.Drawing.Size(38, 16);
            this.lbl_Cat_age.TabIndex = 9;
            this.lbl_Cat_age.Text = "Age :";
            // 
            // lbl_Cat_breed
            // 
            this.lbl_Cat_breed.AutoSize = true;
            this.lbl_Cat_breed.Location = new System.Drawing.Point(266, 152);
            this.lbl_Cat_breed.Name = "lbl_Cat_breed";
            this.lbl_Cat_breed.Size = new System.Drawing.Size(50, 16);
            this.lbl_Cat_breed.TabIndex = 8;
            this.lbl_Cat_breed.Text = "Breed :";
            // 
            // lbl_Cat_Name
            // 
            this.lbl_Cat_Name.AutoSize = true;
            this.lbl_Cat_Name.Location = new System.Drawing.Point(266, 77);
            this.lbl_Cat_Name.Name = "lbl_Cat_Name";
            this.lbl_Cat_Name.Size = new System.Drawing.Size(50, 16);
            this.lbl_Cat_Name.TabIndex = 7;
            this.lbl_Cat_Name.Text = "Name :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_checkOut_Age);
            this.tabPage1.Controls.Add(this.txt_checkOut_Breed);
            this.tabPage1.Controls.Add(this.txt_checkOut_Name);
            this.tabPage1.Controls.Add(this.btn_checkOut);
            this.tabPage1.Controls.Add(this.lbl_checkout_Age);
            this.tabPage1.Controls.Add(this.lbl_checkout_breed);
            this.tabPage1.Controls.Add(this.lbl_Checkout_Name);
            this.tabPage1.Controls.Add(this.checkBoxCat);
            this.tabPage1.Controls.Add(this.checkBoxDog);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 413);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Check Out";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your pet , in order to check out :";
            // 
            // checkBoxDog
            // 
            this.checkBoxDog.AutoSize = true;
            this.checkBoxDog.Location = new System.Drawing.Point(226, 89);
            this.checkBoxDog.Name = "checkBoxDog";
            this.checkBoxDog.Size = new System.Drawing.Size(55, 20);
            this.checkBoxDog.TabIndex = 1;
            this.checkBoxDog.Text = "Dog";
            this.checkBoxDog.UseVisualStyleBackColor = true;
            // 
            // checkBoxCat
            // 
            this.checkBoxCat.AutoSize = true;
            this.checkBoxCat.Location = new System.Drawing.Point(389, 89);
            this.checkBoxCat.Name = "checkBoxCat";
            this.checkBoxCat.Size = new System.Drawing.Size(49, 20);
            this.checkBoxCat.TabIndex = 2;
            this.checkBoxCat.Text = "Cat";
            this.checkBoxCat.UseVisualStyleBackColor = true;
            // 
            // lbl_Checkout_Name
            // 
            this.lbl_Checkout_Name.AutoSize = true;
            this.lbl_Checkout_Name.Location = new System.Drawing.Point(223, 151);
            this.lbl_Checkout_Name.Name = "lbl_Checkout_Name";
            this.lbl_Checkout_Name.Size = new System.Drawing.Size(50, 16);
            this.lbl_Checkout_Name.TabIndex = 3;
            this.lbl_Checkout_Name.Text = "Name :";
            // 
            // lbl_checkout_breed
            // 
            this.lbl_checkout_breed.AutoSize = true;
            this.lbl_checkout_breed.Location = new System.Drawing.Point(223, 198);
            this.lbl_checkout_breed.Name = "lbl_checkout_breed";
            this.lbl_checkout_breed.Size = new System.Drawing.Size(50, 16);
            this.lbl_checkout_breed.TabIndex = 4;
            this.lbl_checkout_breed.Text = "Breed :";
            // 
            // lbl_checkout_Age
            // 
            this.lbl_checkout_Age.AutoSize = true;
            this.lbl_checkout_Age.Location = new System.Drawing.Point(223, 240);
            this.lbl_checkout_Age.Name = "lbl_checkout_Age";
            this.lbl_checkout_Age.Size = new System.Drawing.Size(38, 16);
            this.lbl_checkout_Age.TabIndex = 5;
            this.lbl_checkout_Age.Text = "Age :";
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.Location = new System.Drawing.Point(257, 296);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(155, 23);
            this.btn_checkOut.TabIndex = 6;
            this.btn_checkOut.Text = "Check Out";
            this.btn_checkOut.UseVisualStyleBackColor = true;
            this.btn_checkOut.Click += new System.EventHandler(this.btn_checkOut_Click);
            // 
            // txt_checkOut_Name
            // 
            this.txt_checkOut_Name.Location = new System.Drawing.Point(353, 151);
            this.txt_checkOut_Name.Name = "txt_checkOut_Name";
            this.txt_checkOut_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_checkOut_Name.TabIndex = 7;
            // 
            // txt_checkOut_Breed
            // 
            this.txt_checkOut_Breed.Location = new System.Drawing.Point(353, 198);
            this.txt_checkOut_Breed.Name = "txt_checkOut_Breed";
            this.txt_checkOut_Breed.Size = new System.Drawing.Size(100, 22);
            this.txt_checkOut_Breed.TabIndex = 8;
            // 
            // txt_checkOut_Age
            // 
            this.txt_checkOut_Age.Location = new System.Drawing.Point(353, 240);
            this.txt_checkOut_Age.Name = "txt_checkOut_Age";
            this.txt_checkOut_Age.Size = new System.Drawing.Size(100, 22);
            this.txt_checkOut_Age.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCheckOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlCheckOut.ResumeLayout(false);
            this.tabPageDog.ResumeLayout(false);
            this.tabPageDog.PerformLayout();
            this.tabPageCat.ResumeLayout(false);
            this.tabPageCat.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCheckOut;
        private System.Windows.Forms.TabPage tabPageDog;
        private System.Windows.Forms.TabPage tabPageCat;
        private System.Windows.Forms.Label lbl_Dog_Age;
        private System.Windows.Forms.Label lbl_Dog_Breed;
        private System.Windows.Forms.Label lbl_Dog_Name;
        private System.Windows.Forms.TextBox txt_Dog_Age;
        private System.Windows.Forms.TextBox txt_Dog_Breed;
        private System.Windows.Forms.TextBox txt_Dog_Name;
        private System.Windows.Forms.Button btn_Dog_Book;
        private System.Windows.Forms.Button btn_Cat_Book;
        private System.Windows.Forms.TextBox txt_Cat_Age;
        private System.Windows.Forms.TextBox txt_Cat_breed;
        private System.Windows.Forms.TextBox txt_Cat_name;
        private System.Windows.Forms.Label lbl_Cat_age;
        private System.Windows.Forms.Label lbl_Cat_breed;
        private System.Windows.Forms.Label lbl_Cat_Name;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.Label lbl_checkout_Age;
        private System.Windows.Forms.Label lbl_checkout_breed;
        private System.Windows.Forms.Label lbl_Checkout_Name;
        private System.Windows.Forms.CheckBox checkBoxCat;
        private System.Windows.Forms.CheckBox checkBoxDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_checkOut_Age;
        private System.Windows.Forms.TextBox txt_checkOut_Breed;
        private System.Windows.Forms.TextBox txt_checkOut_Name;
    }
}

