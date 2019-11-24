namespace direct_save
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_data = new System.Windows.Forms.Button();
            this.Average_CTR = new System.Windows.Forms.Button();
            this.Updata_data = new System.Windows.Forms.Button();
            this.Average_pageview = new System.Windows.Forms.Button();
            this.Remove_data = new System.Windows.Forms.Button();
            this.Chart_pageview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chart_CTR = new System.Windows.Forms.Button();
            this.Export_excel = new System.Windows.Forms.Button();
            this.Export_word = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_data
            // 
            this.Add_data.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Add_data.Location = new System.Drawing.Point(210, 341);
            this.Add_data.Name = "Add_data";
            this.Add_data.Size = new System.Drawing.Size(123, 45);
            this.Add_data.TabIndex = 0;
            this.Add_data.Text = "Add";
            this.Add_data.UseVisualStyleBackColor = true;
            this.Add_data.Click += new System.EventHandler(this.Add_data_Chick);
            // 
            // Average_CTR
            // 
            this.Average_CTR.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Average_CTR.Location = new System.Drawing.Point(364, 405);
            this.Average_CTR.Name = "Average_CTR";
            this.Average_CTR.Size = new System.Drawing.Size(171, 45);
            this.Average_CTR.TabIndex = 1;
            this.Average_CTR.Text = "平均點擊率";
            this.Average_CTR.UseVisualStyleBackColor = true;
            this.Average_CTR.Click += new System.EventHandler(this.Average_CTR_Click);
            // 
            // Updata_data
            // 
            this.Updata_data.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Updata_data.Location = new System.Drawing.Point(36, 405);
            this.Updata_data.Name = "Updata_data";
            this.Updata_data.Size = new System.Drawing.Size(123, 45);
            this.Updata_data.TabIndex = 2;
            this.Updata_data.Text = "Update";
            this.Updata_data.UseVisualStyleBackColor = true;
            this.Updata_data.Click += new System.EventHandler(this.Updata_data_Click);
            // 
            // Average_pageview
            // 
            this.Average_pageview.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Average_pageview.Location = new System.Drawing.Point(364, 341);
            this.Average_pageview.Name = "Average_pageview";
            this.Average_pageview.Size = new System.Drawing.Size(171, 45);
            this.Average_pageview.TabIndex = 3;
            this.Average_pageview.Text = "平均瀏覽量";
            this.Average_pageview.UseVisualStyleBackColor = true;
            this.Average_pageview.Click += new System.EventHandler(this.Average_PV_Click);
            // 
            // Remove_data
            // 
            this.Remove_data.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remove_data.Location = new System.Drawing.Point(210, 405);
            this.Remove_data.Name = "Remove_data";
            this.Remove_data.Size = new System.Drawing.Size(123, 45);
            this.Remove_data.TabIndex = 4;
            this.Remove_data.Text = "Delete";
            this.Remove_data.UseVisualStyleBackColor = true;
            this.Remove_data.Click += new System.EventHandler(this.Remove_data_Click);
            // 
            // Chart_pageview
            // 
            this.Chart_pageview.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Chart_pageview.Location = new System.Drawing.Point(541, 341);
            this.Chart_pageview.Name = "Chart_pageview";
            this.Chart_pageview.Size = new System.Drawing.Size(217, 47);
            this.Chart_pageview.TabIndex = 5;
            this.Chart_pageview.Text = "瀏覽量統計圖表";
            this.Chart_pageview.UseVisualStyleBackColor = true;
            this.Chart_pageview.Click += new System.EventHandler(this.Chart_PV_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "名稱";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "編號";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "點擊率";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "瀏覽量";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(31, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "序號";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(132, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "--";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(129, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 45);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(129, 102);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 45);
            this.textBox2.TabIndex = 13;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(129, 178);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 45);
            this.textBox3.TabIndex = 14;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(129, 250);
            this.textBox4.MaxLength = 100;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 45);
            this.textBox4.TabIndex = 15;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(364, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(703, 300);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "編號";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "網站名稱";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "網站編號";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "瀏覽量";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "點擊率";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Chart_CTR
            // 
            this.Chart_CTR.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Chart_CTR.Location = new System.Drawing.Point(541, 405);
            this.Chart_CTR.Name = "Chart_CTR";
            this.Chart_CTR.Size = new System.Drawing.Size(217, 45);
            this.Chart_CTR.TabIndex = 17;
            this.Chart_CTR.Text = "點擊率統計圖表";
            this.Chart_CTR.UseVisualStyleBackColor = true;
            this.Chart_CTR.Click += new System.EventHandler(this.Chart_CTR_Click);
            // 
            // Export_excel
            // 
            this.Export_excel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Export_excel.Location = new System.Drawing.Point(769, 318);
            this.Export_excel.Name = "Export_excel";
            this.Export_excel.Size = new System.Drawing.Size(159, 44);
            this.Export_excel.TabIndex = 18;
            this.Export_excel.Text = "export excel";
            this.Export_excel.UseVisualStyleBackColor = true;
            this.Export_excel.Click += new System.EventHandler(this.Export_excel_Click);
            // 
            // Export_word
            // 
            this.Export_word.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Export_word.Location = new System.Drawing.Point(934, 318);
            this.Export_word.Name = "Export_word";
            this.Export_word.Size = new System.Drawing.Size(159, 44);
            this.Export_word.TabIndex = 19;
            this.Export_word.Text = "export word";
            this.Export_word.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(772, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 45);
            this.label7.TabIndex = 20;
            this.label7.Text = "總瀏覽量";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(934, 405);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(183, 43);
            this.textBox5.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1131, 478);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Export_word);
            this.Controls.Add(this.Export_excel);
            this.Controls.Add(this.Chart_CTR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart_pageview);
            this.Controls.Add(this.Remove_data);
            this.Controls.Add(this.Average_pageview);
            this.Controls.Add(this.Updata_data);
            this.Controls.Add(this.Average_CTR);
            this.Controls.Add(this.Add_data);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Web_Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_data;
        private System.Windows.Forms.Button Average_CTR;
        private System.Windows.Forms.Button Updata_data;
        private System.Windows.Forms.Button Average_pageview;
        private System.Windows.Forms.Button Remove_data;
        private System.Windows.Forms.Button Chart_pageview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Chart_CTR;
        private System.Windows.Forms.Button Export_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Export_word;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
    }
}

