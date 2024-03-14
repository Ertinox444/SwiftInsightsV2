namespace SwiftInsightsV2
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            main_PNL = new Panel();
            flp_Main = new FlowLayoutPanel();
            mainPic_ToMenu = new PictureBox();
            btn_Search = new Button();
            btn_Create = new Button();
            btn_Logout = new PictureBox();
            btn_Quit = new PictureBox();
            flp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic_ToMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Quit).BeginInit();
            SuspendLayout();
            // 
            // main_PNL
            // 
            main_PNL.BackColor = Color.White;
            main_PNL.Location = new Point(259, -2);
            main_PNL.Name = "main_PNL";
            main_PNL.Size = new Size(1679, 1063);
            main_PNL.TabIndex = 0;
            // 
            // flp_Main
            // 
            flp_Main.BackColor = Color.FromArgb(0, 31, 62);
            flp_Main.Controls.Add(mainPic_ToMenu);
            flp_Main.Controls.Add(btn_Search);
            flp_Main.Controls.Add(btn_Create);
            flp_Main.Controls.Add(btn_Logout);
            flp_Main.Controls.Add(btn_Quit);
            flp_Main.Location = new Point(0, -2);
            flp_Main.Name = "flp_Main";
            flp_Main.Size = new Size(262, 1058);
            flp_Main.TabIndex = 1;
            // 
            // mainPic_ToMenu
            // 
            mainPic_ToMenu.Image = Properties.Resources.logo_SwiftInsight;
            mainPic_ToMenu.Location = new Point(3, 3);
            mainPic_ToMenu.Name = "mainPic_ToMenu";
            mainPic_ToMenu.Size = new Size(259, 233);
            mainPic_ToMenu.SizeMode = PictureBoxSizeMode.Zoom;
            mainPic_ToMenu.TabIndex = 0;
            mainPic_ToMenu.TabStop = false;
            mainPic_ToMenu.Click += mainPic_ToMenu_Click;
            // 
            // btn_Search
            // 
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.Font = new Font("TT Chocolates Trl", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(3, 242);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(259, 79);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "RECHERCHER";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Create
            // 
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.Font = new Font("TT Chocolates Trl", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Create.ForeColor = Color.White;
            btn_Create.Location = new Point(3, 327);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(259, 79);
            btn_Create.TabIndex = 1;
            btn_Create.Text = "CREER";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Visible = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.Image = Properties.Resources.logout;
            btn_Logout.Location = new Point(3, 412);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(53, 54);
            btn_Logout.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Logout.TabIndex = 0;
            btn_Logout.TabStop = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Quit
            // 
            btn_Quit.Cursor = Cursors.Hand;
            btn_Quit.Image = Properties.Resources.power;
            btn_Quit.Location = new Point(62, 412);
            btn_Quit.Name = "btn_Quit";
            btn_Quit.Size = new Size(53, 54);
            btn_Quit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Quit.TabIndex = 2;
            btn_Quit.TabStop = false;
            btn_Quit.Click += btn_Quit_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1924, 1055);
            Controls.Add(flp_Main);
            Controls.Add(main_PNL);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Swift Insights";
            WindowState = FormWindowState.Maximized;
            flp_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPic_ToMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Quit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_PNL;
        private FlowLayoutPanel flp_Main;
        private PictureBox mainPic_ToMenu;
        private Button button2;
        private Button btn_Search;
        private Button btn_Create;
        private PictureBox btn_Logout;
        private PictureBox btn_Quit;
    }
}
