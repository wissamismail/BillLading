using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BillLading
{
    public partial class FormTableQomision : MetroFramework.Forms.MetroForm
    {
        Expression<System.Func<BillLading.Lading, bool>> myQuery = s => (s.LadingType == LadingBussiness.LadingTypeSQ & s.isLadingChild == false);

        public FormTableQomision()
        {
            InitializeComponent();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorLoad(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.SQ);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
            LadingBussiness.bindingNavigatorAddNewItem(ladingBindingSource, LadingBussiness.LadingType.SQ);
            ladingDataGridView.ReadOnly = false;
            //ColumnSQ_Code.ReadOnly = true;
            LadingCode.ReadOnly = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            LadingBussiness.bindingNavigatorDeleteItem(ladingBindingSource, this);
            ladingDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            ladingDataGridView.ReadOnly = false;
            //ColumnSQ_Code.ReadOnly = true;
            LadingCode.ReadOnly = true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorSaveItem(ladingBindingSource, this);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            ladingDataGridView.ReadOnly = true;
            LadingBussiness.bindingNavigatorCancelItem(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.SQ);
        }

        private void ladingBindingSource_PositionChanged(object sender, EventArgs e)
        {
            ladingDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorPrintItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.ladingDataGridView.Width, this.ladingDataGridView.Height);
            ladingDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.ladingDataGridView.Width, this.ladingDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
     
    }
}
