namespace SwiftInsightsV2
{
    partial class connectingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectingForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pb_SeePassword = new PictureBox();
            Quit_Button = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_Connect = new Button();
            tb_Password = new TextBox();
            tb_login = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_SeePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 31, 62);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 720);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_SwiftInsight;
            pictureBox1.Location = new Point(3, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 31, 62);
            panel2.Controls.Add(pb_SeePassword);
            panel2.Controls.Add(Quit_Button);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btn_Connect);
            panel2.Controls.Add(tb_Password);
            panel2.Controls.Add(tb_login);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(753, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 555);
            panel2.TabIndex = 1;
            // 
            // pb_SeePassword
            // 
            pb_SeePassword.Cursor = Cursors.Hand;
            pb_SeePassword.Image = Properties.Resources.oeil_cache;
            pb_SeePassword.Location = new Point(42, 371);
            pb_SeePassword.Name = "pb_SeePassword";
            pb_SeePassword.Size = new Size(32, 32);
            pb_SeePassword.SizeMode = PictureBoxSizeMode.Zoom;
            pb_SeePassword.TabIndex = 9;
            pb_SeePassword.TabStop = false;
            pb_SeePassword.Click += pb_SeePassword_Click;
            // 
            // Quit_Button
            // 
            Quit_Button.Font = new Font("TT Chocolates Trl", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Quit_Button.ForeColor = Color.FromArgb(0, 31, 62);
            Quit_Button.Location = new Point(231, 447);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(149, 49);
            Quit_Button.TabIndex = 8;
            Quit_Button.Text = "Quitter";
            Quit_Button.UseVisualStyleBackColor = true;
            Quit_Button.Click += Quit_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TT Chocolates Trl", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 287);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 7;
            label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TT Chocolates Trl", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 136);
            label2.Name = "label2";
            label2.Size = new Size(137, 29);
            label2.TabIndex = 6;
            label2.Text = "Identifiant :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cle;
            pictureBox3.Location = new Point(42, 284);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.compte_1_;
            pictureBox2.Location = new Point(42, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btn_Connect
            // 
            btn_Connect.Font = new Font("TT Chocolates Trl", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Connect.ForeColor = Color.FromArgb(0, 31, 62);
            btn_Connect.Location = new Point(42, 447);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(149, 49);
            btn_Connect.TabIndex = 3;
            btn_Connect.Text = "Connexion";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.White;
            tb_Password.Font = new Font("TT Chocolates Trl DemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Password.Location = new Point(42, 322);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(308, 43);
            tb_Password.TabIndex = 2;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_login
            // 
            tb_login.BackColor = Color.White;
            tb_login.Font = new Font("TT Chocolates Trl DemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tb_login.Location = new Point(42, 181);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(313, 43);
            tb_login.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TT Chocolates Trl", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(376, 44);
            label1.TabIndex = 0;
            label1.Text = "Connexion au Portail : ";
            // 
            // connectingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 714);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "connectingForm";
            Text = "Portail Connexion - Swift Insights";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_SeePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btn_Connect;
        private TextBox tb_Password;
        private TextBox tb_login;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pb_SeePassword;
        private Button Quit_Button;
        private Label label3;
    }
}