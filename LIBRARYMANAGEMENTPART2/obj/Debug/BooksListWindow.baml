   M S B A M L   `   `   `  ����Q  MLIBRARYMANAGEMENTPART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LIBRARYMANAGEMENTPART2LIBRARYMANAGEMENTPART2  5   	   ,    &LIBRARYMANAGEMENTPART2.BooksListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:LIBRARYMANAGEMENTPART2     5   	     � Title$  BooksListWindow��5   	   $
��Auto��6!   $
��Auto��6/   ���#FFF1D8 � WindowState$ 	Maximized=�6Q    � WindowStyle$
 None=�6i   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   ���#4950DE � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5      �� $��Books' List��6   
�������$��30(�5      $
��Bold"�5       �� Padding$ 20,0,0,0q�5      $��0��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6'   5      �� 5      -   5        $��
ButtonExit��5      $��1��5      
������ ��5!      F� 5"      "���Јl�d��� ���l�шl��(X"$��40��6T   $��40��6_   
�������$��9��6z    �� Stretch$ Uniform=�6�   	 � UseLayoutRounding	 .  6�   5$      5%      � 5&   
   $��1��6    5'      �� 5(      $
��auto �6    �� 5)      �� 5*      .+�5,      � $��0��6   $��10q�6     5-      �� 5.      $
��Auto �6'   �� 5/      .+�51      �� $��Search: ��6   $��0��52      �� 53      $��1��6   $	��500��55      $
��Left=�56      ��54      �� 
 �� Path$
 SearchTextBooks� �� UpdateSourceTrigger$ PropertyChanged=�56      57      � 58      $��1��6   .+�59      �� 
������ ��5:      �� $
 	BOOKSLIST� �� SelectedItem 5;      �� $
 SelectedBook� �� View 5<      �� 5=      P�5>      �� 5?   "   ��5@   &   �� 5A   *   $��Title��64    �� CellTemplate 5C   &   �� 5D   *   .R�5E   .   �� ��68   �� $
 	BookTitle�5F   +   5H   #   �� 5I   "   ��5J   &   �� 5K   *   $��Category��64    5M   &   �� 5N   *   .R�5O   .   �� ��68   �� $
 BookCategory�5P   +   5R   #   �� 5S   "   ��5T   &   �� 5U   *   $��Authors��64    5W   &   �� 5X   *   .R�5Y   .   �� ��68   �� $
 BookAuthorName�5[   +   5]   #   �� 5^   "   ��5_   &   �� 5`   *   $��	ID Number��64    5b   &   �� 5c   *   .R�5d   .   �� ��68   �� $
 BookIDNumber�5e   +   5g   #   5i      5k      5l      � 5m      $��2��6    5n      �� 5o      �� 5p      .+�5r      � $��0��6    5s      �� 5t      $
��Auto �6(   �� 5u      $
��Auto �6(   �� 5v      $
��Auto �6(   .+�5x      � $��0��6   $��10,0,0,0q�6(   .+�5y      �� $
��Sort��6$   $
��Bold"�5z   $   $��15(�5{   $   5|      � 5}      $��1��6   .+�5~      ��  �� Orientation$ Vertical=�6%   .+�5      �� $��Title��6'   .��5�   "   �  5�   &   �� 5�   *   �� 5�   *   .+�5�   &   	� -   5        $��RadioButtonTitleAscending��5�   2   $��0��5�   2   $��	Ascending��5�   2   $��Center=�5�   2   5�   2   	� 5�   &   -   5        $ ��RadioButtonTitleDescending��5�   2   $��1��5�   2   $��
Descending��5�   2   $��Center=�5�   2   5�   2   5�   #   5�      �� 5�      $��Category��6'   .��5�   "   �  5�   &   �� 5�   *   �� 5�   *   .+�5�   &   	� -   5        $"��RadioButtonCategoryAscending��5�   2   $��0��5�   2   $��	Ascending��5�   2   $��Center=�5�   2   5�   2   	� 5�   &   -   5        $#��RadioButtonCategoryDescending��5�   2   $��1��5�   2   $��
Descending��5�   2   $��Center=�5�   2   5�   2   5�   #   5�      �� 5�      $��	ID Number��6'   .��5�   "   �  5�   &   �� 5�   *   �� 5�   *   .+�5�   &   	� -   5        $"��RadioButtonIDNumberAscending��5�   2   $��0��5�   2   $��	Ascending��5�   2   $��Center=�5�   2   5�   2   	� 5�   &   -   5        $#��RadioButtonIDNumberDescending��5�   2   $��1��5�   2   $��
Descending��5�   2   $��Center=�5�   2   5�   2   5�   #   5�      5�      5�      � 5�      $��2��6   .+�5�      �� -   5        $��ButtonDefaultSort��5�   !   ���#4950DE$	��200��5�   !   ��5�      �� 5�   "   $��Default Sort��6,   
�������$��15(�5�   ,   $
��Bold"�5�   ,   5�      5�      5�      � 5�      $��1��6   .+�5�      �� -	   5        $��ButtonDeleteBook��5�      $��50��5�      $	��250��5�      ���#4950DE��5�      �� 5�      $��Delete Book��6(   
�������$��30(�5�   (   $
��Bold"�5�   (   5�      5�      5�      5�      5�      5�      