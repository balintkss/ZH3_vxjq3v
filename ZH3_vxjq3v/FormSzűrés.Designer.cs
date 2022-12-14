namespace ZH3_vxjq3v
{
    partial class FormSzűrés
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
            this.buttonÉv = new System.Windows.Forms.Button();
            this.buttonSebesség = new System.Windows.Forms.Button();
            this.buttonGyorsulás = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonÉv
            // 
            this.buttonÉv.Location = new System.Drawing.Point(12, 12);
            this.buttonÉv.Name = "buttonÉv";
            this.buttonÉv.Size = new System.Drawing.Size(84, 23);
            this.buttonÉv.TabIndex = 0;
            this.buttonÉv.Text = "Év Szűrés";
            this.buttonÉv.UseVisualStyleBackColor = true;
            this.buttonÉv.Click += new System.EventHandler(this.buttonÉv_Click);
            // 
            // buttonSebesség
            // 
            this.buttonSebesség.Location = new System.Drawing.Point(102, 12);
            this.buttonSebesség.Name = "buttonSebesség";
            this.buttonSebesség.Size = new System.Drawing.Size(102, 23);
            this.buttonSebesség.TabIndex = 1;
            this.buttonSebesség.Text = "Sebesség szűrés";
            this.buttonSebesség.UseVisualStyleBackColor = true;
            this.buttonSebesség.Click += new System.EventHandler(this.buttonSebesség_Click);
            // 
            // buttonGyorsulás
            // 
            this.buttonGyorsulás.Location = new System.Drawing.Point(210, 12);
            this.buttonGyorsulás.Name = "buttonGyorsulás";
            this.buttonGyorsulás.Size = new System.Drawing.Size(105, 23);
            this.buttonGyorsulás.TabIndex = 2;
            this.buttonGyorsulás.Text = "Gyorsulás szűrés";
            this.buttonGyorsulás.UseVisualStyleBackColor = true;
            this.buttonGyorsulás.Click += new System.EventHandler(this.buttonGyorsulás_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 490);
            this.panel1.TabIndex = 3;
            // 
            // FormSzűrés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGyorsulás);
            this.Controls.Add(this.buttonSebesség);
            this.Controls.Add(this.buttonÉv);
            this.Name = "FormSzűrés";
            this.Text = "FormSzűrés";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonÉv;
        private Button buttonSebesség;
        private Button buttonGyorsulás;
        private Panel panel1;
    }
}