using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteEmpresa clienteEmpresa = new ClienteEmpresa("Movistar", "00110022", "351000000", "movistar@gmail.com", "4519898", "Cordoba");
            MessageBox.Show(clienteEmpresa.ToString());
        }
    }
}
