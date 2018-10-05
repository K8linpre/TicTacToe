namespace TicTacToe
{
    partial class Finish
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
            this.btn2 = new System.Windows.Forms.Button();
            this.tblLytPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytPnl1
            // 
            this.tblLytPnl1.ColumnCount = 1;
            this.tblLytPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl1.Controls.Add(this.lbl1, 0, 0);
            this.tblLytPnl1.Controls.Add(this.btn1, 0, 2);
            this.tblLytPnl1.Controls.Add(this.btn2, 0, 1);
            this.tblLytPnl1.Location = new System.Drawing.Point(-1, 0);
            this.tblLytPnl1.Name = "tblLytPnl1";
            this.tblLytPnl1.RowCount = 3;
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.79185F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.20815F));
            this.tblLytPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tblLytPnl1.Size = new System.Drawing.Size(438, 313);
            this.tblLytPnl1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(135, 7);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(167, 33);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Game Over";
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(144, 233);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 30);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Return To Main";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(119, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Replay Game";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 313);
            this.Controls.Add(this.tblLytPnl1);
            this.MaximumSize = new System.Drawing.Size(450, 352);
            this.Name = "Finish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.tblLytPnl1.ResumeLayout(false);
            this.tblLytPnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytPnl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl1;
    }
}