using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BillLading
{
    public partial class FormTablePrivate : MetroFramework.Forms.MetroForm
    {
        public FormTablePrivate()
        {
            InitializeComponent();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            using (DBModelLadings db = new DBModelLadings())
            {

                ladingBindingSource.DataSource = db.Ladings.Where(s => s.LadingType == "شحن خاص").ToList();
               
            }
        }
    }
}
