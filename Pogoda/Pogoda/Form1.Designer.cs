﻿namespace Pogoda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Temperatura = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Temperatura
            // 
            Temperatura.AutoSize = true;
            Temperatura.Location = new Point(0, 19);
            Temperatura.Name = "Temperatura";
            Temperatura.Size = new Size(76, 15);
            Temperatura.TabIndex = 0;
            Temperatura.Text = "Temperatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Wilgotność:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 96);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Opad atmosferyczne:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 136);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 3;
            label4.Text = "Ostatnia aktualizacja:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Temperatura);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(278, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 186);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Temperatura;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
    }
}
