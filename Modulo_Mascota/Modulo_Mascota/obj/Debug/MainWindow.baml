   M S B A M L   `   `   `  ����I  EModulo_Mascota, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Modulo_MascotaModulo_Mascota  5   	       Modulo_Mascota.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Modulo_Mascota     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Registro Mascota>>>��5
   	   $��670.217��6%   $��676.667��66   ���	#FF8FE66E���	#FF8FE66E � 	Resources 5       
  Brush1 �� Color��%)   &	        �� 5   
   $ White��6)   5      .��5      � $��0,0,2,1q�6    � ColumnDefinitions 5   
   �� 5      $
��153* �6   �� 5      $
��470* �6   �� 5      $	��44* �6   .+�5   
   �� -   5         ��Name$ lblidMascota��5      $��Nombre:��6&   $
��Left=�68   $��
96,154,0,0q�6S   $	��Top=�6g   $	��132��6   $��34��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblidMascota_Copy��5      $��Especie:��6+   $
��Left=�6>   $��
96,188,0,0q�6Y   $	��Top=�6m   $	��132��6�   $��34��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblidMascota_Copy1��5      $��Raza:��6,   $
��Left=�6<   $��
96,222,0,0q�6W   $	��Top=�6k   $	��132��6�   $��34��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblidMascota_Copy2��5      $��Color:��6,   $
��Left=�6=   $��
96,256,0,0q�6X   $	��Top=�6l   $	��132��6�   $��34��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblidMascota_Copy3��5      $��Peso:��6,   $
��Left=�6<   $��
96,290,0,0q�6W   $	��Top=�6k   $	��142��6�   $��34��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblidMascota_Copy5��5      $��Señas Particulares:��6,   $
��Left=�6J   $��
90,424,0,0q�6e   $	��Top=�6y   $	��132��6�   $��24��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblidMascota_Copy6��5      $��Fecha Nacimiento:��6,   $
��Left=�6H   $��
90,468,0,0q�6c   $	��Top=�6w   $	��132��6�   $��24��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��20��6@   $��
27,154,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��274��6�   $��1��6�   �� 5   
   -	   5        $ 	txtSparti��5      $
��Left=�6%   $��20��6@   $��
93,428,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��208��6�   $��1��6�   �� 5   
   -
   5        $ txtPeso��5      $
��Left=�6#   $��20��6>   $��
27,290,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��274��6�   $��1��6�   �� 5   
   -   5        $ txtColor��5      $
��Left=�6$   $��20��6?   $��
27,256,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��274��6�   $��1��6�   �� 5    
   -   5        $ txtRaza��5       $
��Left=�6#   $��20��6>   $��
27,222,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��274��6�   $��1��6�   �� 5!   
   -   5        $ 
txtEspecie��5!      $
��Left=�6&   $��20��6A   $��
27,188,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��274��6�   $��1��6�   �� 5"   
   -   5         ��Name$ button��5"      $��Registrar Mascota>>>��6!   $��1��6I   $
��Left=�6Y   $��30��6t   $��328,550,0,0q�6�   $	��Top=�6�   $	��128��6�   6�   �� 5#   
   -   5        $ button_Copy��5#      $��Cancelar>>>��6&   $��1��6E   $
��Left=�6U   $��30��6p   $��328,592,0,0q�6|   $	��Top=�6�   $	��128��6�   6�   (  "System.Windows.Controls.DatePicker  5$   
   -   5        	  Name$	 dtpFechaNacimiento��5$      $
��Left=�61   $��26��6L   $��
93,466,0,0q�6X   $	��Top=�6l   $	��160��6�   $��1��6�   �� 5%   
   -   5        $ lblidMascota_Copy4��5%      $��ID-Cliente:��6,   $
��Left=�6B   $��	96,66,0,0q�6]   $	��Top=�6p   $	��132��6�   $��34��6�   $��Tahoma)�6�   $��14(�6�   $��2��6�   �� 5&   
   -   5        $ 
txtCliente��5&      $
��Left=�6&   $��20��6A   $��	27,72,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $��97��6�   $��1��6�   �� 5'   
   -   5        
 ��Name$
 groupBox��5'      $��2��6%   $
��Sexo��69   $
��Left=�6G   $��92��6b   $��102,314,0,0q�6n   $	��Top=�6�   $	��418��6�   
���   �.��5(      �� $��2,-11,-2,11q�6   .+�5)      	� -   5         	�Name$ radioButton��5)      $��Macho��63   $
��Left=�6C   $��	42,22,0,0q�6^   $	��Top=�6q    J� RenderTransformOrigin$ 1.272,1.937&�6�   $��25��6�   z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.       �� Angle$ -0.073Q�6.   T� 5/       T� X$ 0.024Q�61    T� Y$ -0.051Q�6;   50      52      	� 53      -   5        $ radioButton1��53      $��Hembra��64   $
��Left=�6E   $	��Top=�6`   $��42,0,0,0q�6x   $��71��6�   $��22��6�   54      55      �� 56   
   $
��auto��6   $
��auto��6   $��imagenes\Mascota.jpg��6+   $��270,10,10,520q�6I   $ 	0.557,0.3&�6`   $��1��6�   �� 57   
   -   5        $
 	groupBox1��57      $��3��6&   $��Datos Mascota:��6:   
���   �$
��Left=�6e   $	��408��6�   $��
71,123,0,0q�6�   $	��Top=�6�   $	��570��6�   59      5:      