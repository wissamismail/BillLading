using System;
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

namespace BillLading
{
    public partial class FormTablePrivate : MetroFramework.Forms.MetroForm
    {
        Expression<System.Func<BillLading.Lading, bool>> myQuery = s => (s.LadingType == LadingBussiness.LadingTypeSP & s.isLadingChild == false);

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

        Bitmap bitmap;
        private void bindingNavigatorPrintItem_Click(object sender, EventArgs e)
        {
            FormReportTablePrivate myReportForm = new FormReportTablePrivate();
            myReportForm.Show();

            return;

            //printDocument1.Print();
            //Resize DataGridView to full height.
            int height = ladingDataGridView.Height;
            ladingDataGridView.Height = ladingDataGridView.RowCount * ladingDataGridView.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.ladingDataGridView.Width, this.ladingDataGridView.Height);
            ladingDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.ladingDataGridView.Width, this.ladingDataGridView.Height));

            //Resize DataGridView back to original height.
            ladingDataGridView.Height = height;

            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;

            IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4); // setting paper size to A4 size
            printDocument1.DefaultPageSettings.PaperSize = sizeA4;
            printDocument1.DefaultPageSettings.Landscape = true;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            //printDocument1.DefaultPageSettings.PaperSize= printDocument1.DefaultPageSettings.PaperSize.Kind.
            //printDocument1.DefaultPageSettings.Landscape = true;
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
