   M S B A M L   `   `   `  ����I  EModuloPricipal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ModuloPricipalModuloPricipal  5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5          ModuloPricipal.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ModuloPricipal     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  Login��5      $	��500��6   $	��400��6     � WindowState$ Normal=�6,    � WindowStyle$ 
ToolWindow=�6A    � WindowStartupLocation$ CenterScreen=�6Z   .��5      � ���	#FF2D2D30 � RowDefinitions 5   
   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6-   .+�5   
   �� $��imagenes\login-Door.png��6   $	��100��61   $	��100��6>   $��0��6J   $��0��6W   6i   �� 5   
   -   5        $��txt_user��5   9   $��35��6    �� 	MaxLength$ 10��6   $	��300��6-   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Ingrese un usuario��6w   $��5,5,5,5q�6�   $��20(�6�   $
��Bold"�6�   $��1��6�    �� TextAlignment$ Center=�6�   �� 5   
   $�� ��6   
�������$��20(�6.   $
��Bold"�6<   $��5,5,5,5q�6O   $��Center=�6`   $��2��6}   6�   G� 5   
   -   5        $��txt_pass��5   >   	 G� 	MaxLength$	 10��6   $��35��6&   $	��300��62    . $ Ingrese la contraseña��6|   $��20(�6�   $
��Bold"�6�   $��3��6�   6  �� 5   
   $��imagenes\Pass.png��6   $��70��6+   $��60��67   $��3��6C   $��325,1,-33,0q�6P   6g   � 5   
   $��4��6   $��Center=�6   
 � ColumnDefinitions
 5      �� 5      $
��auto �6#   62   �� 5       $
��auto �6#   62   �� 5!      $
��auto �6#   .+�5#      �� -   5        $��cmd_star��5#      $��Iniciar��6&   $
��Left=�68   $��5,5,5,5q�6S   $��20(�6d   $
��Bold"�6r   $	��150��6�   6�   5$      5(      5)      