namespace CRUD
{
    partial class testing
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
            this.bayarReparasi1 = new CRUD.BayarReparasi();
            this.SuspendLayout();
            // 
            // bayarReparasi1
            // 
            this.bayarReparasi1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bayarReparasi1.Location = new System.Drawing.Point(12, 12);
            this.bayarReparasi1.Name = "bayarReparasi1";
            this.bayarReparasi1.Size = new System.Drawing.Size(1201, 675);
            this.bayarReparasi1.TabIndex = 0;
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1364, 705);
            this.Controls.Add(this.bayarReparasi1);
            this.Name = "testing";
            this.Text = "testing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.testing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BayarReparasi bayarReparasi1;
    }
}