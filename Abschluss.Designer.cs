
namespace CCPTimer
{
    partial class Abschluss
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
            this.abschlussText = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timestamp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abschlussText
            // 
            this.abschlussText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.abschlussText.ForeColor = System.Drawing.Color.Black;
            this.abschlussText.Location = new System.Drawing.Point(0, 304);
            this.abschlussText.Name = "abschlussText";
            this.abschlussText.Size = new System.Drawing.Size(646, 43);
            this.abschlussText.TabIndex = 0;
            this.abschlussText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(0, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(646, 261);
            this.listBox1.TabIndex = 1;
            // 
            // timestamp
            // 
            this.timestamp.Dock = System.Windows.Forms.DockStyle.Top;
            this.timestamp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timestamp.ForeColor = System.Drawing.Color.Black;
            this.timestamp.Location = new System.Drawing.Point(0, 0);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(646, 43);
            this.timestamp.TabIndex = 2;
            this.timestamp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(622, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abschluss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.timestamp);
            this.Controls.Add(this.abschlussText);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Abschluss";
            this.Size = new System.Drawing.Size(646, 347);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label abschlussText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label timestamp;
        private System.Windows.Forms.Button button1;
    }
}
