namespace FormsAdventure2
{
    partial class frm_title
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
            this.pbx_title = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_title)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_title
            // 
            this.pbx_title.Image = global::FormsAdventure2.Properties.Resources.title_anim2;
            this.pbx_title.Location = new System.Drawing.Point(130, 12);
            this.pbx_title.Name = "pbx_title";
            this.pbx_title.Size = new System.Drawing.Size(785, 146);
            this.pbx_title.TabIndex = 1;
            this.pbx_title.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsAdventure2.Properties.Resources.dragon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbx_title);
            this.Name = "frm_title";
            this.Text = "frm_title";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbx_title;
        private System.Windows.Forms.Button button1;
    }
}