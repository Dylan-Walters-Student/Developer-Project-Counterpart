   M S B A M L   `   `   `  ����L  HDeveloper-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Developer_Project.ComponentsDeveloper_Project.Components  5      I)clr-namespace:Developer_Project.ViewModelDeveloper_Project.ViewModel  6G   1    +Developer_Project.Components.AddContactInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Developer_Project.Components     5      ?	viewmodel)clr-namespace:Developer_Project.ViewModel     6G   .��5	      � 
���z���  � ColumnDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��Add Contact Information��6$   $��30(�6C   $
��Bold"�6Q   � 5   
   $��1��6   $��1��6   
�������  5      �� 5      $��20 �6#   �� 5      $
��auto �6#   �� 5      $��10 �6#   �� 5      $��* �6#   �� 5      $��* �6#    5!      �� 5"      $
��auto �6    �� 5#      $��10 �6    �� 5$      $
��auto �6    �� 5%      $��10 �6    �� 5&      $
��auto �6    �� 5'      $��10 �6    �� 5(      $
��auto �6    �� 5)      $��10 �6    �� 5*      $
��auto �6    �� 5+      $��* �6    �� 5,      $
��auto �6    �� 5-      $
��auto �6    .+�51      �� $��1��6   $��0��6(   $��Name:��65   $��20(�6B   $
��Bold"�6P   $��0 0 0 0q�6b   �� 52      $��3��6   $��0��6&   $��18(�6n   ��63   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6n   �� 54      $��1��6   $��2��6(   $��Address:��65   $��20(�6E   $
��Bold"�6S   �� 55      $��3��6   $��2��6&   $��18(�6q   ��63   �� *	Address+$ PropertyChanged=�6q   �� 57      $��1��6   $��4��6(   $��Email:��65   $��20(�6C   $
��Bold"�6Q   �� 58      $��3��6   $��4��6&   $��18(�6o   ��63   �� *Email+$ PropertyChanged=�6o   �� 5:      $��1��6   $��6��6(   $��Phone:��65   $��20(�6C   $
��Bold"�6Q   �� 5;      $��3��6   $��6��6&   $��18(�6u   ��63   �� *PhoneNumber+$ PropertyChanged=�6u   �� 5=      $��3��6   $��8��6%   $��Create��6T   
������$��0 0 0 5q�6}   ��62   �� *SubmitCommand+6}   5?      5@      5A      