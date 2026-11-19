
namespace Rodilla_FinalLabExam
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblDanielle = new System.Windows.Forms.Label();
            this.lblEdward = new System.Windows.Forms.Label();
            this.lblFatima = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblReportTitle.Font = new System.Drawing.Font("Arial", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(90, 35);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(470, 45);
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "SUMMARY REPORT";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDanielle
            // 
            this.lblDanielle.AutoSize = true;
            this.lblDanielle.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDanielle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanielle.Location = new System.Drawing.Point(80, 120);
            this.lblDanielle.Name = "lblDanielle";
            this.lblDanielle.Size = new System.Drawing.Size(211, 18);
            this.lblDanielle.TabIndex = 1;
            this.lblDanielle.Text = "Danielle Total Sales :          $0";
            // 
            // lblEdward
            // 
            this.lblEdward.AutoSize = true;
            this.lblEdward.BackColor = System.Drawing.Color.AliceBlue;
            this.lblEdward.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdward.Location = new System.Drawing.Point(80, 170);
            this.lblEdward.Name = "lblEdward";
            this.lblEdward.Size = new System.Drawing.Size(208, 18);
            this.lblEdward.TabIndex = 2;
            this.lblEdward.Text = "Edward Total Sales :          $0";
            // 
            // lblFatima
            // 
            this.lblFatima.AutoSize = true;
            this.lblFatima.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFatima.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatima.Location = new System.Drawing.Point(80, 220);
            this.lblFatima.Name = "lblFatima";
            this.lblFatima.Size = new System.Drawing.Size(207, 18);
            this.lblFatima.TabIndex = 3;
            this.lblFatima.Text = "Fatima Total Sales :           $0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 265);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(166, 22);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Sales :    $0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFatima);
            this.Controls.Add(this.lblEdward);
            this.Controls.Add(this.lblDanielle);
            this.Controls.Add(this.lblReportTitle);
            this.Name = "Form2";
            this.Text = "Summary Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblDanielle;
        private System.Windows.Forms.Label lblEdward;
        private System.Windows.Forms.Label lblFatima;
        private System.Windows.Forms.Label lblTotal;
    }
}
