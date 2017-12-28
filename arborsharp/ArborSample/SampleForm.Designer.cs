namespace ArborSample
{
    partial class SampleForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
			this.arborViewer1 = new ArborSample.ArborViewer();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.arborViewer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// arborViewer1
			// 
			this.arborViewer1.BackColor = System.Drawing.Color.White;
			this.arborViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.arborViewer1.Controls.Add(this.button3);
			this.arborViewer1.Controls.Add(this.comboBox3);
			this.arborViewer1.Controls.Add(this.button2);
			this.arborViewer1.Controls.Add(this.button1);
			this.arborViewer1.Controls.Add(this.comboBox2);
			this.arborViewer1.Controls.Add(this.comboBox1);
			this.arborViewer1.Controls.Add(this.textBox2);
			this.arborViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.arborViewer1.EnergyDebug = false;
			this.arborViewer1.Location = new System.Drawing.Point(0, 0);
			this.arborViewer1.Name = "arborViewer1";
			this.arborViewer1.NodesDragging = false;
			this.arborViewer1.Size = new System.Drawing.Size(1223, 587);
			this.arborViewer1.TabIndex = 0;
			this.arborViewer1.TabStop = true;
			this.arborViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArborViewer1MouseMove);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(907, 427);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(274, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Очитстить Поле";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(1060, 55);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 12;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1060, 205);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Добавить связь";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1060, 113);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Добавить элемент";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(1060, 158);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 9;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(918, 158);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(918, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 6;
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1223, 587);
			this.Controls.Add(this.arborViewer1);
			this.KeyPreview = true;
			this.Name = "SampleForm";
			this.Text = "SampleForm";
			this.arborViewer1.ResumeLayout(false);
			this.arborViewer1.PerformLayout();
			this.ResumeLayout(false);

        }

        private ArborViewer arborViewer1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button3;
	}
}
