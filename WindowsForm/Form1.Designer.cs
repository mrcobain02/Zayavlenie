namespace WindowsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.button = new System.Windows.Forms.Button();
            this.NAME = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(326, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студент";
            // 
            // Group
            // 
            this.Group.FormattingEnabled = true;
            this.Group.Items.AddRange(new object[] {
            "ИС-18-02",
            "ИС-18-01",
            "ИС-19-01",
            "ИС-19-02",
            "ИС-19-03",
            "ИС-19-04",
            "ИС-19-05"});
            this.Group.Location = new System.Drawing.Point(104, 137);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(154, 21);
            this.Group.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Заявление"});
            this.comboBox3.Location = new System.Drawing.Point(550, 137);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(104, 224);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(154, 20);
            this.Date.TabIndex = 5;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(330, 224);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(116, 23);
            this.button.TabIndex = 6;
            this.button.Text = "Получить документ";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // NAME
            // 
            this.NAME.FormattingEnabled = true;
            this.NAME.Items.AddRange(new object[] {
            "Летов Егор Федорович",
            "Жуков Сергей Александрович",
            "Иванов Иван Алексеевич"});
            this.NAME.Location = new System.Drawing.Point(330, 137);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(159, 21);
            this.NAME.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox NAME;
    }
}

