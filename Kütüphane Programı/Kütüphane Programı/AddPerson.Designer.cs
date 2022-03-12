
namespace Kütüphane_Programı
{
    partial class AddPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C Kimlik Numarası :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcTextBox
            // 
            this.tcTextBox.BackColor = System.Drawing.Color.Silver;
            this.tcTextBox.Location = new System.Drawing.Point(115, 10);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(150, 20);
            this.tcTextBox.TabIndex = 0;
            this.tcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Silver;
            this.nameTextBox.Location = new System.Drawing.Point(115, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.Silver;
            this.surnameTextBox.Location = new System.Drawing.Point(115, 62);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.surnameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer",
            "Belirtilmemiş"});
            this.sexComboBox.Location = new System.Drawing.Point(115, 114);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(150, 21);
            this.sexComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(271, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon Numarası :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(271, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Posta :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Silver;
            this.emailTextBox.Location = new System.Drawing.Point(374, 35);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(271, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.Silver;
            this.addressTextBox.Location = new System.Drawing.Point(374, 62);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(150, 73);
            this.addressTextBox.TabIndex = 7;
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.SystemColors.Control;
            this.cleanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Font = new System.Drawing.Font("Colonna MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cleanButton.Location = new System.Drawing.Point(274, 141);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(122, 37);
            this.cleanButton.TabIndex = 8;
            this.cleanButton.Text = "Girdileri Temizle";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Colonna MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(402, 141);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 37);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "EKLE";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.Silver;
            this.phoneTextBox.Location = new System.Drawing.Point(374, 9);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(150, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.BackColor = System.Drawing.Color.Silver;
            this.birthdayTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.birthdayTextBox.Location = new System.Drawing.Point(116, 88);
            this.birthdayTextBox.Mask = "00/00/0000";
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(149, 20);
            this.birthdayTextBox.TabIndex = 10;
            this.birthdayTextBox.ValidatingType = typeof(System.DateTime);
            this.birthdayTextBox.Click += new System.EventHandler(this.birthdayTextBox_Click);
            this.birthdayTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.birthdayTextBox_Validating);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(536, 190);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddPerson";
            this.Text = "Kişi Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.MaskedTextBox birthdayTextBox;
    }
}