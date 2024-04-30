namespace Lab5Var1Task1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.checkBoxTurbine = new System.Windows.Forms.CheckBox();
            this.checkBoxSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxExhaustsystem = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.InitialImage")));
            this.pictureBoxCar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(179, 100);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // checkBoxTurbine
            // 
            this.checkBoxTurbine.AutoSize = true;
            this.checkBoxTurbine.Location = new System.Drawing.Point(12, 136);
            this.checkBoxTurbine.Name = "checkBoxTurbine";
            this.checkBoxTurbine.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTurbine.TabIndex = 1;
            this.checkBoxTurbine.Text = "Турбіна";
            this.checkBoxTurbine.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpoiler
            // 
            this.checkBoxSpoiler.AutoSize = true;
            this.checkBoxSpoiler.Location = new System.Drawing.Point(12, 177);
            this.checkBoxSpoiler.Name = "checkBoxSpoiler";
            this.checkBoxSpoiler.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSpoiler.TabIndex = 2;
            this.checkBoxSpoiler.Text = "Спойлер";
            this.checkBoxSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxExhaustsystem
            // 
            this.checkBoxExhaustsystem.AutoSize = true;
            this.checkBoxExhaustsystem.Location = new System.Drawing.Point(12, 219);
            this.checkBoxExhaustsystem.Name = "checkBoxExhaustsystem";
            this.checkBoxExhaustsystem.Size = new System.Drawing.Size(120, 17);
            this.checkBoxExhaustsystem.TabIndex = 3;
            this.checkBoxExhaustsystem.Text = "Вихлопна система";
            this.checkBoxExhaustsystem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxExhaustsystem);
            this.Controls.Add(this.checkBoxSpoiler);
            this.Controls.Add(this.checkBoxTurbine);
            this.Controls.Add(this.pictureBoxCar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.CheckBox checkBoxTurbine;
        private System.Windows.Forms.CheckBox checkBoxSpoiler;
        private System.Windows.Forms.CheckBox checkBoxExhaustsystem;
        private System.Windows.Forms.Button button1;
    }
}

