   M S B A M L   `   `   `  ����?  ;pro1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pro1pro1  5   	       pro1.Employments   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:pro1     5   	     � Title$  Employments��5   	   $	��800��6   $
��1200��6*    � 	Resources 5	       #  CustomDataGridColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value  CustomDataGridStyle&   System.Windows.Controls.DataGrid��%�   &	        &	 P     7   �� 5
   
   "  68   .�5      ��  � �� �	#FFF25AEC6+   5      �� 5   
   "  6,   .�5      ��  �@ ColumnHeaderStyle8   62   5      5      .��5      � ���	#FF310129 � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5       6!   �� 5!      6!   �� 5"      6!   �� 5#      6!   .+�5%   
   �� $��7��6   $��-27,-8,-27,0q�6$   $��7��6:   $��/Group 27.png��6K   $
��Fill=�6b   �� 5(   
   $��Arial Black)�6   $��
60,59,17,0q�6-    J� RenderTransformOrigin$ 0.648,1.058&�6A   $��44(�6e   $��5��6s   ���	#FFFDFDFD�� 6�    � Language$ ru-ru�6�   $=�7Занятость актеров в спектакле��6�   �� 6�   $� ��6�   6�     5)   
   -   5        	  Name$	 datag��5)       $��1��6   #��[ 6/   $��5��6�   $��	60,8,55,0q�6�   $��3��6�   ���	#FF310129���	#FF310129$��20(�6  $��Bahnschrift Condensed)�6  
   HorizontalGridLinesBrush
 �	#FFF25AEC   VerticalGridLinesBrush �	#FFF25AEC$	��281��6}  $	��Top=�6�  ��6�   Z� 6�  �� 5*   
   $��Код актера��6   $
��Left=�6%   $��4��6@   $	��Top=�6M   $ 0.132,0.147&�6e   $��79��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��	45,10,0,0q�6�   $��32��6�   
�������6�   �� 5+   
   -   5         ��Name$ textid��5+      $��Center=�6#   $
��Left=�6E   $��
134,12,0,0q�6`   $��4��6t    �� TextWrapping$
 Wrap=�6�   $	��100��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��30��6  $	��Top=�6  $��2��6'   �� SelectionBrush 6�   Z� .��6;   5,       �� 
TargetType �� CornerRadius ��Name��%�   '��       �� 5-      " ��61   .�5.      ��  � �� 5/      �� 50      " ��6.   .R�51   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�52   &   �� $ PART_ContentHost��63   53   #   54      56      57      58      .��6!   59      �� 5:   
   -   5        $��1��5:      $��
