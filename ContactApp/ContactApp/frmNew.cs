using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            List<AddressList> list = DataLayer.GetAddressLists ();
            cmbAddress.DataSource = list;
            cmbAddress.DisplayMember = "AddressName";
            cmbAddress.ValueMember= "AddressId";

        }
    }
}
