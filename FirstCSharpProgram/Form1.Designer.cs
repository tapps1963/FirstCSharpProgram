namespace FirstCSharpProgram
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
            this.txtHello = new System.Windows.Forms.TextBox();
            this.cmdHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(12, 12);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(100, 20);
            this.txtHello.TabIndex = 0;
            // 
            // cmdHello
            // 
            this.cmdHello.Location = new System.Drawing.Point(15, 48);
            this.cmdHello.Name = "cmdHello";
            this.cmdHello.Size = new System.Drawing.Size(97, 23);
            this.cmdHello.TabIndex = 1;
            this.cmdHello.Text = "button1";
            this.cmdHello.UseVisualStyleBackColor = true;
            this.cmdHello.Click += new System.EventHandler(this.cmdHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdHello);
            this.Controls.Add(this.txtHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHello;
        private System.Windows.Forms.Button cmdHello;
    }
}

