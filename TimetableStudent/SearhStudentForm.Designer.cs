namespace TimetableStudent
{
    partial class SearhStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearhStudentForm));
            this.NameStudentLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.NameStudentInput = new System.Windows.Forms.TextBox();
            this.GroupSelect = new System.Windows.Forms.ComboBox();
            this.SearhTimetable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameStudentLabel
            // 
            this.NameStudentLabel.AutoSize = true;
            this.NameStudentLabel.Location = new System.Drawing.Point(17, 170);
            this.NameStudentLabel.Name = "NameStudentLabel";
            this.NameStudentLabel.Size = new System.Drawing.Size(37, 13);
            this.NameStudentLabel.TabIndex = 0;
            this.NameStudentLabel.Text = "ФИО:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(9, 199);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(45, 13);
            this.GroupLabel.TabIndex = 1;
            this.GroupLabel.Text = "Группа:";
            // 
            // NameStudentInput
            // 
            this.NameStudentInput.Location = new System.Drawing.Point(60, 162);
            this.NameStudentInput.Name = "NameStudentInput";
            this.NameStudentInput.Size = new System.Drawing.Size(251, 20);
            this.NameStudentInput.TabIndex = 2;
            this.NameStudentInput.TextChanged += new System.EventHandler(this.NameStudentInput_TextChanged);
            // 
            // GroupSelect
            // 
            this.GroupSelect.FormattingEnabled = true;
            this.GroupSelect.Location = new System.Drawing.Point(60, 196);
            this.GroupSelect.Name = "GroupSelect";
            this.GroupSelect.Size = new System.Drawing.Size(251, 21);
            this.GroupSelect.TabIndex = 3;
            this.GroupSelect.SelectedIndexChanged += new System.EventHandler(this.GroupSelect_SelectedIndexChanged);
            // 
            // SearhTimetable
            // 
            this.SearhTimetable.Location = new System.Drawing.Point(20, 230);
            this.SearhTimetable.Name = "SearhTimetable";
            this.SearhTimetable.Size = new System.Drawing.Size(291, 23);
            this.SearhTimetable.TabIndex = 4;
            this.SearhTimetable.Text = "Поиск расписания";
            this.SearhTimetable.UseVisualStyleBackColor = true;
            this.SearhTimetable.Click += new System.EventHandler(this.SearhTimetable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 133);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SearhStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 275);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearhTimetable);
            this.Controls.Add(this.GroupSelect);
            this.Controls.Add(this.NameStudentInput);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.NameStudentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearhStudentForm";
            this.Text = "Расписание студента";
            this.Load += new System.EventHandler(this.SearhStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameStudentLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.TextBox NameStudentInput;
        private System.Windows.Forms.ComboBox GroupSelect;
        private System.Windows.Forms.Button SearhTimetable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

