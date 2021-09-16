
namespace WalletManager
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnViewMovements = new System.Windows.Forms.Button();
            this.btnNewMovement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewMovements
            // 
            this.btnViewMovements.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnViewMovements.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnViewMovements.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnViewMovements.Location = new System.Drawing.Point(115, 12);
            this.btnViewMovements.Name = "btnViewMovements";
            this.btnViewMovements.Size = new System.Drawing.Size(315, 93);
            this.btnViewMovements.TabIndex = 0;
            this.btnViewMovements.Text = "Wallets";
            this.btnViewMovements.UseVisualStyleBackColor = false;
            // 
            // btnNewMovement
            // 
            this.btnNewMovement.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnNewMovement.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMovement.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNewMovement.Location = new System.Drawing.Point(115, 111);
            this.btnNewMovement.Name = "btnNewMovement";
            this.btnNewMovement.Size = new System.Drawing.Size(315, 93);
            this.btnNewMovement.TabIndex = 0;
            this.btnNewMovement.Text = "New movement";
            this.btnNewMovement.UseVisualStyleBackColor = false;
            this.btnNewMovement.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuText;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(115, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 93);
            this.button2.TabIndex = 1;
            this.button2.Text = "New movement";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuText;
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(115, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 93);
            this.button3.TabIndex = 2;
            this.button3.Text = "New movement";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuText;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DarkCyan;
            this.button4.Location = new System.Drawing.Point(115, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 93);
            this.button4.TabIndex = 3;
            this.button4.Text = "New movement";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(543, 524);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNewMovement);
            this.Controls.Add(this.btnViewMovements);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewMovements;
        private System.Windows.Forms.Button btnNewMovement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

