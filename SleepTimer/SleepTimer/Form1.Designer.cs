using System.Windows.Forms;

namespace SleepTimer
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.button10m = new System.Windows.Forms.Button();
            this.button45m = new System.Windows.Forms.Button();
            this.button1h = new System.Windows.Forms.Button();
            this.button1h30m = new System.Windows.Forms.Button();
            this.button2h = new System.Windows.Forms.Button();
            this.button4h = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button10m
            // 
            this.button10m.Location = new System.Drawing.Point(12, 113);
            this.button10m.Name = "button10m";
            this.button10m.Size = new System.Drawing.Size(75, 23);
            this.button10m.TabIndex = 0;
            this.button10m.Text = "10 mins";
            this.button10m.UseVisualStyleBackColor = true;
            this.button10m.Click += new System.EventHandler(this.button10m_Click);
            // 
            // button45m
            // 
            this.button45m.Location = new System.Drawing.Point(93, 113);
            this.button45m.Name = "button45m";
            this.button45m.Size = new System.Drawing.Size(75, 23);
            this.button45m.TabIndex = 1;
            this.button45m.Text = "45 mins";
            this.button45m.UseVisualStyleBackColor = true;
            this.button45m.Click += new System.EventHandler(this.button45m_Click);
            // 
            // button1h
            // 
            this.button1h.Location = new System.Drawing.Point(12, 142);
            this.button1h.Name = "button1h";
            this.button1h.Size = new System.Drawing.Size(75, 23);
            this.button1h.TabIndex = 2;
            this.button1h.Text = "1 hour";
            this.button1h.UseVisualStyleBackColor = true;
            this.button1h.Click += new System.EventHandler(this.button1h_Click);
            // 
            // button1h30m
            // 
            this.button1h30m.Location = new System.Drawing.Point(93, 142);
            this.button1h30m.Name = "button1h30m";
            this.button1h30m.Size = new System.Drawing.Size(75, 23);
            this.button1h30m.TabIndex = 3;
            this.button1h30m.Text = "1 h 30 mins";
            this.button1h30m.UseVisualStyleBackColor = true;
            this.button1h30m.Click += new System.EventHandler(this.button1h30m_Click);
            // 
            // button2h
            // 
            this.button2h.Location = new System.Drawing.Point(12, 171);
            this.button2h.Name = "button2h";
            this.button2h.Size = new System.Drawing.Size(75, 23);
            this.button2h.TabIndex = 4;
            this.button2h.Text = "2 hours";
            this.button2h.UseVisualStyleBackColor = true;
            this.button2h.Click += new System.EventHandler(this.button2h_Click);
            // 
            // button4h
            // 
            this.button4h.Location = new System.Drawing.Point(93, 171);
            this.button4h.Name = "button4h";
            this.button4h.Size = new System.Drawing.Size(75, 23);
            this.button4h.TabIndex = 5;
            this.button4h.Text = "4 hours";
            this.button4h.UseVisualStyleBackColor = true;
            this.button4h.Click += new System.EventHandler(this.button4h_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbort.Location = new System.Drawing.Point(12, 200);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(156, 70);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "ABORT";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHours.Location = new System.Drawing.Point(12, 12);
            this.textBoxHours.Multiline = true;
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(47, 37);
            this.textBoxHours.TabIndex = 7;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(12, 55);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(156, 35);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "h";
            // 
            // textBoxMins
            // 
            this.textBoxMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMins.Location = new System.Drawing.Point(93, 12);
            this.textBoxMins.Multiline = true;
            this.textBoxMins.Name = "textBoxMins";
            this.textBoxMins.Size = new System.Drawing.Size(47, 37);
            this.textBoxMins.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "m";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(180, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.button4h);
            this.Controls.Add(this.button2h);
            this.Controls.Add(this.button1h30m);
            this.Controls.Add(this.button1h);
            this.Controls.Add(this.button45m);
            this.Controls.Add(this.button10m);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "SleepTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10m;
        private System.Windows.Forms.Button button45m;
        private System.Windows.Forms.Button button1h;
        private System.Windows.Forms.Button button1h30m;
        private System.Windows.Forms.Button button2h;
        private System.Windows.Forms.Button button4h;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private TextBox textBoxMins;
        private Label label2;
    }
}

