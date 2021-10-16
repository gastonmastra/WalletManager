
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovement));
            this.dgvMovements = new System.Windows.Forms.DataGridView();
            this.btnNewMovement = new System.Windows.Forms.Button();
            this.dateSince = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateUntil = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditMovement = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvMovements.AllowUserToAddRows = false;
            this.dgvMovements.AllowUserToDeleteRows = false;
            this.dgvMovements.AllowUserToResizeRows = false;
            this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Mount,
            this.Description,
            this.Deudor,
            this.totalWallet,
            this.WalletName});
            this.dgvMovements.Location = new System.Drawing.Point(12, 61);
            this.dgvMovements.MultiSelect = false;
            this.dgvMovements.Name = "dgvMovements";
            this.dgvMovements.ReadOnly = true;
            this.dgvMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovements.Size = new System.Drawing.Size(679, 382);
            this.dgvMovements.TabIndex = 1;
            // 
            // btnNewMovement
            // 
            this.btnNewMovement.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMovement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.btnNewMovement.Location = new System.Drawing.Point(407, 449);
            this.btnNewMovement.Name = "btnNewMovement";
            this.btnNewMovement.Size = new System.Drawing.Size(159, 40);
            this.btnNewMovement.TabIndex = 2;
            this.btnNewMovement.Text = "New movement";
            this.btnNewMovement.UseVisualStyleBackColor = true;
            this.btnNewMovement.Click += new System.EventHandler(this.btnNewMovement_Click);
            // 
            // dateSince
            // 
            this.dateSince.CalendarFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateSince.Location = new System.Drawing.Point(13, 35);
            this.dateSince.Name = "dateSince";
            this.dateSince.Size = new System.Drawing.Size(215, 20);
            this.dateSince.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Since";
            // 
            // dateUntil
            // 
            this.dateUntil.CalendarFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateUntil.Location = new System.Drawing.Point(234, 35);
            this.dateUntil.Name = "dateUntil";
            this.dateUntil.Size = new System.Drawing.Size(215, 20);
            this.dateUntil.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Until";
            // 
            // btnEditMovement
            // 
            this.btnEditMovement.BackgroundImage = global::WalletManager.Properties.Resources.edit_1;
            this.btnEditMovement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditMovement.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMovement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.btnEditMovement.Location = new System.Drawing.Point(13, 449);
            this.btnEditMovement.Name = "btnEditMovement";
            this.btnEditMovement.Size = new System.Drawing.Size(40, 40);
            this.btnEditMovement.TabIndex = 22;
            this.btnEditMovement.UseVisualStyleBackColor = true;
            this.btnEditMovement.Click += new System.EventHandler(this.btnEditMovement_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.Location = new System.Drawing.Point(455, 35);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFilter.Size = new System.Drawing.Size(20, 20);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            this.Controls.Add(this.btnEditMovement);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateUntil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSince);
            this.Controls.Add(this.btnNewMovement);
            this.Controls.Add(this.dgvMovements);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMovement";
            this.Text = "Movements";
            this.Load += new System.EventHandler(this.FrmMovement_Load);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.dgvMovements, 0);
            this.Controls.SetChildIndex(this.btnNewMovement, 0);
            this.Controls.SetChildIndex(this.dateSince, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dateUntil, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnFilter, 0);
            this.Controls.SetChildIndex(this.btnEditMovement, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovements;
        public System.Windows.Forms.Button btnNewMovement;
        private System.Windows.Forms.DateTimePicker dateSince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateUntil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        public System.Windows.Forms.Button btnEditMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn WalletName;
    }
}