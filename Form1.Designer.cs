﻿namespace Lab0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(142, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 59);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Form1_Load);
            // 
            // recognizeButton
            // 
            this.recognizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.recognizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recognizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recognizeButton.Location = new System.Drawing.Point(142, 252);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(103, 59);
            this.recognizeButton.TabIndex = 2;
            this.recognizeButton.Text = "Распознать";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.recognizeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(142, 174);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(103, 59);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(142, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 59);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 323);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Крестик-нолик";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
    }
}

