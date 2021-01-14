using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Zuby.ADGV;

namespace BillLading
{
    public partial class FormTablePrivate : MetroFramework.Forms.MetroForm
    {
        Expression<System.Func<BillLading.Lading, bool>> myQuery = s => (s.LadingType == LadingBussiness.LadingTypeSP & s.isLadingChild == false);
   
        public FormTablePrivate()
        {
            InitializeComponent();
            combobox_doldur();
        }
        
        public class ComboDeger
        {
            private string yazi;
            private bool deger;
            public ComboDeger(string stryazi, bool strdeger)
            {
                this.yazi = stryazi;
                this.deger = strdeger;
            }
            public string yazisi
            {
                get
                {
                    return yazi;
                }
            }
            public bool degeri
            {
                get
                {
                    return deger;
                }
            }
        }
        private void combobox_doldur()
        {
            ArrayList ComboDegerleri = new ArrayList();
            ComboDegerleri.Add(new ComboDeger("نعم", true));
            ComboDegerleri.Add(new ComboDeger("كلا", false));
            SP_AdvanceDelivered.DataSource = ComboDegerleri;
            SP_AdvanceDelivered.DisplayMember = "yazisi";
            SP_AdvanceDelivered.ValueMember = "degeri";
        }
        private void FormTable_Load(object sender, EventArgs e)
        {
            if (LadingBussiness.currDate != null)
            {
                myQuery = s => (s.LadingType == LadingBussiness.LadingTypeSP & s.isLadingChild == false & s.DateOfIssue3 >= LadingBussiness.currDate);
            }
            LadingBussiness.bindingNavigatorLoad(ladingBindingSource, myQuery, bindingNavigator1, LadingBussiness.LadingType.SP);

            advancedDataGridViewSearchToolBar_main.SetColumns(ladingDataGridView.Columns);
            foreach (DataGridViewColumn  col in ladingDataGridView.Columns)
                   ladingDataGridView.DisableFilterAndSort(col);
       
        }
        
        private void ladingDataGridView_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            try
            {
               
                ladingBindingSource.Filter = ladingDataGridView.FilterString;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this , ex.StackTrace + '\n' + ex.InnerException.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorAddNewItem(ladingBindingSource, LadingBussiness.LadingType.SP);
            ladingDataGridView.ReadOnly = false;
            //ColumnSP_Code.ReadOnly = true;
            LadingCode.ReadOnly = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorDeleteItem(ladingBindingSource, this);
            ladingDataGridView.ReadOnly = true;
            //ColumnSP_Code.ReadOnly = true;
            LadingCode.ReadOnly = true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            ladingDataGridView.ReadOnly = false;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            LadingBussiness.bindingNavigatorSaveItem(ladingBindingSource, this);
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
            ReportTablePrivate myReportForm = new ReportTablePrivate();
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
