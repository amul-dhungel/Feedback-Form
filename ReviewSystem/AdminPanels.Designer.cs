
namespace ReviewSystem
{
    partial class AdminPanels
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanels));
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCriteria.BackgroundImage")));
            this.btnAddCriteria.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCriteria.Location = new System.Drawing.Point(487, 189);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(139, 38);
            this.btnAddCriteria.TabIndex = 2;
            this.btnAddCriteria.Text = "AddRating";
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(469, 136);
            this.txtRating.Multiline = true;
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(179, 40);
            this.txtRating.TabIndex = 5;
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(209, 136);
            this.txtCriteria.Multiline = true;
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(179, 40);
            this.txtCriteria.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 233);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-17, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 71);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(356, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback Creation !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddRating
            // 
            this.btnAddRating.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRating.BackgroundImage")));
            this.btnAddRating.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRating.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddRating.Location = new System.Drawing.Point(231, 189);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(139, 38);
            this.btnAddRating.TabIndex = 11;
            this.btnAddRating.Text = "AddCriteria";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(362, 488);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 55);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refersh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AdminPanels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.btnAddCriteria);
            this.Name = "AdminPanels";
            this.Size = new System.Drawing.Size(901, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Button btnRefresh;
    }
}
