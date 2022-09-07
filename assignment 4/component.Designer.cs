namespace assignment_4
{
    partial class component
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(34, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(38, 18);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "title";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(27, 43);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(30, 13);
            this.lbl_desc.TabIndex = 1;
            this.lbl_desc.Text = "desc";
            this.lbl_desc.Click += new System.EventHandler(this.lbl_desc_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(30, 77);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(30, 13);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "price";
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(161, 119);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(249, 112);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(112, 10);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 20);
            this.txt_title.TabIndex = 7;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(112, 40);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 20);
            this.txt_desc.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(112, 77);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 9;
            this.txt_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_title);
            this.Name = "component";
            this.Size = new System.Drawing.Size(426, 269);
            this.Load += new System.EventHandler(this.component_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_price;
    }
}
