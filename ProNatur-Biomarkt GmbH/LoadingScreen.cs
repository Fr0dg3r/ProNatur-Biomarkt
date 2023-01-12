using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        static Random r = new Random();
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            if (pbarLoading.Value < 95) pbarLoading.Value += r.Next(5);
            if (pbarLoading.Value < 100) pbarLoading.Value += 1;
            lblProgPercent.Text = pbarLoading.Value.ToString() + "%";

            if(pbarLoading.Value > pbarLoading.Maximum)
            {
                pbarLoading.Value = pbarLoading.Maximum;
                loadingbarTimer.Stop();
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }
    }
}
