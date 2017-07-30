namespace UIThreadDemo03
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
            this.btnCreateUIThread = new System.Windows.Forms.Button();
            this.btnAbortThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateUIThread
            // 
            this.btnCreateUIThread.Location = new System.Drawing.Point(12, 164);
            this.btnCreateUIThread.Name = "btnCreateUIThread";
            this.btnCreateUIThread.Size = new System.Drawing.Size(258, 30);
            this.btnCreateUIThread.TabIndex = 0;
            this.btnCreateUIThread.Text = "Create UI Thread";
            this.btnCreateUIThread.UseVisualStyleBackColor = true;
            this.btnCreateUIThread.Click += new System.EventHandler(this.btnCreateUIThread_Click);
            // 
            // btnAbortThread
            // 
            this.btnAbortThread.Location = new System.Drawing.Point(12, 201);
            this.btnAbortThread.Name = "btnAbortThread";
            this.btnAbortThread.Size = new System.Drawing.Size(258, 30);
            this.btnAbortThread.TabIndex = 1;
            this.btnAbortThread.Text = "Abort Thread";
            this.btnAbortThread.UseVisualStyleBackColor = true;
            this.btnAbortThread.Click += new System.EventHandler(this.btnAbortThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnAbortThread);
            this.Controls.Add(this.btnCreateUIThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUIThread;
        private System.Windows.Forms.Button btnAbortThread;
    }
}

