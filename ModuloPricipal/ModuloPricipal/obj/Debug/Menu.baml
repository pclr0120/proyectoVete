   M S B A M L   `   `   `  ����I  EModuloPricipal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ModuloPricipalModuloPricipal  5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	          ModuloPricipal.Menu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ModuloPricipal     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	        � Title$
  Menu��5   	   $��727.556��6   ���	#FF2D2D30$
��1024��6>    � WindowStartupLocation$ CenterScreen=�6K    � WindowState$ 	Maximized=�6p   .��5      � ���	#FF22226C � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $	��100 �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   .+�5   
   !  MahApps.Metro.Controls.Tile  -   5        $��1��5   2   $��1��6?   $	��350��6P   $	��130��6\   
����+��   Title$ Ventas��6�      TitleFontSize$ 20Q�6�    J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!      .��5#      �� $��imagenes\PuntoVenta.png��6   $	��122��65   $	��140��6B   6P   5$        5%   
   $��1��6   $��2��6%   $	��250��66   $	��130��6B   
���   �$ Reportes��6b   $ 18Q�6s    5&        5'      .��5)      �� $��imagenes\Reportes.png��6   $	��122��63   $	��140��6@   6N   5*        5,   
   $ Mascota��6   $��2��6(   $��1��65   $
��Auto��6F   $	��130��6S   
���2͚�$ 20Q�6z   $��3,2,4,6q�6�    5-        5.      .��50      �� $��imagenes\Mascota.png��6   $	��122��62   $	��140��6?   6M   51        52   
   $ Clientes��6   $��3��6)   $��1��66   $
��Auto��6G   $	��130��6T   
���� ��$ 20Q�6v   $��3,2,4,6q�6�    53        54      .��56      �� $��imagenes\Cliente.png��6   $	��122��62   $	��140��6?   6M   57        58   
   $ 	Empleados��6   $��3��6*   $��2��67   $
��Auto��6H   $	��130��6U   $ 20Q�6c   $��3,2,4,6q�6v    59        5:      .��5<      �� $��imagenes\Empleado.png��6   $	��122��63   $	��140��6@   6N   5=        5>   
   $ Usuarios��6   $��2��6)   $��2��66   $
��Auto��6G   $	��130��6T   
����  �$ 20Q�6t   $��3,2,4,6q�6�    5?        5@      .��5B      �� $��imagenes\User.png��6   $	��122��6/   $	��140��6<   6J   5C        5D   
   $ Producto��6   $��1��6)   $��3��66   $
��Auto��6G   $	��130��6T   
��� � �$ 20Q�6u   $��3,2,4,6q�6�    5E        5F      .��5H      �� $��imagenes\Product.png��6   $	��122��62   $	��140��6?   6M   5I        5J   
   $ Proveedores��6   $��2��6,   $��3��69   $
��Auto��6J   $	��130��6W   
���  ��$ 20Q�6v   $��3,2,4,6q�6�    5K        5L      .��5N      �� $��imagenes\Product.png��6   $	��122��62   $	��140��6?   6M   5O        5P   
   -   5        $ Cerrar��5P      $��3��6>   $��3��6K   $
��Auto��6\   $	��130��6i   ���	#FF6E2D2D$ 20Q�6�   $��3,2,4,6q�6�    5Q        5R      .��5T      �� $��imagenes\Logout.png��6   $	��122��61   $	��140��6>   6L   5U      5Z      5[      