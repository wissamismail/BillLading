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
                bindingNavigator1.BindingSource = binSrcLading;
            } 
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LockTabs(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Lading db = new Lading();         
            binSrcLading.Add(db);
            binSrcLading.MoveLast();
            LockTabs(false);
            placeOfIssue2TextBox.Focus();          
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
                    LockTabs(true);
                }
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            LockTabs(false);
            placeOfIssue2TextBox.Focus();
            Lading obj = binSrcLading.Current as Lading;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBModelLadings db = new DBModelLadings())
                {
                    Lading myLading = binSrcLading.Current as Lading;
                    if (myLading != null)
                    {
                        if (db.Entry<Lading>(myLading).State == EntityState.Deleted)
                            db.Set<Lading>().Attach(myLading);
                        if (myLading.LadingID == 0)
                            db.Entry<Lading>(myLading).State = EntityState.Added;
                            // myLading.DateOfIssue3
                        else
                            db.Entry<Lading>(myLading).State = EntityState.Modified;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "OK", "Item Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,  ex.StackTrace +'\n'+ ex.InnerException.InnerException.Message , ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            LockTabs(true);
            binSrcLading.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void bindingNavigatorPrintItem_Click(object sender, EventArgs e)
        {
            FormReport myReportForm = new FormReport();
            Lading myLading = binSrcLading.Current as Lading;

            myReportForm.LadingID = myLading.LadingID;
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

        private void binSrcLading_PositionChanged(object sender, EventArgs e)
        {
            LockTabs(true);
        }

        private void LockTabs(bool Enable)
        {
            LockTab(Enable, TabPage1);
            LockTab(Enable, metroTabPage2);
            LockTab(Enable, metroTabPage3);
        }

        private void LockTab(bool Enable, MetroFramework.Controls.MetroTabPage TabPage)
        {
           ladingTypeComboBox.Enabled = !(Enable);
           foreach (Control myCtl in TabPage.Controls)
            {
                if (myCtl is TextBox) 
                {
                    TextBox myTxt = (TextBox)myCtl;
                    myTxt.ReadOnly = Enable;
                }

                else if(myCtl is DateTimePicker)
                {
                    DateTimePicker myDT = (DateTimePicker)myCtl;
                    myDT.Enabled = !(Enable);
                }

                else if (myCtl is GroupBox)
                {
                    foreach (Control myCtl2 in myCtl.Controls)
                    {
                        if (myCtl2 is TextBox)
                        {
                            TextBox myTxt2 = (TextBox)myCtl2;
                            myTxt2.ReadOnly = Enable;
                        }
                        else if (myCtl2 is DateTimePicker)
                        {
                            DateTimePicker myDT2 = (DateTimePicker)myCtl2;
                            myDT2.Enabled = !(Enable);
                        }
                    }
                }
            }
            ladingIDTextBox.ReadOnly = true;

        }

        private void bindingNavigatorTableItem_Click(object sender, EventArgs e)
        {
            FormTablePrivate myFormTable = new FormTablePrivate();
            myFormTable.Show();
        }

        private void bindingNavigatorTableSQ_Click(object sender, EventArgs e)
        {
            FormTableQomision myFormTable = new FormTableQomision();
            myFormTable.Show();
        }
    }
}
