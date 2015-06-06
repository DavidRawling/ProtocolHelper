namespace ProtocolHandler
{
    partial class DefinedProtocols
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Custom",
            "C:\\Program Files\\Program.exe",
            "https"}, -1);
            this.CloseButton = new System.Windows.Forms.Button();
            this.ProtocolList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(547, 320);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(145, 46);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ProtocolList
            // 
            this.ProtocolList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProtocolList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProtocolList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtocolList.GridLines = true;
            this.ProtocolList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ProtocolList.Location = new System.Drawing.Point(0, 0);
            this.ProtocolList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProtocolList.Name = "ProtocolList";
            this.ProtocolList.ShowGroups = false;
            this.ProtocolList.Size = new System.Drawing.Size(705, 310);
            this.ProtocolList.TabIndex = 1;
            this.ProtocolList.UseCompatibleStateImageBehavior = false;
            this.ProtocolList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Custom Protocol";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Application Path";
            this.columnHeader2.Width = 390;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Real Protocol";
            this.columnHeader3.Width = 140;
            // 
            // DefinedProtocols
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(705, 380);
            this.Controls.Add(this.ProtocolList);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefinedProtocols";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Defined Protocols";
            this.Shown += new System.EventHandler(this.DefinedProtocols_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView ProtocolList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}