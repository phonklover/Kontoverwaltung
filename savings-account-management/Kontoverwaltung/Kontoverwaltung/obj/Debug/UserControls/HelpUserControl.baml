   M S B A M L   `   `   `  ����J  FKontoverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KontoverwaltungKontoverwaltung  5      %    Kontoverwaltung.HelpUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Kontoverwaltung     5      .��5	      �   � ColumnDefinitions  5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��Center=�62   .+�5      �� $��Forgot Account Number��6   $	��220��65   $��50��6A   $��10q�6M   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value
 �����6;   �� 5       � ��$
 Bold"�6;   �� 5       � �� 5   "   �� 5   &    �� 
TargetType" ��66   .R�5   *   ��  ��Name$ border��61   #��z��6A   #��z��5   /   #��z��5   /    �� CornerRadius$ 5��5   /   ._�5   .   �� $��Center=�6?   $��Center=�6\   5    +    �� Triggers 5!   *   P� 5"   .    P� Property �@J�IsMouseOver	 P� Value	 . . �5#   2   �� 
 �� 
TargetName$
 border��69    � ��
 � ���6c   �� 5$   2   $
 border��69    � z� 5%   6   �� 5&   :    �� ScaleX$	 1.1Q�6I    �� ScaleY$	 1.1Q�6V   5(   3   �� 5)   2   $
 border��69    �@J�RenderTransformOrigin$ 0.5,0.5&�6n   5*   /   5,   '   5.      5/      51      �� 54      $��
Forgot PIN��6   $	��220��6.   $��50��6:   $��10q�6F   ��55      �� 56      " ��6    .�57      ��  � ��
 �����6;   �� 58       � ��$
 Bold"�6;   �� 59       � �� 5:   "   �� 5;   &   " ��66   .R�5<   *   �� $ border��61   #��z��6A   #��z��5=   /   #��z��5>   /   $ 5��5?   /   ._�5@   .   �� $��Center=�6?   $��Center=�6\   5A   +    5B   *   P� 5C   .    �@J�IsMouseOver	 . . �5D   2   �� $
 border��69    � ��
 � ���6c   �� 5E   2   $
 border��69    � z� 5F   6   �� 5G   :   $	 1.1Q�6I   $	 1.1Q�6V   5I   3   �� 5J   2   $
 border��69    �@J�RenderTransformOrigin$ 0.5,0.5&�6n   5K   /   5M   '   5O      5P      5R      5U      �� 5W      -   5         ��Name$ contentControl��5W      5X      5Y      