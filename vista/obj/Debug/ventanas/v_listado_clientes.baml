   M S B A M L   `   `   `  ����@  <vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:vista.ventanasvista.ventanas  5   	   '    !vista.ventanas.v_listado_clientes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:vista.ventanas     5   	   -   5          �Name$  v_lista_clientes��5   	    � Title$! ON BREAK - LISTADO CLIENTES��5   	   $	��450��6-   $
��1117��6:    � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ NoResize=�6l   .��5	      � ��5
   
   �� 5       �� ImageSource$9 3/vista;component/imagenes/logo_white_background.jpg��6    j� Stretch$ Uniform=�6[    �� Opacity$	 0.5Q�6m   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_clientes_lista��5      $
��Left=�6/   $	��321��6J   $��
304,62,0,0q�6W   $	��Top=�6k   $	��700��6�      AutoGenerateColumns .  	   
IsReadOnly	 . ��5   A   �� *	Coleccion+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 RUT��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Rut+  5      $ RAZON SOCIAL��6%    6;   �� *RazonSocial+  5      $ NOMBRE CONTACTO��6%    6>   �� *NombreContacto+  5      $ MAIL CONTACTO��6%    6<   �� *MailContacto+  5      $ 	DIRECCION��6%    68   �� *	Direccion+  5      $ TELEFONO��6%    67   �� *
Telefono+  5      $ ACTIVIDAD EMPRESA��6%    6@   �� *	Actividad+  5      $ TIPO EMPRESA��6%    6;   �� *Tipo+5      	� 5   
   -   5         	�Name$ rdb_rut��5      $��RUT :��6'   $
��Left=�67   $��9,65,0,0q�6R   $	��Top=�6d   6|   	� 5   
   -   5        $ rdb_actividad��5      $��ACTIVIDAD EMPRESA :��6-   $
��Left=�6K   $��	8,124,0,0q�6f   $	��Top=�6y   6�   	� 5   
   -   5        $ rdb_tipo��5      $��TIPO EMPRESA :��6(   $
��Left=�6A   $��	8,179,0,0q�6\   $	��Top=�6o   6�   �� 5   
   -   5         ��Name$ txt_filtro_rut��5      $
��Left=�6*   $��23��6E   $��
160,63,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��128��6�   �� 5   
   -   5         ��Name$ cmb_filtro_actividad��5      $
��Left=�61   $��162,121,0,0q�6L   $	��Top=�6a   $	��129��6y   ���	#FF002893$
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        $ cmb_filtro_tipo��5      $
��Left=�6,   $��162,177,0,0q�6G   $	��Top=�6\   $	��129��6t   $��Candara)�6�   ���	#FF002893$
��Bold"�6�   �� 5    
   -	   5         ��Name$ btn_filtro_buscar��5       $��BUSCAR��6,   $
��Left=�6=   $��162,311,0,0q�6X   $	��Top=�6m   $	��131��6�   $��28��6�   ���	#FF003D95���	#FFFFF9BC���	#FF003D95$
��Bold"�6  $��Candara)�6  $��14(�6*  �� 5!   
   -
   5        $ 	btn_hecho��5!      $��HECHO��6$   $
��Left=�64   $��
890,28,0,0q�6O   $	��Top=�6c   $	��114��6{   $��27��6�   ���	#FFFFF5CA���	#FF06467C���	#FF06467C$
��Bold"�6�   $��Candara)�6�   6   �� 5"   
   -   5         ��Name$ tbl_filtro_utilizar��5"      $
��Left=�61   $��	58,31,0,0q�6L   $
��Wrap=�6_   $	��Top=�6s   $	��275��6�   $��Candara)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF0078DC�� 6�   $�SELECCIONE EL FILTRO A ��6�   �� 6	  $�U��6  �� 6  $�T��6  �� 6'  $�I��6+  �� 66  $�LIZAR��6:  6J  �� 5#   
   -   5        $ tbl_registro_lista��5#      $
��Left=�60   $��
565,32,0,0q�6K   $
��Wrap=�6_   $	��Top=�6s   $	��200��6�   $��REGISTROS ALMACENADOS��6�   $
��Bold"�6�   $��Candara)�6�   ���	#FF0078DC$��16(�6�   �� 5$   
   -   5        $ btn_desplegar_todo_lc��5$      $��LIMPIAR BÚSQUEDA��60   $
��Left=�6K   $��130,350,0,0q�6f   $	��Top=�6{   $	��163��6�   $��31��6�   ���	#FFFFF9BC���	#FF003D95���	#FF003D95$
��Bold"�6�   $��Candara)�6  $��14(�6  6&  5&      5'      