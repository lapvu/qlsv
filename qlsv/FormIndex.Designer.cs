namespace qlsv
{
    partial class FormIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.btnAutoAdd = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataSv = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnChart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(557, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm Kiếm :";
            // 
            // boxSearch
            // 
            this.boxSearch.Location = new System.Drawing.Point(332, 56);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(151, 22);
            this.boxSearch.TabIndex = 5;
            this.boxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxSearch_KeyDown);
            // 
            // btnAutoAdd
            // 
            this.btnAutoAdd.Location = new System.Drawing.Point(12, 106);
            this.btnAutoAdd.Name = "btnAutoAdd";
            this.btnAutoAdd.Size = new System.Drawing.Size(160, 31);
            this.btnAutoAdd.TabIndex = 6;
            this.btnAutoAdd.Text = "Thêm Tự Động";
            this.btnAutoAdd.UseVisualStyleBackColor = true;
            this.btnAutoAdd.Click += new System.EventHandler(this.btnAutoAdd_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(12, 155);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(160, 28);
            this.bntAdd.TabIndex = 7;
            this.bntAdd.Text = "Thêm";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(13, 205);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 31);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataSv
            // 
            this.dataSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSv.Location = new System.Drawing.Point(195, 106);
            this.dataSv.Name = "dataSv";
            this.dataSv.RowTemplate.Height = 24;
            this.dataSv.Size = new System.Drawing.Size(884, 455);
            this.dataSv.TabIndex = 9;
            this.dataSv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSv_CellDoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(13, 263);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(159, 32);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Xuất file excel ";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(13, 323);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(159, 30);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Thống Kê";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Made by Lapvu";
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataSv);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.btnAutoAdd);
            this.Controls.Add(this.boxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIndex";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Button btnAutoAdd;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataSv;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label label3;
    }
}

