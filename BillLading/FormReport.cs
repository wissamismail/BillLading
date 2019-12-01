using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillLading
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'TirDS.Carnet' table. You can move, or remove it, as needed.
            //this.LadingBindingSource.(this.TirDS.Carnet, ID);

 
            this.reportViewer1.RefreshReport();
        }
    }
}
