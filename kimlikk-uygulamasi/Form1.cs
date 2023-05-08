using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace kimlikk_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfotoekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); 
            pictureBox1.ImageLocation = openFileDialog1.FileName; 
            txtfotograf.Text = openFileDialog1.FileName; 
        }

        SqlConnection baglanti=new SqlConnection(@"Data Source=UMUR-DESKTOP;Initial Catalog=kimlik_kartii;Integrated Security=True");

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); /*çalışıyor*/
            SqlCommand komut = new SqlCommand("insert into kimlikk (tc_no,ad,soyad,cinsiyet,dogumtarihi,dogumyeri,fotograf) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti); /*çalışıyor*/
            komut.Parameters.AddWithValue("@p1", txttc.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text); 
            komut.Parameters.AddWithValue("@p3", txtsoyad.Text); 
            komut.Parameters.AddWithValue("@p4", txtcinsiyet.Text); 
            komut.Parameters.AddWithValue("@p5", txtdogumtarihi.Text); 
            komut.Parameters.AddWithValue("@p6", txtdogumyeri.Text); 
            komut.Parameters.AddWithValue("@p7", txtfotograf.Text); 
            komut.ExecuteNonQuery(); 
            baglanti.Close(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kimlik_kartiiDataSet1.kimlikk' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kimlikkTableAdapter.Fill(this.kimlik_kartiiDataSet1.kimlikk); 

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; 
            txttc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); 
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); 
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); 
            txtcinsiyet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); 
            txtdogumtarihi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); 
            txtdogumyeri.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); 
            txtfotograf.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); 

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); 
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kimlikk where tc_no=@p1", baglanti); 
            komut.Parameters.AddWithValue("@p1", txttc.Text); 
            komut.ExecuteNonQuery(); 
            baglanti.Close(); 
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kimlikk set tcno = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txttc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
