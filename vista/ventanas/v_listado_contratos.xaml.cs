using modelo.clases;
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
using System.Windows.Shapes;

namespace vista.ventanas
{
    /// <summary>
    /// Lógica de interacción para v_listado_contratos.xaml
    /// </summary>
    public partial class v_listado_contratos : Window
    {
        
        public clienteCollection coleccion;
        public contratoCollection coleccionContrato;
        private TextBox numeroContrato;
        private List<contrato> contratoBusqueda;

        public v_listado_contratos()
        {
            InitializeComponent();
            DesplegarListaDtg();
        }

        public v_listado_contratos(clienteCollection coleccion, contratoCollection coleccionContrato)
        {
            InitializeComponent();
            this.coleccion = coleccion;
            this.coleccionContrato = coleccionContrato;
            DesplegarListaDtg();
            LlenadoCmbTipoEvento();
            rdb_filtro_rcontrato.IsChecked = true;
            txt_filtro_rcontrato.IsEnabled = true;
            txt_filtro_ncontrato.IsEnabled = false;
            cmb_filtro_econtrato.IsEnabled = false;
            btn_hecho_contratos.Visibility = Visibility.Hidden;
        }
        public v_listado_contratos(clienteCollection coleccion, contratoCollection coleccionContrato,
            TextBox numeroContrato, List<contrato> contratoBusqueda)
        {
            InitializeComponent();
            this.coleccion = coleccion;
            this.coleccionContrato = coleccionContrato;
            this.numeroContrato = numeroContrato;
            this.contratoBusqueda = contratoBusqueda;
            DesplegarListaDtg();
            LlenadoCmbTipoEvento();
            rdb_filtro_rcontrato.IsChecked = true;
            txt_filtro_rcontrato.IsEnabled = true;
            txt_filtro_ncontrato.IsEnabled = false;
            cmb_filtro_econtrato.IsEnabled = false;
            btn_hecho_contratos.Visibility = Visibility.Hidden;
        }

        public void DesplegarListaDtg()
        {
            dtg_contratos_lista.ItemsSource = coleccionContrato.ListaContratos;
            dtg_contratos_lista.Items.Refresh();
        }

        private void LlenadoCmbTipoEvento()
        {
            List<tipoEvento> listaEventos = new List<tipoEvento>();
            listaEventos.Add(new tipoEvento(0, "CENAS", 0, 0));
            listaEventos.Add(new tipoEvento(1, "COCKTAIL", 0, 0));
            listaEventos.Add(new tipoEvento(2, "COFFEEBREAK", 0, 0));

            cmb_filtro_econtrato.ItemsSource = listaEventos;
            cmb_filtro_econtrato.Items.Refresh();
        }

        public void SeleccionFiltro()
        {
            if (rdb_filtro_rcontrato.IsChecked == true)
            {
                txt_filtro_rcontrato.IsEnabled = true;
                txt_filtro_ncontrato.IsEnabled = false;
                txt_filtro_ncontrato.Text = "";
                cmb_filtro_econtrato.IsEnabled = false;
                cmb_filtro_econtrato.SelectedItem = null;

            }
            else if (rdb_filtro_ncontrato.IsChecked == true)
            {
                txt_filtro_ncontrato.IsEnabled = true;
                txt_filtro_rcontrato.Text = "";
                txt_filtro_rcontrato.IsEnabled = false;
                cmb_filtro_econtrato.IsEnabled = false;
                cmb_filtro_econtrato.SelectedItem = null;


            }
            else if (rdb_filtro_econtrato.IsChecked == true)
            {
                cmb_filtro_econtrato.IsEnabled = true;
                txt_filtro_rcontrato.Text = "";
                txt_filtro_rcontrato.IsEnabled = false;
                txt_filtro_ncontrato.Text = "";
                txt_filtro_ncontrato.IsEnabled = false;


            }
        }

        private void Rdb_filtro_rcontrato_Checked(object sender, RoutedEventArgs e)
        {
            SeleccionFiltro();
        }

        private void Rdb_filtro_ncontrato_Checked(object sender, RoutedEventArgs e)
        {
            SeleccionFiltro();
        }

        private void Rdb_filtro_econtrato_Checked(object sender, RoutedEventArgs e)
        {
            SeleccionFiltro();
        }

