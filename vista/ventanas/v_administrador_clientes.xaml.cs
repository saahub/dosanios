using modelo.clases;
using Negocio.Negocio;
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
    /// Lógica de interacción para v_administrador_clientes.xaml
    /// </summary>
    public partial class v_administrador_clientes : Window
    {
        public clienteCollection coleccion;
        public contratoCollection coleccionContrato;


        public v_administrador_clientes()
        {
            InitializeComponent();
            LlenadoCmbActividad();
            LlenadoCmbTipo();

        }
        public v_administrador_clientes(clienteCollection coleccion, contratoCollection coleccionContrato)
        {
            InitializeComponent();
            LlenadoCmbActividad();
            LlenadoCmbTipo();
            this.coleccion = coleccion;
            this.coleccionContrato = coleccionContrato;
            btn_guardar_mod.IsEnabled = false;
            btn_traer_lista.Visibility = Visibility.Hidden;
            btn_buscar_rut.Visibility = Visibility.Hidden;
            btn_cancelarBusqueda_clientes.Visibility = Visibility.Hidden;
            btn_desplegar_todo.Visibility = Visibility.Hidden;
            btn_actualizar_cliente.IsEnabled = false;
            btn_guardar_mod.IsEnabled = false;
            btn_eliminar_cliente.IsEnabled = false;
            dtg_clientes.IsEnabled = false;
            DesplegarListaDtg();

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

            cmb_actividad_empresa.ItemsSource = listaActividad;
            cmb_actividad_empresa.Items.Refresh();
        }

        private void LlenadoCmbTipo()
        {
            List<tipoEmpresa> listaTipo = new List<tipoEmpresa>();

            listaTipo.Add(new tipoEmpresa(0, "SPA"));
            listaTipo.Add(new tipoEmpresa(1, "EIRL"));
            listaTipo.Add(new tipoEmpresa(2, "LIMITADA"));
            listaTipo.Add(new tipoEmpresa(3, "SOCIEDAD ANONIMA"));


            cmb_tipo_empresa.ItemsSource = listaTipo;
            cmb_tipo_empresa.Items.Refresh();
        }

        private void Btn_registrar_cliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReglaAdministradorCliente rAC = new ReglaAdministradorCliente();

                
                cliente cliente = new cliente();

                cliente.Rut = txt_rut.Text;
                cliente.RazonSocial = txt_razon_social.Text;
                cliente.NombreContacto = txt_nombre_contacto.Text;
                cliente.MailContacto = txt_mail_contacto.Text;
                cliente.Direccion = txt_direccion.Text;
                cliente.Telefono = txt_telefono.Text;
                cliente.Actividad = (actividadEmpresa)cmb_actividad_empresa.SelectedItem;
                cliente.Tipo = (tipoEmpresa)cmb_tipo_empresa.SelectedItem;

                if (!ValidarCampoVacio())
                {
                    try
                    {
                        rAC.ValidarCliente(txt_rut.Text);
                        coleccion.RegistrarCliente(cliente);
                        DesplegarListaDtg();
                        MessageBox.Show("CLIENTE: " + cliente.NombreContacto + " REGISTRADO CORRECTAMENTE");
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    DesplegarListaDtg();
                }

                else
                {
                    MessageBox.Show("NECESITA COMPLETAR TODOS LOS CAMPOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void DesplegarListaDtg()
        {
            dtg_clientes.ItemsSource = coleccion.ListaClientes;
            dtg_clientes.Items.Refresh();
        }

        public void BloquearAlBuscar()
        {
            txt_razon_social.IsEnabled = false;
            txt_nombre_contacto.IsEnabled = false;
            txt_mail_contacto.IsEnabled = false;
            txt_direccion.IsEnabled = false;
            txt_telefono.IsEnabled = false;
            cmb_actividad_empresa.IsEnabled = false;
            cmb_tipo_empresa.IsEnabled = false;
            btn_actualizar_cliente.IsEnabled = false;
            btn_guardar_mod.IsEnabled = false;
            btn_eliminar_cliente.IsEnabled = false;
        }

        public void DesbloquearAlBuscar()
        {
            txt_razon_social.IsEnabled = true;
            txt_nombre_contacto.IsEnabled = true;
            txt_mail_contacto.IsEnabled = true;
            txt_direccion.IsEnabled = true;
            txt_telefono.IsEnabled = true;
            cmb_actividad_empresa.IsEnabled = true;
            cmb_tipo_empresa.IsEnabled = true;
            btn_actualizar_cliente.IsEnabled = true;
            btn_eliminar_cliente.IsEnabled = true;

        }
    


        private void Btn_limpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txt_rut.Text = "";
            txt_razon_social.Text = "";
            txt_nombre_contacto.Text = "";
            txt_mail_contacto.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            cmb_actividad_empresa.SelectedItem = null;
            cmb_tipo_empresa.SelectedItem = null;
        }

        private bool ValidarCampoVacio()
        {
            bool validadorEspacio = false;

            if (txt_rut.Text == ""
              | txt_razon_social.Text == ""
              | txt_nombre_contacto.Text == ""
              | txt_mail_contacto.Text == ""
              | txt_direccion.Text == ""
              | txt_telefono.Text == ""
              | cmb_actividad_empresa.SelectedItem == null
              | cmb_tipo_empresa.SelectedItem == null)
            {
                validadorEspacio = true; 
            }
            return validadorEspacio;
        }

        private void Btn_buscar_rut_Click(object sender, RoutedEventArgs e)
        {
            DesbloquearAlBuscar();
            dtg_clientes.IsEnabled = true;
            List<cliente> clienteFiltradoRut = new List<cliente>();
            string rut = txt_rut.Text;

            try
            {
                coleccion.BuscarClienteRut(rut);
                clienteFiltradoRut.Add(coleccion.BuscarClienteRut(rut));
                dtg_clientes.ItemsSource = clienteFiltradoRut;
                dtg_clientes.Items.Refresh();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        
        private void Btn_buscar_cliente_Click(object sender, RoutedEventArgs e)
        {
            btn_traer_lista.Visibility = Visibility.Visible;
            btn_buscar_rut.Visibility = Visibility.Visible;
            btn_cancelarBusqueda_clientes.Visibility = Visibility.Visible;
            btn_desplegar_todo.Visibility = Visibility.Visible;
            btn_registrar_cliente.IsEnabled = false;
            BloquearAlBuscar();

        }

        private void Btn_eliminar_cliente_Click(object sender, RoutedEventArgs e)
        {
            DesbloquearAlBuscar();
            object filaSeleccionada = dtg_clientes.SelectedItem;

            if (filaSeleccionada != null)
            {
                if (filaSeleccionada.GetType() == typeof(cliente))
                {
                    try
                    {
                        cliente cliente = (cliente)filaSeleccionada;

                        if (cliente != null)
                        {
                            EliminarCliente(cliente.Rut);
                            DesplegarListaDtg();


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                
            }
        }

        public bool BuscarContratoRut(string rut)
        {
            bool validadorContrato = false;
            int indice = -1;

            for (int i = 0; i < coleccionContrato.ListaContratos.Count; i++)
            {
                if (coleccionContrato.ListaContratos[i].Cliente.Rut.Equals(rut))
                {
                    indice = i;
                    validadorContrato = true;

                }
            }
            return validadorContrato;

        }

        public void EliminarCliente(string rut)
        {
            DesbloquearAlBuscar();
            if (!BuscarContratoRut(rut))

            {
                int indice = -1;

                for (int i = 0; i < coleccion.ListaClientes.Count; i++)
                {
                    if (coleccion.ListaClientes[i].Rut.Equals(rut))
                    {

                        indice = i;

                    }
                }

                if (indice == -1)
                {
                    throw new Exception("ELEMENTO SELECCIONADO INVALIDO");
                }
                else
                {
                    coleccion.ListaClientes.RemoveAt(indice);
                    DesplegarListaDtg();
                    MessageBox.Show("CLIENTE ELIMINADO CON EXITO");

                }

            }

            else
            {
                MessageBox.Show("CLIENTE CON CONTRATO ASOCIADO - NO PUEDE ELIMINARSE");
            }

        }

        private void Btn_actualizar_cliente_Click(object sender, RoutedEventArgs e)
        {
            DesbloquearAlBuscar();
            txt_rut.IsEnabled = false;
            btn_registrar_cliente.IsEnabled = false;
            btn_guardar_mod.IsEnabled = true;

            object filaSeleccionada = dtg_clientes.SelectedItem;

            if (filaSeleccionada != null)
            {
                if (filaSeleccionada.GetType() == typeof(cliente))
                {
                    cliente cliente = (cliente)filaSeleccionada;
                    try
                    {
                        ActulizarDatosCliente(cliente);
                      

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("ELEMENTO SELECCIONADO INVALIDO");
                }
            }
           
        }

        public void ActulizarDatosCliente(cliente cliente)
        {
            txt_rut.Text = cliente.Rut;
            txt_razon_social.Text = cliente.RazonSocial;
            txt_nombre_contacto.Text = cliente.NombreContacto;
            txt_mail_contacto.Text = cliente.MailContacto;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            cmb_actividad_empresa.SelectedIndex= cliente.Actividad.Id;
            cmb_tipo_empresa.SelectedIndex = cliente.Tipo.Id;
        }

        private void Btn_guardar_mod_Click(object sender, RoutedEventArgs e)
        {
            cliente cliente = new cliente();

            cliente.Rut = txt_rut.Text;
            cliente.RazonSocial = txt_razon_social.Text;
            cliente.NombreContacto = txt_nombre_contacto.Text;
            cliente.MailContacto = txt_mail_contacto.Text;
            cliente.Direccion = txt_direccion.Text;
            cliente.Telefono = txt_telefono.Text;
            cliente.Actividad = (actividadEmpresa)cmb_actividad_empresa.SelectedItem;
            cliente.Tipo = (tipoEmpresa)cmb_tipo_empresa.SelectedItem;

            if (!ValidarCampoVacio())
            {
                try
                {
                    coleccion.GuardarModifCliente(cliente);
                    DesplegarListaDtg();
                    Limpiar();
                    txt_rut.IsEnabled = true;
                    btn_actualizar_cliente.IsEnabled = true;
                    btn_guardar_mod.IsEnabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DesplegarListaDtg();
            }

            else
            {
                MessageBox.Show("NECESITA COMPLETAR CAMPOS");
            }
        }

        private void Btn_traer_lista_Click(object sender, RoutedEventArgs e)
        {
            
            List<cliente> listaClientes = new List<cliente>();
            v_listado_clientes vl_clientes = new v_listado_clientes(coleccion, txt_rut, listaClientes);
            vl_clientes.Visibility = Visibility.Visible;
            vl_clientes.btn_hecho.Visibility = Visibility.Visible;
        }

        private void Btn_cancelarBusqueda_clientes_Click(object sender, RoutedEventArgs e)
        {
            btn_traer_lista.Visibility = Visibility.Hidden;
            btn_buscar_rut.Visibility = Visibility.Hidden;
            btn_cancelarBusqueda_clientes.Visibility = Visibility.Hidden;
            btn_desplegar_todo.Visibility = Visibility.Hidden;
            DesbloquearAlBuscar();
            DesplegarListaDtg();
            Limpiar();
            btn_actualizar_cliente.IsEnabled = false;
            btn_guardar_mod.IsEnabled = false;
            btn_eliminar_cliente.IsEnabled = false;
            dtg_clientes.IsEnabled = false;
            btn_registrar_cliente.IsEnabled = true;


        }

        private void Btn_desplegar_todo_Click(object sender, RoutedEventArgs e)
        {
            DesplegarListaDtg();
        }
    }

}















