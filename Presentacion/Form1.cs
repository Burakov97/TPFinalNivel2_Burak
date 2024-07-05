using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MainWindow : Form
    {
        private List<Articulo> ListaArticulos;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ArticuloConexion datos = new ArticuloConexion();
            ListaArticulos = datos.listar();
            DgvArt.DataSource = ListaArticulos;

            //try
            //{
                PicArt.Load(ListaArticulos[0].Imagen);
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show("Imagen no disponible.");
            //}
        }

        private void DgvArt_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArt.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagen);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                PicArt.Load(imagen);
            }
            catch (Exception ex)
            {
                PicArt.Load("https://media.istockphoto.com/id/494033806/vector/computer-monitor-icon-on-a-blue-background-smoothseries.jpg?s=612x612&w=0&k=20&c=cFdNW60Vn13xBfnxSx2k40kDWPMNMtubaOIsMkzzf8s=");
            }
        }

    }
}
