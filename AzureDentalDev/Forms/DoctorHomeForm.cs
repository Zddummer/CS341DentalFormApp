using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureDentalDev.Forms
{
    public partial class DoctorHomeForm : Form
    {
        public DoctorHomeForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.DoctorHomeFormWelcomeLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoctorHomeFormWelcomeLabel
            // 
            this.DoctorHomeFormWelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DoctorHomeFormWelcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorHomeFormWelcomeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoctorHomeFormWelcomeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormWelcomeLabel.ForeColor = System.Drawing.Color.Aqua;
            this.DoctorHomeFormWelcomeLabel.Location = new System.Drawing.Point(195, 302);
            this.DoctorHomeFormWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorHomeFormWelcomeLabel.Name = "DoctorHomeFormWelcomeLabel";
            this.DoctorHomeFormWelcomeLabel.ReadOnly = true;
            this.DoctorHomeFormWelcomeLabel.Size = new System.Drawing.Size(283, 46);
            this.DoctorHomeFormWelcomeLabel.TabIndex = 0;
            this.DoctorHomeFormWelcomeLabel.Text = "Welcome Dr. ";
            // 
            // DoctorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.DoctorHomeFormWelcomeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorHomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
