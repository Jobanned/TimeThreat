namespace TImeBoom.UserControls
{
    partial class UC_Timer
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
            panelTimer = new Panel();
            textBox1 = new TextBox();
            panelTimer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTimer
            // 
            panelTimer.Controls.Add(textBox1);
            panelTimer.Dock = DockStyle.Fill;
            panelTimer.Location = new Point(0, 0);
            panelTimer.Name = "panelTimer";
            panelTimer.Size = new Size(902, 560);
            panelTimer.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "TimerTest";
            // 
            // UC_Timer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTimer);
            Name = "UC_Timer";
            Size = new Size(902, 560);
            panelTimer.ResumeLayout(false);
            panelTimer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTimer;
        private TextBox textBox1;
    }
}
