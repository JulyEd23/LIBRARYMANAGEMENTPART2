   M S B A M L   `   `   `  ����Q  MLIBRARYMANAGEMENTPART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LIBRARYMANAGEMENTPART2LIBRARYMANAGEMENTPART2  5   	   *    $LIBRARYMANAGEMENTPART2.AddBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:LIBRARYMANAGEMENTPART2     5   	     � Title$  AddBookWindow��5   	   $
��Auto��6   $
��Auto��6-   ���#FFF1D8 � WindowState$ 	Maximized=�6O    � WindowStyle$
 None=�6g   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   ���#4950DE � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5      �� $��Add Book��6   
�������$��30(�5      $
��Bold"�5       �� Padding$ 20,0,0,0q�5      $��0��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6'   5      �� 5      -   5        $��
ButtonExit��5      $��1��5      
������ ��5!      F� 5"      "���Јl�d��� ���l�шl��(X"$��40��6T   $��40��6_   
�������$��9��6z    �� Stretch$ Uniform=�6�   	 � UseLayoutRounding	 .  6�   5$      5%      � 5&   
   $��1��6   ��5'      �� 5(      
 �� ImageSource$
 book-sale.jpg��6    �� Opacity$	 0.2Q�5)      5+      � 5,   
   $��1��6    5-      �� 5.      �� 5/      .+�51      � $��0��6    52      �� 53      $
��Auto �6$   �� 54      $
��Auto �6$   �� 55      $
��Auto �6$   �� 56      $
��Auto �6$   �� 57      $
��Auto �6$   .+�59      �� $��0��6    �� Orientation$ Vertical=�6*   $��Center=�6A   $��20q�6\   .+�5:      �� $��Enter Book Title��6    �� 5;      ��6   ��  �� Path$ title�5<      �� 5=      $��1��6   $ Vertical=�6*   $��Center=�6A   $��20q�6\   .+�5>      �� $��Choose Book Category��6    �� 5?      ��6   �� $ BOOKCATEGORIES� �� SelectedItem 5@      �� $ category�5A      �� 5B      $��2��6   $ Vertical=�6*   $��Center=�6A   $��20q�6\   .+�5C      �� $��No. of Copies��6    �� 5D      -   5        $��ComboBoxNoofCopies��5D      $	��100��5E      $
��Left=�5F      5G      5H      �� 5I      $��3��6   $ Vertical=�6*   $��Center=�6A   $��20q�6\   .+�5J      �� $��Book ID Number(s)��6    �� 5K      -   5        $��ListBoxIDNumbers��5N      $��80��5K      $	��200��5L      $
��Left=�5M      
������ ��5O      �� $ bookid�5P      5Q      � 5R      $��4��6   $��20q�6$    5S      �� 5T      $
��Auto �6(   �� 5U      $
��Auto �6(   �� 5V      .+�5X      �� $��Author's name��6    $��0��5Y       � 5Z      $��1��6    5[      �� 5\      �� 5]      .+�5_      � $��0��6    5`      �� 5a   "   $
��Auto �60   �� 5b   "   $
��Auto �60   �� 5c   "   $
��Auto �60    5e      �� 5f   "   $
��Auto �63   �� 5g   "   .+�5i      �� $��
Firstname ��6(   $��0��5j   (   $��0��5k   (   �� 5l      $��	Lastname ��6(   $��1��5m   (   $��0��5n   (   �� 5o      -   5        $��TextBoxAuthorFirstName��5r   &   $��0��5o   &   $��1��5p   &   ��5q   &   �� $ authorfirstname�5r   &   �� 5s      -   5        $��TextboxAuthorLastName��5v   &   $��1��5s   &   $��1��5t   &   ��5u   &   �� $ authorlastname�5v   &   5w      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $
��0.4* �6$   �� 5�      .+�5�      �� -   5        $��ButtonAddBook��5�      $��0��5�      $��Center=�5�      $��Center=�5�      ���#4950DE$	��220��5�      ��5�      �� 5�      $��Add Book��6$   
�������$��30(�5�   $   $
��Bold"�5�   $   5�      � 5�      $��1��6   5�      5�      5�      5�      5�      