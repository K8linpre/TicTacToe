namespace TicTacToe
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.tblLylPnl1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.flwLblPnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tblLylPnl1.SuspendLayout();
            this.flwLblPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLylPnl1
            // 
            this.tblLylPnl1.ColumnCount = 1;
            this.tblLylPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLylPnl1.Controls.Add(this.btn1, 0, 2);
            this.tblLylPnl1.Controls.Add(this.lbl1, 0, 0);
            this.tblLylPnl1.Controls.Add(this.flwLblPnl1, 0, 1);
            this.tblLylPnl1.Location = new System.Drawing.Point(-1, -1);
            this.tblLylPnl1.Name = "tblLylPnl1";
            this.tblLylPnl1.RowCount = 3;
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.32759F));
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.67242F));
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLylPnl1.Size = new System.Drawing.Size(434, 315);
            this.tblLylPnl1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(142, 270);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 30);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Return to Main";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(127, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(180, 33);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "How To Play";
            // 
            // flwLblPnl1
            // 
            this.flwLblPnl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwLblPnl1.Controls.Add(this.lbl2);
            this.flwLblPnl1.Location = new System.Drawing.Point(3, 85);
            this.flwLblPnl1.Name = "flwLblPnl1";
            this.flwLblPnl1.Size = new System.Drawing.Size(428, 167);
            this.flwLblPnl1.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(3, 3);
            this.lbl2.Margin = new System.Windows.Forms.Padding(3);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(416, 143);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = resources.GetString("lbl2.Text");
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 313);
            this.Controls.Add(this.tblLylPnl1);
            this.MaximumSize = new System.Drawing.Size(450, 352);
            this.Name = "HowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How To Play";
            this.tblLylPnl1.ResumeLayout(false);
            this.tblLylPnl1.PerformLayout();
            this.flwLblPnl1.ResumeLayout(false);
            this.flwLblPnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLylPnl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.FlowLayoutPanel flwLblPnl1;
        private System.Windows.Forms.Label lbl2;
    }
}