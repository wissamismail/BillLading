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
    public partial class FormTablePrivate : MetroFramework.Forms.MetroForm
    {
        Expression<System.Func<BillLading.Lading, bool>> myQuery = s => s.LadingType == LadingBussiness.LadingTypeSP;

        public FormTablePrivate()
        {
            InitializeComponent();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorLoad(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.SP);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorAddNewItem(ladingBindingSource, LadingBussiness.LadingType.SP);
            ladingDataGridView.ReadOnly = false;
            ColumnSP_Code.ReadOnly = true;
            LadingCode.ReadOnly = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorDeleteItem(ladingBindingSource, this);
            ladingDataGridView.ReadOnly = true;
            ColumnSP_Code.ReadOnly = true;
            LadingCode.ReadOnly = true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            ladingDataGridView.ReadOnly = false;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorSaveItem(ladingBindingSource, this, LadingBussiness.LadingType.SP);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            ladingDataGridView.ReadOnly = true;
            LadingBussiness.bindingNavigatorCancelItem(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.SP);
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
