   M S B A M L   `   `   `  ����J  FSimplePhotoPost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SimplePhotoPost.PropertiesSimplePhotoPost.Properties  5   	        SimplePhotoPost.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ?
Properties(clr-namespace:SimplePhotoPost.Properties     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  SimplePhotoPost��5   	   $	��700��6!   $	��829��6.   $	��300��6:   $	��300��6I    � Icon$ SPP_icon.ico��5   	    � WindowStyle$ ThreeDBorderWindow=�6   
������� � 	Resources 5
         TriggerStyle �� 
TargetType �� Triggers :� RoutedEvent ��Name	 �� To	 �� TargetProperty
 g� FillBehavior g� Duration��%�  &	        �� 5   
   " �6%    5      :� 5      $ Button.MouseEnter��6   .[�5      �� .��5      �� $ myStoryboard��6%   .��5      �� $ 	#CC3860FFX�6-   $	 (Background).(Color)�6<   $
 HoldEnd=�6m   $ 0:0:0.2D�6�   5      5      5      :� 5      $ Button.MouseLeave��6   .[�5      �� .��5      �� .��5      �� $	 (Background).(Color)�6-   $
 HoldEnd=�6^   $ 0:0:0.2D�6u   5      5      5      5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $��77 �6   �� 5"      $
��214* �6   �� 5#      $��77 �6   .+�5&   
   �� -   5        $��listBox��5&      $��Stretch=�6!   $��1��6F   
����=H���6o   Z� .@�5'      � -   5         �Name$ btnAddGroup��5'   P   #��[  6   ���	#CC0025B6$��65��6e   $��Stretch=�6q    � UseLayoutRounding .  $��-2,0,0,0q�6�    � ColumnDefinitions 5(      �� 5)      �� 5*      $��72 �6'   .+�5,      �� $
��Wrap=�6   $��Center=�60   $��Center=�6K   $#��Добавить группу��6h    K� ZIndex$ 1��6   
�������$��15(�6�   �� 5-      $��1��6   $��Center=�6,   $
��Wrap=�6I   $��+��6]   $��Center=�6f   
�������$
��Bold"�6�   $��40(�6�   $��
22,2,21,10q�6�   5.      5/      � 51   
   -   5        $��AuthRect��51      ���	#CC0028C8#��[  6P   $��Stretch=�6w   $��Stretch=�6�   .+�52      �� -   5        $��
AuthStatus��53      $��Center=�54      $
��Wrap=�55      $"��Авторизоваться��56      $��Center=�57      
�������$��20(�59      5:      � 5<   
   -   5        $	��SPP��5<      ���	#CC0028C8#��[  61   $��Stretch=�6r   $��Stretch=�6�   $��2��6�   .+�5=      �� $��Center=�5>      $��2��5?      $
��Wrap=�5@      $��SimplePhotoPost��5A      $��Center=�5B      
�������$��30(�6?   5C      5D      5F      