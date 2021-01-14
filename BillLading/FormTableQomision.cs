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
            if (LadingBussiness.currDate != null)
            {
                myQuery = s => (s.LadingType == LadingBussiness.LadingTypeSQ & s.isLadingChild == false & s.DateOfIssue3 >= LadingBussiness.currDate);
            }
            LadingBussiness.bindingNavigatorLoad(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.SQ);
            advancedDataGridViewSearchToolBar_main.SetColumns(ladingDataGridView.Columns);
            foreach (DataGridViewColumn col in ladingDataGridView.Columns)
                ladingDataGridView.DisableFilterAndSort(col);
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
            ReportTableQomision myReportForm = new ReportTableQomision();
            myReportForm.Show();
        }

        private void advancedDataGridViewSearchToolBar_main_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = ladingDataGridView.CurrentCell.ColumnIndex + 1 >= ladingDataGridView.ColumnCount;
                bool endrow = ladingDataGridView.CurrentCell.RowIndex + 1 >= ladingDataGridView.RowCount;

                if (endcol && endrow)
                {
                    startColumn = ladingDataGridView.CurrentCell.ColumnIndex;
                    startRow = ladingDataGridView.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : ladingDataGridView.CurrentCell.ColumnIndex + 1;
                    startRow = ladingDataGridView.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = ladingDataGridView.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = ladingDataGridView.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                ladingDataGridView.CurrentCell = c;
        }
    }
}
