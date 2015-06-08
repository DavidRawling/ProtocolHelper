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
            this.CloseButton = new System.Windows.Forms.Button();
            this.ProtocolDGV = new System.Windows.Forms.DataGridView();
            this.CustomProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolDGV)).BeginInit();
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProtocolDGV
            // 
            this.ProtocolDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProtocolDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomProtocol,
            this.Application,
            this.RealProtocol});
            this.ProtocolDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProtocolDGV.Location = new System.Drawing.Point(0, 0);
            this.ProtocolDGV.MultiSelect = false;
            this.ProtocolDGV.Name = "ProtocolDGV";
            this.ProtocolDGV.Size = new System.Drawing.Size(705, 300);
            this.ProtocolDGV.TabIndex = 1;
            // 
            // Name
            // 
            this.CustomProtocol.DataPropertyName = "Name";
            this.CustomProtocol.HeaderText = "Custom Protocol";
            this.CustomProtocol.Name = "Name";
            this.CustomProtocol.Width = 140;
            // 
            // Application
            // 
            this.Application.DataPropertyName = "Application";
            this.Application.HeaderText = "Application Path";
            this.Application.Name = "Application";
            this.Application.Width = 300;
            // 
            // Protocol
            // 
            this.RealProtocol.DataPropertyName = "Protocol";
            this.RealProtocol.HeaderText = "Real Protocol";
            this.RealProtocol.Name = "Protocol";
            this.RealProtocol.Width = 140;
            // 
            // DefinedProtocols
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(705, 380);
            this.Controls.Add(this.ProtocolDGV);
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
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView ProtocolDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Application;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealProtocol;
    }
}