using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonnerManagementSystem
{
    public partial class AddNewDonor : Form
    {
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) form newDonor";
            DataSet ds = fn.getData(query);
            int count in
                t.Parse(ds.Tables[0].Rows[0][0].ToString());
            lebelNewID.Text = (count).ToString();
        }
    }
}
