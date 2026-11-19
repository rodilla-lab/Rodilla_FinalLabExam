using System;
using System.Windows.Forms;

namespace Rodilla_FinalLabExam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void UpdateReport(
            decimal danielle,
            decimal edward,
            decimal fatima,
            decimal total)
        {
            lblDanielle.Text =
                "Danielle Total Sales: $" +
                danielle.ToString("N2");

            lblEdward.Text =
                "Edward Total Sales: $" +
                edward.ToString("N2");

            lblFatima.Text =
                "Fatima Total Sales: $" +
                fatima.ToString("N2");

            lblTotal.Text =
                "Total Sales: $" +
                total.ToString("N2");
        }
    }
}