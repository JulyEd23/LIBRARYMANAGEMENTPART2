   M S B A M L   `   `   `  ����Q  MLIBRARYMANAGEMENTPART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LIBRARYMANAGEMENTPART2LIBRARYMANAGEMENTPART2  5   	   /    )LIBRARYMANAGEMENTPART2.EditBorrowerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:LIBRARYMANAGEMENTPART2     5   	     � Title$  EditBorrowerWindow��5   	   $
��Auto��6$   $
��Auto��62    � WindowState$ 	Maximized=�6?   ���#FFF1D8 � WindowStyle$
 None=�6l   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   ���#4950DE.+�5      �� $��Edit Borrower��6   
�������$��30(�5      $
��Bold"�5       �� Padding$ 20,0,0,0q�5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6'   5      �� 5      -   5        $#��ButtonEditBorrowerWindowClose��5      $��Right=�5      
������ ��5      F� 5      "���Јl�d��� ���l�шl��(X"$��40��6T   $��40��6_   
�������$��9��6z    �� Stretch$ Uniform=�6�    � UseLayoutRounding .  6�   5      5       � 5!   
   $��1��6   	 � ColumnDefinitions	 5"      �� 5#      �� 5$      .+�5&      � $��0��6    5'      �� 5(      �� 5)      �� 5*      �� 5+      �� 5,      .+�5.      �� $��0��6   
 �� Orientation$
 Vertical=�6*   $��Center=�6A   $��20q�6\   .+�5/      �� $��Lastname��6    �� 50      ��6   ��  �� Path$ BorrowerLastName�51      �� 52      $��1��6   $
 Vertical=�6*   $��Center=�6A   $��20q�6\   .+�53      �� $��	Firstname��6    �� 54      ��6   �� $ BorrowerFirstName�55      �� 56      $��2��6   ��57      �� 58      $��Gender��6$   .��5:      � $��5q�6   	 5;      �� 5<      �� 5=      .+�5?      	� -   5        $��RadioButtonMale��5@   &   $
��Male��5?   &   $��0��5A   &   $��Center=�5B   &   $��Center=�5C   &   6A   	� 5D      -   5        $��RadioButtonFemale��5E   &   $��Female��5D   &   $��1��5F   &   $��Center=�5G   &   $��Center=�5H   &   6A   5I      5J      �� 5K      $��3��6   ��5L      �� 5M      $��Borrower Type��6$   .��5O      � $��5q�6   	 5P      �� 5Q      �� 5R      .+�5T      	� -   5        $��RadioButtonStudent��5U   &   $��Student��5T   &   $��0��5V   &   $��Center=�5W   &   $��Center=�5X   &   6A   	� 5Y      -   5        $��RadioButtonTeacher��5Z   &   $��Teacher��5Y   &   $��1��5[   &   $��Center=�5\   &   $��Center=�5]   &   6A   5^      5_      �� 5`      $
 Vertical=�6   $��4��64   $��Center=�6A   $��20q�6\   .+�5a      �� $��	ID Number��6    �� 5b      -   5        $��TextBlockIDNumber��5c       
�������5d      5e      � 5f      $��1��6    5g      �� 5h      �� 5i      .+�5k      �� -   5        $��ButtonSaveEditBorrower��5p      $��0��5k      $��Center=�5l      $��Center=�5m      $	��200��5n      ���#4950DE��5r      �� 5s      $
��Save��6$   $��30(�5t   $   
�������$
��Bold"�5v   $   5x      5y      5z      5{      5|      