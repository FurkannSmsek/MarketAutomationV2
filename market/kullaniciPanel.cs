
using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class kullaniciPanel : Form
    {
        Controller controller = new Controller();
        public kullaniciPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kullaniciPanel_Load(object sender, EventArgs e)
        {
            defaultDegerleriDoldur();
            tumKullanicilariDoldur();
        }

        private void defaultDegerleriDoldur()
        {
            combo_yetki.Items.Add("Admin");
            combo_yetki.Items.Add("Kasiyer");
            combo_yetki.SelectedIndex = 0;

           

            combo_guvenlikSorusu.Items.Add("En Sevdiğiniz Hayvan");
            combo_guvenlikSorusu.Items.Add("En Sevdiğiniz Araba? ");
            combo_guvenlikSorusu.Items.Add("Birinci Sinif öğretmeninizin adı?");
            combo_guvenlikSorusu.Items.Add("Anneniniz kızlık soyadı?");

            combo_guvenlikSorusu.SelectedIndex = 0;
        }

        private void tumKullanicilariDoldur()
        {
            List<User> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = userList;
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.emailAdres = txt_emailAdres.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = combo_guvenlikCevabi.Text;
            
           LoginStatus sonuc = controller.kullaniciGuncelle(user);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi: ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenemedi! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.emailAdres = txt_emailAdres.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = combo_guvenlikCevabi.Text;

            LoginStatus sonuc = controller.kullaniciEkle(user);

            if(sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt EKlendi: ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void combo_bolge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_yetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emailAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_guvenlikSorusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_guvenlikCevabi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_kullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_emailAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            combo_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            combo_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combo_guvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
  
        }
    }
}
