   M S B A M L   `   `   `  ����Q  MLIBRARYMANAGEMENTPART2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LIBRARYMANAGEMENTPART2LIBRARYMANAGEMENTPART2  5   	   ,    &LIBRARYMANAGEMENTPART2.LogInUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:LIBRARYMANAGEMENTPART2     5   	     � Title$  LogInUserWindow��5   	   ���#FFEAD3$
��Auto��66   $
��Auto��6D    � WindowState$ 	Maximized=�6Q    � WindowStyle$
 None=�6i   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   �� 5      .+�5   
   � $��0��6   ���#4950DE.+�5      �� $&�� Welcome to ED Library Management��6   $��30(�5      $��DemiBold"�5      
�������$��Center=�5      $��Center=�5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 3Q�6'   5      �� 5      -   5        $��buttonexitloginwndow��5      $��Right=�5      
������ ��5      F� 5      $��23.3774��6   $��23.46��6+    �� Stretch$ Uniform=�6:   
������������@�G     ��v%��?$�H Ѥ�j �=� �    ���@�G ��eQ<�� ����xi0@Ѱ2��e���d8��h�� �=� �x�c$�H Ѱ2    �<�� H�j �@�G     6Y   5       5!      � 5"   
   $��1��6   ��5#      �� 5$       �� ImageSource$ booksstock.jpg��6    �� Opacity$	 0.2Q�5%      5'      � 5(   
   $��1��6   .+�5)      � $��Center=�6   $��Center=�6.    5*      �� 5+      $��50 �6$   �� 5,      $��50 �6$   �� 5-      $��50 �6$   	 � ColumnDefinitions	 5/      �� 50      $
��Auto �6'   �� 51      $
��Auto �6'   .+�53      �� $��
Username: ��6   $
��Bold"�54      $��0��55      $��0��56      $��Center=�57      �� 58      $��
Password: ��6   $
��Bold"�59      $��1��5:      $��0��5;      $��Center=�5<      �� 5=      -   5        $��txtbxusername��5B      $��0��5=      $��1��5>      $��Center=�5?      $	��300��5@      $
��10,0q�5A      5B      G� 5C      -   5        $��psswrdbx��5H      $��1��5C      $��1��5D      $��Center=�5E      $	��300��5F      $
��10,0q�5G      5H      �� 5I      -   5        $��buttonlogin��5N      $��2��5I      $��2��5J      $	��100��5K      $��30��5L      ���#4950DE��5P      �� 5Q      -   5        $��txtbttnlogin��5T   $   $��Enter��5Q   $   $��17(�5R   $   
�������$��Center=�5U   $    5V        5W   "   $ 2Q�63   5Y       5[        5\      $ 2Q�6+   
 � Triggers
 5^      :� 5_       :� RoutedEvent$ 
MouseEnter��6'   .[�5`      �� .��5a   "   ��  �� TargetProperty$ Width�6-    g� AutoReverse .  .��5c   &   W�  W� From$	 100X�66   	 W� To$	 105X�5d   6    g� Duration$ 0:0:0.1D�5e   6   5f   #   5g      �� 5h      .��5i   "   �� $ Height�6-    .  .��5k   &   W� $ 30X�66   $ 35X�5l   6   $ 0:0:0.1D�5m   6   5n   #   5o      �� 5p      .��5q   "   �� $ FontSize�6-    �� 
TargetName$ txtbttnlogin��5r   -    .  .��5t   &   W� $ 17X�66   $ 20X�5u   6   $ 0:0:0.1D�5v   6   5w   #   5x      5y      :� 5z      $ 
MouseLeave��6'   .[�5{      �� .��5|   "   �� $ Width�6-    .  .��5~   &   W� $	 105X�66   $	 100X�5   6   $ 0:0:0.1D�5�   6   5�   #   5�      �� 5�      .��5�   "   �� $ Height�6-    .  .��5�   &   W� $ 35X�66   $ 30X�5�   6   $ 0:0:0.1D�5�   6   5�   #   5�      �� 5�      .��5�   "   �� $ FontSize�6-   $ txtbttnlogin��5�   -    .  .��5�   &   W� $ 20X�66   $ 17X�5�   6   $ 0:0:0.1D�5�   6   5�   #   5�      5�      5�      5�      5�      5�      5�      