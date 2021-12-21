namespace monastery_app.Forms
{
    partial class PriestForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataNote = new System.Windows.Forms.DataGridView();
            this.noteBackButton = new System.Windows.Forms.Button();
            this.noteDeleteButton = new System.Windows.Forms.Button();
            this.noteEditButton = new System.Windows.Forms.Button();
            this.noteAddButton = new System.Windows.Forms.Button();
            this.textBoxNotePrice = new System.Windows.Forms.TextBox();
            this.comboBoxNoteUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataScheduleWork = new System.Windows.Forms.DataGridView();
            this.buttonBackScheduleWork = new System.Windows.Forms.Button();
            this.buttonDeleteScheduleWork = new System.Windows.Forms.Button();
            this.buttonEditScheduleWork = new System.Windows.Forms.Button();
            this.buttonAddScheduleWork = new System.Windows.Forms.Button();
            this.dateTimePickerScheduleWork = new System.Windows.Forms.DateTimePicker();
            this.comboBoxServiceScheduleWork = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataServices = new System.Windows.Forms.DataGridView();
            this.buttonBackService = new System.Windows.Forms.Button();
            this.buttonDeleteService = new System.Windows.Forms.Button();
            this.buttonEditService = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNote)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataScheduleWork)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataNote);
            this.tabPage1.Controls.Add(this.noteBackButton);
            this.tabPage1.Controls.Add(this.noteDeleteButton);
            this.tabPage1.Controls.Add(this.noteEditButton);
            this.tabPage1.Controls.Add(this.noteAddButton);
            this.tabPage1.Controls.Add(this.textBoxNotePrice);
            this.tabPage1.Controls.Add(this.comboBoxNoteUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Записки";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataNote
            // 
            this.dataNote.AllowUserToAddRows = false;
            this.dataNote.AllowUserToDeleteRows = false;
            this.dataNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNote.Location = new System.Drawing.Point(6, 52);
            this.dataNote.Name = "dataNote";
            this.dataNote.ReadOnly = true;
            this.dataNote.RowTemplate.Height = 25;
            this.dataNote.Size = new System.Drawing.Size(756, 342);
            this.dataNote.TabIndex = 26;
            // 
            // noteBackButton
            // 
            this.noteBackButton.Location = new System.Drawing.Point(493, 23);
            this.noteBackButton.Name = "noteBackButton";
            this.noteBackButton.Size = new System.Drawing.Size(75, 23);
            this.noteBackButton.TabIndex = 25;
            this.noteBackButton.Text = "Назад";
            this.noteBackButton.UseVisualStyleBackColor = true;
            this.noteBackButton.Click += new System.EventHandler(this.noteBackButton_Click_1);
            // 
            // noteDeleteButton
            // 
            this.noteDeleteButton.Location = new System.Drawing.Point(412, 23);
            this.noteDeleteButton.Name = "noteDeleteButton";
            this.noteDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.noteDeleteButton.TabIndex = 24;
            this.noteDeleteButton.Text = "Удалить";
            this.noteDeleteButton.UseVisualStyleBackColor = true;
            this.noteDeleteButton.Click += new System.EventHandler(this.noteDeleteButton_Click_1);
            // 
            // noteEditButton
            // 
            this.noteEditButton.Location = new System.Drawing.Point(331, 23);
            this.noteEditButton.Name = "noteEditButton";
            this.noteEditButton.Size = new System.Drawing.Size(75, 23);
            this.noteEditButton.TabIndex = 23;
            this.noteEditButton.Text = "Изменить";
            this.noteEditButton.UseVisualStyleBackColor = true;
            this.noteEditButton.Click += new System.EventHandler(this.noteEditButton_Click_1);
            // 
            // noteAddButton
            // 
            this.noteAddButton.Location = new System.Drawing.Point(250, 23);
            this.noteAddButton.Name = "noteAddButton";
            this.noteAddButton.Size = new System.Drawing.Size(75, 23);
            this.noteAddButton.TabIndex = 22;
            this.noteAddButton.Text = "Добавить";
            this.noteAddButton.UseVisualStyleBackColor = true;
            this.noteAddButton.Click += new System.EventHandler(this.noteAddButton_Click_1);
            // 
            // textBoxNotePrice
            // 
            this.textBoxNotePrice.Location = new System.Drawing.Point(142, 23);
            this.textBoxNotePrice.Name = "textBoxNotePrice";
            this.textBoxNotePrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxNotePrice.TabIndex = 21;
            // 
            // comboBoxNoteUser
            // 
            this.comboBoxNoteUser.FormattingEnabled = true;
            this.comboBoxNoteUser.Location = new System.Drawing.Point(6, 23);
            this.comboBoxNoteUser.Name = "comboBoxNoteUser";
            this.comboBoxNoteUser.Size = new System.Drawing.Size(130, 23);
            this.comboBoxNoteUser.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пожертвование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Пользователь";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataScheduleWork);
            this.tabPage4.Controls.Add(this.buttonBackScheduleWork);
            this.tabPage4.Controls.Add(this.buttonDeleteScheduleWork);
            this.tabPage4.Controls.Add(this.buttonEditScheduleWork);
            this.tabPage4.Controls.Add(this.buttonAddScheduleWork);
            this.tabPage4.Controls.Add(this.dateTimePickerScheduleWork);
            this.tabPage4.Controls.Add(this.comboBoxServiceScheduleWork);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Расписание служб";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataScheduleWork
            // 
            this.dataScheduleWork.AllowUserToAddRows = false;
            this.dataScheduleWork.AllowUserToDeleteRows = false;
            this.dataScheduleWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataScheduleWork.Location = new System.Drawing.Point(6, 54);
            this.dataScheduleWork.Name = "dataScheduleWork";
            this.dataScheduleWork.ReadOnly = true;
            this.dataScheduleWork.RowTemplate.Height = 25;
            this.dataScheduleWork.Size = new System.Drawing.Size(756, 338);
            this.dataScheduleWork.TabIndex = 17;
            // 
            // buttonBackScheduleWork
            // 
            this.buttonBackScheduleWork.Location = new System.Drawing.Point(611, 25);
            this.buttonBackScheduleWork.Name = "buttonBackScheduleWork";
            this.buttonBackScheduleWork.Size = new System.Drawing.Size(75, 23);
            this.buttonBackScheduleWork.TabIndex = 16;
            this.buttonBackScheduleWork.Text = "Назад";
            this.buttonBackScheduleWork.UseVisualStyleBackColor = true;
            this.buttonBackScheduleWork.Click += new System.EventHandler(this.buttonBackScheduleWork_Click);
            // 
            // buttonDeleteScheduleWork
            // 
            this.buttonDeleteScheduleWork.Location = new System.Drawing.Point(530, 25);
            this.buttonDeleteScheduleWork.Name = "buttonDeleteScheduleWork";
            this.buttonDeleteScheduleWork.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteScheduleWork.TabIndex = 15;
            this.buttonDeleteScheduleWork.Text = "Удалить";
            this.buttonDeleteScheduleWork.UseVisualStyleBackColor = true;
            this.buttonDeleteScheduleWork.Click += new System.EventHandler(this.buttonDeleteScheduleWork_Click);
            // 
            // buttonEditScheduleWork
            // 
            this.buttonEditScheduleWork.Location = new System.Drawing.Point(449, 25);
            this.buttonEditScheduleWork.Name = "buttonEditScheduleWork";
            this.buttonEditScheduleWork.Size = new System.Drawing.Size(75, 23);
            this.buttonEditScheduleWork.TabIndex = 14;
            this.buttonEditScheduleWork.Text = "Изменить";
            this.buttonEditScheduleWork.UseVisualStyleBackColor = true;
            this.buttonEditScheduleWork.Click += new System.EventHandler(this.buttonEditScheduleWork_Click);
            // 
            // buttonAddScheduleWork
            // 
            this.buttonAddScheduleWork.Location = new System.Drawing.Point(368, 25);
            this.buttonAddScheduleWork.Name = "buttonAddScheduleWork";
            this.buttonAddScheduleWork.Size = new System.Drawing.Size(75, 23);
            this.buttonAddScheduleWork.TabIndex = 13;
            this.buttonAddScheduleWork.Text = "Добавить";
            this.buttonAddScheduleWork.UseVisualStyleBackColor = true;
            this.buttonAddScheduleWork.Click += new System.EventHandler(this.buttonAddScheduleWork_Click);
            // 
            // dateTimePickerScheduleWork
            // 
            this.dateTimePickerScheduleWork.Location = new System.Drawing.Point(162, 25);
            this.dateTimePickerScheduleWork.Name = "dateTimePickerScheduleWork";
            this.dateTimePickerScheduleWork.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerScheduleWork.TabIndex = 12;
            // 
            // comboBoxServiceScheduleWork
            // 
            this.comboBoxServiceScheduleWork.FormattingEnabled = true;
            this.comboBoxServiceScheduleWork.Location = new System.Drawing.Point(6, 25);
            this.comboBoxServiceScheduleWork.Name = "comboBoxServiceScheduleWork";
            this.comboBoxServiceScheduleWork.Size = new System.Drawing.Size(150, 23);
            this.comboBoxServiceScheduleWork.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Дата службы";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Служба";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataServices);
            this.tabPage5.Controls.Add(this.buttonBackService);
            this.tabPage5.Controls.Add(this.buttonDeleteService);
            this.tabPage5.Controls.Add(this.buttonEditService);
            this.tabPage5.Controls.Add(this.buttonAddService);
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 398);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Службы";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // dataServices
            // 
            this.dataServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServices.Location = new System.Drawing.Point(6, 84);
            this.dataServices.Name = "dataServices";
            this.dataServices.RowTemplate.Height = 25;
            this.dataServices.Size = new System.Drawing.Size(756, 308);
            this.dataServices.TabIndex = 17;
            // 
            // buttonBackService
            // 
            this.buttonBackService.Location = new System.Drawing.Point(249, 55);
            this.buttonBackService.Name = "buttonBackService";
            this.buttonBackService.Size = new System.Drawing.Size(75, 23);
            this.buttonBackService.TabIndex = 16;
            this.buttonBackService.Text = "Назад";
            this.buttonBackService.UseVisualStyleBackColor = true;
            this.buttonBackService.Click += new System.EventHandler(this.buttonBackService_Click);
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.Location = new System.Drawing.Point(168, 55);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteService.TabIndex = 15;
            this.buttonDeleteService.Text = "Удалить";
            this.buttonDeleteService.UseVisualStyleBackColor = true;
            this.buttonDeleteService.Click += new System.EventHandler(this.buttonDeleteService_Click);
            // 
            // buttonEditService
            // 
            this.buttonEditService.Location = new System.Drawing.Point(87, 55);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(75, 23);
            this.buttonEditService.TabIndex = 14;
            this.buttonEditService.Text = "Изменить";
            this.buttonEditService.UseVisualStyleBackColor = true;
            this.buttonEditService.Click += new System.EventHandler(this.buttonEditService_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(6, 55);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(75, 23);
            this.buttonAddService.TabIndex = 13;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(485, 23);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Описание";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Название службы";
            // 
            // PriestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PriestForm";
            this.Text = "PriestForm";
            this.Load += new System.EventHandler(this.PriestForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNote)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataScheduleWork)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataNote;
        private System.Windows.Forms.Button noteBackButton;
        private System.Windows.Forms.Button noteDeleteButton;
        private System.Windows.Forms.Button noteEditButton;
        private System.Windows.Forms.Button noteAddButton;
        private System.Windows.Forms.TextBox textBoxNotePrice;
        private System.Windows.Forms.ComboBox comboBoxNoteUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataScheduleWork;
        private System.Windows.Forms.Button buttonBackScheduleWork;
        private System.Windows.Forms.Button buttonDeleteScheduleWork;
        private System.Windows.Forms.Button buttonEditScheduleWork;
        private System.Windows.Forms.Button buttonAddScheduleWork;
        private System.Windows.Forms.DateTimePicker dateTimePickerScheduleWork;
        private System.Windows.Forms.ComboBox comboBoxServiceScheduleWork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataServices;
        private System.Windows.Forms.Button buttonBackService;
        private System.Windows.Forms.Button buttonDeleteService;
        private System.Windows.Forms.Button buttonEditService;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}