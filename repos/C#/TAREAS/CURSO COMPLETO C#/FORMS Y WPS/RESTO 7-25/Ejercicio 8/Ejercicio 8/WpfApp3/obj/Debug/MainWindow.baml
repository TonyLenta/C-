   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  
MainWindow��5   	   $��469.5��6   $	��497��6+    � WindowStyle$ ThreeDBorderWindow=�67   $��Center=�6X   $��Center=�6s   .��5	      � $��0,0,-125,17q�6   $��Center=�6    $	��629��6=   $��Center=�6I    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� $��
Resultado:��6   $��Center=�6'   $	��164��6D   $��40,243,153,15q�6Q   $��Center=�6h   $	��436��6�   �� 5   
   $��Ingrese Temperatura��6   $��Center=�60   $	��164��6M   $��40,29,154,0q�6Z   $	��Top=�6o   $	��435��6�   �� 5   
   $��Temperatura��6   $
��Left=�6&   $��	78,62,0,0q�6A   $	��Top=�6T    J� RenderTransformOrigin$ -1.921,-2.538&�6l   �� 5   
   -   5         ��Name$ btnCalcular��5      $��Calcular��6&   $
��Left=�69   $��
372,62,0,0q�6T   $	��Top=�6h   $��79��6�   6�   �� 5   
   -   5        $ btnNuevo��5      $��Nuevo��6#   $
��Left=�63   $��372,103,0,0q�6N   $	��Top=�6c   $��79��6{   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��372,142,0,0q�6N   $	��Top=�6c   $��79��6{   6�   �� 5   
   -   5         ��Name$ txtTemperatura��5      $
��Left=�6*   $��23��6E   $��
78,104,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $��  ��6y   $	��Top=�6�   $	��192��6�   �� 5   
   $��Tipo de clima:��6   $
��Left=�6)   $��
78,273,0,0q�6D   $	��Top=�6X   $ -1.921,-2.538&�6p   �� 5   
   -   5        $ txtclima��5      $
��Left=�6$   $��24��6?   $��
78,304,0,0q�6K   $
 Wrap=�6_   $��  ��6s   $	��Top=�6}   $	��192��6�   5      5      