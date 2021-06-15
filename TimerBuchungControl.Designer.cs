
namespace CCPTimer
{
    partial class TimerBuchungControl
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
            this.components = new System.ComponentModel.Container();
            this.DateRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.abschlussButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateRefresh
            // 
            this.DateRefresh.Enabled = true;
            this.DateRefresh.Interval = 1;
            this.DateRefresh.Tick += new System.EventHandler(this.DateRefresh_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.abschlussButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 291);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // abschlussButton
            // 
            this.abschlussButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.abschlussButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abschlussButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.abschlussButton.FlatAppearance.BorderSize = 0;
            this.abschlussButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abschlussButton.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abschlussButton.ForeColor = System.Drawing.Color.White;
            this.abschlussButton.Location = new System.Drawing.Point(326, 5);
            this.abschlussButton.Name = "abschlussButton";
            this.abschlussButton.Size = new System.Drawing.Size(317, 48);
            this.abschlussButton.TabIndex = 3;
            this.abschlussButton.Text = "A B S C H L U S S";
            this.abschlussButton.UseVisualStyleBackColor = false;
            this.abschlussButton.Click += new System.EventHandler(this.abschlussButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(3, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(317, 48);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "S T A R T";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(646, 291);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TimerBuchungControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TimerBuchungControl";
            this.Size = new System.Drawing.Size(646, 347);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DateRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button abschlussButton;
        private System.Windows.Forms.Button buchen;
    }
}
