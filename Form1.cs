using DBLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace PreubasImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            PruebasContext context = new PruebasContext();
            var fileBase64 = Convert.ToBase64String(File.ReadAllBytes("hola.txt"));
            context.Pictures.Add(new Picture()
            {
               Base64String = fileBase64,
               Title = "hola.txt"
            });

            await context.SaveChangesAsync();
        }
    }
}
