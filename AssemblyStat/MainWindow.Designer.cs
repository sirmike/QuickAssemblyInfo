namespace AssemblyStat
{
    partial class MainWindow
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.ColumnHeader NameHeader;
            System.Windows.Forms.ColumnHeader VersionHeader;
            System.Windows.Forms.ColumnHeader PublicKeyHeader;
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assemblyList = new System.Windows.Forms.ListView();
            this.debuggableLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            NameHeader = new System.Windows.Forms.ColumnHeader();
            VersionHeader = new System.Windows.Forms.ColumnHeader();
            PublicKeyHeader = new System.Windows.Forms.ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(this.debuggableLabel);
            groupBox1.Controls.Add(this.nameTB);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Location = new System.Drawing.Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(574, 44);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assembly info";
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(58, 15);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(451, 20);
            this.nameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.assemblyList);
            groupBox2.Location = new System.Drawing.Point(8, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(10);
            groupBox2.Size = new System.Drawing.Size(574, 389);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "References";
            // 
            // assemblyList
            // 
            this.assemblyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            NameHeader,
            VersionHeader,
            PublicKeyHeader});
            this.assemblyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblyList.FullRowSelect = true;
            this.assemblyList.GridLines = true;
            this.assemblyList.Location = new System.Drawing.Point(10, 23);
            this.assemblyList.MultiSelect = false;
            this.assemblyList.Name = "assemblyList";
            this.assemblyList.Size = new System.Drawing.Size(554, 356);
            this.assemblyList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.assemblyList.TabIndex = 0;
            this.assemblyList.UseCompatibleStateImageBehavior = false;
            this.assemblyList.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            NameHeader.Text = "Name";
            NameHeader.Width = 373;
            // 
            // VersionHeader
            // 
            VersionHeader.Text = "Version";
            VersionHeader.Width = 59;
            // 
            // PublicKeyHeader
            // 
            PublicKeyHeader.Text = "Public Key";
            PublicKeyHeader.Width = 118;
            // 
            // debuggableLabel
            // 
            this.debuggableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debuggableLabel.AutoSize = true;
            this.debuggableLabel.Location = new System.Drawing.Point(515, 18);
            this.debuggableLabel.Name = "debuggableLabel";
            this.debuggableLabel.Size = new System.Drawing.Size(0, 13);
            this.debuggableLabel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 455);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Quick Assembly Info";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView assemblyList;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label debuggableLabel;






    }
}