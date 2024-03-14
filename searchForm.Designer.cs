namespace SwiftInsightsV2
{
    partial class searchForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tb_Search = new TextBox();
            panel1 = new Panel();
            resultNumber_PerPage = new NumericUpDown();
            label1 = new Label();
            tb_PageNumber = new TextBox();
            pb_PreviousPage = new PictureBox();
            pb_NextPage = new PictureBox();
            panel2 = new Panel();
            pb_Search = new PictureBox();
            advDGV_Search = new DataGridView();
            label2 = new Label();
            tb_Max = new TextBox();
            lbl_NumerResult = new Label();
            tb_NumberOfResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)resultNumber_PerPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_PreviousPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_NextPage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)advDGV_Search).BeginInit();
            SuspendLayout();
            // 
            // tb_Search
            // 
            tb_Search.BackColor = Color.White;
            tb_Search.BorderStyle = BorderStyle.None;
            tb_Search.Font = new Font("TT Chocolates Trl DemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Search.ForeColor = Color.FromArgb(0, 31, 62);
            tb_Search.Location = new Point(216, 47);
            tb_Search.Name = "tb_Search";
            tb_Search.PlaceholderText = "Entrer une information...";
            tb_Search.Size = new Size(476, 32);
            tb_Search.TabIndex = 1;
            tb_Search.KeyPress += tb_Search_KeyPress_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 31, 62);
            panel1.Location = new Point(216, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 10);
            panel1.TabIndex = 2;
            // 
            // resultNumber_PerPage
            // 
            resultNumber_PerPage.BackColor = Color.White;
            resultNumber_PerPage.Font = new Font("TT Chocolates Trl DemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultNumber_PerPage.ForeColor = Color.FromArgb(0, 31, 62);
            resultNumber_PerPage.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            resultNumber_PerPage.Location = new Point(398, 129);
            resultNumber_PerPage.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            resultNumber_PerPage.Name = "resultNumber_PerPage";
            resultNumber_PerPage.Size = new Size(150, 31);
            resultNumber_PerPage.TabIndex = 3;
            resultNumber_PerPage.Value = new decimal(new int[] { 20, 0, 0, 0 });
            resultNumber_PerPage.ValueChanged += resultNumber_PerPage_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TT Chocolates Trl DemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 31, 62);
            label1.Location = new Point(66, 129);
            label1.Name = "label1";
            label1.Size = new Size(326, 28);
            label1.TabIndex = 4;
            label1.Text = "Nombre de résultats par page :";
            // 
            // tb_PageNumber
            // 
            tb_PageNumber.Font = new Font("TT Chocolates Trl", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tb_PageNumber.ForeColor = Color.FromArgb(0, 31, 62);
            tb_PageNumber.Location = new Point(1380, 110);
            tb_PageNumber.Name = "tb_PageNumber";
            tb_PageNumber.Size = new Size(57, 47);
            tb_PageNumber.TabIndex = 5;
            tb_PageNumber.Text = "1";
            tb_PageNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // pb_PreviousPage
            // 
            pb_PreviousPage.Cursor = Cursors.Hand;
            pb_PreviousPage.Image = Properties.Resources.fleche_droite_2_;
            pb_PreviousPage.Location = new Point(1324, 110);
            pb_PreviousPage.Name = "pb_PreviousPage";
            pb_PreviousPage.Size = new Size(50, 47);
            pb_PreviousPage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_PreviousPage.TabIndex = 6;
            pb_PreviousPage.TabStop = false;
            pb_PreviousPage.Click += pb_PreviousPage_Click;
            // 
            // pb_NextPage
            // 
            pb_NextPage.Cursor = Cursors.Hand;
            pb_NextPage.Image = Properties.Resources.fleche_droite_1_;
            pb_NextPage.Location = new Point(1540, 110);
            pb_NextPage.Name = "pb_NextPage";
            pb_NextPage.Size = new Size(50, 47);
            pb_NextPage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_NextPage.TabIndex = 7;
            pb_NextPage.TabStop = false;
            pb_NextPage.Click += pb_NextPage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 31, 62);
            panel2.Controls.Add(pb_Search);
            panel2.Location = new Point(689, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 56);
            panel2.TabIndex = 8;
            // 
            // pb_Search
            // 
            pb_Search.Image = Properties.Resources.chercher_1_;
            pb_Search.Location = new Point(4, 4);
            pb_Search.Name = "pb_Search";
            pb_Search.Size = new Size(48, 49);
            pb_Search.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Search.TabIndex = 0;
            pb_Search.TabStop = false;
            pb_Search.Click += pb_Search_Click;
            // 
            // advDGV_Search
            // 
            advDGV_Search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            advDGV_Search.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            advDGV_Search.BackgroundColor = Color.White;
            advDGV_Search.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle1.Font = new Font("TT Chocolates Trl", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            advDGV_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            advDGV_Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle2.Font = new Font("TT Chocolates Trl", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            advDGV_Search.DefaultCellStyle = dataGridViewCellStyle2;
            advDGV_Search.GridColor = Color.FromArgb(0, 31, 62);
            advDGV_Search.Location = new Point(66, 160);
            advDGV_Search.Name = "advDGV_Search";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle3.Font = new Font("TT Chocolates Trl", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            advDGV_Search.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            advDGV_Search.RowHeadersVisible = false;
            advDGV_Search.RowHeadersWidth = 51;
            advDGV_Search.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("TT Chocolates Trl DemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            advDGV_Search.RowsDefaultCellStyle = dataGridViewCellStyle4;
            advDGV_Search.RowTemplate.Height = 35;
            advDGV_Search.RowTemplate.ReadOnly = true;
            advDGV_Search.RowTemplate.Resizable = DataGridViewTriState.False;
            advDGV_Search.Size = new Size(1556, 812);
            advDGV_Search.TabIndex = 9;
            advDGV_Search.CellDoubleClick += advDGV_Search_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TT Chocolates Trl", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 31, 62);
            label2.Location = new Point(1443, 113);
            label2.Name = "label2";
            label2.Size = new Size(29, 41);
            label2.TabIndex = 10;
            label2.Text = "-";
            // 
            // tb_Max
            // 
            tb_Max.Font = new Font("TT Chocolates Trl", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Max.ForeColor = Color.FromArgb(0, 31, 62);
            tb_Max.Location = new Point(1478, 110);
            tb_Max.Name = "tb_Max";
            tb_Max.Size = new Size(57, 47);
            tb_Max.TabIndex = 11;
            tb_Max.Text = "1";
            tb_Max.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_NumerResult
            // 
            lbl_NumerResult.AutoSize = true;
            lbl_NumerResult.Font = new Font("TT Chocolates Trl", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NumerResult.ForeColor = Color.FromArgb(0, 31, 62);
            lbl_NumerResult.Location = new Point(833, 51);
            lbl_NumerResult.Name = "lbl_NumerResult";
            lbl_NumerResult.Size = new Size(230, 28);
            lbl_NumerResult.TabIndex = 12;
            lbl_NumerResult.Text = "Nombre de résultats :";
            // 
            // tb_NumberOfResult
            // 
            tb_NumberOfResult.Font = new Font("TT Chocolates Trl", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tb_NumberOfResult.ForeColor = Color.FromArgb(0, 31, 62);
            tb_NumberOfResult.Location = new Point(1069, 43);
            tb_NumberOfResult.Name = "tb_NumberOfResult";
            tb_NumberOfResult.Size = new Size(118, 47);
            tb_NumberOfResult.TabIndex = 13;
            tb_NumberOfResult.Text = "1";
            tb_NumberOfResult.TextAlign = HorizontalAlignment.Center;
            // 
            // searchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1661, 1016);
            Controls.Add(tb_NumberOfResult);
            Controls.Add(lbl_NumerResult);
            Controls.Add(tb_Max);
            Controls.Add(label2);
            Controls.Add(advDGV_Search);
            Controls.Add(panel2);
            Controls.Add(pb_NextPage);
            Controls.Add(pb_PreviousPage);
            Controls.Add(tb_PageNumber);
            Controls.Add(label1);
            Controls.Add(resultNumber_PerPage);
            Controls.Add(panel1);
            Controls.Add(tb_Search);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "searchForm";
            Text = "searchForm";
            ((System.ComponentModel.ISupportInitialize)resultNumber_PerPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_PreviousPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_NextPage).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)advDGV_Search).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_Search;
        private Panel panel1;
        private NumericUpDown resultNumber_PerPage;
        private Label label1;
        private TextBox tb_PageNumber;
        private PictureBox pb_PreviousPage;
        private PictureBox pb_NextPage;
        private Panel panel2;
        private PictureBox pb_Search;
        private DataGridView advDGV_Search;
        private Label label2;
        private TextBox tb_Max;
        private Label lbl_NumerResult;
        private TextBox tb_NumberOfResult;
    }
}