using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_demo
{
    public partial class Form1 : Form
    {

        CustomerRepository CustomerR = new CustomerRepository();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnObtenerTodo_Click(object sender, EventArgs e)
        {
            var client = CustomerR.ObtenerTodo();
            dgvObenerTodo.DataSource = client;
        }
    }
}
