namespace сандали
{
    partial class FormAddZakaz
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
            this.textBoxNumZak = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAdres = new System.Windows.Forms.ComboBox();
            this.dateTimePickerZakaza = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVidachi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumZak
            // 
            this.textBoxNumZak.Location = new System.Drawing.Point(106, 16);
            this.textBoxNumZak.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumZak.Name = "textBoxNumZak";
            this.textBoxNumZak.Size = new System.Drawing.Size(188, 25);
            this.textBoxNumZak.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(106, 58);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(188, 25);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // comboBoxAdres
            // 
            this.comboBoxAdres.FormattingEnabled = true;
            this.comboBoxAdres.Location = new System.Drawing.Point(106, 100);
            this.comboBoxAdres.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAdres.Name = "comboBoxAdres";
            this.comboBoxAdres.Size = new System.Drawing.Size(188, 25);
            this.comboBoxAdres.TabIndex = 2;
            // 
            // dateTimePickerZakaza
            // 
            this.dateTimePickerZakaza.Location = new System.Drawing.Point(106, 143);
            this.dateTimePickerZakaza.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerZakaza.Name = "dateTimePickerZakaza";
            this.dateTimePickerZakaza.Size = new System.Drawing.Size(188, 25);
            this.dateTimePickerZakaza.TabIndex = 3;
            // 
            // dateTimePickerVidachi
            // 
            this.dateTimePickerVidachi.Location = new System.Drawing.Point(106, 187);
            this.dateTimePickerVidachi.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerVidachi.Name = "dateTimePickerVidachi";
            this.dateTimePickerVidachi.Size = new System.Drawing.Size(188, 25);
            this.dateTimePickerVidachi.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить  заказ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Статус заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адрес пункта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата выдачи";
            // 
            // FormAddZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 285);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerVidachi);
            this.Controls.Add(this.dateTimePickerZakaza);
            this.Controls.Add(this.comboBoxAdres);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxNumZak);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddZakaz";
            this.Text = "FormAddZakaz";
            this.Load += new System.EventHandler(this.FormAddZakaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumZak;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxAdres;
        private System.Windows.Forms.DateTimePicker dateTimePickerZakaza;
        private System.Windows.Forms.DateTimePicker dateTimePickerVidachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}