namespace UIElements
{
    partial class EditOPS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBManual = new System.Windows.Forms.RadioButton();
            this.rBAuto = new System.Windows.Forms.RadioButton();
            this.FileBox = new System.Windows.Forms.GroupBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.lNameFile = new System.Windows.Forms.Label();
            this.ManualBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB332 = new System.Windows.Forms.TextBox();
            this.tB330 = new System.Windows.Forms.TextBox();
            this.tB328 = new System.Windows.Forms.TextBox();
            this.tB326 = new System.Windows.Forms.TextBox();
            this.tB324 = new System.Windows.Forms.TextBox();
            this.tB322 = new System.Windows.Forms.TextBox();
            this.tB327 = new System.Windows.Forms.TextBox();
            this.tB325 = new System.Windows.Forms.TextBox();
            this.tB323 = new System.Windows.Forms.TextBox();
            this.tB321 = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.OfDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.FileBox.SuspendLayout();
            this.ManualBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBManual);
            this.groupBox1.Controls.Add(this.rBAuto);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "В ручную / В Автомате";
            // 
            // rBManual
            // 
            this.rBManual.AutoSize = true;
            this.rBManual.Location = new System.Drawing.Point(103, 19);
            this.rBManual.Name = "rBManual";
            this.rBManual.Size = new System.Drawing.Size(70, 17);
            this.rBManual.TabIndex = 1;
            this.rBManual.Text = "В ручную";
            this.rBManual.UseVisualStyleBackColor = true;
            this.rBManual.CheckedChanged += new System.EventHandler(this.rBManual_CheckedChanged);
            // 
            // rBAuto
            // 
            this.rBAuto.AutoSize = true;
            this.rBAuto.Checked = true;
            this.rBAuto.Location = new System.Drawing.Point(6, 19);
            this.rBAuto.Name = "rBAuto";
            this.rBAuto.Size = new System.Drawing.Size(77, 17);
            this.rBAuto.TabIndex = 0;
            this.rBAuto.TabStop = true;
            this.rBAuto.Text = "Из Файла";
            this.rBAuto.UseVisualStyleBackColor = true;
            this.rBAuto.CheckedChanged += new System.EventHandler(this.rBAuto_CheckedChanged);
            // 
            // FileBox
            // 
            this.FileBox.Controls.Add(this.bOpen);
            this.FileBox.Controls.Add(this.lNameFile);
            this.FileBox.Enabled = false;
            this.FileBox.Location = new System.Drawing.Point(192, 3);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(333, 50);
            this.FileBox.TabIndex = 1;
            this.FileBox.TabStop = false;
            this.FileBox.Text = "Файл";
            // 
            // bOpen
            // 
            this.bOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOpen.Location = new System.Drawing.Point(234, 16);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(93, 23);
            this.bOpen.TabIndex = 3;
            this.bOpen.Text = "Открыть";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // lNameFile
            // 
            this.lNameFile.AutoSize = true;
            this.lNameFile.Location = new System.Drawing.Point(17, 21);
            this.lNameFile.Name = "lNameFile";
            this.lNameFile.Size = new System.Drawing.Size(31, 13);
            this.lNameFile.TabIndex = 4;
            this.lNameFile.Text = "none";
            // 
            // ManualBox
            // 
            this.ManualBox.Controls.Add(this.label4);
            this.ManualBox.Controls.Add(this.label3);
            this.ManualBox.Controls.Add(this.label2);
            this.ManualBox.Controls.Add(this.label1);
            this.ManualBox.Controls.Add(this.tB332);
            this.ManualBox.Controls.Add(this.tB330);
            this.ManualBox.Controls.Add(this.tB328);
            this.ManualBox.Controls.Add(this.tB326);
            this.ManualBox.Controls.Add(this.tB324);
            this.ManualBox.Controls.Add(this.tB322);
            this.ManualBox.Controls.Add(this.tB327);
            this.ManualBox.Controls.Add(this.tB325);
            this.ManualBox.Controls.Add(this.tB323);
            this.ManualBox.Controls.Add(this.tB321);
            this.ManualBox.Enabled = false;
            this.ManualBox.Location = new System.Drawing.Point(3, 59);
            this.ManualBox.Name = "ManualBox";
            this.ManualBox.Size = new System.Drawing.Size(522, 79);
            this.ManualBox.TabIndex = 2;
            this.ManualBox.TabStop = false;
            this.ManualBox.Text = "В ручную";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кратность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.5";
            // 
            // tB332
            // 
            this.tB332.Location = new System.Drawing.Point(378, 45);
            this.tB332.Name = "tB332";
            this.tB332.Size = new System.Drawing.Size(54, 20);
            this.tB332.TabIndex = 0;
            this.tB332.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB330
            // 
            this.tB330.Location = new System.Drawing.Point(318, 45);
            this.tB330.Name = "tB330";
            this.tB330.Size = new System.Drawing.Size(54, 20);
            this.tB330.TabIndex = 0;
            this.tB330.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB328
            // 
            this.tB328.Location = new System.Drawing.Point(258, 45);
            this.tB328.Name = "tB328";
            this.tB328.Size = new System.Drawing.Size(54, 20);
            this.tB328.TabIndex = 0;
            this.tB328.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB326
            // 
            this.tB326.Location = new System.Drawing.Point(201, 45);
            this.tB326.Name = "tB326";
            this.tB326.Size = new System.Drawing.Size(54, 20);
            this.tB326.TabIndex = 0;
            this.tB326.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB324
            // 
            this.tB324.Location = new System.Drawing.Point(141, 45);
            this.tB324.Name = "tB324";
            this.tB324.Size = new System.Drawing.Size(54, 20);
            this.tB324.TabIndex = 0;
            this.tB324.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB322
            // 
            this.tB322.Location = new System.Drawing.Point(81, 45);
            this.tB322.Name = "tB322";
            this.tB322.Size = new System.Drawing.Size(54, 20);
            this.tB322.TabIndex = 0;
            this.tB322.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB327
            // 
            this.tB327.Location = new System.Drawing.Point(258, 19);
            this.tB327.Name = "tB327";
            this.tB327.Size = new System.Drawing.Size(54, 20);
            this.tB327.TabIndex = 0;
            this.tB327.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB325
            // 
            this.tB325.Location = new System.Drawing.Point(201, 19);
            this.tB325.Name = "tB325";
            this.tB325.Size = new System.Drawing.Size(54, 20);
            this.tB325.TabIndex = 0;
            this.tB325.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB323
            // 
            this.tB323.Location = new System.Drawing.Point(141, 19);
            this.tB323.Name = "tB323";
            this.tB323.Size = new System.Drawing.Size(54, 20);
            this.tB323.TabIndex = 0;
            this.tB323.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB321
            // 
            this.tB321.Location = new System.Drawing.Point(81, 19);
            this.tB321.Name = "tB321";
            this.tB321.Size = new System.Drawing.Size(54, 20);
            this.tB321.TabIndex = 0;
            this.tB321.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // bSave
            // 
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(180, 144);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(111, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(297, 144);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(111, 23);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(414, 144);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // OfDialog
            // 
            this.OfDialog.Filter = "*.txt|";
            // 
            // EditOPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.ManualBox);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditOPS";
            this.Size = new System.Drawing.Size(540, 177);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FileBox.ResumeLayout(false);
            this.FileBox.PerformLayout();
            this.ManualBox.ResumeLayout(false);
            this.ManualBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBManual;
        private System.Windows.Forms.RadioButton rBAuto;
        private System.Windows.Forms.GroupBox FileBox;
        private System.Windows.Forms.GroupBox ManualBox;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lNameFile;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB332;
        private System.Windows.Forms.TextBox tB330;
        private System.Windows.Forms.TextBox tB328;
        private System.Windows.Forms.TextBox tB326;
        private System.Windows.Forms.TextBox tB324;
        private System.Windows.Forms.TextBox tB322;
        private System.Windows.Forms.TextBox tB327;
        private System.Windows.Forms.TextBox tB325;
        private System.Windows.Forms.TextBox tB323;
        private System.Windows.Forms.TextBox tB321;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog OfDialog;
    }
}
