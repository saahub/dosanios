   M S B A M L   `   `   `  ����@  <vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:vista.ventanasvista.ventanas  5   	   -    'vista.ventanas.v_administrador_clientes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:vista.ventanas     5   	   -   5          �Name$  v_adm_clientes��5   	    � Title$* $ON BREAK - ADMINISTRADOR DE CLIENTES��5   	   $	��450��66   $
��1117��6C    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ NoResize=�6u   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6    � ColumnDefinitions 5
   
   �� 5      $
��547* �6   �� 5      $	��49* �6   ��5   
   �� 5       �� ImageSource$9 3/vista;component/imagenes/logo_white_background.jpg��6    j� Stretch$ Uniform=�6[    �� Opacity$
 0.35Q�6m   .+�5   
   �� -   5        	 ��Name$	 lbl_rut��5      $
��RUT ��6!   $
��Left=�60   $��	13,43,0,0q�6K   $	��Top=�6^   $
��Bold"�6v   $��11(�6�   �� 5   
   -   5        $	 lbl_razon_social��5      $��RAZON SOCIAL��6*   $
��Left=�6A   $��	13,81,0,0q�6\   $	��Top=�6o   $
��Bold"�6�   $��11(�6�   �� 5   
   -   5        $	 lbl_nombre_contacto��5      $��NOMBRE CONTACTO��6-   $
��Left=�6G   $��
13,124,0,0q�6b   $	��Top=�6v   $
��Bold"�6�   $��11(�6�   �� 5   
   -   5        $	 lbl_mail_contacto��5      $��MAIL CONTACTO��6+   $
��Left=�6C   $��146,126,0,0q�6^   $	��Top=�6s   $
��Bold"�6�   $��11(�6�   �� 5   
   -   5        $	 lbl_direccion��5      $��	DIRECCION��6'   $
��Left=�6;   $��
16,163,0,0q�6V   $	��Top=�6j   $
��Bold"�6�   $��11(�6�   �� 5   
   -   5        $	 lbl_telefono��5      $��TELEFONO��6&   $
��Left=�69   $��147,164,0,0q�6T   $	��Top=�6i   $
��Bold"�6�   $��11(�6�   �� 5   
   -   5        $	 lbl_actividad_empresa��5      $��ACTIVIDAD EMPRESA��6/   $
��Left=�6K   $��
16,203,0,0q�6f   $	��Top=�6z   $
��Bold"�6�   $��11(�6�   �� 5   
   -	   5        $	 lbl_tipo_empresa��5      $��TIPO EMPRESA��6*   $
��Left=�6A   $��146,203,0,0q�6\   $	��Top=�6q   $
��Bold"�6�   $��11(�6�   �� 5   
   -
   5        
 ��Name$
 txt_rut��5      $
��Left=�6#   $��23��6>   $��	18,62,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��118��6�   �� 5   
   -   5        $
 txt_razon_social��5      $
��Left=�6,   $��24��6G   $��
19,103,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��118��6�   �� 5   
   -   5        $
 txt_nombre_contacto��5      $
��Left=�6/   $��23��6J   $��
19,146,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��118��6�   �� 5   
   -   5        $
 txt_mail_contacto��5      $
��Left=�6-   $��23��6H   $��150,146,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $
 txt_direccion��5      $
��Left=�6)   $��23��6D   $��
19,184,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��119��6�   �� 5   
   -   5        $
 txt_telefono��5      $
��Left=�6(   $��23��6C   $��150,185,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5         ��Name$ cmb_actividad_empresa��5      $
��Left=�62   $��
18,224,0,0q�6M   $	��Top=�6a   $	��119��6y   �� 5    
   -   5        $ cmb_tipo_empresa��5       $
��Left=�6-   $��151,224,0,0q�6H   $	��Top=�6]   $	��119��6u   $��23��6�   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ dtg_clientes��5!      $
��Left=�6)   $	��327��6D   $��
550,58,0,0q�6Q   $	��Top=�6e   $	��487��6}      AutoGenerateColumns .     
IsReadOnly . $��2��5"   ]   ���	#FFE0F5FF��6;   �� *	Coleccion+   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$	 RUT��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Rut+  5%      $ RAZON SOCIAL��6%    6;   �� *RazonSocial+  5&      $ NOMBRE CONTACTO��6%    6>   �� *NombreContacto+  5'      $ MAIL CONTACTO��6%    6<   �� *MailContacto+  5(      $ 	DIRECCION��6%    68   �� *	Direccion+  5)      $ TELEFONO��6%    67   �� *
Telefono+  5*      $ ACTIVIDAD EMPRESA��6%    6@   �� *	Actividad+  5+      $ TIPO EMPRESA��6%    6;   �� *Tipo+5-      �� 5.   
   -   5         ��Name$ btn_registrar_cliente��5.      $��	REGISTRAR��60   $
��Left=�6D   $��322,258,0,0q�6_   $	��Top=�6t   $	��184��6�   ���	#FFFFFFC1���	#FF22379E���	#FF363793$
��Bold"�6  $��20��6  �� 5/   
   -   5        $ btn_buscar_rut��5/      $��
BUSCAR RUT��6)   $
��Left=�6>   $��
175,62,0,0q�6Y   $	��Top=�6m   $��91��6�   $��23��6�   ���	#FF22379E���	#FFFFFFC1$
��Bold"�6�   ���	#FF22379E6�   �� 50   
   -   5        $ btn_buscar_cliente��50      $��HABILITAR BUSQUEDA��6-   $
��Left=�6J   $��
325,63,0,0q�6e   $	��Top=�6y   $	��183��6�   $��24��6�   ���	#FFFFFFC1���	#FF223793$
��Bold"�6�   ���	#FF22379E6
  �� 51   
   -   5        $ btn_actualizar_cliente��51      $��
ACTUALIZAR��61   $
��Left=�6F   $��
19,292,0,0q�6a   $	��Top=�6u   $	��119��6�   ���	#FFFFFFC1���	#FF22379E���	#FF363793$
��Bold"�6  �� 52   
   -   5        $ btn_eliminar_cliente��52      $��ELIMINAR��6/   $
��Left=�6B   $��
19,329,0,0q�6]   $	��Top=�6q   $	��118��6�   ���	#FFFFFFC1���	#FF22379E���	#FF363793$
��Bold"�6�   �� 53   
   -   5        $ btn_guardar_mod��53      $��GUARDAR��6*   $
��Left=�6<   $��150,292,0,0q�6W   $	��Top=�6l   $	��118��6�   ���	#FFFFB2B2���	#FF420000���	#FF420000$
��Bold"�6�   �� 54   
   -   5        $ btn_limpiar��54      $��LIMPIAR��6&   $
��Left=�68   $��321,293,0,0q�6S   $	��Top=�6h   $	��184��6�   ���	#FFFFFFC1���	#FF22379E���	#FF363793$
��Bold"�6�   $��19��6�   �� 55   
   -   5         ��Name$ tbl_datos_cliente��55      $
��Left=�6/   $��	18,17,0,0q�6J   $
��Wrap=�6]   $��DATOS CLIENTE - EMPRESA��6q   $	��Top=�6�   $
��Bold"�6�   $��Candara)�6�   $��16(�6�   ���	#FF0094E86�   �� 56   
   -   5        $ btn_traer_lista��56      $��TRAER DESDE LISTA��6*   $
��Left=�6F   $��325,100,0,0q�6a   $	��Top=�6v   $	��182��6�   $��23��6�   $
��Bold"�6�   ���	#FFFFFFC1���	#FF22379E���	#FF22379E6�   �� 57   
   -   5        $# btn_cancelarBusqueda_clientes��57      $��
FINALIZAR ��68   $
��Left=�6M   $��326,183,0,0q�6h   $	��Top=�6}   $	��181��6�   $��24��6�   ���	#FFFFB2B2���	#FF340000���	#FF420000$
��Bold"�6�   $��Candara)�6  $��14(�6  6(  �� 58   
   -   5        $ btn_desplegar_todo��58      $��REFRESCAR BUSQUEDA��6-   $
��Left=�6J   $��326,146,0,0q�6e   $	��Top=�6z   $	��181��6�   $��22��6�   ���	#FFFFFFC1���	#FF2237A2���	#FF2237A2$
��Bold"�6�   $��Candara)�6  $��14(�6  6%  �� 59   
   -   5        $ tbl_mas_opciones��59      $
��Left=�6.   $��
20,262,0,0q�6I   $
��Wrap=�6]   $��MÁS OPCIONES��6q   $	��Top=�6�   $
��Bold"�6�   $��Candara)�6�   $��16(�6�   ���	#FF0094E86�   �� 5:   
   -   5        $ tbl_opciones_busqueda��5:      $
��Left=�63   $��
324,17,0,0q�6N   $
��Wrap=�6b   $	��Top=�6v   $
��Bold"�6�   $��Candara)�6�   $��16(�6�   ���	#FF0094E8�� 6�   $�OPCIONES DE ��6�   �� 6�   $�B��6�   �� 6  $�Ú��6  �� 6  $�SQUEDA��6  6(  �� 5;   
   -    5        $ tbl_registros_alamcenados��5;      $
��Left=�67   $��
700,16,0,0q�6R   $
��Wrap=�6f   $	��Top=�6z   $
��Bold"�6�   $��Candara)�6�   $��16(�6�   ���	#FF0094E8$��REGISTROS ALMACENADOS��6�   5=      5>      