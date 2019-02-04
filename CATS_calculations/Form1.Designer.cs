namespace CATS_calculations
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
            this.buttonForSelectFile = new System.Windows.Forms.Button();
            this.ComboBoxForDates = new System.Windows.Forms.ComboBox();
            this.ButtonForCalculatingCATS = new System.Windows.Forms.Button();
            this.LabelForSelectFile = new System.Windows.Forms.Label();
            this.LabelForFileLocation = new System.Windows.Forms.Label();
            this.LabelForSelectDate = new System.Windows.Forms.Label();
            this.LabelForCalculatedTime = new System.Windows.Forms.Label();
            this.LabelTitleForCalcTime = new System.Windows.Forms.Label();
            this.ButtonForCalculatingCATSweek = new System.Windows.Forms.Button();
            this.LabelKrutov = new System.Windows.Forms.Label();
            this.ButtonForServiceRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForSelectFile
            // 
            this.buttonForSelectFile.Location = new System.Drawing.Point(57, 40);
            this.buttonForSelectFile.Name = "buttonForSelectFile";
            this.buttonForSelectFile.Size = new System.Drawing.Size(118, 29);
            this.buttonForSelectFile.TabIndex = 0;
            this.buttonForSelectFile.Text = "Выбрать файл...";
            this.buttonForSelectFile.UseVisualStyleBackColor = true;
            this.buttonForSelectFile.Click += new System.EventHandler(this.buttonForSelectFile_Click);
            // 
            // ComboBoxForDates
            // 
            this.ComboBoxForDates.FormattingEnabled = true;
            this.ComboBoxForDates.Location = new System.Drawing.Point(57, 99);
            this.ComboBoxForDates.Name = "ComboBoxForDates";
            this.ComboBoxForDates.Size = new System.Drawing.Size(118, 21);
            this.ComboBoxForDates.TabIndex = 1;
            this.ComboBoxForDates.SelectedIndexChanged += new System.EventHandler(this.ComboBoxForDates_SelectedIndexChanged);
            // 
            // ButtonForCalculatingCATS
            // 
            this.ButtonForCalculatingCATS.Location = new System.Drawing.Point(57, 143);
            this.ButtonForCalculatingCATS.Name = "ButtonForCalculatingCATS";
            this.ButtonForCalculatingCATS.Size = new System.Drawing.Size(118, 37);
            this.ButtonForCalculatingCATS.TabIndex = 2;
            this.ButtonForCalculatingCATS.Text = "Рассчитать рабочее время за день";
            this.ButtonForCalculatingCATS.UseVisualStyleBackColor = true;
            this.ButtonForCalculatingCATS.Click += new System.EventHandler(this.ButtonForCalculatingCATS_Click);
            // 
            // LabelForSelectFile
            // 
            this.LabelForSelectFile.AutoSize = true;
            this.LabelForSelectFile.Location = new System.Drawing.Point(57, 21);
            this.LabelForSelectFile.Name = "LabelForSelectFile";
            this.LabelForSelectFile.Size = new System.Drawing.Size(86, 13);
            this.LabelForSelectFile.TabIndex = 3;
            this.LabelForSelectFile.Text = "Выберете файл";
            // 
            // LabelForFileLocation
            // 
            this.LabelForFileLocation.AutoSize = true;
            this.LabelForFileLocation.Location = new System.Drawing.Point(182, 55);
            this.LabelForFileLocation.Name = "LabelForFileLocation";
            this.LabelForFileLocation.Size = new System.Drawing.Size(0, 13);
            this.LabelForFileLocation.TabIndex = 4;
            // 
            // LabelForSelectDate
            // 
            this.LabelForSelectDate.AutoSize = true;
            this.LabelForSelectDate.Location = new System.Drawing.Point(57, 83);
            this.LabelForSelectDate.Name = "LabelForSelectDate";
            this.LabelForSelectDate.Size = new System.Drawing.Size(82, 13);
            this.LabelForSelectDate.TabIndex = 5;
            this.LabelForSelectDate.Text = "Выберете дату";
            // 
            // LabelForCalculatedTime
            // 
            this.LabelForCalculatedTime.AutoSize = true;
            this.LabelForCalculatedTime.Location = new System.Drawing.Point(242, 195);
            this.LabelForCalculatedTime.Name = "LabelForCalculatedTime";
            this.LabelForCalculatedTime.Size = new System.Drawing.Size(0, 13);
            this.LabelForCalculatedTime.TabIndex = 6;
            this.LabelForCalculatedTime.Click += new System.EventHandler(this.LabelForCalculatedTime_Click);
            this.LabelForCalculatedTime.MouseEnter += new System.EventHandler(this.LabelForCalculatedTime_MouseEnter);
            // 
            // LabelTitleForCalcTime
            // 
            this.LabelTitleForCalcTime.AutoSize = true;
            this.LabelTitleForCalcTime.Location = new System.Drawing.Point(57, 195);
            this.LabelTitleForCalcTime.Name = "LabelTitleForCalcTime";
            this.LabelTitleForCalcTime.Size = new System.Drawing.Size(137, 13);
            this.LabelTitleForCalcTime.TabIndex = 7;
            this.LabelTitleForCalcTime.Text = "Итоговое рабочее время:";
            // 
            // ButtonForCalculatingCATSweek
            // 
            this.ButtonForCalculatingCATSweek.Location = new System.Drawing.Point(181, 143);
            this.ButtonForCalculatingCATSweek.Name = "ButtonForCalculatingCATSweek";
            this.ButtonForCalculatingCATSweek.Size = new System.Drawing.Size(118, 37);
            this.ButtonForCalculatingCATSweek.TabIndex = 8;
            this.ButtonForCalculatingCATSweek.Text = "Рассчитать рабочее время за неделю";
            this.ButtonForCalculatingCATSweek.UseVisualStyleBackColor = true;
            this.ButtonForCalculatingCATSweek.Click += new System.EventHandler(this.ButtonForCalculatingCATSweek_Click);
            // 
            // LabelKrutov
            // 
            this.LabelKrutov.AutoSize = true;
            this.LabelKrutov.Location = new System.Drawing.Point(438, 195);
            this.LabelKrutov.Name = "LabelKrutov";
            this.LabelKrutov.Size = new System.Drawing.Size(0, 13);
            this.LabelKrutov.TabIndex = 9;
            // 
            // ButtonForServiceRequest
            // 
            this.ButtonForServiceRequest.Location = new System.Drawing.Point(305, 143);
            this.ButtonForServiceRequest.Name = "ButtonForServiceRequest";
            this.ButtonForServiceRequest.Size = new System.Drawing.Size(133, 37);
            this.ButtonForServiceRequest.TabIndex = 10;
            this.ButtonForServiceRequest.Text = "Обращения выполненные за день";
            this.ButtonForServiceRequest.UseVisualStyleBackColor = true;
            this.ButtonForServiceRequest.Click += new System.EventHandler(this.ButtonForServiceRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 221);
            this.Controls.Add(this.ButtonForServiceRequest);
            this.Controls.Add(this.LabelKrutov);
            this.Controls.Add(this.ButtonForCalculatingCATSweek);
            this.Controls.Add(this.LabelTitleForCalcTime);
            this.Controls.Add(this.LabelForCalculatedTime);
            this.Controls.Add(this.LabelForSelectDate);
            this.Controls.Add(this.LabelForFileLocation);
            this.Controls.Add(this.LabelForSelectFile);
            this.Controls.Add(this.ButtonForCalculatingCATS);
            this.Controls.Add(this.ComboBoxForDates);
            this.Controls.Add(this.buttonForSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет рабочего времени";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForSelectFile;
        private System.Windows.Forms.ComboBox ComboBoxForDates;
        private System.Windows.Forms.Button ButtonForCalculatingCATS;
        private System.Windows.Forms.Label LabelForSelectFile;
        private System.Windows.Forms.Label LabelForFileLocation;
        private System.Windows.Forms.Label LabelForSelectDate;
        private System.Windows.Forms.Label LabelForCalculatedTime;
        private System.Windows.Forms.Label LabelTitleForCalcTime;
        private System.Windows.Forms.Button ButtonForCalculatingCATSweek;
        private System.Windows.Forms.Label LabelKrutov;
        private System.Windows.Forms.Button ButtonForServiceRequest;
    }
}

