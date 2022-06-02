
namespace lolautoaccept
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.autoacceptb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // autoacceptb
            // 
            this.autoacceptb.AutoSize = true;
            this.autoacceptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.autoacceptb.Location = new System.Drawing.Point(124, 12);
            this.autoacceptb.Name = "autoacceptb";
            this.autoacceptb.Size = new System.Drawing.Size(86, 19);
            this.autoacceptb.TabIndex = 0;
            this.autoacceptb.Text = "autoaccept";
            this.autoacceptb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 46);
            this.Controls.Add(this.autoacceptb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoAccept";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoacceptb;
    }
}

