namespace TicTacToe
{
    partial class Computer
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.tblLytPnl1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flwLytPnl4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Playermove1 = new System.Windows.Forms.Label();
            this.Computermove1 = new System.Windows.Forms.Label();
            this.flwLytPnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tblLytPnl1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flwLytPnl4.SuspendLayout();
            this.flwLytPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 1);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(453, 33);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Tic Tac Toe - Player vs Computer";
            // 
            // tblLytPnl1
            // 
            this.tblLytPnl1.ColumnCount = 3;
            this.tblLytPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tblLytPnl1.Controls.Add(this.btn10, 1, 3);
            this.tblLytPnl1.Controls.Add(this.btn1, 0, 0);
            this.tblLytPnl1.Controls.Add(this.btn3, 2, 0);
            this.tblLytPnl1.Controls.Add(this.btn2, 1, 0);
            this.tblLytPnl1.Controls.Add(this.btn5, 1, 1);
            this.tblLytPnl1.Controls.Add(this.btn9, 2, 2);
            this.tblLytPnl1.Controls.Add(this.btn8, 1, 2);
            this.tblLytPnl1.Controls.Add(this.btn4, 0, 1);
            this.tblLytPnl1.Controls.Add(this.btn7, 0, 2);
            this.tblLytPnl1.Controls.Add(this.btn6, 2, 1);
            this.tblLytPnl1.Controls.Add(this.flowLayoutPanel3, 2, 3);
            this.tblLytPnl1.Controls.Add(this.flwLytPnl1, 0, 3);
            this.tblLytPnl1.Location = new System.Drawing.Point(-1, 37);
            this.tblLytPnl1.Name = "tblLytPnl1";
            this.tblLytPnl1.RowCount = 4;
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.46236F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53764F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblLytPnl1.Size = new System.Drawing.Size(486, 324);
            this.tblLytPnl1.TabIndex = 3;
            // 
            // btn10
            // 
            this.btn10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(168, 284);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(150, 30);
            this.btn10.TabIndex = 15;
            this.btn10.Text = "Back To Game Modes";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(7, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(147, 78);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.playerClick);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(331, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(147, 78);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.playerClick);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(169, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(147, 78);
            this.btn2.TabIndex = 4;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.playerClick);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(169, 103);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(147, 78);
            this.btn5.TabIndex = 6;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.playerClick);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(331, 193);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(147, 78);
            this.btn9.TabIndex = 7;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.playerClick);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(169, 193);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(147, 78);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.playerClick);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(7, 103);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(147, 78);
            this.btn4.TabIndex = 9;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.playerClick);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(6, 193);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 78);
            this.btn7.TabIndex = 10;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.playerClick);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(331, 103);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(147, 78);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.playerClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flwLytPnl4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(327, 277);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(156, 44);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // flwLytPnl4
            // 
            this.flwLytPnl4.Controls.Add(this.label2);
            this.flwLytPnl4.Controls.Add(this.label9);
            this.flwLytPnl4.Controls.Add(this.Playermove1);
            this.flwLytPnl4.Controls.Add(this.Computermove1);
            this.flwLytPnl4.Location = new System.Drawing.Point(3, 3);
            this.flwLytPnl4.Name = "flwLytPnl4";
            this.flwLytPnl4.Size = new System.Drawing.Size(155, 44);
            this.flwLytPnl4.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "P Moves";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(25, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "C Moves";
            // 
            // Playermove1
            // 
            this.Playermove1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Playermove1.AutoSize = true;
            this.Playermove1.Location = new System.Drawing.Point(22, 19);
            this.Playermove1.Margin = new System.Windows.Forms.Padding(22, 3, 3, 0);
            this.Playermove1.Name = "Playermove1";
            this.Playermove1.Size = new System.Drawing.Size(13, 13);
            this.Playermove1.TabIndex = 4;
            this.Playermove1.Text = "0";
            // 
            // Computermove1
            // 
            this.Computermove1.AutoSize = true;
            this.Computermove1.Location = new System.Drawing.Point(108, 19);
            this.Computermove1.Margin = new System.Windows.Forms.Padding(70, 3, 3, 0);
            this.Computermove1.Name = "Computermove1";
            this.Computermove1.Size = new System.Drawing.Size(13, 13);
            this.Computermove1.TabIndex = 5;
            this.Computermove1.Text = "0";
            // 
            // flwLytPnl1
            // 
            this.flwLytPnl1.Controls.Add(this.label4);
            this.flwLytPnl1.Controls.Add(this.label5);
            this.flwLytPnl1.Controls.Add(this.label7);
            this.flwLytPnl1.Controls.Add(this.label8);
            this.flwLytPnl1.Location = new System.Drawing.Point(3, 277);
            this.flwLytPnl1.Name = "flwLytPnl1";
            this.flwLytPnl1.Size = new System.Drawing.Size(156, 44);
            this.flwLytPnl1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(36, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Computer";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(22, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(75, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "0";
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(485, 362);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tblLytPnl1);
            this.MaximumSize = new System.Drawing.Size(501, 401);
            this.Name = "Computer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player vs Computer";
            this.tblLytPnl1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flwLytPnl4.ResumeLayout(false);
            this.flwLytPnl4.PerformLayout();
            this.flwLytPnl1.ResumeLayout(false);
            this.flwLytPnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnl4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Playermove1;
        private System.Windows.Forms.Label Computermove1;
        private System.Windows.Forms.Button btn10;
    }
}