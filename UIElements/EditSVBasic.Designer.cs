namespace UIElements
{
    partial class EditSVBasic
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTypeTO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpVvoda = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbXN = new System.Windows.Forms.CheckBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFUAB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBlock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заводской №:";
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbNumber.Location = new System.Drawing.Point(92, 8);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(81, 20);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextChanged += new System.EventHandler(this.t_Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата ввода:";
            // 
            // cbTypeTO
            // 
            this.cbTypeTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTypeTO.FormattingEnabled = true;
            this.cbTypeTO.Items.AddRange(new object[] {
            "ПНР",
            "К1",
            "К",
            "В",
            "О"});
            this.cbTypeTO.Location = new System.Drawing.Point(527, 8);
            this.cbTypeTO.Name = "cbTypeTO";
            this.cbTypeTO.Size = new System.Drawing.Size(59, 21);
            this.cbTypeTO.TabIndex = 4;
            this.cbTypeTO.SelectedIndexChanged += new System.EventHandler(this.t_Change);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(412, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тип последнего ТО:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(592, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата ТО:";
            // 
            // dtpVvoda
            // 
            this.dtpVvoda.CustomFormat = "MMMM yyyy";
            this.dtpVvoda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVvoda.Location = new System.Drawing.Point(260, 8);
            this.dtpVvoda.Name = "dtpVvoda";
            this.dtpVvoda.Size = new System.Drawing.Size(146, 20);
            this.dtpVvoda.TabIndex = 8;
            this.dtpVvoda.ValueChanged += new System.EventHandler(this.t_Change);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "MMMM yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(652, 8);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(146, 20);
            this.dtpDateTo.TabIndex = 9;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.t_Change);
            // 
            // cbXN
            // 
            this.cbXN.AutoSize = true;
            this.cbXN.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbXN.Location = new System.Drawing.Point(4, 37);
            this.cbXN.Name = "cbXN";
            this.cbXN.Size = new System.Drawing.Size(103, 17);
            this.cbXN.TabIndex = 10;
            this.cbXN.Text = "Накладка XN1";
            this.cbXN.UseVisualStyleBackColor = true;
            this.cbXN.CheckedChanged += new System.EventHandler(this.t_Change);
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.SystemColors.Window;
            this.tbType.Location = new System.Drawing.Point(191, 34);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(215, 20);
            this.tbType.TabIndex = 12;
            this.tbType.TextChanged += new System.EventHandler(this.t_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(139, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип СВ:";
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(635, 82);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 23);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bClear
            // 
            this.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(518, 82);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(111, 23);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(401, 82);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(111, 23);
            this.bSave.TabIndex = 15;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ЩПТ-";
            // 
            // cbAB
            // 
            this.cbAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAB.FormattingEnabled = true;
            this.cbAB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbAB.Location = new System.Drawing.Point(44, 66);
            this.cbAB.Name = "cbAB";
            this.cbAB.Size = new System.Drawing.Size(46, 21);
            this.cbAB.TabIndex = 16;
            this.cbAB.SelectedIndexChanged += new System.EventHandler(this.t_Change);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(96, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "АБ";
            // 
            // tbFUAB
            // 
            this.tbFUAB.BackColor = System.Drawing.SystemColors.Window;
            this.tbFUAB.Location = new System.Drawing.Point(228, 66);
            this.tbFUAB.Name = "tbFUAB";
            this.tbFUAB.Size = new System.Drawing.Size(81, 20);
            this.tbFUAB.TabIndex = 20;
            this.tbFUAB.TextChanged += new System.EventHandler(this.t_Change);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(123, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Предохранитель:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(469, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Блок:";
            // 
            // cbBlock
            // 
            this.cbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlock.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBlock.FormattingEnabled = true;
            this.cbBlock.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbBlock.Location = new System.Drawing.Point(510, 35);
            this.cbBlock.Name = "cbBlock";
            this.cbBlock.Size = new System.Drawing.Size(46, 21);
            this.cbBlock.TabIndex = 21;
            this.cbBlock.SelectedIndexChanged += new System.EventHandler(this.t_Change);
            // 
            // EditSVBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbBlock);
            this.Controls.Add(this.tbFUAB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAB);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbXN);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpVvoda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTypeTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Name = "EditSVBasic";
            this.Size = new System.Drawing.Size(802, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypeTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpVvoda;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox cbXN;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFUAB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBlock;
    }
}
