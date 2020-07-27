using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace FacturxD
{
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT* FROM Usuarios WHERE id_usuario=" + VentanaLogin.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblNomAd.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

           pictureBox1.Image = Image.FromFile(url);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConP = new ContenedorPrincipal();
            this.Hide();
            ConP.Show();
        }
    }
}
