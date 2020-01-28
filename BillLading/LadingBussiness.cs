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

    static class LadingBussiness
    {
        public const string LadingTypeSP = "شحن خاص";
        public const string LadingTypeSQ = "شحن قوميسيون";

        static public void bindingNavigatorLoad(System.Windows.Forms.BindingSource binSrc, 
                                                System.Linq.Expressions.Expression<System.Func<BillLading.Lading,bool>> query,
                                                System.Windows.Forms.BindingNavigator binNavigator)
        {
            using (DBModelLadings db = new DBModelLadings())
            {
                binSrc.DataSource = db.Ladings.Where(query).ToList();
                binNavigator.BindingSource = binSrc;
            }
        }

        static public void bindingNavigatorAddNewItem(System.Windows.Forms.BindingSource binSrc, Boolean isLading,string LadingType)
        {
            Lading db = new Lading();
            db.isLading = isLading;
            db.LadingType = LadingType;
            binSrc.Add(db);
            binSrc.MoveLast();
        }

        static public void bindingNavigatorDeleteItem(System.Windows.Forms.BindingSource binSrc, MetroFramework.Forms.MetroForm myForm)
        {
            if (MetroFramework.MetroMessageBox.Show(myForm, "Delete Current Item,Are You Sure?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }

            using (DBModelLadings db = new DBModelLadings())
            {
                Lading obj = binSrc.Current as Lading;
                if (obj != null)
                {
                    if (db.Entry<Lading>(obj).State == EntityState.Deleted)
                        db.Set<Lading>().Attach(obj);
                    db.Entry<Lading>(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(myForm, "OK", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binSrc.RemoveCurrent();
                    
                }
            }
        }
        static public void bindingNavigatorSaveItem(System.Windows.Forms.BindingSource binSrc, MetroFramework.Forms.MetroForm myForm)
        {
            try
            {
                using (DBModelLadings db = new DBModelLadings())
                {
                    Lading myLading = binSrc.Current as Lading;
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
                        MetroFramework.MetroMessageBox.Show(myForm, "OK", "Item Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(myForm, ex.StackTrace + '\n' + ex.InnerException.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public void bindingNavigatorCancelItem(System.Windows.Forms.BindingSource binSrc,
                                                System.Linq.Expressions.Expression<System.Func<BillLading.Lading, bool>> query,
                                                System.Windows.Forms.BindingNavigator binNavigator)
        {  
            binSrc.ResetBindings(false);
            bindingNavigatorLoad(binSrc, query, binNavigator);
        }

    }
}
