   M S B A M L   `   `   `  ����A  =TaskUS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TaskUSTaskUS  5   	       TaskUS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:TaskUS     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6A   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��1��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF8C809B��6#    � Offset$ 1Q�65   � 5      $ 	#FF49148B��6#   5      .+�5      �� -   5        $��3,0,3,0q�5   B   .@�5      �� $��3,6,3,3q�6   ���	#FF673AB7���	#FF673AB7$��Center=�6_   .��5      �� $��Button��6    
�������$��15(�6A   $��Medium"�6O   $��Champagne & Limousines)�6c   6�   5      �� 5      $��3q�6   ���	#FF673AB7���	#FF673AB7$��Center=�6X   .��5       �� $��Label��6    $��15(�6-   
�������$��Medium"�6N   $��Champagne & Limousines)�6b   6�   5!      �� 5"      $��3q�6   ���	#FF673AB7���	#FF673AB7$��Center=�6Y   .��5#      �� $��ComboBox��6    $��15(�60   
�������$��Medium"�6Q   $��Champagne & Limousines)�6e   6�   5$      �� 5%      $��3q�6   ���	#FF673AB7���	#FF673AB7$��Center=�6X   .��5&      �� $��CheckBox��6    $��15(�60   
�������$��Medium"�6Q   $��Champagne & Limousines)�6e   6�   5'      5(      5)      � 5*   
   $��1��6   $��1��6   .+�5+      �� $
��Auto=�6      ScrollViewerStyle#���   6K   .��5,      �� -   5        	 ��Name$	 sp��5,      
 J� 	AllowDrop
 . 
������� �� Orientation$ Vertical=�5-   9   5.      5/      50      � 51   
   -   5         �Name$ GridTitlebar��51      $��2��6%   ���	#FF512DA8.+�52      �� $ 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�53      �� -   5         ��Name$ ButtonPower��53       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6.   $��25��6t   $��25��6   
���������6�   Z� ��6�   Z� .��54      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   55      56      �� 57      $ 
Horizontal=�6   $��Right=�62   $
��30,0q�6N   .+�58      �� -   5        $ ButtonMaximize��58      #��[ 61   $��25��6w   $��25��6�   
���������6�   Z� ��6�   Z� .��59        $ WindowMaximize=�6.   5:      5;      �� 5<      $ 
Horizontal=�6   $��Right=�62   $
��60,0q�6N   .+�5=      �� -   5        $ ButtonMinimize��5=      #��[ 61   $��25��6w   $��25��6�   
���������6�   Z� ��6�   Z� .��5>        $ WindowMinimize=�6.   5?      5@      5A      5C      5D      