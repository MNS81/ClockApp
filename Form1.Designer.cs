namespace ClockApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            fontDialog1 = new FontDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 0;
            label1.Text = "xxx";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.application_exit;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.InitialImage = Properties.Resources.application_exit;
            pictureBox1.Location = new Point(40, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 18);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            ClientSize = new Size(57, 18);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Opacity = 0.5D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontDialog fontDialog1;
        private PictureBox pictureBox1;
    }
}
