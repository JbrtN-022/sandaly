namespace сандали
{
    partial class UserControlTovar
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTovar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelArticul = new System.Windows.Forms.Label();
            this.labelTovar = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelProizvoditel = new System.Windows.Forms.Label();
            this.labelCenaOld = new System.Windows.Forms.Label();
            this.labelEdIzm = new System.Windows.Forms.Label();
            this.labelKolVo = new System.Windows.Forms.Label();
            this.labelSkidka = new System.Windows.Forms.Label();
            this.labelCenaNew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelArticul
            // 
            this.labelArticul.AutoSize = true;
            this.labelArticul.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticul.Location = new System.Drawing.Point(150, 4);
            this.labelArticul.Name = "labelArticul";
            this.labelArticul.Size = new System.Drawing.Size(118, 17);
            this.labelArticul.TabIndex = 1;
            this.labelArticul.Text = "Артикул товара";
            // 
            // labelTovar
            // 
            this.labelTovar.AutoSize = true;
            this.labelTovar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTovar.Location = new System.Drawing.Point(150, 22);
            this.labelTovar.Name = "labelTovar";
            this.labelTovar.Size = new System.Drawing.Size(297, 17);
            this.labelTovar.TabIndex = 2;
            this.labelTovar.Text = "Категория товара | Наименование товара";
            // 
            // labelDesc
            // 
            this.labelDesc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesc.Location = new System.Drawing.Point(150, 45);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(297, 35);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Описание товара:";
            this.labelDesc.Click += new System.EventHandler(this.labelDesc_Click);
            // 
            // labelProizvoditel
            // 
            this.labelProizvoditel.AutoSize = true;
            this.labelProizvoditel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProizvoditel.Location = new System.Drawing.Point(150, 74);
            this.labelProizvoditel.Name = "labelProizvoditel";
            this.labelProizvoditel.Size = new System.Drawing.Size(94, 15);
            this.labelProizvoditel.TabIndex = 4;
            this.labelProizvoditel.Text = "Производитель:";
            // 
            // labelCenaOld
            // 
            this.labelCenaOld.AutoSize = true;
            this.labelCenaOld.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCenaOld.Location = new System.Drawing.Point(150, 89);
            this.labelCenaOld.Name = "labelCenaOld";
            this.labelCenaOld.Size = new System.Drawing.Size(38, 15);
            this.labelCenaOld.TabIndex = 5;
            this.labelCenaOld.Text = "Цена:";
            // 
            // labelEdIzm
            // 
            this.labelEdIzm.AutoSize = true;
            this.labelEdIzm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEdIzm.Location = new System.Drawing.Point(150, 104);
            this.labelEdIzm.Name = "labelEdIzm";
            this.labelEdIzm.Size = new System.Drawing.Size(120, 15);
            this.labelEdIzm.TabIndex = 6;
            this.labelEdIzm.Text = "Единица измерения:";
            // 
            // labelKolVo
            // 
            this.labelKolVo.AutoSize = true;
            this.labelKolVo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolVo.Location = new System.Drawing.Point(150, 119);
            this.labelKolVo.Name = "labelKolVo";
            this.labelKolVo.Size = new System.Drawing.Size(129, 15);
            this.labelKolVo.TabIndex = 7;
            this.labelKolVo.Text = "Количество на складе:";
            // 
            // labelSkidka
            // 
            this.labelSkidka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSkidka.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkidka.Location = new System.Drawing.Point(453, 4);
            this.labelSkidka.Name = "labelSkidka";
            this.labelSkidka.Size = new System.Drawing.Size(140, 140);
            this.labelSkidka.TabIndex = 8;
            this.labelSkidka.Text = "СКИДКА";
            this.labelSkidka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSkidka.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelCenaNew
            // 
            this.labelCenaNew.AutoSize = true;
            this.labelCenaNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCenaNew.Location = new System.Drawing.Point(216, 89);
            this.labelCenaNew.Name = "labelCenaNew";
            this.labelCenaNew.Size = new System.Drawing.Size(0, 15);
            this.labelCenaNew.TabIndex = 9;
            // 
            // UserControlTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelCenaNew);
            this.Controls.Add(this.labelSkidka);
            this.Controls.Add(this.labelKolVo);
            this.Controls.Add(this.labelEdIzm);
            this.Controls.Add(this.labelCenaOld);
            this.Controls.Add(this.labelProizvoditel);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelTovar);
            this.Controls.Add(this.labelArticul);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTovar";
            this.Size = new System.Drawing.Size(597, 146);
            this.Load += new System.EventHandler(this.UserControlTovar_Load);
            this.Click += new System.EventHandler(this.UserControlTovar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelArticul;
        private System.Windows.Forms.Label labelTovar;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelProizvoditel;
        private System.Windows.Forms.Label labelCenaOld;
        private System.Windows.Forms.Label labelEdIzm;
        private System.Windows.Forms.Label labelKolVo;
        private System.Windows.Forms.Label labelSkidka;
        private System.Windows.Forms.Label labelCenaNew;
    }
}
