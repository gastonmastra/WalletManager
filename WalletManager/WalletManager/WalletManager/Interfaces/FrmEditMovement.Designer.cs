
namespace WalletManager.Interfaces
{
    partial class FrmEditMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditMovement));
            this.dateMovement = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeOfMovement = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnAddWallet = new System.Windows.Forms.Button();
            this.btnAddClasification = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmbClasification = new System.Windows.Forms.ComboBox();
            this.txtMount = new System.Windows.Forms.TextBox();
            this.cmbWallets = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(635, 451);
            // 
            // dateMovement
            // 
            this.dateMovement.CalendarFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateMovement.Location = new System.Drawing.Point(12, 12);
            this.dateMovement.Name = "dateMovement";
            this.dateMovement.Size = new System.Drawing.Size(215, 20);
            this.dateMovement.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mount";
            // 
            // cmbTypeOfMovement
            // 
            this.cmbTypeOfMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.cmbTypeOfMovement.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbTypeOfMovement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.cmbTypeOfMovement.FormattingEnabled = true;
            this.cmbTypeOfMovement.Location = new System.Drawing.Point(320, 75);
            this.cmbTypeOfMovement.Name = "cmbTypeOfMovement";
            this.cmbTypeOfMovement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTypeOfMovement.Size = new System.Drawing.Size(218, 31);
            this.cmbTypeOfMovement.TabIndex = 27;
            this.cmbTypeOfMovement.Text = "Type of movement";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnAddPerson.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.btnAddPerson.Location = new System.Drawing.Point(544, 110);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(31, 31);
            this.btnAddPerson.TabIndex = 26;
            this.btnAddPerson.Text = "+";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            // 
            // btnAddWallet
            // 
            this.btnAddWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnAddWallet.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.btnAddWallet.Location = new System.Drawing.Point(544, 38);
            this.btnAddWallet.Name = "btnAddWallet";
            this.btnAddWallet.Size = new System.Drawing.Size(31, 31);
            this.btnAddWallet.TabIndex = 25;
            this.btnAddWallet.Text = "+";
            this.btnAddWallet.UseVisualStyleBackColor = false;
            // 
            // btnAddClasification
            // 
            this.btnAddClasification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnAddClasification.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClasification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.btnAddClasification.Location = new System.Drawing.Point(236, 38);
            this.btnAddClasification.Name = "btnAddClasification";
            this.btnAddClasification.Size = new System.Drawing.Size(31, 31);
            this.btnAddClasification.TabIndex = 24;
            this.btnAddClasification.Text = "+";
            this.btnAddClasification.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.button2.Location = new System.Drawing.Point(472, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnConfirm.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.btnConfirm.Location = new System.Drawing.Point(357, 244);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 36);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.comboBox3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(320, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox3.Size = new System.Drawing.Size(218, 31);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.Text = "Person";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtDescription.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.txtDescription.Location = new System.Drawing.Point(12, 169);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(563, 69);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.Text = "";
            // 
            // cmbClasification
            // 
            this.cmbClasification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.cmbClasification.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbClasification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.cmbClasification.FormattingEnabled = true;
            this.cmbClasification.Location = new System.Drawing.Point(12, 38);
            this.cmbClasification.Name = "cmbClasification";
            this.cmbClasification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbClasification.Size = new System.Drawing.Size(218, 31);
            this.cmbClasification.Sorted = true;
            this.cmbClasification.TabIndex = 20;
            this.cmbClasification.Text = "Clasification";
            // 
            // txtMount
            // 
            this.txtMount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtMount.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.txtMount.Location = new System.Drawing.Point(12, 110);
            this.txtMount.Name = "txtMount";
            this.txtMount.Size = new System.Drawing.Size(218, 30);
            this.txtMount.TabIndex = 18;
            // 
            // cmbWallets
            // 
            this.cmbWallets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.cmbWallets.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbWallets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.cmbWallets.FormattingEnabled = true;
            this.cmbWallets.Location = new System.Drawing.Point(320, 38);
            this.cmbWallets.Name = "cmbWallets";
            this.cmbWallets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbWallets.Size = new System.Drawing.Size(218, 31);
            this.cmbWallets.TabIndex = 17;
            this.cmbWallets.Text = "Wallet";
            // 
            // FrmEditMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeOfMovement);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnAddWallet);
            this.Controls.Add(this.btnAddClasification);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbClasification);
            this.Controls.Add(this.txtMount);
            this.Controls.Add(this.cmbWallets);
            this.Controls.Add(this.dateMovement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditMovement";
            this.Text = "Edit Movement";
            this.Load += new System.EventHandler(this.FrmEditMovement_Load);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.dateMovement, 0);
            this.Controls.SetChildIndex(this.cmbWallets, 0);
            this.Controls.SetChildIndex(this.txtMount, 0);
            this.Controls.SetChildIndex(this.cmbClasification, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.btnAddClasification, 0);
            this.Controls.SetChildIndex(this.btnAddWallet, 0);
            this.Controls.SetChildIndex(this.btnAddPerson, 0);
            this.Controls.SetChildIndex(this.cmbTypeOfMovement, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeOfMovement;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnAddWallet;
        private System.Windows.Forms.Button btnAddClasification;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbClasification;
        private System.Windows.Forms.TextBox txtMount;
        private System.Windows.Forms.ComboBox cmbWallets;
    }
}