Поиск��6!   $
��Left=�61   $��	84,0,0,67q�6L   $��4��6_   $	��141��6l   
�������$��Arial Black)�6�   $��16(�6�   ���	#FF310129$��35��6�   $��Bottom=�6  $��2��6  ��6�   Z�  5;      ��%_   '��       �� 5<      " ��6   .�5=      ��  �@��CornerRadius$ 20��65   5>      5?      5@      �� 5A   
   -   5        $��1��5A      $��Показать всё��6!   $
��Left=�68   $��
85,21,0,56q�6S   $��5��6g   $	��140��6t   ���	#FFFFFFFF$��Arial Black)�6�   $��16(�6�   ���	#FF310129$��35��6  $��2��6  ��6�   Z�  5B      ��%_   '��       �� 5C      " ��6   .�5D      ��  �@��CornerRadius$ 20��65   5E      5F      5G      �� 5H   
   $��Год��6   $
��Left=�6   $��4��69   $	��Top=�6F   $ 0.132,0.147&�6^   $��79��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��	45,56,0,0q�6�   $��32��6�   
�������6�   �� 5I   
   -   5        $ 	text_year��5I      $��Center=�6&   $
��Left=�6H   $��
134,72,0,0q�6c   $��4��6w   $
 Wrap=�6�   $	��100��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��30��6  $	��Top=�6  $��2��6*   6�   Z� .��6>   5J      ��%�   '��       �� 5K      " ��61   .�5L      ��  � �� 5M      �� 5N      " ��6.   .R�5O   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5P   &   �� $ PART_ContentHost��63   5Q   #   5R      5T      5U      5V      .��6!   5W      �� 5X   
   -   5        $��1��5X      $��
Поиск��6!   $
��Left=�61   $��84,0,0,7q�6L   $��4��6^   $	��141��6k   
�������$��Arial Black)�6�   $��16(�6�   ���	#FF310129$��35��6�   $��Bottom=�6  $��2��6  ��6�   Z�  5Y      ��%_   '��       �� 5Z      " ��6   .�5[      ��  �@��CornerRadius$ 20��65   5\      5]      5^      �� 5_   
   $;��5Количество отыгранных ролей ��6   $
��Left=�67   $��4��6R   $	��Top=�6_   $ 0.132,0.147&�6w   $	��205��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��	10,13,0,0q�6�   $��32��6�   
�������$��3��6
  $��2��6  �� 5`   
   -   5        $ 	text_code��5`      $��Center=�6&   $
��Left=�6H   $��
116,68,0,0q�6c   $��4��6w   $
 Wrap=�6�   $	��100��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��30��6  $	��Top=�6  $��3��6*  $��2��6:   6�   Z� .��6N   5a      ��%�   '��       �� 5b      " ��61   .�5c      ��  � �� 5d      �� 5e      " ��6.   .R�5f   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5g   &   �� $ PART_ContentHost��63   5h   #   5i      5k      5l      5m      .��6!   5n      �� 5o   
   -   5        $ textchange_year��5o      $��Center=�6,   $
��Left=�6N   $��	116,2,0,0q�6i   $��5��6|   $
 Wrap=�6�   $	��100��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��30��6  $	��Top=�6  $��3��6/  $��2��6?   6�   Z� .��6S   5p      ��%�   '��       �� 5q      " ��61   .�5r      ��  � �� 5s      �� 5t      " ��6.   .R�5u   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5v   &   �� $ PART_ContentHost��63   5w   #   5x      5z      5{      5|      .��6!   5}      �� 5~   
   $��Код актера��6   $
��Left=�6%   $��4��6@   $	��Top=�6M   $ 0.132,0.147&�6e   $��79��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��
160,67,0,0q�6�   $��32��6�   
�������$��2��6�   $��2��6  �� 5   
   $��Год��6   $
��Left=�6   $��4��69   $	��Top=�6F   $ 0.132,0.147&�6^   $��71��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��160,112,0,0q�6�   $��32��6�   
�������$��2��6�   $��2��6  $��2��6  �� 5�   
   $%��Новое количество��6   $
��Left=�6+   $��5��6F   $	��Top=�6S   $ 0.132,0.147&�6k   $	��118��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��
160,58,0,0q�6�   $��32��6�   
�������$��2��6�   $��2��6  �� 5�   
   -	   5        $ textchange_play��5�      $��Center=�6,   $
��Left=�6N   $��
116,58,0,0q�6i   $��5��6}   $
 Wrap=�6�   $	��100��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��30��6  $	��Top=�6  $��3��60  $��2��6@   6�   Z� .��6T   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   -
   5        $��3��5�      $��Изменить��6!   $
��Left=�64   $��	96,0,0,70q�6O   $��6��6b   $	��140��6o   
�������$��Arial Black)�6�   $��16(�6�   ���	#FF310129$��35��6�   $��Bottom=�6  $��2��6#  ��6�   Z�  5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 20��65   5�      5�      5�      �� 5�   
   -   5        $ textcode��5�      $��Center=�6$   $
��Left=�6F   $��
161,10,0,0q�6a   $��1��6u   $
 Wrap=�6�   $	��120��6�   $��5��6�   ���	#FF310129$��30��6�   $	��Top=�6�   $��Bahnschrift Condensed)�6  $��20(�6*  $��2��68   6�   Z� .��6L   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   $��Код��6   $��1��6   $	��Top=�6+   $ 0.132,0.147&�6C   $��Bahnschrift Condensed)�6g   $��18(�6�   $��	16,10,0,0q�6�   $��32��6�   $��5��6�   
�������$
��Left=�6�   $��33��6�   �� 5�   
   -   5        $ text_codeper��5�      $��Center=�6)   $
