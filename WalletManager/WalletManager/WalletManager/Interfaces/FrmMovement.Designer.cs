
namespace WalletManager.Interfaces
{
    partial class FrmMovement
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
            this.dgvMovements = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WalletName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovements
            // 
            this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Mount,
            this.Description,
            this.Deudor,
            this.totalWallet,
            this.WalletName});
            this.dgvMovements.Location = new System.Drawing.Point(13, 13);
            this.dgvMovements.Name = "dgvMovements";
            this.dgvMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovements.Size = new System.Drawing.Size(679, 430);
            this.dgvMovements.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Mount
            // 
            this.Mount.HeaderText = "Mount";
            this.Mount.Name = "Mount";
            this.Mount.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Deudor
            // 
            this.Deudor.HeaderText = "Deudor";
            this.Deudor.Name = "Deudor";
            this.Deudor.ReadOnly = true;
            // 
            // totalWallet
            // 
            this.totalWallet.HeaderText = "Total Wallet";
            this.totalWallet.Name = "totalWallet";
            this.totalWallet.ReadOnly = true;
            // 
            // WalletName
            // 
            this.WalletName.HeaderText = "Wallet name";
            this.WalletName.Name = "WalletName";
            this.WalletName.ReadOnly = true;
            // 
            // FrmMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.dgvMovements);
            this.Name = "FrmMovement";
            this.Text = "FrmMovement";
            this.Load += new System.EventHandler(this.FrmMovement_Load);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.dgvMovements, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn WalletName;
    }
}