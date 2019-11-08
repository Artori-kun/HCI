namespace ElevatorEmulator
{
    partial class SettingForm
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
            this.weightLimitLabel = new System.Windows.Forms.Label();
            this.elevatorSpeedLabel = new System.Windows.Forms.Label();
            this.basementNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.settingExitButton = new System.Windows.Forms.Button();
            this.settingApplyButton = new System.Windows.Forms.Button();
            this.settingOKButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.floorLockLabel = new System.Windows.Forms.Label();
            this.floorNumLabel = new System.Windows.Forms.Label();
            this.floorNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basementNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // weightLimitLabel
            // 
            this.weightLimitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.weightLimitLabel.Location = new System.Drawing.Point(19, 48);
            this.weightLimitLabel.Name = "weightLimitLabel";
            this.weightLimitLabel.Size = new System.Drawing.Size(170, 22);
            this.weightLimitLabel.TabIndex = 0;
            this.weightLimitLabel.Text = "Số tầng hầm:";
            // 
            // elevatorSpeedLabel
            // 
            this.elevatorSpeedLabel.AutoSize = true;
            this.elevatorSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.elevatorSpeedLabel.Location = new System.Drawing.Point(6, 34);
            this.elevatorSpeedLabel.Name = "elevatorSpeedLabel";
            this.elevatorSpeedLabel.Size = new System.Drawing.Size(51, 16);
            this.elevatorSpeedLabel.TabIndex = 1;
            this.elevatorSpeedLabel.Text = "Tốc độ";
            this.elevatorSpeedLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // basementNumericUpDown
            // 
            this.basementNumericUpDown.Location = new System.Drawing.Point(195, 48);
            this.basementNumericUpDown.Name = "basementNumericUpDown";
            this.basementNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.basementNumericUpDown.TabIndex = 2;
            this.basementNumericUpDown.ValueChanged += new System.EventHandler(this.weightLimitNumericUpDown_ValueChanged);
            // 
            // settingExitButton
            // 
            this.settingExitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingExitButton.Location = new System.Drawing.Point(295, 543);
            this.settingExitButton.Name = "settingExitButton";
            this.settingExitButton.Size = new System.Drawing.Size(75, 23);
            this.settingExitButton.TabIndex = 4;
            this.settingExitButton.Text = "Thoát";
            this.settingExitButton.UseVisualStyleBackColor = false;
            this.settingExitButton.Click += new System.EventHandler(this.settingExitButton_Click);
            // 
            // settingApplyButton
            // 
            this.settingApplyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingApplyButton.Location = new System.Drawing.Point(214, 543);
            this.settingApplyButton.Name = "settingApplyButton";
            this.settingApplyButton.Size = new System.Drawing.Size(75, 23);
            this.settingApplyButton.TabIndex = 5;
            this.settingApplyButton.Text = "Áp dụng";
            this.settingApplyButton.UseVisualStyleBackColor = false;
            // 
            // settingOKButton
            // 
            this.settingOKButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingOKButton.Location = new System.Drawing.Point(133, 543);
            this.settingOKButton.Name = "settingOKButton";
            this.settingOKButton.Size = new System.Drawing.Size(75, 23);
            this.settingOKButton.TabIndex = 6;
            this.settingOKButton.Text = "OK";
            this.settingOKButton.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3",
            "Tầng 4",
            "Tầng 5",
            "Tầng 6"});
            this.checkedListBox1.Location = new System.Drawing.Point(152, 65);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(196, 106);
            this.checkedListBox1.TabIndex = 7;
            // 
            // floorLockLabel
            // 
            this.floorLockLabel.AutoSize = true;
            this.floorLockLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.floorLockLabel.Location = new System.Drawing.Point(6, 56);
            this.floorLockLabel.Name = "floorLockLabel";
            this.floorLockLabel.Size = new System.Drawing.Size(87, 19);
            this.floorLockLabel.TabIndex = 8;
            this.floorLockLabel.Text = "Khóa cứng:";
            this.floorLockLabel.Click += new System.EventHandler(this.floorLockLabel_Click);
            // 
            // floorNumLabel
            // 
            this.floorNumLabel.AutoSize = true;
            this.floorNumLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorNumLabel.Location = new System.Drawing.Point(19, 23);
            this.floorNumLabel.Name = "floorNumLabel";
            this.floorNumLabel.Size = new System.Drawing.Size(64, 19);
            this.floorNumLabel.TabIndex = 9;
            this.floorNumLabel.Text = "Số tầng:";
            // 
            // floorNumNumericUpDown
            // 
            this.floorNumNumericUpDown.Location = new System.Drawing.Point(195, 22);
            this.floorNumNumericUpDown.Name = "floorNumNumericUpDown";
            this.floorNumNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.floorNumNumericUpDown.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.floorNumLabel);
            this.groupBox1.Controls.Add(this.floorNumNumericUpDown);
            this.groupBox1.Controls.Add(this.basementNumericUpDown);
            this.groupBox1.Controls.Add(this.weightLimitLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tầng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.elevatorSpeedLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cân nặng";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(65, 29);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Controls.Add(this.floorLockLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 260);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cài đặt hệ thống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(7, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Khoảng cách tầng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(195, 213);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Khóa động:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chế độ khóa:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Khóa cứng",
            "Khóa động"});
            this.comboBox1.Location = new System.Drawing.Point(152, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.numericUpDown3);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 89);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới hạn";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(195, 53);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(195, 21);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cân nặng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tốc độ:";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 573);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settingOKButton);
            this.Controls.Add(this.settingApplyButton);
            this.Controls.Add(this.settingExitButton);
            this.Name = "SettingForm";
            this.Text = "Cài đặt";
            ((System.ComponentModel.ISupportInitialize)(this.basementNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label weightLimitLabel;
        private System.Windows.Forms.Label elevatorSpeedLabel;
        private System.Windows.Forms.NumericUpDown basementNumericUpDown;
        private System.Windows.Forms.Button settingExitButton;
        private System.Windows.Forms.Button settingApplyButton;
        private System.Windows.Forms.Button settingOKButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label floorLockLabel;
        private System.Windows.Forms.Label floorNumLabel;
        private System.Windows.Forms.NumericUpDown floorNumNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}