        private void Btn_filtro_contrato_Click(object sender, RoutedEventArgs e)
        {
            if (rdb_filtro_rcontrato.IsChecked == false && rdb_filtro_ncontrato.IsChecked == false
                && rdb_filtro_econtrato.IsChecked == false)
            {
                MessageBox.Show("POR FAVOR, SELECCIONE TIPO DE BUSQUEDA");
            }
            else
            {
                if (rdb_filtro_rcontrato.IsChecked == true)
                {
                    if (txt_filtro_rcontrato.Text != "")
                    {
                        try
                        {
                            List<contrato> contratoFiltradoRut = new List<contrato>();

                            string rut = txt_filtro_rcontrato.Text;

                            coleccionContrato.BuscarContratoRutLista(rut);
                            dtg_contratos_lista.ItemsSource = coleccionContrato.BuscarContratoRutLista(rut);
                            dtg_contratos_lista.Items.Refresh();
                        }
                        catch (Exception ex)
                        {
                            dtg_contratos_lista.ItemsSource = new List<contrato>();
                            dtg_contratos_lista.Items.Refresh();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("POR FAVOR INGRESE UN RUT A BUSCAR");
                    }
                }


                if (rdb_filtro_ncontrato.IsChecked == true)
                {
                    if (txt_filtro_ncontrato.Text != "")
                    {
                        try
                        {
                            List<contrato> contratoFiltradoNumero = new List<contrato>();
                            string numero = txt_filtro_ncontrato.Text;
                            coleccionContrato.BuscarContratonumero(numero);
                            contratoFiltradoNumero.Add(coleccionContrato.BuscarContratonumero(numero));
                            dtg_contratos_lista.ItemsSource = contratoFiltradoNumero;
                            dtg_contratos_lista.Items.Refresh();
                        }
                        catch (Exception ex)
                        {
                            dtg_contratos_lista.ItemsSource = new List<contrato>();
                            dtg_contratos_lista.Items.Refresh();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("POR FAVOR INGRESE EL NUMERO DE CONTRATO A BUSCAR");
                    }

                }

                if (rdb_filtro_econtrato.IsChecked == true)
                {
                    object tipoSeleccionado = cmb_filtro_econtrato.SelectedItem;

                    if (tipoSeleccionado != null)
                    {
                        tipoEvento tipo = (tipoEvento)tipoSeleccionado;
                        try
                        {

                            coleccionContrato.BuscarContratoTipo(tipo);
                            List<contrato> contradoFiltradoTipo = coleccionContrato.BuscarContratoTipo(tipo);
                                int cuenta = contradoFiltradoTipo.Count();

                                if (cuenta != 0)
                                {
                                    dtg_contratos_lista.ItemsSource = contradoFiltradoTipo;
                                    dtg_contratos_lista.Items.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("NO EXISTE TIPO DE EMPRESA ASOCIADO");
                                    dtg_contratos_lista.ItemsSource = contradoFiltradoTipo;
                                    dtg_contratos_lista.Items.Refresh();
                                }

                        }
                        catch (Exception ex)
                        {
                            dtg_contratos_lista.ItemsSource = new List<contrato>();
                            dtg_contratos_lista.Items.Refresh();
                            MessageBox.Show(ex.Message);
                        }
                    }

                    else
                    {
                        MessageBox.Show("NO HA SELECCIONADO UN TIPO PARA LA BUSQUEDA");
                    }

                }
            }

            
        }

        private void Btn_hecho_contratos_Click(object sender, RoutedEventArgs e)
        {
          

            object filaSeleccionada = dtg_contratos_lista.SelectedItem;

            if (filaSeleccionada != null)
            {
                if (filaSeleccionada.GetType() == typeof(contrato))
                {
                    contrato contrato = (contrato)filaSeleccionada;
                    this.contratoBusqueda.Add(contrato);
                    this.numeroContrato.Text = contrato.NumeroContrato;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ELEMENTO SELECCIONADO INVALIDO");
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN CONTRATO");
            }

            
        }

        private void Btn_limpiar_busContrato_Click(object sender, RoutedEventArgs e)
        {
            if (coleccion.ListaClientes.Count() == 0)
            {

                MessageBox.Show("NO HAY DATOS QUE MOSTRAR, FAVOR INGRESE CLIENTES");

            }
            else
            {
                txt_filtro_rcontrato.Text = "";
                txt_filtro_ncontrato.Text = "";
                cmb_filtro_econtrato.SelectedItem = null;
                DesplegarListaDtg();
            }
        }
    }
}
