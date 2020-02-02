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
using System.Linq.Expressions;

namespace BillLading
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Expression<System.Func<BillLading.Lading, bool>> myQuery = s => s.isLading == true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorLoad(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.Main);     
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LockTabs(true);
        }

        private void ladingTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DBModelLadings db = new DBModelLadings())
            {
                Lading myLading = ladingBindingSource.Current as Lading;

                if (myLading != null)
                {
                    if (ladingTypeComboBox.SelectedIndex == 1)
                         myLading.LadingType = LadingBussiness.LadingTypeSP;
                    else if (ladingTypeComboBox.SelectedIndex == 2)
                        myLading.LadingType = LadingBussiness.LadingTypeSQ;
                    db.Entry<Lading>(myLading).State = EntityState.Modified;
                   // MetroFramework.MetroMessageBox.Show(this, ladingTypeComboBox.SelectedItem.ToString(), myLading.LadingType.ToString(), MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            LadingBussiness.bindingNavigatorAddNewItem(ladingBindingSource, LadingBussiness.LadingType.Main);
            LockTabs(false);
            placeOfIssue2TextBox.Focus();          
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorDeleteItem(ladingBindingSource, this);
            LockTabs(true);
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            LockTabs(false);
            placeOfIssue2TextBox.Focus();
            Lading obj = ladingBindingSource.Current as Lading;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorSaveItem(ladingBindingSource, this, LadingBussiness.LadingType.Main);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            LockTabs(true);
            LadingBussiness.bindingNavigatorCancelItem(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.Main);
 
        }

        private void bindingNavigatorPrintItem_Click(object sender, EventArgs e)
        {
            FormReport myReportForm = new FormReport();
            Lading myLading = ladingBindingSource.Current as Lading;

            myReportForm.LadingID = myLading.LadingID;
            myReportForm.Show();
        }

        private void bindingNavigatorFindIDItem_KeyDown(object sender, KeyEventArgs e)
        {
        try
            {
                int postition = ladingBindingSource.Find("LadingID", bindingNavigatorFindIDItem.Text);
                if (postition != -1)
                {
                    ladingBindingSource.Position = postition;
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
            ladingCodeTextBox.ReadOnly = true;

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
