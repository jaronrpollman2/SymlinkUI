namespace SymlinkUI
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
            this.btn_CreateSymlink = new System.Windows.Forms.Button();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.txt_Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_browseSources = new System.Windows.Forms.Button();
            this.btn_BrowseTarget = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CreateSymlink
            // 
            this.btn_CreateSymlink.Location = new System.Drawing.Point(91, 125);
            this.btn_CreateSymlink.Name = "btn_CreateSymlink";
            this.btn_CreateSymlink.Size = new System.Drawing.Size(172, 23);
            this.btn_CreateSymlink.TabIndex = 0;
            this.btn_CreateSymlink.Text = "Create Symlink";
            this.btn_CreateSymlink.UseVisualStyleBackColor = true;
            this.btn_CreateSymlink.Click += new System.EventHandler(this.btn_CreateSymlink_Click);
            // 
            // txt_Source
            // 
            this.txt_Source.Location = new System.Drawing.Point(12, 28);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(297, 20);
            this.txt_Source.TabIndex = 1;
            // 
            // txt_Target
            // 
            this.txt_Target.Enabled = false;
            this.txt_Target.Location = new System.Drawing.Point(12, 79);
            this.txt_Target.Name = "txt_Target";
            this.txt_Target.Size = new System.Drawing.Size(297, 20);
            this.txt_Target.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target";
            // 
            // btn_browseSources
            // 
            this.btn_browseSources.Location = new System.Drawing.Point(317, 28);
            this.btn_browseSources.Name = "btn_browseSources";
            this.btn_browseSources.Size = new System.Drawing.Size(30, 23);
            this.btn_browseSources.TabIndex = 5;
            this.btn_browseSources.Text = "...";
            this.btn_browseSources.UseVisualStyleBackColor = true;
            this.btn_browseSources.Click += new System.EventHandler(this.btn_browseSources_Click);
            // 
            // btn_BrowseTarget
            // 
            this.btn_BrowseTarget.Enabled = false;
            this.btn_BrowseTarget.Location = new System.Drawing.Point(317, 77);
            this.btn_BrowseTarget.Name = "btn_BrowseTarget";
            this.btn_BrowseTarget.Size = new System.Drawing.Size(30, 23);
            this.btn_BrowseTarget.TabIndex = 6;
            this.btn_BrowseTarget.Text = "...";
            this.btn_BrowseTarget.UseVisualStyleBackColor = true;
            this.btn_BrowseTarget.Click += new System.EventHandler(this.btn_BrowseTarget_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_BrowseTarget);
            this.Controls.Add(this.btn_browseSources);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Target);
            this.Controls.Add(this.txt_Source);
            this.Controls.Add(this.btn_CreateSymlink);
            this.Name = "Form1";
            this.Text = "Symlink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateSymlink;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.TextBox txt_Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_browseSources;
        private System.Windows.Forms.Button btn_BrowseTarget;
        private System.Windows.Forms.Label label3;
    }
}

