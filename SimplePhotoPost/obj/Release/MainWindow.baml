   M S B A M L   `   `   `  ���� J  FSimplePhotoPost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SimplePhotoPost.PropertiesSimplePhotoPost.Properties       SimplePhotoPost.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ?
Properties(clr-namespace:SimplePhotoPost.Properties     X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -     � Title$  SimplePhotoPost��$	��700��$	��829��$	��300��$	��300�� � Icon$ SPP_icon.ico�� � WindowStyle$ ThreeDBorderWindow=�
������� � 	Resources    TriggerStyle �� 
TargetType �� Triggers :� RoutedEvent ��Name	 �� To	 �� TargetProperty
 g� FillBehavior g� Duration��%  &	        �� " � :� $ Button.MouseEnter��.[��� .���� $ myStoryboard��.���� $ 	#CC3860FFX�$	 (Background).(Color)�$
 HoldEnd=�$ 0:0:0.2D�:� $ Button.MouseLeave��.[��� .���� .���� $	 (Background).(Color)�$
 HoldEnd=�$ 0:0:0.2D�.���  � RowDefinitions �� $��77 ��� $
��214* ��� $��77 �.+��� -   $��listBox��$��Stretch=�$��1��
����=H���Z� .@�� -    �Name$ btnAddGroup��#��[  ���	#CC0025B6$��65��$��Stretch=� � UseLayoutRounding .  $��-2,0,0,0q� � ColumnDefinitions �� �� $��72 �.+��� $
��Wrap=�$��Center=�$��Center=�$#��Добавить группу�� K� ZIndex$ 1��
�������$��15(��� $��1��$��Center=�$
��Wrap=�$��+��$��Center=�
�������$
��Bold"�$��40(�$��
22,2,21,10q�� -   $��AuthRect�����	#CC0028C8#��[  $��Stretch=�$��Stretch=�.+��� -   $��
AuthStatus��$��Center=�$
��Wrap=�$"��Авторизоваться��$��Center=�
�������$��20(�� -   $	��SPP�����	#CC0028C8#��[  $��Stretch=�$��Stretch=�$��2��.+��� $��Center=�$��2��$
��Wrap=�$��SimplePhotoPost��$��Center=�
�������$��30(