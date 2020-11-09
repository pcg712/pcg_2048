namespace pcg_2048
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.best = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.l11 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.Label();
            this.l14 = new System.Windows.Forms.Label();
            this.l21 = new System.Windows.Forms.Label();
            this.l22 = new System.Windows.Forms.Label();
            this.l23 = new System.Windows.Forms.Label();
            this.l24 = new System.Windows.Forms.Label();
            this.l31 = new System.Windows.Forms.Label();
            this.l32 = new System.Windows.Forms.Label();
            this.l33 = new System.Windows.Forms.Label();
            this.l34 = new System.Windows.Forms.Label();
            this.l41 = new System.Windows.Forms.Label();
            this.l42 = new System.Windows.Forms.Label();
            this.l43 = new System.Windows.Forms.Label();
            this.l44 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(284, 142);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(164, 42);
            this.start.TabIndex = 1;
            this.start.Text = "开始游戏";
            this.start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(288, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(407, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "best";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(288, 99);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(15, 15);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // best
            // 
            this.best.AutoSize = true;
            this.best.Location = new System.Drawing.Point(391, 99);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(15, 15);
            this.best.TabIndex = 5;
            this.best.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pcg_2048.Properties.Resources.k1_j;
            this.pictureBox1.Location = new System.Drawing.Point(99, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::pcg_2048.Properties.Resources._4;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.l11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.l13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.l14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.l21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.l22, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.l23, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.l24, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.l31, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l32, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.l33, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.l34, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.l41, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.l42, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.l43, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.l44, 3, 3);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 212);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l11.Location = new System.Drawing.Point(0, 0);
            this.l11.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(89, 89);
            this.l11.TabIndex = 0;
            this.l11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l12.Location = new System.Drawing.Point(91, 0);
            this.l12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(88, 89);
            this.l12.TabIndex = 1;
            this.l12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l13
            // 
            this.l13.AutoSize = true;
            this.l13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l13.Location = new System.Drawing.Point(181, 0);
            this.l13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(88, 89);
            this.l13.TabIndex = 2;
            this.l13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l14
            // 
            this.l14.AutoSize = true;
            this.l14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l14.Location = new System.Drawing.Point(271, 0);
            this.l14.Margin = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(89, 89);
            this.l14.TabIndex = 3;
            this.l14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l21
            // 
            this.l21.AutoSize = true;
            this.l21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l21.Location = new System.Drawing.Point(0, 91);
            this.l21.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.l21.Name = "l21";
            this.l21.Size = new System.Drawing.Size(89, 88);
            this.l21.TabIndex = 4;
            this.l21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l22
            // 
            this.l22.AutoSize = true;
            this.l22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l22.Location = new System.Drawing.Point(91, 91);
            this.l22.Margin = new System.Windows.Forms.Padding(1);
            this.l22.Name = "l22";
            this.l22.Size = new System.Drawing.Size(88, 88);
            this.l22.TabIndex = 5;
            this.l22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l23
            // 
            this.l23.AutoSize = true;
            this.l23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l23.Location = new System.Drawing.Point(181, 91);
            this.l23.Margin = new System.Windows.Forms.Padding(1);
            this.l23.Name = "l23";
            this.l23.Size = new System.Drawing.Size(88, 88);
            this.l23.TabIndex = 6;
            this.l23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l24
            // 
            this.l24.AutoSize = true;
            this.l24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l24.Location = new System.Drawing.Point(271, 91);
            this.l24.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.l24.Name = "l24";
            this.l24.Size = new System.Drawing.Size(89, 88);
            this.l24.TabIndex = 7;
            this.l24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l31
            // 
            this.l31.AutoSize = true;
            this.l31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l31.Location = new System.Drawing.Point(0, 181);
            this.l31.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.l31.Name = "l31";
            this.l31.Size = new System.Drawing.Size(89, 88);
            this.l31.TabIndex = 8;
            this.l31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l32
            // 
            this.l32.AutoSize = true;
            this.l32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l32.Location = new System.Drawing.Point(91, 181);
            this.l32.Margin = new System.Windows.Forms.Padding(1);
            this.l32.Name = "l32";
            this.l32.Size = new System.Drawing.Size(88, 88);
            this.l32.TabIndex = 9;
            this.l32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l33
            // 
            this.l33.AutoSize = true;
            this.l33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l33.Location = new System.Drawing.Point(181, 181);
            this.l33.Margin = new System.Windows.Forms.Padding(1);
            this.l33.Name = "l33";
            this.l33.Size = new System.Drawing.Size(88, 88);
            this.l33.TabIndex = 10;
            this.l33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l34
            // 
            this.l34.AutoSize = true;
            this.l34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l34.Location = new System.Drawing.Point(271, 181);
            this.l34.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.l34.Name = "l34";
            this.l34.Size = new System.Drawing.Size(89, 88);
            this.l34.TabIndex = 11;
            this.l34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l41
            // 
            this.l41.AutoSize = true;
            this.l41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l41.Location = new System.Drawing.Point(0, 271);
            this.l41.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.l41.Name = "l41";
            this.l41.Size = new System.Drawing.Size(89, 89);
            this.l41.TabIndex = 12;
            this.l41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l42
            // 
            this.l42.AutoSize = true;
            this.l42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l42.Location = new System.Drawing.Point(91, 271);
            this.l42.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.l42.Name = "l42";
            this.l42.Size = new System.Drawing.Size(88, 89);
            this.l42.TabIndex = 13;
            this.l42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l43
            // 
            this.l43.AutoSize = true;
            this.l43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l43.Location = new System.Drawing.Point(181, 271);
            this.l43.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.l43.Name = "l43";
            this.l43.Size = new System.Drawing.Size(88, 89);
            this.l43.TabIndex = 14;
            this.l43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l44
            // 
            this.l44.AutoSize = true;
            this.l44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l44.Location = new System.Drawing.Point(271, 271);
            this.l44.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.l44.Name = "l44";
            this.l44.Size = new System.Drawing.Size(89, 89);
            this.l44.TabIndex = 15;
            this.l44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(537, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.best);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "pcg_2048";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label best;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.Label l21;
        private System.Windows.Forms.Label l22;
        private System.Windows.Forms.Label l23;
        private System.Windows.Forms.Label l24;
        private System.Windows.Forms.Label l31;
        private System.Windows.Forms.Label l32;
        private System.Windows.Forms.Label l33;
        private System.Windows.Forms.Label l34;
        private System.Windows.Forms.Label l41;
        private System.Windows.Forms.Label l42;
        private System.Windows.Forms.Label l43;
        private System.Windows.Forms.Label l44;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

