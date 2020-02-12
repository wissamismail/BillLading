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
        public static int maxMain =0;
        public static int maxSP = 0;
        public static int maxSQ = 0;

        public enum LadingType
        {
            Main,
            SP,
            SQ,
            Child
        }

        static public void bindingNavigatorLoad(System.Windows.Forms.BindingSource binSrc, 
                                                System.Linq.Expressions.Expression<System.Func<BillLading.Lading,bool>> query,
                                                System.Windows.Forms.BindingNavigator binNavigator, LadingType myLadingType)
        {
            using (DBModelLadings db = new DBModelLadings())
            {
                BindingList<Lading> myList = new BindingList<Lading>(db.Ladings.Where(query).ToList());
               
                binSrc.DataSource = myList;
                binNavigator.BindingSource = binSrc;
                switch (myLadingType)
                {
                    case  LadingType.Main:
                        {
                            maxMain = myList.Select(p => p.LadingCode).DefaultIfEmpty(0).Max();
                            maxSP = myList.Select(p => p.SP_Code).DefaultIfEmpty(0).Max();
                            maxSQ = myList.Select(p => p.SQ_Code).DefaultIfEmpty(0).Max();
                            break;
                        }
                    case LadingType.SP:
                        {
                            maxSP = db.Ladings.Select(p => p.SP_Code).DefaultIfEmpty(0).Max();
                            break;
                        }
                    case LadingType.SQ:
                        {
                            maxSQ = db.Ladings.Select(p => p.SQ_Code).DefaultIfEmpty(0).Max();
                            break;
                        }
                    default: break;
                }
                
            }
        }

        static public void bindingNavigatorAddNewItem(System.Windows.Forms.BindingSource binSrc, LadingType myLadingType)
        {
            Lading dbLading = new Lading();

            switch (myLadingType)
            {
                case LadingType.Child:
                    {
                        using (DBModelLadings db1 = new DBModelLadings())
                        {
                            Lading myCurrLading = binSrc.Current as Lading;
                            //dbLading = myCurrLading;
                          
                            dbLading = db1.Ladings.AsNoTracking().FirstOrDefault(e => e.LadingID == myCurrLading.LadingID);
                            //db1.Entry<Lading>(dbLading).State = EntityState.Added;
                            dbLading.LadingID = 0 ;
                            dbLading.isLadingChild = true;
                        }

                        dbLading.isLading = true;
                        break;
                    }
                case LadingType.Main:
                    {
                        dbLading.LadingType = "";
                        maxMain = maxMain + 1;
                        dbLading.LadingCode = maxMain + 1;
                        dbLading.isLading = true;
                        break;
                    }
                case LadingType.SP:
                    {
                        dbLading.LadingType = LadingTypeSP;
                        maxSP = maxSP + 1;
                        dbLading.SP_Code = maxSP;
                        break;
                    }
                case LadingType.SQ:
                    {
                        dbLading.LadingType = LadingTypeSQ;
                        maxSQ = maxSQ + 1;
                        dbLading.SQ_Code = maxSQ;
                        break;
                    }
                default: break;
            }

            binSrc.Add(dbLading);
            binSrc.MoveLast();
            
        }

        static public void bindingNavigatorDeleteItem(System.Windows.Forms.BindingSource binSrc, MetroFramework.Forms.MetroForm myForm)
        {
            if (MetroFramework.MetroMessageBox.Show(myForm, "Delete Current Item,Are You Sure?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }

            try { 
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
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(myForm, ex.StackTrace + '\n' + ex.InnerException.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        String message;
                        if (db.Entry<Lading>(myLading).State == EntityState.Deleted)
                            db.Set<Lading>().Attach(myLading);
                        if (myLading.LadingID == 0)
                        {
                            db.Entry<Lading>(myLading).State = EntityState.Added;
                            incrimentSaveItem(myLading);
                            message = " البوليصة الجديدة ";
                        }
                        // myLading.DateOfIssue3
                        else
                        {
                            db.Entry<Lading>(myLading).State = EntityState.Modified;
                            message = " التعديلات على البوليصة ";
                        }

                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(myForm, "تم حفظ" + message, "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(myForm, ex.StackTrace + '\n' + ex.InnerException.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static  void incrimentSaveItem(Lading myLading)
        {
            if (myLading.isLading==true & myLading.isLadingChild==false)
            {
                if (myLading.LadingType == LadingTypeSP)
                {
                    maxSP = maxSP + 1;
                    myLading.SP_Code = maxSP;
                }
                else if (myLading.LadingType == LadingTypeSQ)
                {
                    maxSQ = maxSQ + 1;
                    myLading.SQ_Code = maxSQ;
                }
            }
            
        }
            static public void bindingNavigatorCancelItem(System.Windows.Forms.BindingSource binSrc,
                                                System.Linq.Expressions.Expression<System.Func<BillLading.Lading, bool>> query,
                                                System.Windows.Forms.BindingNavigator binNavigator, LadingType LadingType)
        {  
            binSrc.ResetBindings(false);
            bindingNavigatorLoad(binSrc, query, binNavigator, LadingType);
        }

    }
}
