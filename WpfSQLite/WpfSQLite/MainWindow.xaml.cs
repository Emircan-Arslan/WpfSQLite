using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfSQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtOgrenciNo.Text == "" || txtOgrenciNot.Text == "")
            {
                MessageBox.Show("Alanları Doldurun");
            }
            else
            {
                string yol = "Data source = DB.db";
                SQLiteConnection baglanti = new SQLiteConnection(yol);
                baglanti.Open();
                try
                {
                    string sql = "insert into ogrenciler(OgrenciNo,OgrenciNot) values (@OgrenciNo,@OgrenciNot)";
                    SQLiteCommand komutislet = new SQLiteCommand(sql, baglanti);

                    komutislet.Parameters.AddWithValue("@OgrenciNo", txtOgrenciNo.Text);
                    komutislet.Parameters.AddWithValue("@OgrenciNot", txtOgrenciNot.Text);
                    komutislet.ExecuteNonQuery();
                    baglanti.Dispose();
                    MessageBox.Show("kayıt yapıldı ");
                    DBislemci.GridDoldur(dataGrid1);
                    txtOgrenciNo.Text = "";
                    txtOgrenciNot.Text = "";
                }
                catch (Exception ee)
                {
                    MessageBox.Show("AYNI NUMARADAN OLABİLİR DEĞİŞTİRİN \n\n " + ee.ToString());
                }
                finally
                {
                    baglanti.Dispose();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Öğrenci No Giriniz ");
            }
            else
            {
                if (MessageBox.Show("Silinsin Mi ?", "Soru", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    // hiçbir şey yapma
                }
                else
                {
                    // evet şeyler yap

                    string yol = "Data source = DB.db";
                    SQLiteConnection baglanti = new SQLiteConnection(yol);
                    baglanti.Open();
                    try
                    {
                        string sql = "delete from ogrenciler where OgrenciNo=" + txtOgrenciNo.Text + "";
                        SQLiteCommand komutislet = new SQLiteCommand(sql, baglanti);
                        komutislet.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Silindi");
                        DBislemci.GridDoldur(dataGrid1);
                        txtOgrenciNo.Text = "";
                        txtOgrenciNot.Text = "";
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Hata Alanları Kotrol Edin " + ee.ToString());
                    }
                    finally
                    {
                        baglanti.Dispose();
                    }
                }
            }


        }

        private void BtnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Öğrenci No Giriniz ");
            }
            else
            {
                if (MessageBox.Show("Not Değişsin mi ?", "Soru", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    // hiçbir şey yapma
                }
                else
                {



                    string yol = "Data source = DB.db";
                    SQLiteConnection baglanti = new SQLiteConnection(yol);
                    baglanti.Open();
                    try
                    {
                        string sql = "update ogrenciler set OgrenciNot='" + txtOgrenciNot.Text + "' where OgrenciNo=" + txtOgrenciNo.Text + "";
                        SQLiteCommand komutislet = new SQLiteCommand(sql, baglanti);
                        komutislet.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Güncellendi");
                        DBislemci.GridDoldur(dataGrid1);
                        txtOgrenciNo.Text = "";
                        txtOgrenciNot.Text = "";
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Hata Alanları Kotrol Edin " + ee.ToString());
                    }
                    finally
                    {
                        baglanti.Dispose();
                    }
                }
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DBislemci.GridDoldur(dataGrid1);
        }
    }
}
