   M S B A M L   `   `   `  ����@  <vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:vista.ventanasvista.ventanas  5   	   .    (vista.ventanas.v_administrador_contratos   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:vista.ventanas     5   	   -   5          �Name$  v_adm_contrato��5   	    � Title$+ %ON BREAK - ADMINISTRADOR DE CONTRATOS��5   	   $	��450��67   $
��1117��6D    � WindowStartupLocation$ CenterScreen=�6Q    � 
ResizeMode$ NoResize=�6v   .��5	      � ��5
   
   �� 5       �� ImageSource$9 3/vista;component/imagenes/logo_white_background.jpg��6    j� Stretch$ Uniform=�6[    �� Opacity$	 0.3Q�6m   .+�5   
   �� -   5         ��Name$ lbl_crear_contrato��5      $��DATOS CONTRATO��6,   $
��Left=�6E   $��12,1,0,0q�6`   $	��Top=�6r   $��Candara)�6�   $��18(�6�   $
��Bold"�6�   ���	#FF5394F36�   �� 5   
   -   5        $ lbl_creacion_fecha��5      $��FECHA CREACION CONTRATO��6,   $
��Left=�6N   $��
211,16,0,0q�6i   $	��Top=�6}   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        $ lbl_termino_fecha��5      $��FECHA TERMINO CONTRATO��6+   $
��Left=�6L   $��
400,15,0,0q�6g   $	��Top=�6{   $
��Bold"�6�   $��Candara)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtp_fecha_termino��5      $
��Left=�60   $��
399,37,0,0q�6K   $	��Top=�6_   $	��176��6w   $��24��6�   �� 5   
   -   5        	 ��Name$	 btn_registrar_contrato��5      $��REGISTRAR CONTRATO��61   $
��Left=�6N   $��358,370,0,0q�6i   $	��Top=�6~   $	��138��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6  �� 5   
   -   5        $ lbl_termino_evento��5      $��TERMINO EVENTO��6,   $
��Left=�6E   $��
208,94,0,0q�6`   $	��Top=�6t   $	��110��6�   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        $ lbl_inicio_evento��5      $��INICIO EVENTO��6+   $
��Left=�6C   $��	14,90,0,0q�6^   $	��Top=�6q   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -	   5        $ lbl_asistentes��5      $��ASISTENTES ��6(   $
��Left=�6>   $��
59,311,0,0q�6Y   $	��Top=�6m   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -
   5        $ lbl_personal_adicional��5      $��PERSONAL ADICIONAL ��60   $
��Left=�6N   $��	6,339,0,0q�6i   $	��Top=�6|   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        
 ��Name$
 txt_asistentes��5      $
��Left=�6*   $��23��6E   $��132,311,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $��53��6�    J� RenderTransformOrigin$ 0.488,0.478&�6�   �� 5   
   -   5        $
 txt_personal_adicional��5      $
��Left=�62   $��24��6M   $��132,339,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $��53��6�   �� 5   
   -   5         ��Name$ chk_vigencia��5      $��COMENZAR VIGENCIA��6)   $
��Left=�6E   $��429,207,0,0q�6`   $	��Top=�6u   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        $
 txt_valor_contrato��5      $
��Left=�6.   $��22��6I   $��131,367,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $��54��6�   �� 5   
   -   5        $ lbl_observaciones��5      $��OBSERVACIONES��6+   $
��Left=�6C   $��278,176,0,0q�6^   $	��Top=�6s   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        $
 txt_observaciones��5      $
��Left=�6-   $��29��6H   $��280,197,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��130��6�   �� 5   
   -   5        $
 txt_rut_asociado��5      $
��Left=�6,   $��23��6G   $��280,275,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��129��6�   �� 5   
   -   5        $ lbl_rut_asociado��5      $��CLIENTE A ASOCIAR��6*   $
��Left=�6F   $��276,233,0,0q�6a   $	��Top=�6v   $
��Bold"�6�   $��Candara)�6�   ���	#FF245DD86�   �� 5   
   -   5        $ lbl_nombre_asociado��5      $��NOMBRE CLIENTE��6-   $
��Left=�6F   $��278,299,0,0q�6a   $	��Top=�6v   $
��Bold"�6�   $��Candara)�6�   �� 5   
   -   5        $
 txt_nombre_asociado��5      $
��Left=�6/   $��27��6J   $��282,322,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��128��6�   �� 5    
   -   5        $	 btn_limpiar_contrato��5       $��LIMPIAR��6/   $
��Left=�6A   $��285,370,0,0q�6\   $	��Top=�6q   $��63��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6�   �� 5!   
   -   5         ��Name$ cmb_tipo_evento��5!      $
��Left=�6,   $��110,263,0,0q�6G   $	��Top=�6\   $��88��6t   �� 5"   
   -   5        $ lbl_rut_asociado_Copy��5"      $��TIPO DE EVENTO��6/   $
��Left=�6H   $��
10,263,0,0q�6c   $	��Top=�6w   $
��Bold"�6�   $��Candara)�6�   �� 5#   
   -   5        $	 btn_buscar_contrato��5#      $��HABILITAR BÚSQUEDA��6.   $
��Left=�6K   $��
593,49,0,0q�6f   $	��Top=�6z   $	��157��6�   $��29��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6  �� 5$   
   -   5        $
 txt_numero_contrato��5$      $
��Left=�6/   $��26��6J   $��594,103,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��155��6�   �� 5%   
   -   5        $ lbl_numero_contratoBuscar��5%      $��N ° CONTRATO��63   $
��Left=�6J   $��
594,80,0,0q�6e   $	��Top=�6y   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ dtg_contratos��5&      $
��Left=�6*   $	��158��6E   $��595,233,0,0q�6R   $	��Top=�6g   $	��433��6      AutoGenerateColumns .     
IsReadOnly . ���	#FFD0E3FF��5'   B   �� *ColeccionContrato+   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ NUMERO CONTRATO��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *NumeroContrato+  5*      $ FECHA CREACION��6%    6=   �� *CreacionContrato+  5+      $ FECHA TERMINO��6%    6<   �� *TerminoContrato+  5,      $ INICIO EVENTO��6%    6<   �� *FechaHorarioInicio+  5-      $ TERMINO EVENTO��6%    6=   �� *FechaHorarioTermino+  5.      $ 
ASISTENTES��6%    69   �� *
Asistentes+  5/      $ PERSONAL ADICIONAL��6%    6A   �� *PersonalAdicional+  50      $ VIGENCIA��6%    67   �� *
Vigencia+  51      $ VALOR CONTRATO (UF)��6%    6B   �� *ValorContrato+  52      $ OBSERVACIONES��6%    6<   �� *Observaciones+  53      $ RUT CLIENTE��6%    6:   �� *	Cliente+  54      $ TIPO EVENTO��6%    6:   �� *Evento+56      �� 57   
   -   5        $	 btn_actualizar_contrato��57      $��ACTUALIZAR CONTRATO��62   $
��Left=�6P   $��594,152,0,0q�6k   $	��Top=�6�   $	��154��6�   $��32��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6  �� 58   
   -   5        $	 btn_terminar_contrato��58      $��TERMINAR CONTRATO��60   $
��Left=�6L   $��595,197,0,0q�6g   $	��Top=�6|   $	��153��6�   $��29��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6  �� 59   
   -   5        $	 btn_valor_contrato��59      $��VALOR CONTRATO��6-   $
��Left=�6F   $��
11,368,0,0q�6a   $	��Top=�6u   $	��113��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6   �� 5:   
   -   5        $	 btn_guardarmodCont��5:      $��GUARDAR��6-   $
��Left=�6?   $��771,150,0,0q�6Z   $	��Top=�6o   $	��100��6�   ���	#FFFDB6B6���	#FF4B0F00���	#FF4B0F00$
��Bold"�6�   $��32��6  �� 5;   
   -    5        $	 btn_confirm_contrato��5;      $��	CONFIRMAR��6/   $
��Left=�6C   $��772,196,0,0q�6^   $	��Top=�6s   $	��100��6�   ���	#FFFDB6B6���	#FF4B0F00���	#FF4B0F28$
��Bold"�6   $��31��6  �� 5<   
   -!   5        $
 txt_fecha_creacion��5<      $
��Left=�6.   $��22��6I   $��
206,38,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��175��6�     5=   
   -"   5        $ dtp_inicio_evento��5=      $
��Left=�60   $��
17,116,0,0q�6K   $	��Top=�6_   $	��167��6w   $��25��6�     5>   
   -#   5        $ dtp_termino_evento��5>      $
��Left=�61   $��209,116,0,0q�6L   $	��Top=�6a   $	��170��6y   $��25��6�   �� 5?   
   -$   5        $ lbl_rut_asociado_Copy1��5?      $��UF��60   $
��Left=�6=   $��191,367,0,0q�6X   $	��Top=�6m   $
��Bold"�6�   $��Candara)�6�   �� 5@   
   -%   5        $	 btn_verificar_rut��5@      $��VERIFICAR RUT��6,   $
��Left=�6D   $��430,301,0,0q�6_   $	��Top=�6t   $	��147��6�   $��23��6�   ���	#FFFFF3A6���	#FF003DC1���	#FF245DD8$
��Bold"�6
  �� 5A   
   -&   5        $
 txt_id_contrato��5A      $
��Left=�6+   $��23��6F   $��	94,38,0,0q�6R   $
 Wrap=�6e   $	��Top=�6y   $��91��6�   �� 5B   
   -'   5        $ lbl_id_contrato��5B      $��ID GENERADO ��6)   $
��Left=�6@   $��	13,38,0,0q�6[   $	��Top=�6n   $
��Bold"�6�   $��Candara)�6�   �� 5C   
   -(   5        $	 btn_buscarEnRegistro��5C      $��VERIFICAR N°��6/   $
��Left=�6F   $��905,103,0,0q�6a   $	��Top=�6v   $	��102��6�   $��24��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6  $ 0.496,0.455&�6!  �� 5D   
   -)   5        $	 btn_cancelar_busqueda��5D      $��	FINALIZAR��60   $
��Left=�6D   $��
769,48,0,0q�6_   $	��Top=�6s   $	��237��6�   $��29��6�   ���	#FFFDB6B6���	#FF4B0F00���	#FF4B0F00$
��Bold"�6  �� 5E   
   -*   5        $ lbl_cotizacion��5E      $��COTIZACIÓN CONTRATO��6(   $
��Left=�6F   $��
11,144,0,0q�6a   $	��Top=�6u   $��Candara)�6�   $��18(�6�   $
��Bold"�6�   ���	#FF5394F36�   �� 5F   
   -+   5        $	 btn_clientes_contrato��5F      $��TRAER DESDE LISTA��60   $
��Left=�6L   $��430,271,0,0q�6g   $	��Top=�6|   $	��146��6�   $��26��6�   ���	#FFFFFFA6���	#FF003DC1���	#FF245DD8$
��Bold"�6�   6  �� 5G   
   -,   5        $	 btn_listraer_contratos��5G      $��TRAER DESDE LISTA��61   $
��Left=�6M   $��770,104,0,0q�6h   $	��Top=�6}   $	��120��6�   $
��Bold"�6�   ���	#FFFFFFA6���	#FF245DD8���	#FF245DD3$��23��6  �� 5H   
   $��RUT CLIENTE��6   $
��Left=�6&   $��278,255,0,0q�6A   $	��Top=�6V   $��Candara)�6n   $
��Bold"�6�   �� 5I   
   --   5        $
 txt_valores_refrenciaA��5I      $
��Left=�62   $��17��6M   $��
73,194,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF2478DC$
��Bold"�6�   $��Candara)�6�   �� 5J   
   -.   5        $
 txt_valores_referenciaB��5J      $
��Left=�63   $��17��6N   $��
73,213,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF003574$
��Bold"�6�   $��Candara)�6�   �� 5K   
   -/   5        $
 txt_valores_referenciaC��5K      $
��Left=�63   $��17��6N   $��
73,232,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF003574$��Candara)�6�   $
��Bold"�6   �� 5L   
   -0   5        $ lbl_cena��5L      $��CENAS��6"   $
