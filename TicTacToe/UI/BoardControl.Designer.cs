using System;
using System.Windows.Forms;
using TicTacToe.Classes;
using TicTacToe.Classes.Interfaces;

namespace TicTacToe
{
    partial class BoardControl 
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.b5 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.b5);
            this.groupBox.Controls.Add(this.b9);
            this.groupBox.Controls.Add(this.b1);
            this.groupBox.Controls.Add(this.b8);
            this.groupBox.Controls.Add(this.b2);
            this.groupBox.Controls.Add(this.b7);
            this.groupBox.Controls.Add(this.b3);
            this.groupBox.Controls.Add(this.b6);
            this.groupBox.Controls.Add(this.b4);
            this.groupBox.Location = new System.Drawing.Point(13, 11);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(124, 128);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(44, 51);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(35, 35);
            this.b5.TabIndex = 8;
            this.b5.TabStop = false;
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.White;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(78, 85);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(35, 35);
            this.b9.TabIndex = 12;
            this.b9.TabStop = false;
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.Black;
            this.b1.Location = new System.Drawing.Point(10, 17);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(35, 35);
            this.b1.TabIndex = 0;
            this.b1.TabStop = false;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.White;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(44, 85);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(35, 35);
            this.b8.TabIndex = 11;
            this.b8.TabStop = false;
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(44, 17);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(35, 35);
            this.b2.TabIndex = 5;
            this.b2.TabStop = false;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.White;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(10, 85);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(35, 35);
            this.b7.TabIndex = 10;
            this.b7.TabStop = false;
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(78, 17);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(35, 35);
            this.b3.TabIndex = 6;
            this.b3.TabStop = false;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.White;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(78, 51);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(35, 35);
            this.b6.TabIndex = 9;
            this.b6.TabStop = false;
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(10, 51);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(35, 35);
            this.b4.TabIndex = 7;
            this.b4.TabStop = false;
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // BoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "BoardControl";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b4;

        
    }
}
