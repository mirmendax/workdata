namespace UIElements
{
    partial class EditOMV
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
            this.FileBox = new System.Windows.Forms.GroupBox();
            this.lNameFile = new System.Windows.Forms.Label();
            this.bOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBManual = new System.Windows.Forms.RadioButton();
            this.rBAuto = new System.Windows.Forms.RadioButton();
            this.ManualBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB344 = new System.Windows.Forms.TextBox();
            this.tB359 = new System.Windows.Forms.TextBox();
            this.tB354 = new System.Windows.Forms.TextBox();
            this.tB349 = new System.Windows.Forms.TextBox();
            this.tB358 = new System.Windows.Forms.TextBox();
            this.tB353 = new System.Windows.Forms.TextBox();
            this.tB348 = new System.Windows.Forms.TextBox();
            this.tB357 = new System.Windows.Forms.TextBox();
            this.tB352 = new System.Windows.Forms.TextBox();
            this.tB347 = new System.Windows.Forms.TextBox();
            this.tB356 = new System.Windows.Forms.TextBox();
            this.tB351 = new System.Windows.Forms.TextBox();
            this.tB346 = new System.Windows.Forms.TextBox();
            this.tB355 = new System.Windows.Forms.TextBox();
            this.tB350 = new System.Windows.Forms.TextBox();
            this.tB345 = new System.Windows.Forms.TextBox();
            this.tB343 = new System.Windows.Forms.TextBox();
            this.tB342 = new System.Windows.Forms.TextBox();
            this.tB341 = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.OfDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ManualBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileBox
            // 
            this.FileBox.Controls.Add(this.lNameFile);
            this.FileBox.Controls.Add(this.bOpen);
            this.FileBox.Enabled = false;
            this.FileBox.Location = new System.Drawing.Point(194, 3);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(257, 50);
            this.FileBox.TabIndex = 3;
            this.FileBox.TabStop = false;
            this.FileBox.Text = "Файл";
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
            // bOpen
            // 
            this.bOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOpen.Location = new System.Drawing.Point(158, 16);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(93, 23);
            this.bOpen.TabIndex = 3;
            this.bOpen.Text = "Открыть";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBManual);
            this.groupBox1.Controls.Add(this.rBAuto);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 50);
            this.groupBox1.TabIndex = 2;
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
            // ManualBox
            // 
            this.ManualBox.Controls.Add(this.label2);
            this.ManualBox.Controls.Add(this.label1);
            this.ManualBox.Controls.Add(this.label4);
            this.ManualBox.Controls.Add(this.label5);
            this.ManualBox.Controls.Add(this.label3);
            this.ManualBox.Controls.Add(this.tB344);
            this.ManualBox.Controls.Add(this.tB359);
            this.ManualBox.Controls.Add(this.tB354);
            this.ManualBox.Controls.Add(this.tB349);
            this.ManualBox.Controls.Add(this.tB358);
            this.ManualBox.Controls.Add(this.tB353);
            this.ManualBox.Controls.Add(this.tB348);
            this.ManualBox.Controls.Add(this.tB357);
            this.ManualBox.Controls.Add(this.tB352);
            this.ManualBox.Controls.Add(this.tB347);
            this.ManualBox.Controls.Add(this.tB356);
            this.ManualBox.Controls.Add(this.tB351);
            this.ManualBox.Controls.Add(this.tB346);
            this.ManualBox.Controls.Add(this.tB355);
            this.ManualBox.Controls.Add(this.tB350);
            this.ManualBox.Controls.Add(this.tB345);
            this.ManualBox.Controls.Add(this.tB343);
            this.ManualBox.Controls.Add(this.tB342);
            this.ManualBox.Controls.Add(this.tB341);
            this.ManualBox.Enabled = false;
            this.ManualBox.Location = new System.Drawing.Point(3, 59);
            this.ManualBox.Name = "ManualBox";
            this.ManualBox.Size = new System.Drawing.Size(448, 136);
            this.ManualBox.TabIndex = 4;
            this.ManualBox.TabStop = false;
            this.ManualBox.Text = "В ручную";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ug=1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ug=1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ug=0.8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мощность";
            // 
            // tB344
            // 
            this.tB344.Location = new System.Drawing.Point(329, 24);
            this.tB344.Name = "tB344";
            this.tB344.Size = new System.Drawing.Size(54, 20);
            this.tB344.TabIndex = 0;
            this.tB344.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB359
            // 
            this.tB359.Location = new System.Drawing.Point(329, 102);
            this.tB359.Name = "tB359";
            this.tB359.Size = new System.Drawing.Size(54, 20);
            this.tB359.TabIndex = 0;
            this.tB359.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB354
            // 
            this.tB354.Location = new System.Drawing.Point(329, 76);
            this.tB354.Name = "tB354";
            this.tB354.Size = new System.Drawing.Size(54, 20);
            this.tB354.TabIndex = 0;
            this.tB354.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB349
            // 
            this.tB349.Location = new System.Drawing.Point(329, 50);
            this.tB349.Name = "tB349";
            this.tB349.Size = new System.Drawing.Size(54, 20);
            this.tB349.TabIndex = 0;
            this.tB349.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB358
            // 
            this.tB358.Location = new System.Drawing.Point(269, 102);
            this.tB358.Name = "tB358";
            this.tB358.Size = new System.Drawing.Size(54, 20);
            this.tB358.TabIndex = 0;
            this.tB358.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB353
            // 
            this.tB353.Location = new System.Drawing.Point(269, 76);
            this.tB353.Name = "tB353";
            this.tB353.Size = new System.Drawing.Size(54, 20);
            this.tB353.TabIndex = 0;
            this.tB353.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB348
            // 
            this.tB348.Location = new System.Drawing.Point(269, 50);
            this.tB348.Name = "tB348";
            this.tB348.Size = new System.Drawing.Size(54, 20);
            this.tB348.TabIndex = 0;
            this.tB348.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB357
            // 
            this.tB357.Location = new System.Drawing.Point(209, 102);
            this.tB357.Name = "tB357";
            this.tB357.Size = new System.Drawing.Size(54, 20);
            this.tB357.TabIndex = 0;
            this.tB357.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB352
            // 
            this.tB352.Location = new System.Drawing.Point(209, 76);
            this.tB352.Name = "tB352";
            this.tB352.Size = new System.Drawing.Size(54, 20);
            this.tB352.TabIndex = 0;
            this.tB352.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB347
            // 
            this.tB347.Location = new System.Drawing.Point(209, 50);
            this.tB347.Name = "tB347";
            this.tB347.Size = new System.Drawing.Size(54, 20);
            this.tB347.TabIndex = 0;
            this.tB347.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB356
            // 
            this.tB356.Location = new System.Drawing.Point(149, 102);
            this.tB356.Name = "tB356";
            this.tB356.Size = new System.Drawing.Size(54, 20);
            this.tB356.TabIndex = 0;
            this.tB356.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB351
            // 
            this.tB351.Location = new System.Drawing.Point(149, 76);
            this.tB351.Name = "tB351";
            this.tB351.Size = new System.Drawing.Size(54, 20);
            this.tB351.TabIndex = 0;
            this.tB351.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB346
            // 
            this.tB346.Location = new System.Drawing.Point(149, 50);
            this.tB346.Name = "tB346";
            this.tB346.Size = new System.Drawing.Size(54, 20);
            this.tB346.TabIndex = 0;
            this.tB346.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB355
            // 
            this.tB355.Location = new System.Drawing.Point(89, 102);
            this.tB355.Name = "tB355";
            this.tB355.Size = new System.Drawing.Size(54, 20);
            this.tB355.TabIndex = 0;
            this.tB355.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB350
            // 
            this.tB350.Location = new System.Drawing.Point(89, 76);
            this.tB350.Name = "tB350";
            this.tB350.Size = new System.Drawing.Size(54, 20);
            this.tB350.TabIndex = 0;
            this.tB350.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB345
            // 
            this.tB345.Location = new System.Drawing.Point(89, 50);
            this.tB345.Name = "tB345";
            this.tB345.Size = new System.Drawing.Size(54, 20);
            this.tB345.TabIndex = 0;
            this.tB345.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB343
            // 
            this.tB343.Location = new System.Drawing.Point(269, 24);
            this.tB343.Name = "tB343";
            this.tB343.Size = new System.Drawing.Size(54, 20);
            this.tB343.TabIndex = 0;
            this.tB343.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB342
            // 
            this.tB342.Location = new System.Drawing.Point(209, 24);
            this.tB342.Name = "tB342";
            this.tB342.Size = new System.Drawing.Size(54, 20);
            this.tB342.TabIndex = 0;
            this.tB342.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // tB341
            // 
            this.tB341.Location = new System.Drawing.Point(149, 24);
            this.tB341.Name = "tB341";
            this.tB341.Size = new System.Drawing.Size(54, 20);
            this.tB341.TabIndex = 0;
            this.tB341.TextChanged += new System.EventHandler(this.tB_TextChanged);
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(329, 212);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bClear
            // 
            this.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(212, 212);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(111, 23);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(95, 212);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(111, 23);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // OfDialog
            // 
            this.OfDialog.FileName = "openFileDialog1";
            // 
            // EditOMV
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
            this.Name = "EditOMV";
            this.Size = new System.Drawing.Size(455, 251);
            this.FileBox.ResumeLayout(false);
            this.FileBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManualBox.ResumeLayout(false);
            this.ManualBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FileBox;
        private System.Windows.Forms.Label lNameFile;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBManual;
        private System.Windows.Forms.RadioButton rBAuto;
        private System.Windows.Forms.GroupBox ManualBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB344;
        private System.Windows.Forms.TextBox tB359;
        private System.Windows.Forms.TextBox tB354;
        private System.Windows.Forms.TextBox tB349;
        private System.Windows.Forms.TextBox tB358;
        private System.Windows.Forms.TextBox tB353;
        private System.Windows.Forms.TextBox tB348;
        private System.Windows.Forms.TextBox tB357;
        private System.Windows.Forms.TextBox tB352;
        private System.Windows.Forms.TextBox tB347;
        private System.Windows.Forms.TextBox tB356;
        private System.Windows.Forms.TextBox tB351;
        private System.Windows.Forms.TextBox tB346;
        private System.Windows.Forms.TextBox tB355;
        private System.Windows.Forms.TextBox tB350;
        private System.Windows.Forms.TextBox tB345;
        private System.Windows.Forms.TextBox tB343;
        private System.Windows.Forms.TextBox tB342;
        private System.Windows.Forms.TextBox tB341;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.OpenFileDialog OfDialog;
    }
}
