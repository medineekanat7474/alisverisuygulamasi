﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisverisuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int birimfiyat, adet, toplamtutar;
            birimfiyat = Convert.ToInt32(txtBirimFiyat.Text);

            adet = Convert.ToInt32(txtAdet.Text);

            toplamtutar = birimfiyat * adet;
            lblToplamTutar.Text ="TOPLAM TUTAR: "+ toplamtutar.ToString();
        }
    }
}
