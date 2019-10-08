using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfSQLite
{
    public class DBislemci
    {

        public static bool GridDoldur(DataGrid grd)
        {
            sbyte i = 0;
            string yol = "Data source=DB.db"; // bin içerisinde olduğu için direk olarak ekledik 
            SQLiteConnection baglanti = new SQLiteConnection(yol); // veri tabanına bağlandım 
            SQLiteCommand com = new SQLiteCommand("select * from ogrenciler", baglanti);
            try
            {
                SQLiteDataAdapter adp = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                baglanti.Dispose();
            }
            if (i > 0) return true;
            else return false;

        }


    }
}
