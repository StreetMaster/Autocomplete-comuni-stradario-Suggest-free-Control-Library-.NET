using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuggestControl.Data;

namespace Suggest_free_csharp
{
    public partial class DemoSuggestFree : Form
    {
        public DemoSuggestFree()
        {
            InitializeComponent();
            txtSuggestComune.TownOutput = DataUtil.TownOutputEnum.Town;
        }

        private void cbSoloComuni_CheckedChanged(object sender, EventArgs e)
        {
            txtSuggestComune.TownOutput = cbSoloComuni.Checked ? DataUtil.TownOutputEnum.Town : DataUtil.TownOutputEnum.All;
        }

        private void txtSuggestComune_TownSelect(object sender, SuggestControl.SelectTownEventArgs e)
        {
            txtProvincia.Text = e.Town.Province;
            txtCap.Text = e.Town.Zip;
            txtFrazione.Text = e.Town.Village;     
        }

        private void txtSuggestComune_TextChanged(object sender, EventArgs e)
        {
            txtProvincia.Text = string.Empty;
            txtCap.Text = string.Empty;
            txtFrazione.Text = string.Empty;
        }

        private void txtStreetMasterKey_TextChanged(object sender, EventArgs e)
        {
            if (txtStreetMasterKey.Text.Trim()!= string.Empty)
            {
                txtSuggestComune.StreetMasterKey= txtStreetMasterKey.Text;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.streetmaster.it");
        }
    } 
}
