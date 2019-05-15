using System;

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
            this.TurnLabel = new System.Windows.Forms.TableLayoutPanel();
            this.RestartButton = new System.Windows.Forms.Button();
            this.TurnLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Name1 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.Name2 = new System.Windows.Forms.Label();
            this.TicTacToeKnappar = new System.Windows.Forms.TableLayoutPanel();
            this.SpelKnapp1 = new System.Windows.Forms.Button();
            this.SpelKnapp4 = new System.Windows.Forms.Button();
            this.SpelKnapp7 = new System.Windows.Forms.Button();
            this.SpelKnapp2 = new System.Windows.Forms.Button();
            this.SpelKnapp5 = new System.Windows.Forms.Button();
            this.SpelKnapp3 = new System.Windows.Forms.Button();
            this.SpelKnapp6 = new System.Windows.Forms.Button();
            this.SpelKnapp9 = new System.Windows.Forms.Button();
            this.SpelKnapp8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TurnLabel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TicTacToeKnappar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TurnLabel);
            this.panel1.Controls.Add(this.TicTacToeKnappar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 876);
            this.panel1.TabIndex = 0;
            // 
            // TurnLabel
            // 
            this.TurnLabel.ColumnCount = 3;
            this.TurnLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TurnLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TurnLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TurnLabel.Controls.Add(this.RestartButton, 0, 0);
            this.TurnLabel.Controls.Add(this.TurnLable, 2, 0);
            this.TurnLabel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurnLabel.Location = new System.Drawing.Point(0, 661);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.RowCount = 1;
            this.TurnLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TurnLabel.Size = new System.Drawing.Size(1172, 215);
            this.TurnLabel.TabIndex = 1;
            this.TurnLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(3, 3);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(384, 209);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            // 
            // TurnLable
            // 
            this.TurnLable.AutoSize = true;
            this.TurnLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLable.Location = new System.Drawing.Point(783, 0);
            this.TurnLable.Name = "TurnLable";
            this.TurnLable.Size = new System.Drawing.Size(121, 42);
            this.TurnLable.TabIndex = 1;
            this.TurnLable.Text = "Turn: ";
            this.TurnLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TurnLable.Click += new System.EventHandler(this.TurnLable_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Name1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPlayer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPlayer2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Name2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(393, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 209);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Name1
            // 
            this.Name1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(144, 45);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(45, 13);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "Player1;";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlayer1.Location = new System.Drawing.Point(195, 42);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(186, 20);
            this.textBoxPlayer1.TabIndex = 2;
            this.textBoxPlayer1.TextChanged += new System.EventHandler(this.textBoxPlayer1_TextChanged);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlayer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPlayer2.Location = new System.Drawing.Point(195, 146);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(186, 20);
            this.textBoxPlayer2.TabIndex = 3;
            this.textBoxPlayer2.TextChanged += new System.EventHandler(this.textBoxPlayer2_TextChanged);
            // 
            // Name2
            // 
            this.Name2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Name2.AutoSize = true;
            this.Name2.Location = new System.Drawing.Point(144, 150);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(45, 13);
            this.Name2.TabIndex = 1;
            this.Name2.Text = "Player2:";
            // 
            // TicTacToeKnappar
            // 
            this.TicTacToeKnappar.ColumnCount = 3;
            this.TicTacToeKnappar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TicTacToeKnappar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp1, 0, 0);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp4, 0, 1);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp7, 0, 2);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp2, 1, 0);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp5, 1, 1);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp8, 1, 2);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp3, 2, 0);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp6, 2, 1);
            this.TicTacToeKnappar.Controls.Add(this.SpelKnapp9, 2, 2);
            this.TicTacToeKnappar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TicTacToeKnappar.Location = new System.Drawing.Point(0, 0);
            this.TicTacToeKnappar.Name = "TicTacToeKnappar";
            this.TicTacToeKnappar.RowCount = 3;
            this.TicTacToeKnappar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeKnappar.Size = new System.Drawing.Size(1172, 661);
            this.TicTacToeKnappar.TabIndex = 0;
            // 
            // SpelKnapp1
            // 
            this.SpelKnapp1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp1.Location = new System.Drawing.Point(3, 3);
            this.SpelKnapp1.Name = "SpelKnapp1";
            this.SpelKnapp1.Size = new System.Drawing.Size(384, 214);
            this.SpelKnapp1.TabIndex = 0;
            this.SpelKnapp1.Tag = "0";
            this.SpelKnapp1.UseVisualStyleBackColor = false;
            this.SpelKnapp1.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp4
            // 
            this.SpelKnapp4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp4.Location = new System.Drawing.Point(3, 223);
            this.SpelKnapp4.Name = "SpelKnapp4";
            this.SpelKnapp4.Size = new System.Drawing.Size(384, 214);
            this.SpelKnapp4.TabIndex = 1;
            this.SpelKnapp4.Tag = "3";
            this.SpelKnapp4.UseVisualStyleBackColor = false;
            this.SpelKnapp4.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp7
            // 
            this.SpelKnapp7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp7.Location = new System.Drawing.Point(3, 443);
            this.SpelKnapp7.Name = "SpelKnapp7";
            this.SpelKnapp7.Size = new System.Drawing.Size(384, 215);
            this.SpelKnapp7.TabIndex = 2;
            this.SpelKnapp7.Tag = "6";
            this.SpelKnapp7.UseVisualStyleBackColor = false;
            this.SpelKnapp7.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp2
            // 
            this.SpelKnapp2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp2.Location = new System.Drawing.Point(393, 3);
            this.SpelKnapp2.Name = "SpelKnapp2";
            this.SpelKnapp2.Size = new System.Drawing.Size(384, 214);
            this.SpelKnapp2.TabIndex = 3;
            this.SpelKnapp2.Tag = "1";
            this.SpelKnapp2.UseVisualStyleBackColor = false;
            this.SpelKnapp2.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp5
            // 
            this.SpelKnapp5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp5.Location = new System.Drawing.Point(393, 223);
            this.SpelKnapp5.Name = "SpelKnapp5";
            this.SpelKnapp5.Size = new System.Drawing.Size(384, 214);
            this.SpelKnapp5.TabIndex = 4;
            this.SpelKnapp5.Tag = "4";
            this.SpelKnapp5.UseVisualStyleBackColor = false;
            this.SpelKnapp5.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp3
            // 
            this.SpelKnapp3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp3.Location = new System.Drawing.Point(783, 3);
            this.SpelKnapp3.Name = "SpelKnapp3";
            this.SpelKnapp3.Size = new System.Drawing.Size(386, 214);
            this.SpelKnapp3.TabIndex = 6;
            this.SpelKnapp3.Tag = "2";
            this.SpelKnapp3.UseVisualStyleBackColor = false;
            this.SpelKnapp3.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp6
            // 
            this.SpelKnapp6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp6.Location = new System.Drawing.Point(783, 223);
            this.SpelKnapp6.Name = "SpelKnapp6";
            this.SpelKnapp6.Size = new System.Drawing.Size(386, 214);
            this.SpelKnapp6.TabIndex = 7;
            this.SpelKnapp6.Tag = "5";
            this.SpelKnapp6.UseVisualStyleBackColor = false;
            this.SpelKnapp6.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp9
            // 
            this.SpelKnapp9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp9.Location = new System.Drawing.Point(783, 443);
            this.SpelKnapp9.Name = "SpelKnapp9";
            this.SpelKnapp9.Size = new System.Drawing.Size(386, 215);
            this.SpelKnapp9.TabIndex = 8;
            this.SpelKnapp9.Tag = "8";
            this.SpelKnapp9.UseVisualStyleBackColor = false;
            this.SpelKnapp9.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // SpelKnapp8
            // 
            this.SpelKnapp8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpelKnapp8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpelKnapp8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelKnapp8.Location = new System.Drawing.Point(393, 443);
            this.SpelKnapp8.Name = "SpelKnapp8";
            this.SpelKnapp8.Size = new System.Drawing.Size(384, 215);
            this.SpelKnapp8.TabIndex = 5;
            this.SpelKnapp8.Tag = "7";
            this.SpelKnapp8.UseVisualStyleBackColor = false;
            this.SpelKnapp8.Click += new System.EventHandler(this.spelknapp_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 876);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.Text = "TicTacToe";
            this.panel1.ResumeLayout(false);
            this.TurnLabel.ResumeLayout(false);
            this.TurnLabel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TicTacToeKnappar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TicTacToeKnappar;
        private System.Windows.Forms.Button SpelKnapp1;
        private System.Windows.Forms.Button SpelKnapp4;
        private System.Windows.Forms.Button SpelKnapp7;
        private System.Windows.Forms.Button SpelKnapp2;
        private System.Windows.Forms.Button SpelKnapp5;
        private System.Windows.Forms.Button SpelKnapp3;
        private System.Windows.Forms.Button SpelKnapp6;
        private System.Windows.Forms.Button SpelKnapp9;
        private System.Windows.Forms.TableLayoutPanel TurnLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label TurnLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Button SpelKnapp8;
    }
}

