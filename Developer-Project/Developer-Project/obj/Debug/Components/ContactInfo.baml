   M S B A M L   `   `   `  ����L  HDeveloper-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Developer_Project.ComponentsDeveloper_Project.Components  5      I)clr-namespace:Developer_Project.ViewModelDeveloper_Project.ViewModel  6G   .    (Developer_Project.Components.ContactInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Developer_Project.Components     5      ?	viewmodel)clr-namespace:Developer_Project.ViewModel     6G   $��20(�5   7   .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��30(�6(   ��66   �� *Name+�� 5      $��1��6   $��30(�6(   $��Information��66   5      � 5!   
   $��1��6    5"      �� 5#      $
��auto �6#   �� 5$      $
��auto �6#   �� 5%      $��* �6#   .+�5'      �� $��0��6   $��Name: ��6(   �� 5(      $��1��6   ��6(   �� *Name+5)      � 5+   
   $��3��6    5,      �� 5-      $
��auto �6#   �� 5.      $
��auto �6#   �� 5/      $��* �6#   .+�51      �� $��0��6   $��Email: ��6(   �� 52      $��1��6   ��6(   �� *Email+53      � 55   
   $��4��6    56      �� 57      $
��auto �6#   �� 58      $
��auto �6#   �� 59      $��* �6#   .+�5;      �� $��0��6   $��	Address: ��6(   �� 5<      $��1��6   ��6(   �� *	Address+5=      � 5?   
   $��5��6    5@      �� 5A      $
��auto �6#   �� 5B      $��2* �6#   �� 5C      $��* �6#   .+�5E      �� $��0��6   $��Phone Number: ��6(   �� 5F      $��1��6   ��6(   �� *PhoneNumber+5G      �� 5I   
   $��6��6   $��10��6!   $��Delete Contact��6Q   
���\\��$��	50 0 50 5q�6�   ��6/   �� *DeleteCommand+6�   5J      5K      