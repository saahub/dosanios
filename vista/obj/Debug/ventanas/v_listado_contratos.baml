   M S B A M L   `   `   `  ����@  <vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:vista.ventanasvista.ventanas  5   	   (    "vista.ventanas.v_listado_contratos   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:vista.ventanas     5   	   -   5          �Name$  v_listar_contrato��5   	    � Title$# ON BREAK - LISTADO CONTRATOS ��5   	   $	��450��6/   $
��1117��6<    � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_   .��5	      � ��5
   
   �� 5       �� ImageSource$? 9/vista;component/imagenes/logo_transparent_background.png��6    j� Stretch$ Uniform=�6a    �� Opacity$
 0.35Q�6s   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_contratos_lista��5      $
��Left=�60   $	��289��6K   $��
328,88,0,0q�6X   $	��Top=�6l   $	��632��6�      AutoGenerateColumns .  	   
IsReadOnly	 . ��5   A   �� *ColeccionContrato+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ NUMERO CONTRATO��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *NumeroContrato+  5      $ FECHA CREACION��6%    6=   �� *CreacionContrato+  5      $ FECHA TERMINO��6%    6<   �� *TerminoContrato+  5      $ INICIO EVENTO��6%    6<   �� *FechaHorarioInicio+  5      $ TERMINO EVENTO��6%    6=   �� *FechaHorarioTermino+  5      $ 
ASISTENTES��6%    69   �� *
Asistentes+  5      $ PERSONAL ADICIONAL��6%    6A   �� *PersonalAdicional+  5      $ VIGENCIA��6%    67   �� *
Vigencia+  5      $ VALOR CONTRATO (UF)��6%    6B   �� *ValorContrato+  5      $ OBSERVACIONES��6%    6<   �� *Observaciones+  5      $ RUT CLIENTE��6%    6:   �� *	Cliente+  5      $ TIPO EVENTO��6%    6:   �� *Evento+5      	� 5   
   -   5         	�Name$ rdb_filtro_rcontrato��5      $��RUT CLIENTE :��64   $
��Left=�6L   $��	14,93,0,0q�6g   $	��Top=�6z   6�   	� 5   
   -   5        $ rdb_filtro_ncontrato��5      $��NUMERO CONTRATO :��64   $
��Left=�6P   $��
14,149,0,0q�6k   $	��Top=�6   6�   	� 5    
   -   5        $ rdb_filtro_econtrato��5       $��TIPO EVENTO :��64   $
��Left=�6L   $��
14,207,0,0q�6g   $	��Top=�6{   6�   �� 5!   
   -   5         ��Name$ txt_filtro_rcontrato��5!      $
��Left=�60   $��23��6K   $��
165,91,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��141��6�   �� 5"   
   -   5        $ txt_filtro_ncontrato��5"      $
��Left=�60   $��23��6K   $��165,144,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��141��6�   �� 5#   
   -   5         ��Name$ cmb_filtro_econtrato��5#      $
��Left=�61   $��165,202,0,0q�6L   $	��Top=�6a   $	��140��6y   �� 5$   
   -	   5         ��Name$ btn_filtro_contrato��5$      $��BUSCAR��6.   $
��Left=�6?   $��194,291,0,0q�6Z   $	��Top=�6o   $	��111��6�   $��32��6�   ���	#FFF4FF87���	#FF001B95���	#FF001B95$
��Bold"�6  $��Candara)�6  $��14(�6.  �� 5%   
   -
   5        $ btn_hecho_contratos��5%      $��HECHO��6.   $
��Left=�6>   $��
860,54,0,0q�6Y   $	��Top=�6m   $	��100��6�   $��29��6�   $
��Bold"�6�   $��Candara)�6�   ���	#FF06367A���	#FF06367A���	#FFFFF7C76
  �� 5&   
   -   5        $ btn_limpiar_busContrato��5&      $��LIMPIAR BÚSQUEDA��62   $
��Left=�6M   $��162,345,0,0q�6h   $	��Top=�6}   $	��144��6�   $��32��6�   ���	#FFF4FF87���	#FF001B95���	#FF001B95$
��Bold"�6�   $��Candara)�6  $��14(�6  6(  �� 5'   
   $
��Left=�6   $��	54,32,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��Candara)�6n   $
��Bold"�6�   ���	#FF4769FF$��16(�6�   �� 6�   $%�SELECCIONE EL FILTRO A UTILIZAR��6�   �� 6�   �� 6�   6�   �� 5(   
   $
��Left=�6   $��
560,31,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��Candara)�6o   $
��Bold"�6�   ���	#FF4769FF$��16(�6�   $��26��6�   �� 6�   $�REGISTROS ALMACENADOS��6�   �� 6�   �� 6�   6�   5*      5+      