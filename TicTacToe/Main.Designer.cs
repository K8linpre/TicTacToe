namespace TicTacToe
{
    partial class Main
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
            this.tblLylPnl1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.tblLylPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLylPnl1
            // 
            this.tblLylPnl1.ColumnCount = 1;
            this.tblLylPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLylPnl1.Controls.Add(this.btn3, 0, 3);
            this.tblLylPnl1.Controls.Add(this.btn2, 0, 2);
            this.tblLylPnl1.Controls.Add(this.btn1, 0, 1);
            this.tblLylPnl1.Controls.Add(this.title, 0, 0);
            this.tblLylPnl1.Location = new System.Drawing.Point(-2, 0);
            this.tblLylPnl1.Name = "tblLylPnl1";
            this.tblLylPnl1.RowCount = 4;
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblLylPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tblLylPnl1.Size = new System.Drawing.Size(434, 314);
            this.tblLylPnl1.TabIndex = 0;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(142, 266);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 30);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "How to Play";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(142, 201);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 30);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Score History";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(117, 113);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Play Game";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(129, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(175, 39);
            this.title.TabIndex = 3;
            this.title.Text = "Tic-Tac-Toe";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 313);
            this.Controls.Add(this.tblLylPnl1);
            this.MaximumSize = new System.Drawing.Size(450, 352);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.tblLylPnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLylPnl1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label title;
    }
}

