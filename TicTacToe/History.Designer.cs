namespace TicTacToe
{
    partial class History
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
            this.tblLytPnl1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl4 = new System.Windows.Forms.Label();
            this.flwLylPnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.TxtBx2 = new System.Windows.Forms.TextBox();
            this.tblLytPnl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flwLylPnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytPnl1
            // 
            this.tblLytPnl1.AutoSize = true;
            this.tblLytPnl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLytPnl1.ColumnCount = 1;
            this.tblLytPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl1.Controls.Add(this.lbl1, 0, 0);
            this.tblLytPnl1.Controls.Add(this.btn1, 0, 2);
            this.tblLytPnl1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tblLytPnl1.Location = new System.Drawing.Point(-3, 0);
            this.tblLytPnl1.Name = "tblLytPnl1";
            this.tblLytPnl1.RowCount = 3;
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.78022F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.21978F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblLytPnl1.Size = new System.Drawing.Size(435, 313);
            this.tblLytPnl1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(122, 10);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(191, 33);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Score History";
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(142, 277);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 30);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Return To Main";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flwLylPnl2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 212);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lbl4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(429, 36);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // lbl4
            // 
            this.lbl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(130, 3);
            this.lbl4.Margin = new System.Windows.Forms.Padding(130, 3, 3, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(174, 24);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "All Games Played";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwLylPnl2
            // 
            this.flwLylPnl2.Controls.Add(this.txtBx1);
            this.flwLylPnl2.Controls.Add(this.TxtBx2);
            this.flwLylPnl2.Location = new System.Drawing.Point(3, 39);
            this.flwLylPnl2.Name = "flwLylPnl2";
            this.flwLylPnl2.Size = new System.Drawing.Size(426, 177);
            this.flwLylPnl2.TabIndex = 1;
            // 
            // txtBx1
            // 
            this.txtBx1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtBx1.BackColor = System.Drawing.SystemColors.Control;
            this.txtBx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBx1.Location = new System.Drawing.Point(3, 3);
            this.txtBx1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtBx1.Multiline = true;
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.ReadOnly = true;
            this.txtBx1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx1.Size = new System.Drawing.Size(168, 170);
            this.txtBx1.TabIndex = 1;
            this.txtBx1.Text = "Player vs Computer";
            this.txtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBx2
            // 
            this.TxtBx2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TxtBx2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBx2.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBx2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBx2.Location = new System.Drawing.Point(254, 3);
            this.TxtBx2.Margin = new System.Windows.Forms.Padding(80, 3, 3, 10);
            this.TxtBx2.Multiline = true;
            this.TxtBx2.Name = "TxtBx2";
            this.TxtBx2.ReadOnly = true;
            this.TxtBx2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBx2.Size = new System.Drawing.Size(168, 170);
            this.TxtBx2.TabIndex = 2;
            this.TxtBx2.Text = "Player vs Player";
            this.TxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 313);
            this.Controls.Add(this.tblLytPnl1);
            this.MaximumSize = new System.Drawing.Size(450, 352);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score History";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tblLytPnl1.ResumeLayout(false);
            this.tblLytPnl1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flwLylPnl2.ResumeLayout(false);
            this.flwLylPnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytPnl1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.FlowLayoutPanel flwLylPnl2;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TextBox TxtBx2;
    }
}