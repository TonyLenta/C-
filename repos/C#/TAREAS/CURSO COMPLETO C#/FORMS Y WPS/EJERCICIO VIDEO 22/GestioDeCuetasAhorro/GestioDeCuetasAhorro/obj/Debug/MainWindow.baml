   M S B A M L   `   `   `  ����O  KGestioDeCuetasAhorro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GestioDeCuetasAhorroGestioDeCuetasAhorro  5   	   %    GestioDeCuetasAhorro.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GestioDeCuetasAhorro     5   	     � Title$  
MainWindow��5   	   $��789.962��6   $��646.053��6-   .��5	      � $��0,0,105,-111q�6    � RowDefinitions 5
   
   �� 5      $
��157* �6   �� 5      $
��483* �6   .+�5   
   �� $��Ingreso de datos��6   $
��Left=�6-   $	��147��6H   $	��Top=�6U   $	��513��6m   $��61,10,-41,0q�6y   .��5      �� -   5         ��Name$ btnAbrirCuenta��5      $��Abrir cuenta��6-   $��385,31,41,74q�6D   6Z   5      �� 5   
   $��Trasacciones��6   $
��Left=�6)   $	��110��6D   $��61,25,-41,0q�6Q   $	��Top=�6f   $	��513��6~   $��1��6�   .��5      �� $��	Historial��6   $
��Left=�6*   $	��185��6E   $��4,127,-1,-224q�6R   $	��Top=�6i   $	��498��6�   .��5      �� -   5         ��Name$ lstDeposito��5      $
��Left=�6/   $	��100��6J   $	��Top=�6W   $	��100��6o   $��	63,43,0,0q�6{   5      5      �� 5   
   $��Cliente:��6   $
��Left=�6#   $	��Top=�6>   $��	91,38,0,0q�6V   �� 5   
   -   5         ��Name$ txtMonto��5      $
��Left=�6$   $��23��6?    �� TextWrapping$
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��
197,95,0,0q�6�   6�   �� 5   
   -   5        $ 
txtCliente��5      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��
197,42,0,0q�6�   �� 5   
   -   5        $ 	btnRetiro��5      $��Retiro��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��
359,84,0,0q�6s   $��1��6�   6�   �� 5   
   -   5        $ btnDeposito��5      $��Deposito��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��
178,79,0,0q�6w   $��1��6�   6�   �� 5   
   $��	Depositos��6   $��156,184,307,273q�6$   $��1��6=   �� 5   
   $��Retiros��6   $��301,184,162,273q�6"   $��1��6;   �� 5   
   $��Saldo��6   $��476,229,10,228q�6    $��1��68   �� 5   
   -   5        $ btnNuevo��5      $��Nuevo��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��458,299,0,0q�6q   $��1��6�   6�   �� 5   
   $��Monto:��6   $
��Left=�6!   $	��Top=�6<   $��
100,92,0,0q�6T   �� 5    
   -   5        $ 
lstRetiros��5       $��271,229,162,328q�6&   $��1��6?   �� 5!   
   -	   5        $ 	txtSaldos��5!      $
��Left=�6%   $��23��6@   $
 Wrap=�6L   $	��Top=�6`   $	��120��6x   $��413,262,0,0q�6�   $��1��6�   5#      5$      