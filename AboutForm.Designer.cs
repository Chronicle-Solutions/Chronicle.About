namespace Chronicle.About
{
    partial class AboutForm
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
            listView1 = new System.Windows.Forms.ListView();
            pluginName = new System.Windows.Forms.ColumnHeader();
            pluginVersion = new System.Windows.Forms.ColumnHeader();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { pluginName, pluginVersion });
            listView1.Location = new System.Drawing.Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(269, 333);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += this.listView1_SelectedIndexChanged;
            // 
            // pluginName
            // 
            pluginName.Text = "Name";
            pluginName.Width = 150;
            // 
            // pluginVersion
            // 
            pluginVersion.Text = "Version";
            pluginVersion.Width = 90;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(287, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(209, 333);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(508, 357);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pluginName;
        private System.Windows.Forms.ColumnHeader pluginVersion;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}