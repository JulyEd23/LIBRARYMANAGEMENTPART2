   M S B A M L   `   `   `  ����Q  MLIBRARYMANAGEMENTPART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LIBRARYMANAGEMENTPART2LIBRARYMANAGEMENTPART2  5   	   (    "LIBRARYMANAGEMENTPART2.FinesWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:LIBRARYMANAGEMENTPART2     5   	     � Title$  FinesWindow��5   	   $
��Auto��6   $
��Auto��6+    � WindowStyle$
 None=�68   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   ���#4950DE � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5      �� $��0��6   $��Fines��5      
�������$
��Bold"�5      $��30(�5      $��Center=�5      $��10,0,0,0q�5      5      �� 5      -   5        $��
ButtonExit��5      $��1��5      
������ ��5       F� 5!      "���Јl�d��� ���l�шl��(X"$��40��6T   $��40��6_   
�������$��9��6z    �� Stretch$ Uniform=�6�    � UseLayoutRounding .  6�   5#      5$      � 5%   
   $��1��6   ��5&      �� 5'       �� ImageSource$ moneybooks.jpg��6    �� Opacity$ 1Q�5(      5*      � 5+   
   $��1��6   ��5,      �� 5-       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 0,0&�67   .��5.      � 
 � Color$
 Transparent��6#    � Offset$ 5Q�67   � 5/      $
 #FFEAD3��6#   $	 0.7Q�63   50       52      �� 53      �� 54      .+�56      � $��0��6   .+�57      �� -   5        $��ListViewViolatorsList��59      
������ ��57      ��  �� Path$ VIOLATORSLIST� �� View 5:      �� 5;      P�5<      �� 5=   "   ��5>   &   �� 5?   *   $��Lastname��64    �� CellTemplate 5A   &   �� 5B   *   .R�5C   .   �� ��68   �� $ ViolatorLastName�5D   +   5F   #   �� 5G   "   ��5H   &   �� 5I   *   $��	Firstname��64    5K   &   �� 5L   *   .R�5M   .   �� ��68   �� $ ViolatorFirstName�5N   +   5P   #   �� 5Q   "   ��5R   &   �� 5S   *   $��
Date Fined��64    5U   &   �� 5V   *   .R�5W   .   �� ��68   �� $ ViolatorDateFined� �� StringFormat$ {0:MMMM d, yyyy}��5X   +   5Z   #   �� 5[   "   ��5\   &   �� 5]   *   $
��Fine��64    5_   &   �� 5`   *   .R�5a   .   �� ��68   �� $ ViolatorTotalFine�5b   +   5d   #   5f       � ContextMenu 5h      �� 5i      .@�5j      m� $
��Sort��6'   .@�5k   "   m� $��Lastname��6+   .@�5l   &   m� -   5        $��LastNameAscending��5m   /   $��	Ascending��5l   /   5n   /   m� 5o   &   -   5        $��LastNameDescending��5p   /   $��
Descending��5o   /   5q   /   5r   #   m� 5s   "   $��	Firstname��6+   .@�5t   &   m� -   5        $��FirstNameAscending��5u   /   $��	Ascending��5t   /   5v   /   m� 5w   &   -   5        $��FirstNameDescending��5x   /   $��
Descending��5w   /   5y   /   5z   #   m� 5{   "   $��
Date Fined��6+   .@�5|   &   m� -   5        $��DateFinedAscending��5}   /   $��	Ascending��5|   /   5~   /   m� 5   &   -   5        $��DateFinedDescending��5�   /   $��
Descending��5   /   5�   /   5�   #   m� 5�   "   $
��Fine��6+   .@�5�   &   m� -	   5        $��FineAscending��5�   /   $��	Ascending��5�   /   5�   /   m� 5�   &   -
   5        $��FineDescending��5�   /   $��
Descending��5�   /   5�   /   5�   #   5�      m� 5�      $��Default Sort��6'   5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�      .+�5�      � $��0��6   .+�5�      ��  �� Orientation$ Vertical=�6!   $��Center=�5�   !   $��Center=�5�   !   .+�5�      �� $��Total Fine:��6$   $��30(�5�   $   $
��Bold"�5�   $   �� 5�      -   5        $��TextBlockTotalFine��5�   $   $��10q�5�   $   $��Center=�5�   $   $��20(�5�   $   5�      5�      � 5�      $��1��6   5�      5�      5�      5�      5�      