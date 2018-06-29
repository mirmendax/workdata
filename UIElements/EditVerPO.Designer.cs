namespace UIElements
{
    partial class EditVerPO
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
            this.tbARV = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogView = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tbBMTZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARV:";
            // 
            // tbARV
            // 
            this.tbARV.BackColor = System.Drawing.SystemColors.Window;
            this.tbARV.Location = new System.Drawing.Point(46, 12);
            this.tbARV.Name = "tbARV";
            this.tbARV.Size = new System.Drawing.Size(81, 20);
            this.tbARV.TabIndex = 1;
            this.tbARV.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(197, 12);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(81, 20);
            this.tbLink.TabIndex = 3;
            this.tbLink.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(156, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link:";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(350, 12);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(81, 20);
            this.tbDisplay.TabIndex = 5;
            this.tbDisplay.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(300, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display:";
            // 
            // tbLogView
            // 
            this.tbLogView.Location = new System.Drawing.Point(506, 12);
            this.tbLogView.Name = "tbLogView";
            this.tbLogView.Size = new System.Drawing.Size(81, 20);
            this.tbLogView.TabIndex = 7;
            this.tbLogView.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(449, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "LogView:";
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(614, 49);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bClear
            // 
            this.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(497, 49);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(111, 23);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(380, 49);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(111, 23);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbBMTZ
            // 
            this.tbBMTZ.Location = new System.Drawing.Point(657, 12);
            this.tbBMTZ.Name = "tbBMTZ";
            this.tbBMTZ.Size = new System.Drawing.Size(81, 20);
            this.tbBMTZ.TabIndex = 12;
            this.tbBMTZ.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(611, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "БМТЗ:";
            // 
            // EditVerPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.tbBMTZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbLogView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbARV);
            this.Controls.Add(this.label1);
            this.Name = "EditVerPO";
            this.Size = new System.Drawing.Size(759, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbARV;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbBMTZ;
        private System.Windows.Forms.Label label5;
    }
}
