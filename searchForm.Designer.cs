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
            advDGV_Search = new Zuby.ADGV.AdvancedDataGridView();
            tb_Search = new TextBox();
            panel1 = new Panel();
            resultNumber_PerPage = new NumericUpDown();
            label1 = new Label();
            tb_PageNumber = new TextBox();
            pb_PreviousPage = new PictureBox();
            pb_NextPage = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)advDGV_Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultNumber_PerPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_PreviousPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_NextPage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // advDGV_Search
            // 
            advDGV_Search.BackgroundColor = Color.FromArgb(0, 31, 62);
            advDGV_Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advDGV_Search.FilterAndSortEnabled = true;
            advDGV_Search.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advDGV_Search.GridColor = Color.FromArgb(0, 31, 62);
            advDGV_Search.Location = new Point(66, 160);
            advDGV_Search.Name = "advDGV_Search";
            advDGV_Search.RightToLeft = RightToLeft.No;
            advDGV_Search.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("TT Chocolates Trl", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 31, 62);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            advDGV_Search.RowsDefaultCellStyle = dataGridViewCellStyle1;
            advDGV_Search.RowTemplate.Height = 29;
            advDGV_Search.Size = new Size(1533, 813);
            advDGV_Search.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advDGV_Search.TabIndex = 0;
            // 
            // tb_Search
            // 
            tb_Search.BackColor = Color.White;
            tb_Search.BorderStyle = BorderStyle.None;
            tb_Search.Font = new Font("TT Chocolates Trl DemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Search.ForeColor = Color.FromArgb(0, 31, 62);
            tb_Search.Location = new Point(216, 47);
            tb_Search.Name = "tb_Search";
            tb_Search.PlaceholderText = "Entrer une informations...";
            tb_Search.Size = new Size(476, 32);
            tb_Search.TabIndex = 1;
            tb_Search.Enter += tb_Search_Enter;
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
            tb_PageNumber.Location = new Point(1442, 110);
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
            pb_PreviousPage.Location = new Point(1386, 110);
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
            pb_NextPage.Location = new Point(1505, 110);
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
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(689, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 56);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chercher_1_;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // searchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1661, 1016);
            Controls.Add(panel2);
            Controls.Add(pb_NextPage);
            Controls.Add(pb_PreviousPage);
            Controls.Add(tb_PageNumber);
            Controls.Add(label1);
            Controls.Add(resultNumber_PerPage);
            Controls.Add(panel1);
            Controls.Add(tb_Search);
            Controls.Add(advDGV_Search);
            FormBorderStyle = FormBorderStyle.None;
            Name = "searchForm";
            Text = "searchForm";
            ((System.ComponentModel.ISupportInitialize)advDGV_Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultNumber_PerPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_PreviousPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_NextPage).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advDGV_Search;
        private TextBox tb_Search;
        private Panel panel1;
        private NumericUpDown resultNumber_PerPage;
        private Label label1;
        private TextBox tb_PageNumber;
        private PictureBox pb_PreviousPage;
        private PictureBox pb_NextPage;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}