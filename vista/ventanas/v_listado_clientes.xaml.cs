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
    /// Lógica de interacción para v_listado_clientes.xaml
    /// </summary>
    public partial class v_listado_clientes : Window
    {
        private clienteCollection coleccion;
        private TextBox rutbusqueda;
        private List<cliente> clienteBusqueda;


        public v_listado_clientes()
        {
            InitializeComponent();
            ActualizarDataGrid();
        }

        public v_listado_clientes(clienteCollection coleccion)
        {
            InitializeComponent();
            this.coleccion = coleccion;
            ActualizarDataGrid();
            LlenadoCmbActividad();
            LlenadoCmbTipo();
            cmb_filtro_actividad.IsEnabled = false;
            cmb_filtro_tipo.IsEnabled = false;
            btn_hecho.Visibility = Visibility.Hidden;

        }
        public v_listado_clientes(clienteCollection coleccion, TextBox rutbusqueda, List<cliente> clienteBusqueda)
        {
            InitializeComponent();
            this.coleccion = coleccion;
            ActualizarDataGrid();
            LlenadoCmbActividad();
            LlenadoCmbTipo();
            cmb_filtro_actividad.IsEnabled = false;
            cmb_filtro_tipo.IsEnabled = false;
            btn_hecho.Visibility = Visibility.Hidden;
            this.rutbusqueda = rutbusqueda;
            this.clienteBusqueda = clienteBusqueda;

        }

        private void ActualizarDataGrid()
        {
            dtg_clientes_lista.ItemsSource = coleccion.ListaClientes;
            dtg_clientes_lista.Items.Refresh();

        }


        private void LlenadoCmbActividad()
        {
            List<actividadEmpresa> listaActividad = new List<actividadEmpresa>();

            listaActividad.Add(new actividadEmpresa(0, "AGROPECUARIA"));
            listaActividad.Add(new actividadEmpresa(1, "MINERIA"));
            listaActividad.Add(new actividadEmpresa(2, "MANUFACTURA"));
            listaActividad.Add(new actividadEmpresa(3, "COMERCIO"));
            listaActividad.Add(new actividadEmpresa(4, "HOTELERIA"));
            listaActividad.Add(new actividadEmpresa(5, "ALIMENTOS"));
            listaActividad.Add(new actividadEmpresa(6, "TRASNPORTE"));
            listaActividad.Add(new actividadEmpresa(7, "SERVICIOS"));

            cmb_filtro_actividad.ItemsSource = listaActividad;
            cmb_filtro_actividad.Items.Refresh();
        }

        private void LlenadoCmbTipo()
        {
            List<tipoEmpresa> listaTipo = new List<tipoEmpresa>();

            listaTipo.Add(new tipoEmpresa(0, "SPA"));
            listaTipo.Add(new tipoEmpresa(1, "EIRL"));
            listaTipo.Add(new tipoEmpresa(2, "LIMITADA"));
            listaTipo.Add(new tipoEmpresa(3, "SOCIEDAD ANONIMA"));


            cmb_filtro_tipo.ItemsSource = listaTipo;
            cmb_filtro_tipo.Items.Refresh();
        }


        public void SeleccionFiltro()
        {
            if (rdb_rut.IsChecked == true)
            {
                txt_filtro_rut.IsEnabled = true;
                cmb_filtro_actividad.IsEnabled = false;
                cmb_filtro_actividad.SelectedItem = null;
                cmb_filtro_tipo.IsEnabled = false;
                cmb_filtro_tipo.SelectedItem = null;

            }
            else if (rdb_actividad.IsChecked == true)
            {
                cmb_filtro_actividad.IsEnabled = true;
                txt_filtro_rut.IsEnabled = false;
                txt_filtro_rut.Text = "";
                cmb_filtro_tipo.IsEnabled = false;
                cmb_filtro_tipo.SelectedItem = null;
            }
            else if (rdb_tipo.IsChecked == true)
            {
                cmb_filtro_tipo.IsEnabled = true;
                txt_filtro_rut.IsEnabled = false;
                txt_filtro_rut.Text = "";
                cmb_filtro_actividad.IsEnabled = false;
                cmb_filtro_actividad.SelectedItem = null;
            }
        }

        private void Rdb_rut_Checked(object sender, RoutedEventArgs e)
        {
            SeleccionFiltro();
            
        }

        private void Rdb_actividad_Checked(object sender, RoutedEventArgs e)
        {
            SeleccionFiltro();
        }

        private void Rdb_tipo_Checked(object sender, RoutedEventArgs e)
        {
            SeleccionFiltro();
        }

        private void Btn_filtro_buscar_Click(object sender, RoutedEventArgs e)
        {
            if (rdb_rut.IsChecked == false && rdb_actividad.IsChecked == false
                && rdb_tipo.IsChecked == false)
            {
                MessageBox.Show("POR FAVOR, SELECCIONE TIPO DE BUSQUEDA");
            }
            else
            {
                if (rdb_rut.IsChecked == true)
                {
                    if (txt_filtro_rut.Text != "")
                    {

                        try
                        {
                            List<cliente> clienteFiltradoRut = new List<cliente>();
                            string rut = txt_filtro_rut.Text;
                            coleccion.BuscarClienteRut(rut);
                            clienteFiltradoRut.Add(coleccion.BuscarClienteRut(rut));
                            dtg_clientes_lista.ItemsSource = clienteFiltradoRut;
                            dtg_clientes_lista.Items.Refresh();
                        }
                        catch (Exception ex)
                        {
                            dtg_clientes_lista.ItemsSource = new List<cliente>();
                            dtg_clientes_lista.Items.Refresh();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("POR FAVOR INGRESE UN RUT A BUSCAR");
                    }


                }


                if (rdb_actividad.IsChecked == true)
                {

                    object actividadSeleccionada = cmb_filtro_actividad.SelectedItem;

                    if (actividadSeleccionada != null)
                    {
                        actividadEmpresa actividad = (actividadEmpresa)actividadSeleccionada;
                        try
                        {

                            coleccion.BuscarClienteActividad(actividad);

                            List<cliente> clienteFiltradoActividad = coleccion.BuscarClienteActividad(actividad);
                            int cuenta = clienteFiltradoActividad.Count();

                            if (cuenta != 0)
                            {
                                dtg_clientes_lista.ItemsSource = clienteFiltradoActividad;
                                dtg_clientes_lista.Items.Refresh();
                                
                            }

                            else
                            {
                                MessageBox.Show("NO EXISTE ACTIVIDAD ASOCIADA");
                                dtg_clientes_lista.ItemsSource = clienteFiltradoActividad;
                                dtg_clientes_lista.Items.Refresh();
                            }

                        }
                        catch (Exception ex)
                        {
                            dtg_clientes_lista.ItemsSource = new List<cliente>();
                            dtg_clientes_lista.Items.Refresh();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO HA SELECCIONADO ACTIVIDAD PARA BUSQUEDA");
                    }

                }

                if (rdb_tipo.IsChecked == true)
                {
                    object tipoSeleccionado = cmb_filtro_tipo.SelectedItem;
                    if (tipoSeleccionado != null)
                    {
                        tipoEmpresa tipo = (tipoEmpresa)tipoSeleccionado;
                        try
                        {

                            coleccion.BuscarClienteTipo(tipo);
                            List<cliente> clienteFiltradoTipo = coleccion.BuscarClienteTipo(tipo);
                            int cuenta = clienteFiltradoTipo.Count();

                            if (cuenta != 0)
                            {
                                dtg_clientes_lista.ItemsSource = clienteFiltradoTipo;
                                dtg_clientes_lista.Items.Refresh();
                            }

                            else
                            {
                                MessageBox.Show("NO EXISTE TIPO ASOCIADO");
                                dtg_clientes_lista.ItemsSource = clienteFiltradoTipo;
                                dtg_clientes_lista.Items.Refresh();

                            }

                        }
                        catch (Exception ex)
                        {
                            dtg_clientes_lista.ItemsSource = new List<cliente>();
                            dtg_clientes_lista.Items.Refresh();
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
           

        

        private void Btn_hecho_Click(object sender, RoutedEventArgs e)
        {
           
            object filaSeleccionada = dtg_clientes_lista.SelectedItem;
            if (coleccion.ListaClientes.Count != 0)
            {

                if (filaSeleccionada != null)
                {
                    if (filaSeleccionada.GetType() == typeof(cliente))
                    {
                        cliente cliente = (cliente)filaSeleccionada;

                        this.clienteBusqueda.Add(cliente);
                        this.rutbusqueda.Text = cliente.Rut;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ELEMENTO SELECCIONADO INVALIDO");
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN CLIENTE");
                }
            }
            else
            {
                MessageBox.Show("NO EXISTEN CLIENTES REGISTRADOS");
            }
            
        }


        private void Btn_desplegar_todo_lc_Click(object sender, RoutedEventArgs e)
        {

            if (coleccion.ListaClientes.Count() == 0)
            {

                MessageBox.Show("NO HAY DATOS QUE MOSTRAR, FAVOR INGRESE CLIENTES");

            }
            else
            {
                txt_filtro_rut.Text = "";
                cmb_filtro_actividad.SelectedItem = null;
                cmb_filtro_tipo.SelectedItem = null;
                ActualizarDataGrid();
            }
            
        }











    }
}
