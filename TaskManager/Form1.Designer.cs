namespace TaskManager
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEndTask = new System.Windows.Forms.Button();
            this.listboxTasks = new System.Windows.Forms.ListBox();
            this.labelTopTask = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTaskPeak = new System.Windows.Forms.Label();
            this.labelTaskPeakNumber = new System.Windows.Forms.Label();
            this.labelAllocatedMemoryNumber = new System.Windows.Forms.Label();
            this.labelAllocatedMemory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskManager.Properties.Resources.brightstork_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEndTask
            // 
            this.buttonEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEndTask.Location = new System.Drawing.Point(279, 274);
            this.buttonEndTask.Name = "buttonEndTask";
            this.buttonEndTask.Size = new System.Drawing.Size(76, 28);
            this.buttonEndTask.TabIndex = 2;
            this.buttonEndTask.Text = "End Task";
            this.buttonEndTask.UseVisualStyleBackColor = true;
            this.buttonEndTask.Click += new System.EventHandler(this.buttonEndTask_Click);
            // 
            // listboxTasks
            // 
            this.listboxTasks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listboxTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxTasks.FormattingEnabled = true;
            this.listboxTasks.Location = new System.Drawing.Point(12, 131);
            this.listboxTasks.Name = "listboxTasks";
            this.listboxTasks.Size = new System.Drawing.Size(261, 171);
            this.listboxTasks.TabIndex = 3;
            // 
            // labelTopTask
            // 
            this.labelTopTask.AutoSize = true;
            this.labelTopTask.Location = new System.Drawing.Point(279, 145);
            this.labelTopTask.Name = "labelTopTask";
            this.labelTopTask.Size = new System.Drawing.Size(35, 13);
            this.labelTopTask.TabIndex = 4;
            this.labelTopTask.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top Memory Task:";
            // 
            // labelTaskPeak
            // 
            this.labelTaskPeak.AutoSize = true;
            this.labelTaskPeak.Location = new System.Drawing.Point(279, 183);
            this.labelTaskPeak.Name = "labelTaskPeak";
            this.labelTaskPeak.Size = new System.Drawing.Size(69, 13);
            this.labelTaskPeak.TabIndex = 6;
            this.labelTaskPeak.Text = "Task\'s Peak:";
            // 
            // labelTaskPeakNumber
            // 
            this.labelTaskPeakNumber.AutoSize = true;
            this.labelTaskPeakNumber.Location = new System.Drawing.Point(279, 196);
            this.labelTaskPeakNumber.Name = "labelTaskPeakNumber";
            this.labelTaskPeakNumber.Size = new System.Drawing.Size(87, 13);
            this.labelTaskPeakNumber.TabIndex = 7;
            this.labelTaskPeakNumber.Text = "Allowed Memory:";
            // 
            // labelAllocatedMemoryNumber
            // 
            this.labelAllocatedMemoryNumber.AutoSize = true;
            this.labelAllocatedMemoryNumber.Location = new System.Drawing.Point(279, 236);
            this.labelAllocatedMemoryNumber.Name = "labelAllocatedMemoryNumber";
            this.labelAllocatedMemoryNumber.Size = new System.Drawing.Size(69, 13);
            this.labelAllocatedMemoryNumber.TabIndex = 8;
            this.labelAllocatedMemoryNumber.Text = "Task\'s Peak:";
            // 
            // labelAllocatedMemory
            // 
            this.labelAllocatedMemory.AutoSize = true;
            this.labelAllocatedMemory.Location = new System.Drawing.Point(279, 223);
            this.labelAllocatedMemory.Name = "labelAllocatedMemory";
            this.labelAllocatedMemory.Size = new System.Drawing.Size(94, 13);
            this.labelAllocatedMemory.TabIndex = 9;
            this.labelAllocatedMemory.Text = "Allocated Memory:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 314);
            this.Controls.Add(this.labelAllocatedMemory);
            this.Controls.Add(this.labelAllocatedMemoryNumber);
            this.Controls.Add(this.labelTaskPeakNumber);
            this.Controls.Add(this.labelTaskPeak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTopTask);
            this.Controls.Add(this.listboxTasks);
            this.Controls.Add(this.buttonEndTask);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "brightstork v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEndTask;
        private System.Windows.Forms.ListBox listboxTasks;
        private System.Windows.Forms.Label labelTopTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTaskPeak;
        private System.Windows.Forms.Label labelTaskPeakNumber;
        private System.Windows.Forms.Label labelAllocatedMemoryNumber;
        private System.Windows.Forms.Label labelAllocatedMemory;
    }
}

