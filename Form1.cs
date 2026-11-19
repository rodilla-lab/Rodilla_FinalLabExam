using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Rodilla_FinalLabExam
{
    public partial class Form1 : Form
    {
        decimal danielleSales = 0;
        decimal edwardSales = 0;
        decimal fatimaSales = 0;
        decimal totalSales = 0;

        Form2 summaryForm;

        PrintDocument printDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();

            summaryForm = new Form2();
            summaryForm.Show();

            btnSubmit.Click += btnSubmit_Click;
            btnClear.Click += btnClear_Click;
            btnPrint.Click += btnPrint_Click;

            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string initial = txtInitial.Text.Trim().ToUpper();

            decimal amount;

            if (initial != "D" && initial != "E" && initial != "F")
            {
                MessageBox.Show("Invalid Sales Person Initial!");
                txtInitial.Focus();
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid sales amount!");
                txtAmount.Focus();
                return;
            }

            string name = "";
            decimal personTotal = 0;

            if (initial == "D")
            {
                danielleSales += amount;
                name = "Danielle";
                personTotal = danielleSales;
            }
            else if (initial == "E")
            {
                edwardSales += amount;
                name = "Edward";
                personTotal = edwardSales;
            }
            else if (initial == "F")
            {
                fatimaSales += amount;
                name = "Fatima";
                personTotal = fatimaSales;
            }

            totalSales += amount;

            summaryForm.UpdateReport(
                danielleSales,
                edwardSales,
                fatimaSales,
                totalSales
            );

            lblMessage.Text =
                "$" + amount.ToString("N2") +
                " in sales has been successfully recorded for " +
                name +
                ", bringing his/her total sales to $" +
                personTotal.ToString("N2");

            txtInitial.Clear();
            txtAmount.Clear();

            txtInitial.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInitial.Clear();
            txtAmount.Clear();
            lblMessage.Text = "";

            txtInitial.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();

            preview.Document = printDocument;

            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(
            object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            Font boldFont = new Font("Arial", 14, FontStyle.Bold);

            float y = 50;

            g.DrawString("SUMMARY REPORT",
                titleFont, Brushes.Black, 50, y);

            y += 60;

            g.DrawString("Danielle Total Sales: $" +
                danielleSales.ToString("N2"),
                normalFont, Brushes.Black, 50, y);

            y += 40;

            g.DrawString("Edward Total Sales: $" +
                edwardSales.ToString("N2"),
                normalFont, Brushes.Black, 50, y);

            y += 40;

            g.DrawString("Fatima Total Sales: $" +
                fatimaSales.ToString("N2"),
                normalFont, Brushes.Black, 50, y);

            y += 60;

            g.DrawString("Total Sales: $" +
                totalSales.ToString("N2"),
                boldFont, Brushes.Black, 50, y);
        }
    }
}