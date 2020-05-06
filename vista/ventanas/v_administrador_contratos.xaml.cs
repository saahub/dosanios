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
    /// Lógica de interacción para v_administrador_contratos.xaml
    /// </summary>
    public partial class v_administrador_contratos : Window
    {
        public clienteCollection coleccion;
        public contratoCollection coleccionContrato;

        public v_administrador_contratos()
        {
            InitializeComponent();
            LlenadoCmbTipoEvento();
            txt_fecha_creacion.Text = DateTime.Now.ToShortDateString();
            txt_id_contrato.IsEnabled = false;


        }

        public v_administrador_contratos(clienteCollection coleccion, contratoCollection coleccionContrato)
        {
            InitializeComponent();
            LlenadoCmbTipoEvento();
            this.coleccion = coleccion;
            this.coleccionContrato = coleccionContrato;
            txt_fecha_creacion.Text = DateTime.Now.ToShortDateString();
            BloqueadoAlIniciar();
            OcultoAlIniciar();
            DesplegarListaDtg();
            TablaDatosBase();
            BloqueoTabla();
            txt_id_contrato.Text = GeneradorId();
            dtg_contratos.IsEnabled = false;
        }


        public void TablaDatosBase()
        {
            txt_valores_referenciaA.Text = "30";
            txt_valores_referenciaB.Text = "20";
            txt_valores_referenciaC.Text = "10";
            txt_personal_referenciaA.Text = "50";
            txt_personal_referenciaB.Text = "45";
            txt_personal_referenciaC.Text = "40";
        }

        public void BloqueoTabla()
        {
            txt_valores_referenciaA.IsEnabled = false; 
            txt_valores_referenciaB.IsEnabled = false;
            txt_valores_referenciaC.IsEnabled = false;
            txt_personal_referenciaA.IsEnabled = false;
            txt_personal_referenciaB.IsEnabled = false;
            txt_personal_referenciaC.IsEnabled = false;
        }

        private void LlenadoCmbTipoEvento()
        {
            List<tipoEvento> listaEventos = new List<tipoEvento>();
            listaEventos.Add(new tipoEvento(0, "CENAS", 0, 0));
            listaEventos.Add(new tipoEvento(1, "COCKTAIL", 0, 0));
            listaEventos.Add(new tipoEvento(2, "COFFEEBREAK", 0, 0));

            cmb_tipo_evento.ItemsSource = listaEventos;
            cmb_tipo_evento.Items.Refresh();

        }

        public void BloqueadoAlIniciar()
        {
            txt_id_contrato.IsEnabled = false;
            txt_fecha_creacion.IsEnabled = false;
            dtp_fecha_termino.IsEnabled = false;
         
            txt_valor_contrato.IsEnabled = false;
            txt_nombre_asociado.IsEnabled = false;
            btn_actualizar_contrato.IsEnabled = false;
            btn_guardarmodCont.IsEnabled = false;
            btn_confirm_contrato.IsEnabled = false;
            btn_terminar_contrato.IsEnabled = false;
        }

        public void OcultoAlIniciar()
        {
            lbl_numero_contratoBuscar.Visibility = Visibility.Hidden;
            txt_numero_contrato.Visibility = Visibility.Hidden;
            btn_buscarEnRegistro.Visibility = Visibility.Hidden;
            btn_listraer_contratos.Visibility = Visibility.Hidden;
            btn_cancelar_busqueda.Visibility = Visibility.Hidden;
            
        }

        public void BloquearAlBuscar()
        {
            dtp_inicio_evento.IsEnabled = false;
            dtp_termino_evento.IsEnabled = false;
            txt_asistentes.IsEnabled = false;
            txt_personal_adicional.IsEnabled = false;
            cmb_tipo_evento.IsEnabled = false;
            btn_valor_contrato.IsEnabled = false;
            txt_observaciones.IsEnabled = false;
            chk_vigencia.IsEnabled = false;
            btn_registrar_contrato.IsEnabled = false;
            txt_rut_asociado.IsEnabled = false;
            btn_verificar_rut.IsEnabled = false;
            btn_clientes_contrato.IsEnabled = false;
            btn_limpiar_contrato.IsEnabled = false;

        }

        public void DesbloquearAlVerificarContrato()
        {
            dtp_inicio_evento.IsEnabled = true;
            dtp_termino_evento.IsEnabled = true;
            txt_asistentes.IsEnabled = true;
            txt_personal_adicional.IsEnabled = true;
            cmb_tipo_evento.IsEnabled = true;
            btn_valor_contrato.IsEnabled = true;
            txt_observaciones.IsEnabled = true;
            chk_vigencia.IsEnabled = true;
            txt_rut_asociado.IsEnabled = true;
            btn_verificar_rut.IsEnabled = true;
            btn_clientes_contrato.IsEnabled = true;
            btn_actualizar_contrato.IsEnabled = true;
            btn_terminar_contrato.IsEnabled = true;
        }

        public string GeneradorId()
        {
            int anioHoy = DateTime.Now.Year;
            int mesHoy = DateTime.Now.Month;
            int diaHoy = DateTime.Now.Day;
            int horaHoy = DateTime.Now.Hour;
            int minHoy = DateTime.Now.Minute;

            string anio = Convert.ToString(anioHoy);
            string mes = Convert.ToString(mesHoy);
            string dia = Convert.ToString(diaHoy);
            string hora = Convert.ToString(horaHoy);
            string min = Convert.ToString(minHoy);

            if (mesHoy < 10)
            {
                mes = "0" + mes;
            }
            if (diaHoy < 10)
            {
                dia = "0" + dia;
            }
            if (horaHoy < 10)
            {
                hora = "0" + hora;
            }
            if (minHoy < 10)
            {
                min = "0" + min;
            }

            string idContrato = anio + mes + dia + hora + min;
            return idContrato;

        }


        private void Btn_registrar_contrato_Click(object sender, RoutedEventArgs e)
        {
            contrato contrato = new contrato();

            if (!ValidarEspacioVacio())
            {
               
                try
                {

                    contrato.NumeroContrato = txt_id_contrato.Text;
                    contrato.CreacionContrato = txt_fecha_creacion.Text;
                    contrato.FechaHorarioInicio = Convert.ToDateTime(dtp_inicio_evento.Text);
                    contrato.FechaHorarioTermino = Convert.ToDateTime(dtp_termino_evento.Text);
                    contrato.Asistentes = int.Parse(txt_asistentes.Text);
                    contrato.PersonalAdicional = int.Parse(txt_personal_adicional.Text);
                    if (chk_vigencia.IsChecked == true)
                    {
                        contrato.Vigencia = true;
                    }

                    contrato.ValorContrato = Convert.ToDouble(txt_valor_contrato.Text);
                    contrato.Observaciones = txt_observaciones.Text;
                    contrato.Evento = (tipoEvento)cmb_tipo_evento.SelectedItem;
                    contrato.Cliente = BuscarClienteRut(txt_rut_asociado.Text);
                    try
                    {
                        if (Convert.ToDateTime(dtp_inicio_evento.Text) > Convert.ToDateTime(dtp_termino_evento.Text))
                        {
                            MessageBox.Show("LA FECHA DE INICIO NO PUEDE SER POSTERIOR AL TERMINO DEL EVENTO");
                        }
                        else
                        {
                            coleccionContrato.RegistrarContrato(contrato);
                            DesplegarListaDtg();
                            Limpiar();
                            txt_id_contrato.Text = GeneradorId();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source = "DATOS DE ASISTENTES O PERSONAL ADICIONAL INVALIDOS");
                }
                
               
            }
            else
            {
                MessageBox.Show("FAVOR COMPLETE TODOS LOS CAMPOS");
            }

        }

        public void DesplegarListaDtg()
        {
            dtg_contratos.ItemsSource = coleccionContrato.ListaContratos;
            dtg_contratos.Items.Refresh();
        }

        public bool ValidarEspacioVacio()
        {
            bool validador = false;

            if (dtp_inicio_evento.Text == ""
             | dtp_termino_evento.Text == ""
             | txt_asistentes.Text == ""
             | txt_asistentes.Text == "0"
             | txt_personal_adicional.Text == ""
             | txt_personal_adicional.Text == "0"
             | cmb_tipo_evento.SelectedItem == null
             | txt_observaciones.Text == ""
             | txt_valor_contrato.Text == ""
             | chk_vigencia.IsChecked == false
             | txt_rut_asociado.Text == ""
             | txt_nombre_asociado.Text == "")
            {
                validador = true;
            }
            return validador;
        }

        private void Btn_valor_contrato_Click(object sender, RoutedEventArgs e)
        {
            if (txt_asistentes.Text == "" | txt_personal_adicional.Text == "")
            {
                MessageBox.Show("NECESITA INGRESAR DATOS PARA REALIZAR CALCULO DE SU CONTRATO");
            }
            else
            {

                int recargoAsistentes = 0;
                double recargoPersonal = 0;

                try
                {

                    int.Parse(txt_asistentes.Text);
                    int.Parse(txt_personal_adicional.Text);
                    int numeroAsistentes = int.Parse(txt_asistentes.Text);
                    int personalAdicional = int.Parse(txt_personal_adicional.Text);

                    if (numeroAsistentes >= 1 && numeroAsistentes <= 20)
                    {
                        recargoAsistentes = 3 + recargoAsistentes;
                    }
                    if (numeroAsistentes >= 21 && numeroAsistentes <= 50)
                    {
                        recargoAsistentes = 5 + recargoAsistentes;
                    }
                    if (numeroAsistentes > 50)
                    {
                        recargoAsistentes = ((numeroAsistentes - 50) / 20) * 2 + 5;
                    }



                        if (personalAdicional == 2)
                        {
                            recargoPersonal = 2 + recargoPersonal;
                        }
                        if (personalAdicional == 3)
                        {
                            recargoPersonal = 3 + recargoPersonal;
                        }
                        if (personalAdicional == 4)
                        {
                            recargoPersonal = 3.5 + recargoPersonal;
                        }
                        if (personalAdicional > 4)
                        {
                            recargoPersonal = (personalAdicional - 4) * 0.5 + 3.5;
                        }


                    object eventoSeleccionado = cmb_tipo_evento.SelectedItem;
                    tipoEvento evento = (tipoEvento)eventoSeleccionado;

                    int valorBaseEvento = 0;


                    if (cmb_tipo_evento.SelectedItem != null)
                    {
                        if (recargoAsistentes >= 0 | recargoPersonal >= 0 )
                        {
                            if (evento.Descripcion == "CENAS")
                            {
                                valorBaseEvento = 30;

                            }
                            if (evento.Descripcion == "COCKTAIL")
                            {
                                valorBaseEvento = 20;

                            }
                            if (evento.Descripcion == "COFFEEBREAK")
                            {
                                valorBaseEvento = 10;
                            }

                            if (personalAdicional == 1)
                            {
                                MessageBox.Show("EL PERSONAL ADICIONAL DEBE SER MAYOR A UNO");
                            }

                            else {
                                double valorTotalContrato = valorBaseEvento + recargoAsistentes + recargoPersonal;

                                txt_valor_contrato.Text = Convert.ToString(valorTotalContrato);
                            }
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE UN TIPO DE EVENTO ");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source = " FAVOR INGRESE SOLO NUMEROS ");
                }
            }


        }  
        

        

        
        private void Btn_verificar_rut_Click(object sender, RoutedEventArgs e)
        {
            cliente cliente = new cliente();
            cliente.Rut = txt_rut_asociado.Text;
            string rut = cliente.Rut;

            try
            {
                BuscarClienteRut(rut);
                txt_nombre_asociado.Text = BuscarClienteRut(rut).NombreContacto;
                MessageBox.Show("CLIENTE EXISTE");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public cliente BuscarClienteRut(string rut)
        {

            cliente cliente = new cliente();

            int indice = -1;

            for (int i = 0; i < coleccion.ListaClientes.Count; i++)
            {
                if (coleccion.ListaClientes[i].Rut.Equals(rut))
                { indice = i; }
            }

            if (indice == -1)
            {
                throw new Exception("NO SE HA ENCONTRADO CLIENTE EN SISTEMA");
            }
            else
            {
                cliente = coleccion.ListaClientes[indice];

            }

            return cliente;

        }

        private void Btn_limpiar_contrato_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            txt_id_contrato.Text = "";
            dtp_fecha_termino.Text = "";
            dtp_inicio_evento.Text = "";
            dtp_termino_evento.Text = "";
            txt_asistentes.Text = "";
            txt_personal_adicional.Text = "";
            cmb_tipo_evento.SelectedItem = null;
            txt_observaciones.Text = "";
            txt_valor_contrato.Text = "";
            chk_vigencia.IsChecked = false;
            txt_rut_asociado.Text = "";
            txt_nombre_asociado.Text = "";
            txt_id_contrato.Text = GeneradorId();


        }

        private void Btn_actualizar_contrato_Click(object sender, RoutedEventArgs e)
        {
            txt_rut_asociado.IsEnabled = false;
            txt_numero_contrato.IsEnabled = false;
            btn_verificar_rut.IsEnabled = false;
            btn_clientes_contrato.IsEnabled = false;
            btn_guardarmodCont.IsEnabled = true;

            object filaSeleccionada = dtg_contratos.SelectedItem;

            if (filaSeleccionada != null)
            {
                if (filaSeleccionada.GetType() == typeof(contrato))
                {
                    contrato contrato = (contrato)filaSeleccionada;
                    try
                    {
                       
                      ActulizarDatosContrato(contrato);
                    
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

        public void ActulizarDatosContrato(contrato contrato)
        {
            

            txt_id_contrato.Text = contrato.NumeroContrato;
            dtp_fecha_termino.Text = Convert.ToString(contrato.TerminoContrato);
            dtp_inicio_evento.Text = Convert.ToString(contrato.FechaHorarioInicio);
            dtp_termino_evento.Text = Convert.ToString(contrato.FechaHorarioInicio);
            txt_asistentes.Text = Convert.ToString(contrato.Asistentes);
            txt_personal_adicional.Text = Convert.ToString(contrato.PersonalAdicional);
            chk_vigencia.IsChecked = contrato.Vigencia;
            txt_valor_contrato.Text = Convert.ToString(contrato.ValorContrato);
            txt_observaciones.Text = contrato.Observaciones;
            txt_rut_asociado.Text = contrato.Cliente.Rut;
            txt_nombre_asociado.Text = contrato.Cliente.NombreContacto;
            cmb_tipo_evento.SelectedIndex = contrato.Evento.Id;

            
           
        }

        private void Btn_guardarmodCont_Click(object sender, RoutedEventArgs e)
        {

            contrato contrato = new contrato();


            if (!ValidarEspacioVacio())
            {
                try
                {
                    contrato.NumeroContrato = txt_id_contrato.Text;
                    contrato.CreacionContrato = txt_fecha_creacion.Text;
                    contrato.TerminoContrato = Convert.ToDateTime(dtp_fecha_termino.Text);
                    contrato.FechaHorarioInicio = Convert.ToDateTime(dtp_inicio_evento.Text);
                    contrato.FechaHorarioTermino = Convert.ToDateTime(dtp_termino_evento.Text);
                    contrato.Asistentes = int.Parse(txt_asistentes.Text);
                    contrato.PersonalAdicional = int.Parse(txt_personal_adicional.Text);

                    if (chk_vigencia.IsChecked == true)
                    {
                        contrato.Vigencia = true;
                    }

                    contrato.ValorContrato = Convert.ToDouble(txt_valor_contrato.Text);
                    contrato.Observaciones = txt_observaciones.Text;
                    contrato.Evento = (tipoEvento)cmb_tipo_evento.SelectedItem;
                    contrato.Cliente = BuscarClienteRut(txt_rut_asociado.Text);
                    try
                    {
                        if (Convert.ToDateTime(dtp_inicio_evento.Text) > Convert.ToDateTime(dtp_termino_evento.Text))
                        {
                            MessageBox.Show("LA FECHA DE INICIO NO PUEDE SER POSTERIOR AL TERMINO DEL EVENTO");
                        }
                        else
                        {
                            coleccionContrato.GuardarModifContrato(contrato);
                            DesplegarListaDtg();
                            Limpiar();
                            btn_guardarmodCont.IsEnabled = false;
                            txt_id_contrato.Text = GeneradorId();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source = "DATOS DE ASISTENTES O PERSONAL ADICIONAL INVALIDOS");
                }
            }
            else
            {
                MessageBox.Show("FAVOR COMPLETE TODOS LOS CAMPOS");
            }

        }

        private void Btn_buscar_contrato_Click(object sender, RoutedEventArgs e)
        {
            lbl_numero_contratoBuscar.Visibility = Visibility.Visible;
            txt_numero_contrato.Visibility = Visibility.Visible;
            btn_buscarEnRegistro.Visibility = Visibility.Visible;
            btn_listraer_contratos.Visibility = Visibility.Visible;
            btn_cancelar_busqueda.Visibility = Visibility.Visible;
            btn_refrescar_id.IsEnabled = false;
            BloquearAlBuscar();
        }

        private void Btn_buscarEnRegistro_Click(object sender, RoutedEventArgs e)
        {
            dtg_contratos.IsEnabled = true;
            DesbloquearAlVerificarContrato();
            btn_verificar_rut.IsEnabled = false;
            btn_clientes_contrato.IsEnabled = false;
            txt_rut_asociado.IsEnabled = false;
            chk_vigencia.IsEnabled = false;

            try
            {
                List<contrato> contratoFiltradoNumero = new List<contrato>();
                string numero = txt_numero_contrato.Text;
                coleccionContrato.BuscarContratonumero(numero);
                contratoFiltradoNumero.Add(coleccionContrato.BuscarContratonumero(numero));
                dtg_contratos.ItemsSource = contratoFiltradoNumero;
                dtg_contratos.Items.Refresh();
            }
            catch (Exception ex)
            {
                dtg_contratos.ItemsSource = new List<contrato>();
                dtg_contratos.Items.Refresh();
                MessageBox.Show(ex.Message);
            }

        }


        public void ActulizarVigencia(contrato contrato)
        {
            txt_id_contrato.Text = contrato.NumeroContrato;
            txt_id_contrato.IsEnabled = false;
            dtp_fecha_termino.Text = Convert.ToString(contrato.TerminoContrato);
            dtp_fecha_termino.IsEnabled = true;
            dtp_inicio_evento.Text = Convert.ToString(contrato.FechaHorarioInicio);
            dtp_inicio_evento.IsEnabled = false;
            dtp_termino_evento.Text = Convert.ToString(contrato.FechaHorarioInicio);
            dtp_termino_evento.IsEnabled = false;
            txt_asistentes.Text = Convert.ToString(contrato.Asistentes);
            txt_asistentes.IsEnabled = false;
            txt_personal_adicional.Text = Convert.ToString(contrato.PersonalAdicional);
            txt_personal_adicional.IsEnabled = false;
            chk_vigencia.IsChecked = contrato.Vigencia;
            txt_valor_contrato.Text = Convert.ToString(contrato.ValorContrato);
            txt_valor_contrato.IsEnabled = false;
            txt_observaciones.Text = contrato.Observaciones;
            txt_observaciones.IsEnabled = false;
            txt_rut_asociado.Text = contrato.Cliente.Rut;
            txt_rut_asociado.IsEnabled = false;
            txt_nombre_asociado.Text = contrato.Cliente.NombreContacto;
            txt_nombre_asociado.IsEnabled = false;
            cmb_tipo_evento.SelectedValue = contrato.Evento;
            cmb_tipo_evento.IsEnabled = false;

        }

       

        private void Btn_terminar_contrato_Click(object sender, RoutedEventArgs e)
        {

            txt_rut_asociado.IsEnabled = false;
            btn_confirm_contrato.IsEnabled = true;
            btn_valor_contrato.IsEnabled = false;
            chk_vigencia.IsEnabled = true;



            object filaSeleccionada = dtg_contratos.SelectedItem;

            if (filaSeleccionada != null)
            {
                if (filaSeleccionada.GetType() == typeof(contrato))
                {
                    contrato contrato = (contrato)filaSeleccionada;
                    try
                    {
                        contrato.TerminoContrato = DateTime.Now;

                        ActulizarVigencia(contrato);
                       
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

        private void Btn_confirm_contrato_Click(object sender, RoutedEventArgs e)
        {
            contrato contrato = new contrato();
            

            if (dtp_fecha_termino != null)
            { 
                contrato.NumeroContrato = txt_id_contrato.Text;
                contrato.CreacionContrato = txt_fecha_creacion.Text;
                contrato.TerminoContrato = Convert.ToDateTime(dtp_fecha_termino.Text);
                contrato.FechaHorarioInicio = Convert.ToDateTime(dtp_inicio_evento.Text);
                contrato.FechaHorarioTermino = Convert.ToDateTime(dtp_termino_evento.Text);
                contrato.Asistentes = int.Parse(txt_asistentes.Text);
                contrato.PersonalAdicional = int.Parse(txt_personal_adicional.Text);

                if (chk_vigencia.IsChecked == false)
                {
                    contrato.Vigencia = false;
                }

                contrato.ValorContrato = Convert.ToDouble(txt_valor_contrato.Text);
                contrato.Observaciones = txt_observaciones.Text;
                contrato.Evento = (tipoEvento)cmb_tipo_evento.SelectedItem;
                contrato.Cliente = BuscarClienteRut(txt_rut_asociado.Text);
                try
                {
                    
                        coleccionContrato.GuardarConfirmContrato(contrato);
                        btn_confirm_contrato.IsEnabled = false;
                        dtp_fecha_termino.IsEnabled = false;
                        txt_rut_asociado.IsEnabled = false;
                        DesplegarListaDtg();
                        Limpiar();
                        txt_id_contrato.Text = GeneradorId();
                        HabilitarAlConfirmar();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("FAVOR COMPLETE TODOS LOS CAMPOS");
            }

        }

        public void HabilitarAlConfirmar()
        {
           
            dtp_inicio_evento.IsEnabled = true;
            dtp_termino_evento.IsEnabled = true;
            txt_asistentes.IsEnabled = true;
            txt_personal_adicional.IsEnabled = true;
            txt_observaciones.IsEnabled = true;
            txt_rut_asociado.IsEnabled = true;
            cmb_tipo_evento.IsEnabled = true;
            btn_valor_contrato.IsEnabled = true;

        }

        private void Btn_cliente_contrato_Click(object sender, RoutedEventArgs e)
        {
            List<cliente> listaClientes = new List<cliente>();
            v_listado_clientes vl_clientes = new v_listado_clientes(coleccion, txt_rut_asociado, listaClientes);
            vl_clientes.Visibility = Visibility.Visible;
            vl_clientes.btn_hecho.Visibility = Visibility.Visible;

           
        }

        private void Btn_listraer_contratos_Click(object sender, RoutedEventArgs e)
        {
            List<contrato> listaContratos= new List<contrato>();
            v_listado_contratos vl_contratos = new v_listado_contratos(coleccion, coleccionContrato, txt_numero_contrato, listaContratos);
            vl_contratos.Visibility = Visibility.Visible;
            vl_contratos.btn_hecho_contratos.Visibility = Visibility.Visible;
        }

        private void Btn_cancelar_busqueda_Click(object sender, RoutedEventArgs e)
        {
            lbl_numero_contratoBuscar.Visibility = Visibility.Hidden;
            txt_numero_contrato.Visibility = Visibility.Hidden;
            txt_numero_contrato.Text = "";
            btn_buscarEnRegistro.Visibility = Visibility.Hidden;
            btn_listraer_contratos.Visibility = Visibility.Hidden;
            btn_cancelar_busqueda.Visibility = Visibility.Hidden;
            txt_rut_asociado.IsEnabled = true;
            btn_clientes_contrato.IsEnabled = true;
            btn_verificar_rut.IsEnabled = true;
            btn_actualizar_contrato.IsEnabled = false;
            btn_terminar_contrato.IsEnabled = false;
            btn_registrar_contrato.IsEnabled = true;
            btn_limpiar_contrato.IsEnabled = true;
            dtg_contratos.IsEnabled = false;
            btn_valor_contrato.IsEnabled = true;
            btn_refrescar_id.IsEnabled = true;
            dtp_fecha_termino.IsEnabled = false;
        }

        private void Btn_refrescar_id_Click(object sender, RoutedEventArgs e)
        {
            txt_id_contrato.Text = GeneradorId();
        }
    }


    
}

