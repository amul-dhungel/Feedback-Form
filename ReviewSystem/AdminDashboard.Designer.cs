
namespace ReviewSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnGraphs = new FlatButton.JFlatButton();
            this.btnReports = new FlatButton.JFlatButton();
            this.btnAddFormDetails = new FlatButton.JFlatButton();
            this.reports1 = new ReviewSystem.Reports();
            this.home1 = new ReviewSystem.Home();
            this.graphs1 = new ReviewSystem.Graphs();
            this.adminPanels1 = new ReviewSystem.AdminPanels();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSetting.BackgroundImage")));
            this.pnlSetting.Controls.Add(this.pictureBox1);
            this.pnlSetting.Controls.Add(this.pnlHome);
            this.pnlSetting.Controls.Add(this.btnGraphs);
            this.pnlSetting.Controls.Add(this.btnReports);
            this.pnlSetting.Controls.Add(this.btnAddFormDetails);
            this.pnlSetting.Location = new System.Drawing.Point(-3, -4);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(207, 588);
            this.pnlSetting.TabIndex = 0;
            this.pnlSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSetting_Paint);
            // 
            // pnlHome
            // 
            this.pnlHome.Location = new System.Drawing.Point(203, 3);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(882, 551);
            this.pnlHome.TabIndex = 1;
            // 
            // btnGraphs
            // 
            this.btnGraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnGraphs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnGraphs.ButtonText = "Graphs";
            this.btnGraphs.CausesValidation = false;
            this.btnGraphs.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnGraphs.ErrorImageLeft")));
            this.btnGraphs.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnGraphs.ErrorImageRight")));
            this.btnGraphs.FocusBackground = System.Drawing.Color.Empty;
            this.btnGraphs.FocusFontColor = System.Drawing.Color.Empty;
            this.btnGraphs.ForeColors = System.Drawing.Color.White;
            this.btnGraphs.HoverBackground = System.Drawing.Color.Empty;
            this.btnGraphs.HoverFontColor = System.Drawing.Color.Empty;
            this.btnGraphs.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnGraphs.ImageLeft")));
            this.btnGraphs.ImageRight = null;
            this.btnGraphs.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnGraphs.Location = new System.Drawing.Point(4, 349);
            this.btnGraphs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnGraphs.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnGraphs.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnGraphs.Size = new System.Drawing.Size(203, 56);
            this.btnGraphs.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnGraphs.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnGraphs.TabIndex = 2;
            this.btnGraphs.Click += new System.EventHandler(this.btnGraphs_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnReports.ButtonText = "Reports";
            this.btnReports.CausesValidation = false;
            this.btnReports.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnReports.ErrorImageLeft")));
            this.btnReports.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnReports.ErrorImageRight")));
            this.btnReports.FocusBackground = System.Drawing.Color.Empty;
            this.btnReports.FocusFontColor = System.Drawing.Color.Empty;
            this.btnReports.ForeColors = System.Drawing.Color.White;
            this.btnReports.HoverBackground = System.Drawing.Color.Empty;
            this.btnReports.HoverFontColor = System.Drawing.Color.Empty;
            this.btnReports.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnReports.ImageLeft")));
            this.btnReports.ImageRight = null;
            this.btnReports.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnReports.Location = new System.Drawing.Point(2, 266);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnReports.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnReports.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnReports.Size = new System.Drawing.Size(203, 56);
            this.btnReports.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnReports.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnReports.TabIndex = 1;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAddFormDetails
            // 
            this.btnAddFormDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddFormDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddFormDetails.ButtonText = "Add Details";
            this.btnAddFormDetails.CausesValidation = false;
            this.btnAddFormDetails.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddFormDetails.ErrorImageLeft")));
            this.btnAddFormDetails.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnAddFormDetails.ErrorImageRight")));
            this.btnAddFormDetails.FocusBackground = System.Drawing.Color.Empty;
            this.btnAddFormDetails.FocusFontColor = System.Drawing.Color.Empty;
            this.btnAddFormDetails.ForeColors = System.Drawing.Color.White;
            this.btnAddFormDetails.HoverBackground = System.Drawing.Color.Empty;
            this.btnAddFormDetails.HoverFontColor = System.Drawing.Color.Empty;
            this.btnAddFormDetails.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddFormDetails.ImageLeft")));
            this.btnAddFormDetails.ImageRight = null;
            this.btnAddFormDetails.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAddFormDetails.Location = new System.Drawing.Point(4, 182);
            this.btnAddFormDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFormDetails.Name = "btnAddFormDetails";
            this.btnAddFormDetails.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAddFormDetails.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAddFormDetails.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAddFormDetails.Size = new System.Drawing.Size(203, 56);
            this.btnAddFormDetails.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddFormDetails.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAddFormDetails.TabIndex = 0;
            this.btnAddFormDetails.Click += new System.EventHandler(this.btnAddFormDetails_Click);
            // 
            // reports1
            // 
            this.reports1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reports1.Location = new System.Drawing.Point(200, 2);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(879, 548);
            this.reports1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.ForeColor = System.Drawing.Color.Transparent;
            this.home1.Location = new System.Drawing.Point(200, -1);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(882, 551);
            this.home1.TabIndex = 2;
            // 
            // graphs1
            // 
            this.graphs1.Location = new System.Drawing.Point(200, -1);
            this.graphs1.Name = "graphs1";
            this.graphs1.Size = new System.Drawing.Size(882, 551);
            this.graphs1.TabIndex = 3;
            this.graphs1.Load += new System.EventHandler(this.graphs1_Load);
            // 
            // adminPanels1
            // 
            this.adminPanels1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminPanels1.Location = new System.Drawing.Point(200, -1);
            this.adminPanels1.Name = "adminPanels1";
            this.adminPanels1.Size = new System.Drawing.Size(882, 551);
            this.adminPanels1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 552);
            this.Controls.Add(this.adminPanels1);
            this.Controls.Add(this.graphs1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.reports1);
            this.Controls.Add(this.pnlSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSetting;
        private FlatButton.JFlatButton btnGraphs;
        private FlatButton.JFlatButton btnReports;
        private FlatButton.JFlatButton btnAddFormDetails;
        private System.Windows.Forms.Panel pnlHome;
        private Reports reports1;
        private Home home1;
        private Graphs graphs1;
        private AdminPanels adminPanels1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}