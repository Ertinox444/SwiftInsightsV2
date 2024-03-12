using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInsightsV2
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void tb_Search_Enter(object sender, EventArgs e)
        {
            tb_Search.BackColor = Color.White;
        }

        private void resultNumber_PerPage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pb_PreviousPage_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tb_PageNumber.Text) > 1)
            {
                tb_PageNumber.Text = Convert.ToString(Convert.ToInt32(tb_PageNumber.Text) - 1);
            }
        }

        private void pb_NextPage_Click(object sender, EventArgs e)
        {
            tb_PageNumber.Text = Convert.ToString(Convert.ToInt32(tb_PageNumber.Text) +1);
        }
    }
}
