﻿using System;

namespace View
{
    partial class View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RestartButton = new System.Windows.Forms.Button();
            this.TurnLable = new System.Windows.Forms.Label();
            this.TicTacToeKnappar = new System.Windows.Forms.TableLayoutPanel();
            this.SpelKnapp1 = new System.Windows.Forms.Button();
            this.SpelKnapp2 = new System.Windows.Forms.Button();
            this.SpelKnapp3 = new System.Windows.Forms.Button();
            this.SpelKnapp4 = new System.Windows.Forms.Button();
            this.SpelKnapp5 = new System.Windows.Forms.Button();
            this.SpelKnapp6 = new System.Windows.Forms.Button();
            this.SpelKnapp7 = new System.Windows.Forms.Button();
            this.SpelKnapp8 = new System.Windows.Forms.Button();
            this.SpelKnapp9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TicTacToeKnappar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.TicTacToeKnappar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 876);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RestartButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TurnLable, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 656);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 220);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // RestartButton
            // 
            this.RestartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(3, 3);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(580, 214);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            // 
            // TurnLable
            // 
            this.TurnLable.AutoSize = true;
            this.TurnLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLable.Location = new System.Drawing.Point(589, 0);
            this.TurnLable.Name = "TurnLable";
            this.TurnLable.Size = new System.Drawing.Size(121, 42);
            this.TurnLable.TabIndex = 1;
            this.TurnLable.Text = "Turn: ";
            this.TurnLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToeKnappar
            // 
            this.TicTacToeKnappar.ColumnCount = 3;
            this.TicTacToeKnappar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TicTacToeKnappar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp1, 0, 0);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp2, 0, 1);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp3, 0, 2);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp4, 1, 0);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp5, 1, 1);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp6, 1, 2);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp7, 2, 0);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp8, 2, 1);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp9, 2, 2);
            this.TicTacToeKnappar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TicTacToeKnappar.Location = new System.Drawing.Point(0, 0);
            this.TicTacToeKnappar.Name = "TicTacToeKnappar";
            this.TicTacToeKnappar.RowCount = 3;
            this.TicTacToeKnappar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.Size = new System.Drawing.Size(1172, 656);
            this.TicTacToeKnappar.TabIndex = 0;
            //this.TicTacToeKnappar.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp1
            // 
            this.SpelKnapp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SpelKnapp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp1.Location = new System.Drawing.Point(3, 3);
            this.SpelKnapp1.Name = "SpelKnapp1";
            this.SpelKnapp1.Size = new System.Drawing.Size(384, 212);
            this.SpelKnapp1.TabIndex = 0;
            this.SpelKnapp1.Tag = "0";
            this.SpelKnapp1.UseVisualStyleBackColor = true;
            this.SpelKnapp1.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp2
            // 
            this.SpelKnapp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp2.Location = new System.Drawing.Point(3, 221);
            this.SpelKnapp2.Name = "SpelKnapp2";
            this.SpelKnapp2.Size = new System.Drawing.Size(384, 212);
            this.SpelKnapp2.TabIndex = 1;
            this.SpelKnapp2.Tag = "3";
            this.SpelKnapp2.UseVisualStyleBackColor = true;
            this.SpelKnapp2.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp3
            // 
            this.SpelKnapp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp3.Location = new System.Drawing.Point(3, 439);
            this.SpelKnapp3.Name = "SpelKnapp3";
            this.SpelKnapp3.Size = new System.Drawing.Size(384, 214);
            this.SpelKnapp3.TabIndex = 2;
            this.SpelKnapp3.Tag = "6";
            this.SpelKnapp3.UseVisualStyleBackColor = true;
            this.SpelKnapp3.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp4
            // 
            this.SpelKnapp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp4.Location = new System.Drawing.Point(393, 3);
            this.SpelKnapp4.Name = "SpelKnapp4";
            this.SpelKnapp4.Size = new System.Drawing.Size(384, 212);
            this.SpelKnapp4.TabIndex = 3;
            this.SpelKnapp4.Tag = "1";
            this.SpelKnapp4.UseVisualStyleBackColor = true;
            this.SpelKnapp4.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp5
            // 
            this.SpelKnapp5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp5.Location = new System.Drawing.Point(393, 221);
            this.SpelKnapp5.Name = "SpelKnapp5";
            this.SpelKnapp5.Size = new System.Drawing.Size(384, 212);
            this.SpelKnapp5.TabIndex = 4;
            this.SpelKnapp5.Tag = "4";
            this.SpelKnapp5.UseVisualStyleBackColor = true;
            this.SpelKnapp5.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp6
            // 
            this.SpelKnapp6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp6.Location = new System.Drawing.Point(393, 439);
            this.SpelKnapp6.Name = "SpelKnapp6";
            this.SpelKnapp6.Size = new System.Drawing.Size(384, 214);
            this.SpelKnapp6.TabIndex = 5;
            this.SpelKnapp6.Tag = "7";
            this.SpelKnapp6.UseVisualStyleBackColor = true;
            this.SpelKnapp6.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp7
            // 
            this.SpelKnapp7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp7.Location = new System.Drawing.Point(783, 3);
            this.SpelKnapp7.Name = "SpelKnapp7";
            this.SpelKnapp7.Size = new System.Drawing.Size(386, 212);
            this.SpelKnapp7.TabIndex = 6;
            this.SpelKnapp7.Tag = "2";
            this.SpelKnapp7.UseVisualStyleBackColor = true;
            this.SpelKnapp7.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp8
            // 
            this.SpelKnapp8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp8.Location = new System.Drawing.Point(783, 221);
            this.SpelKnapp8.Name = "SpelKnapp8";
            this.SpelKnapp8.Size = new System.Drawing.Size(386, 212);
            this.SpelKnapp8.TabIndex = 7;
            this.SpelKnapp8.Tag = "5";
            this.SpelKnapp8.UseVisualStyleBackColor = true;
            this.SpelKnapp8.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp9
            // 
            this.SpelKnapp9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpelKnapp9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp9.Location = new System.Drawing.Point(783, 439);
            this.SpelKnapp9.Name = "SpelKnapp9";
            this.SpelKnapp9.Size = new System.Drawing.Size(386, 214);
            this.SpelKnapp9.TabIndex = 8;
            this.SpelKnapp9.Tag = "8";
            this.SpelKnapp9.UseVisualStyleBackColor = true;
            this.SpelKnapp9.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 876);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.Text = "ghjghjgh";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TicTacToeKnappar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TicTacToeKnappar;
        private System.Windows.Forms.Button SpelKnapp1;
        private System.Windows.Forms.Button SpelKnapp2;
        private System.Windows.Forms.Button SpelKnapp3;
        private System.Windows.Forms.Button SpelKnapp4;
        private System.Windows.Forms.Button SpelKnapp5;
        private System.Windows.Forms.Button SpelKnapp6;
        private System.Windows.Forms.Button SpelKnapp7;
        private System.Windows.Forms.Button SpelKnapp8;
        private System.Windows.Forms.Button SpelKnapp9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label TurnLable;
    }
}