��Left=�62   $��
24,191,0,0q�6M   $	��Top=�6a   $��37��6y   $��9(�6�   �� 5M   
   -1   5        $ lbl_cocktail��5M      $��COCKTAIL��6&   $
��Left=�69   $��
13,209,0,0q�6T   $	��Top=�6h   $��51��6�   $��9(�6�   �� 5N   
   -2   5        $ lbl_cofeebreak��5N      $��
COFEEBREAK��6(   $
��Left=�6=   $��	3,227,0,0q�6X   $	��Top=�6k   $��61��6�   $��9(�6�   �� 5O   
   -3   5        $ lbl_valor_base��5O      $��VALOR BASE 
       (UF)��6(   $
��Left=�6S   $��
64,164,0,0q�6n   $	��Top=�6�   $��79��6�   $��9(�6�   �� 5P   
   -4   5        $
 txt_valores_referenciaA��5P      $
��Left=�63   $��17��6N   $��
73,194,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF003574$
��Bold"�6�   $��Candara)�6�   �� 5Q   
   -5   5        $
 txt_personal_referenciaB��5Q      $
��Left=�64   $��17��6O   $��154,213,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF003574$
��Bold"�6�   $��Candara)�6�   �� 5R   
   -6   5        $
 txt_personal_referenciaC��5R      $
��Left=�64   $��17��6O   $��154,232,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF003574$��Candara)�6�   $
��Bold"�6  �� 5S   
   -7   5        $
 txt_personal_referenciaA��5S      $
��Left=�64   $��17��6O   $��154,194,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $��44��6�   ���	#FFD8FAFF���	#FF02B7D4���	#FF003574$
��Bold"�6�   $��Candara)�6�   �� 5T   
   -8   5        $ lbl_personal_base��5T      $"��PERSONAL BASE
   (PERSONAS)��6+   $
��Left=�6Z   $��138,165,0,0q�6u   $	��Top=�6�   $��79��6�   $��9(�6�   �� 5U   
   -9   5        $	 btn_refrescar_id��5U      $��REFRESCAR ID��6+   $
��Left=�6B   $��	94,64,0,0q�6]   $	��Top=�6p   $��90��6�   $��24��6�   ���	#FFFFF3A6���	#FF003DC1���	#FF245DD8$��Candara)�6�   $
��Bold"�6�   6  5W      5X      