using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Negocios.Interfaces;

namespace Apresentacao
{
    public partial class Form1 : Form
    {
        IPedidoNegocios _pedidoNegocios = new PedidoNegocios();
       
        public Form1()
        {
            InitializeComponent();
        }
    }
}
