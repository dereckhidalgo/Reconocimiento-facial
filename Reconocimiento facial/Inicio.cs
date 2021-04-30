using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Reconocimiento f = new Frm_Reconocimiento();
            f.Show();
            
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
