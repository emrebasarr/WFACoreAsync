using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACoreAsync_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Topla(int sayi, int sayi2)
        {
            Thread.Sleep(5000);
            MessageBox.Show($"{sayi+sayi2}");
        }

        public void Cikar(int sayi, int sayi2)
        {
            MessageBox.Show($"{sayi - sayi2}");
        }

        Task ToplaAsync(int sayi, int sayi2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                //MessageBox.Show($"{sayi + sayi2}");

                //this.Invoke(() =>
                //{
                //    Text = $"{sayi + sayi2}";
                //});
            });
        }

        private async void btnTopla_Click(object sender, EventArgs e)
        {
            //Topla(3, 3);
            await ToplaAsync(3, 3);
            MessageBox.Show("Toplama Görevi başarılı bir şekilde gerçekleştirildi");
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            Cikar(5, 3);
        }
    }
}