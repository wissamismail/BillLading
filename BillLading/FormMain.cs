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
                TabPage1.Enabled = false;
                binSrcLading.DataSource = db.Ladings.ToList();
                bindingNavigator1.BindingSource = binSrcLading;
            } 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Lading db = new Lading();         
            binSrcLading.Add(db);
            binSrcLading.MoveLast();
            TabPage1.Enabled = true;
            ladingIDTextBox.Focus();          
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Delete Current Item,Are You Sure?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }

            using (DBModelLadings db = new DBModelLadings())
            {
                Lading obj = binSrcLading.Current as Lading;
                if (obj != null)
                {
                    if (db.Entry<Lading>(obj).State == EntityState.Deleted)
                        db.Set<Lading>().Attach(obj);
                    db.Entry<Lading>(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "OK", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binSrcLading.RemoveCurrent();
                    TabPage1.Enabled = false;
                }
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            TabPage1.Enabled = true;
            ladingIDTextBox.Focus();
            Lading obj = binSrcLading.Current as Lading;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBModelLadings db = new DBModelLadings())
                {
                    Lading obj = binSrcLading.Current as Lading;
                    if (obj != null)
                    {
                        if (db.Entry<Lading>(obj).State == EntityState.Deleted)
                            db.Set<Lading>().Attach(obj);
                        if (obj.LadingID == 0)
                            db.Entry<Lading>(obj).State = EntityState.Added;
                        else
                            db.Entry<Lading>(obj).State = EntityState.Modified;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "OK", "Item Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,  ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            TabPage1.Enabled = false;
            binSrcLading.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void bindingNavigatorPrintItem_Click(object sender, EventArgs e)
        {
            FormReport myReportForm = new FormReport();
            myReportForm.Show();
        }

        private void bindingNavigatorFindIDItem_KeyDown(object sender, KeyEventArgs e)
        {
        try
            {
                int postition = binSrcLading.Find("LadingID", bindingNavigatorFindIDItem.Text);
                if (postition != -1)
                {
                    binSrcLading.Position = postition;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorTableItem_Click(object sender, EventArgs e)
        {
            FormTable myFormTable = new FormTable();
            myFormTable.Show();
        }

    }
}
