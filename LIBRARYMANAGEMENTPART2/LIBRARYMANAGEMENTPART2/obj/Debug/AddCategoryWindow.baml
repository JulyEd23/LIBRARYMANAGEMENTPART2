   M S B A M L   `   `   `  ����Q  MLIBRARYMANAGEMENTPART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LIBRARYMANAGEMENTPART2LIBRARYMANAGEMENTPART2  5   	   .    (LIBRARYMANAGEMENTPART2.AddCategoryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:LIBRARYMANAGEMENTPART2     5   	     � Title$  AddCategoryWindow��5   	   $
��Auto��6#   $
��Auto��61    � WindowStartupLocation$ CenterScreen=�6>    � WindowStyle$
 None=�6c   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   ���#4950DE � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5      � $��0��6   .+�5      �� $��Add Category��6   $��30(�5      $
��Bold"�5      
�������$��20,0,0,0q�5      5      � 5      $��1��6   .+�5      �� -   5        $��ButtonExitWindow��5      
������ $��Right=�5      ��5      F� 5       "���Јl�d��� ���l�шl��(X"$��40��6X   $��40��6c   
�������$��9��6~    �� Stretch$ Uniform=�6�    � UseLayoutRounding .  6�   5"      5#      5$      � 5%   
   $��1��6   ��5&      �� 5'       �� ImageSource$ booksubjectcategory.jpg��6    �� Opacity$ 1Q�5(      5*      � 5+   
   $��1��6   ��5,      �� 5-      	 �� 
StartPoint$		 1,1&�6&   
 �� EndPoint$	
 1,1&�67   .��5.      �  � Color$ Transparent��6#    � Offset$ 10Q�67   � 5/      $ #FFF1D8��6#   $	 0.1Q�63   50       52      �� 53      �� 54      .+�56      � $��0��6    57      �� 58      $
��Auto �6$   �� 59      �� 5:      $
��Auto �6$   .+�5<      �� $��Category List��6   $��0��5=      $��20(�5>      $��Center=�5?       �� Padding$ 5q�5@      �� 5A      $��1��6   $��20q�5B      
������ ��5C      ��  �� Path$ BOOKCATEGORIES� �� SelectedItem 5D      �� $ selectedcategory�5E      �� 5F      -   5        $��ButtonDeleteCategory��5I      $��2��5F      ���#4950DE$	��100��5H      $��	0,10,0,20q�5K      ��5L      �� 5M      $��Delete��6$   
�������$
��Bold"�5O   $   $��20(�5P   $   5R      5S      � 5T      $��1��6    5U      �� 5V      �� 5W      .+�5Y      ��  �� Orientation$ Vertical=�6   $��Center=�64   .+�5Z      �� $��20��5[      $	��300��5\      ��5Z      �� $ addcategory�5\      �� 5]      $��Enter new category here��6    $��Center=�5^       5_      �� 5`      -   5        $��ButtonAddCategory��5d      $��1��5`      $��50��5a      $	��250��5b      ���#4950DE��5f      �� 5g      $��Add Category��6$   
�������$��20(�5i       $
��Bold"�5j       5l      5m      5n      5o      5p      