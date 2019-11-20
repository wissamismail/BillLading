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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DBModelLadings db = new DBModelLadings())
            {
                binSrcLading.DataSource = db.Ladings.ToList();
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            binSrcLading.Add(new Lading());
            binSrcLading.MoveLast();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lading obj = binSrcLading.Current as Lading;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            binSrcLading.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Delete Item", "Delete Current Item,Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }
            using (DBModelLadings db = new DBModelLadings())
            {
                Lading obj = binSrcLading.Current as Lading;
                if(obj != null)
                {
                    if (db.Entry<Lading>(obj).State == EntityState.Deleted)
                        db.Set<Lading>().Attach(obj);
                    db.Entry<Lading>(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "OK", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binSrcLading.RemoveCurrent();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DBModelLadings db = new DBModelLadings())
            {
                Lading obj = binSrcLading.Current as Lading;
                if (obj != null)
                {
                    if (db.Entry<Lading>(obj).State == EntityState.Deleted)
                        db.Set<Lading>().Attach(obj);
                    if (obj.LadingID == 0)
                        db.Entry<Lading>(obj).State= EntityState.Added;
                    else
                        db.Entry<Lading>(obj).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "OK", "Item Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
