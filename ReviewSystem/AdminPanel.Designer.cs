
namespace ReviewSystem
{
    partial class AdminPanel
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
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(96, 65);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(179, 22);
            this.txtCriteria.TabIndex = 0;
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.Location = new System.Drawing.Point(296, 65);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(101, 26);
            this.btnAddCriteria.TabIndex = 1;
            this.btnAddCriteria.Text = "AddCriteria";
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(96, 109);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(179, 22);
            this.txtRating.TabIndex = 2;
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(296, 109);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(101, 26);
            this.btnAddRating.TabIndex = 3;
            this.btnAddRating.Text = "AddRating";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(338, 404);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 233);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(708, 226);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(80, 38);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(708, 291);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(80, 37);
            this.btnGraph.TabIndex = 7;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.btnAddCriteria);
            this.Controls.Add(this.txtCriteria);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnGraph;
    }
}