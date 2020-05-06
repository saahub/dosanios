using modelo.colecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using vista.ventanas;

namespace vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private clienteCollection coleccion;
        private contratoCollection coleccionContrato;

        public MainWindow()
        {
            InitializeComponent();
            coleccion = new clienteCollection();
            coleccionContrato = new contratoCollection(); ;

        }

        private void Btn_adm_clientes_Click(object sender, RoutedEventArgs e)
        {
            v_administrador_clientes vad_clientes = new v_administrador_clientes(coleccion, coleccionContrato);
            vad_clientes.Visibility = Visibility.Visible;
        }

        private void Btn_list_clientes_Click(object sender, RoutedEventArgs e)
        {
            v_listado_clientes vl_clientes = new v_listado_clientes(coleccion);
            vl_clientes.Visibility = Visibility.Visible;
        }

        private void Btn_adm_contratos_Click(object sender, RoutedEventArgs e)
        {
            v_administrador_contratos vad_contrato = new v_administrador_contratos(coleccion, coleccionContrato);
            vad_contrato.Visibility = Visibility.Visible;
        }

        private void Btn_list_contratos_Click(object sender, RoutedEventArgs e)
        {
            v_listado_contratos vl_contratos = new v_listado_contratos(coleccion, coleccionContrato);
            vl_contratos.Visibility = Visibility.Visible;
        }
    }
}