��Left=�6K   $��
161,66,0,0q�6f   $��1��6z   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��30��6�   $��5��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6  $��2��6#  $ 0.687,0.534&�67  .��6[   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   $��Код спектакля��6   $
��Left=�6(   $��	10,66,0,0q�6C   $��1��6V   $	��Top=�6c   $ 0.132,0.147&�6{   $	��101��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��5��6�   
�������6�   �� 5�   
   $��Роль��6   $
��Left=�6   $��16,7,0,0q�6:   $��2��6L   $	��Top=�6Y   $ 0.132,0.147&�6q   $��64��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��5��6�   
�������$��27��6�   �� 5�   
   -   5        $ textcost��5�      $��Center=�6%   $
��Left=�6G   $��
162,62,0,0q�6b   $��2��6v   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��30��6�   $��5��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6  $��2��6  .��63   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   $+��%Стоимость контракта��6   $��Center=�6.   $��0,62,0,0q�6K   $��2��6]   $	��Top=�6j   $ 0.132,0.147&�6�   $	��138��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   $��5��6�   
�������$��30��6  �� 5�   
   -   5        $ tyear��5�      $��Center=�6"   $��5��6D   $
��Left=�6T   $��	162,2,0,0q�6o   $��3��6�   $
 Wrap=�6�   $	��120��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��30��6�   $	��Top=�6  $��2��6  .��6/   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   $��5��6   $��Год��6    $
��Left=�6.   $��16,1,0,0q�6I   $��3��6[   $	��Top=�6h   $ 0.132,0.147&�6�   $��53��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   
�������6�   �� 5�   
   -   5        $ 	textplays��5�      $��Center=�6&   $��5��6H   $
��Left=�6X   $��
162,50,0,0q�6s   $��3��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��30��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6  $��2��6   .��64   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   $��5��6   $%��Количество ролей��6    $
��Left=�6;   $��	16,48,0,0q�6V   $��3��6i   $	��Top=�6v   $ 0.132,0.147&�6�   $	��122��6�   $��Bahnschrift Condensed)�6�   $��18(�6�   
�������6�   �� 5�   
   -   5        $��5��5�      $��Добавить��6!   $
��Left=�64   $��
162,15,0,0q�6O   $��4��6c   $	��Top=�6p   $��35��6�   $	��120��6�   
�������$��Arial Black)�6�   $��16(�6�   $��2��6
  ��6�   Z�  5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 20��65   5�      5�      5�      �� 5�   
   -   5        $ textpole��5�      $��Center=�6%   $��
162,7,62,0q�6G   $��2��6[   $
 Wrap=�6h   $	��Top=�6|   $��30��6�   $��5��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6�   $��2��6�   .��6   5�      ��%�   '��       �� 5�      " ��61   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5�   &   �� $ PART_ContentHost��63   5�   #   5�      5�      5�      5�      .��6!   5�      �� 5�   
   -   5        $��5��5�      $��Удалить��6!   $��
33,10,21,0q�63   $��6��6G   $	��Top=�6T   $��35��6l   
�������$��Arial Black)�6�   $��16(�6�   $ 1.885,0.629&�6�   ��6�   Z�  5�      ��%_   '��       �� 5      " ��6   .�5     ��  �@��CornerRadius$ 20��65   5     5     5     �� 5  
   -   5        $ 
textid_del��5     $��Center=�6'   $��Center=�6I   $��0,16,0,0q�6f   $��5��6x   $
 Wrap=�6�   $	��120��6�   $��5��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6	  $��30��6  $	��Top=�6#   6�   Z� .��6;   5     ��%�   '��       �� 5     " ��61   .�5     ��  � �� 5	     �� 5
     " ��6.   .R�5  "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5  &   �� $ PART_ContentHost��63   5  #   5     5     5     5     .��6!   5     �� 5  
   $��Код��6   $��5��6   $	��Top=�6+   $ 0.132,0.147&�6C   $��Bahnschrift Condensed)�6g   $��18(�6�   $��
150,16,0,0q�6�   $��32��6�   $��4��6�   
�������$
��Left=�6�   $��33��6�   $��2��6  �� 5  
   -   5        $ textyear_del��5     $��Center=�6)   $��Center=�6K   $��0,70,0,0q�6h   $��5��6z   $
 Wrap=�6�   $	��120��6�   $��5��6�   ���	#FF310129$��Bahnschrift Condensed)�6�   $��20(�6  $��30��6  $	��Top=�6%   6�   Z� .��6=   5     ��%�   '��       �� 5     " ��61   .�5     ��  � �� 5     �� 5     " ��6.   .R�5  "   �� $ 15��6)   $��1q�6;   ���#F25AEC
�������._�5  &   �� $ PART_ContentHost��63   5  #   5     5      5!     5"     .��6!   5#     �� 5$  
   $��Год��6   $��5��6   $	��Top=�6+   $ 0.132,0.147&�6C   $��Bahnschrift Condensed)�6g   $��18(�6�   $��
150,70,0,0q�6�   $��32��6�   $��4��6�   
�������$
��Left=�6�   $��33��6�   $��2��6  5'     5(     