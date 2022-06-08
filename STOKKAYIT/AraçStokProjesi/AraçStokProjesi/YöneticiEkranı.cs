using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçStokProjesi
{
    public partial class YöneticiEkrani : Form
    {
        public YöneticiEkrani()
        {
            InitializeComponent();
        }

        SqlConnection stokbaglantisi = new SqlConnection(" Data Source = DESKTOP-0P73CNR; Initial Catalog=YedekParçaStok; Integrated Security = True ");

        private void btnprcek_Click(object sender, EventArgs e)
        {
            string parca = txtprcad.Text;    // text parça kodu
            string stok = txtstkkd.Text;     // text stokkodu
            string mevcut = txtmvctstk.Text; // text mevcutstok kodu
            string birim = txtbirim.Text;    // text fiyat kodu
            string max = txtmax.Text;      // text max stok
            string teminat = txttmnt.Text;  // text teminat süresi

            stokbaglantisi.Open();
            SqlCommand stokekle = new SqlCommand("INSERT INTO YoneticiParcaEkrani (StokKodu,ParçaAdı,BirimFiyat,MevcutStok,MaximumStok,TeminatSuresi)  VALUES ('"+stok+ "','" + parca + "','" + birim + "','" + mevcut + "','" + max + "','" + teminat + "')", stokbaglantisi);
            stokekle.ExecuteNonQuery();
            stokbaglantisi.Close();
            parcalar();
        }

        private void YöneticiEkranı_Load(object sender, EventArgs e)
        {

            parcalar();

        }
        private void parcalar() // veri tabanı kayıtları 
        {

            stokbaglantisi.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select * from   YoneticiParcaEkrani",stokbaglantisi);
            DataTable tbl = new DataTable();
            data.Fill(tbl);
            dataGridView1.DataSource = tbl;
            stokbaglantisi.Close();

        }

        private void lbltmnt_Click(object sender, EventArgs e)
        {

        }

        private void btnprcsil_Click(object sender, EventArgs e)
        {

            string stok = txtstkkd.Text;
            stokbaglantisi.Open();
            SqlCommand stokekle = new SqlCommand("DELETE FROM YoneticiParcaEkrani Where StokKodu=('" + stok + "')", stokbaglantisi);
            stokekle.ExecuteNonQuery();
            stokbaglantisi.Close();

            parcalar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstkkd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtprcad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbirim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmvctstk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmax.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txttmnt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnprcgncl_Click(object sender, EventArgs e)
        {


            string parca = txtprcad.Text;   
            string stok = txtstkkd.Text;     
            string mevcut = txtmvctstk.Text; 
            string birim = txtbirim.Text;    
            string max = txtmax.Text;      
            string teminat = txttmnt.Text;

            stokbaglantisi.Open();
            SqlCommand stokekle = new SqlCommand("UPDATE YoneticiParcaEkrani SET StokKodu = ('" + stok + "','" + parca + "','" + birim + "','" + mevcut + "','" + max + "','" + teminat + "')", stokbaglantisi);
            stokekle.ExecuteNonQuery();
            parcalar();


        }

        private void yntcgrup_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
