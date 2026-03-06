namespace сандали
{
    partial class FormUppZakaz
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpp = new System.Windows.Forms.Button();
            this.dateTimePickerVidachi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerZakaza = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAdres = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxNumZak = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Дата выдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Адрес пункта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Статус заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Номер заказа";
            // 
            // buttonUpp
            // 
            this.buttonUpp.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonUpp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpp.Location = new System.Drawing.Point(14, 226);
            this.buttonUpp.Name = "buttonUpp";
            this.buttonUpp.Size = new System.Drawing.Size(286, 39);
            this.buttonUpp.TabIndex = 16;
            this.buttonUpp.Text = "Изменить заказ";
            this.buttonUpp.UseVisualStyleBackColor = false;
            this.buttonUpp.Click += new System.EventHandler(this.buttonUpp_Click);
            // 
            // dateTimePickerVidachi
            // 
            this.dateTimePickerVidachi.Location = new System.Drawing.Point(112, 185);
            this.dateTimePickerVidachi.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerVidachi.Name = "dateTimePickerVidachi";
            this.dateTimePickerVidachi.Size = new System.Drawing.Size(188, 25);
            this.dateTimePickerVidachi.TabIndex = 15;
            // 
            // dateTimePickerZakaza
            // 
            this.dateTimePickerZakaza.Location = new System.Drawing.Point(112, 141);
            this.dateTimePickerZakaza.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerZakaza.Name = "dateTimePickerZakaza";
            this.dateTimePickerZakaza.Size = new System.Drawing.Size(188, 25);
            this.dateTimePickerZakaza.TabIndex = 14;
            // 
            // comboBoxAdres
            // 
            this.comboBoxAdres.FormattingEnabled = true;
            this.comboBoxAdres.Location = new System.Drawing.Point(112, 98);
            this.comboBoxAdres.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAdres.Name = "comboBoxAdres";
            this.comboBoxAdres.Size = new System.Drawing.Size(188, 25);
            this.comboBoxAdres.TabIndex = 13;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(112, 56);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(188, 25);
            this.comboBoxStatus.TabIndex = 12;
            // 
            // textBoxNumZak
            // 
            this.textBoxNumZak.Location = new System.Drawing.Point(112, 14);
            this.textBoxNumZak.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumZak.Name = "textBoxNumZak";
            this.textBoxNumZak.Size = new System.Drawing.Size(188, 25);
            this.textBoxNumZak.TabIndex = 11;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(12, 271);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(288, 39);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "Удалить заказ";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormUppZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 317);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpp);
            this.Controls.Add(this.dateTimePickerVidachi);
            this.Controls.Add(this.dateTimePickerZakaza);
            this.Controls.Add(this.comboBoxAdres);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxNumZak);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUppZakaz";
            this.Text = "FormUppZakaz";
            this.Load += new System.EventHandler(this.FormUppZakaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpp;
        private System.Windows.Forms.DateTimePicker dateTimePickerVidachi;
        private System.Windows.Forms.DateTimePicker dateTimePickerZakaza;
        private System.Windows.Forms.ComboBox comboBoxAdres;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxNumZak;
        private System.Windows.Forms.Button buttonDel;
    }
}