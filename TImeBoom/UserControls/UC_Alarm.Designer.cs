namespace TImeBoom.UserControls
{
    partial class UC_Alarm
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
            panelAlarm = new Panel();
            textBox1 = new TextBox();
            panelAlarm.SuspendLayout();
            SuspendLayout();
            // 
            // panelAlarm
            // 
            panelAlarm.Controls.Add(textBox1);
            panelAlarm.Dock = DockStyle.Fill;
            panelAlarm.Location = new Point(0, 0);
            panelAlarm.Name = "panelAlarm";
            panelAlarm.Size = new Size(902, 560);
            panelAlarm.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "AlarmTest";
            // 
            // UC_Alarm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAlarm);
            Name = "UC_Alarm";
            Size = new Size(902, 560);
            panelAlarm.ResumeLayout(false);
            panelAlarm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAlarm;
        private TextBox textBox1;
    }
}
