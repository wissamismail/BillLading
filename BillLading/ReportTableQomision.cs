using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillLading
{
    public partial class ReportTableQomision : Form
    {
        public ReportTableQomision()
        {
            InitializeComponent();
        }

        public int LadingID { get; internal set; }

        private void FormReport_Load(object sender, EventArgs e)
        {

            using (DBModelLadings db = new DBModelLadings())
            {

                BindingList<Lading> myList = new BindingList<Lading>(db.Ladings.Where(s => s.LadingType == LadingBussiness.LadingTypeSQ & s.isLadingChild == false).ToList());
                this.LadingBindingSource.DataSource = myList.OrderBy(c => c.SQ_Code);
            }


            this.reportViewer.RefreshReport();
        }
    }
}
