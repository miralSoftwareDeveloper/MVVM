   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MVVMMVVM  5   	       MVVM.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MVVM     5   	     � Title$  
MainWindow��5   	   $	��550��5	   	   $	��800��5
   	    � WindowStyle$ SingleBorderWindow=�5   	    � DataContext 5        MVVM.VMEmployees  5   
    � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value " CustomErrorControlOnErrorStyle ��Name � RowDefinitions	 �� Padding
 �� CornerRadius ��Name =� Errors��%�  &	        &	 S     �� 5   
   " ��6#   .�5      ��  � ��$ 2,40,0,0q�6'   6:   5      �� 5   
   " ��67   .�5      ��  � ��$ 55��6'   64   �� 5       � ��$	 2 1q�6(   66   �� 5       � ��$ 1q�60   6<   �� 5       � ��
 �����6@   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5!      �� $ placeholder��64   5+      5-      �� 5.       � �� 5/      �� 50      .R�51      �  52      �� 53   "   $
��Auto �60   6@   �� 54   "   $
��Auto �60   6@   .+�57      �� $��0��6%   #	 z��62   #��z��58   %   #��z��59   %   $
 3��5:   %   ._�5;   "   �� $ PART_ContentHost��6/   5<      �� 5=      $��1��5>   !   $��0,1,0,0q�5?   !   $��12(�5@   !   #��z 5A   !   $��2��6S   ��5C   "   �� 5D   &   .R�5E   *   �� 
���  ����6E   �� *ErrorContent+6f   5F   '   5H      5I      5J      5M      5O      5P      .��5Q      �  5R   
   �� 5S      $	��45* �6   6+   �� 5T      $	��10* �6   6+   �� 5U      $	��45* �6   6+   .+�5X   
   � $��0��6    � ColumnDefinitions 5Y      �� 5Z      $	��10* �6#   61   �� 5[      $	��90* �6#   61   .+�5]      �� $��0��6   .+�5^      �� $
��Name��6   $��2,8,0,0q�6'   6;   �� 5_      $��Address��6   #��[  6*   6P   �� 5`      $
��City��6   #��[  6)   6O   �� 5a      $��State��6   #��[  6)   6O   5b      �� 5c      -   5        $��
spEmployee��5c      $��1��6+    6;   ��  �� Mode$ OneWay=�.+�5f      �� -   5        $��txtName��5f      $��0,10,0,0q�5k   )   #��[ 5l   )   ��5g      ��  �� Path$ EmployeeName�$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�" �� ValidatesOnNotifyDataErrors$
 True��5l   )   �� 5m      -   5        $��
txtAddress��5n      $��0,10,0,0q�5p      #��[ 5q      ��5o      �� $ EmployeeAddess�$ TwoWay=�5q   O   �� 5r      -   5        $��txtCity��5s      $��0,10,0,0q�5u      #��[ 5v      ��5t      �� $ EmployeeCity�$ TwoWay=�5v   O   �� 5w      -   5        $��txtState��5x      $��0,10,0,0q�5z      #��[ 5{      ��5y      �� $ EmployeeState�$ TwoWay=�.��5{   M   5|      5}      5~      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5�      �� -   5        $��txtAdd��5�      $��30��5�      $	��150��5�      $��5q�5�      $	��Add��5�      ��5�      �� *
AddCommand+{�5�      �� *	CanCreate+��5�      ��  �� ElementName$ 
spEmployee��$ DataContext�5�   !   �� 5�      -   5        $��txtClear��5�      $��30��6%   $	��150��61   $��5q�6=   $��Clear��6H   6Z   5�      � 5�   
   $��2��6   .+�5�      &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��5�      $
��Auto��5�      $
��Auto��6   ��6-   �� *Listemployees+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Name+6a     5�      $ Address��6E   $
 Auto 6V    6)   �� *	Address+6e     5�      $
 City��6B   $
 Auto 6P    6)   �� *City+6_     5�      $ State��6C   $ * 6R    6)   �� *State+6^   5�      5�      5�      5�      