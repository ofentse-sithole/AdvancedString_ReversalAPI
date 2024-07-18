﻿namespace AdvancedString_ReversalAPI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_enter_word = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_palindrome = new System.Windows.Forms.Label();
            this.label_reversed_answer = new System.Windows.Forms.Label();
            this.api_submit_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(46, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 336);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.api_submit_btn);
            this.panel2.Controls.Add(this.label_palindrome);
            this.panel2.Controls.Add(this.label_reversed_answer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_enter_word);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(317, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 336);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Advanced String Reversal API";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdvancedString_ReversalAPI.Properties.Resources.download_icon_api_1330174955558535016_48;
            this.pictureBox1.Location = new System.Drawing.Point(66, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter word: ";
            // 
            // txt_enter_word
            // 
            this.txt_enter_word.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enter_word.Location = new System.Drawing.Point(207, 34);
            this.txt_enter_word.Name = "txt_enter_word";
            this.txt_enter_word.Size = new System.Drawing.Size(187, 25);
            this.txt_enter_word.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Reversed Word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "IsPalindrome:";
            // 
            // label_palindrome
            // 
            this.label_palindrome.AutoSize = true;
            this.label_palindrome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_palindrome.Location = new System.Drawing.Point(204, 173);
            this.label_palindrome.Name = "label_palindrome";
            this.label_palindrome.Size = new System.Drawing.Size(105, 17);
            this.label_palindrome.TabIndex = 6;
            this.label_palindrome.Text = "True or False";
            // 
            // label_reversed_answer
            // 
            this.label_reversed_answer.AutoSize = true;
            this.label_reversed_answer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reversed_answer.Location = new System.Drawing.Point(204, 106);
            this.label_reversed_answer.Name = "label_reversed_answer";
            this.label_reversed_answer.Size = new System.Drawing.Size(64, 17);
            this.label_reversed_answer.TabIndex = 5;
            this.label_reversed_answer.Text = "Answer";
            // 
            // api_submit_btn
            // 
            this.api_submit_btn.BackColor = System.Drawing.Color.MistyRose;
            this.api_submit_btn.Location = new System.Drawing.Point(97, 275);
            this.api_submit_btn.Name = "api_submit_btn";
            this.api_submit_btn.Size = new System.Drawing.Size(102, 31);
            this.api_submit_btn.TabIndex = 7;
            this.api_submit_btn.Text = "Submit";
            this.api_submit_btn.UseVisualStyleBackColor = false;
            this.api_submit_btn.Click += new System.EventHandler(this.api_submit_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.api_exit_button);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.MistyRose;
            this.btn_clear.Location = new System.Drawing.Point(255, 275);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 31);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "API";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_palindrome;
        private System.Windows.Forms.Label label_reversed_answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_enter_word;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button api_submit_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clear;
    }
}

