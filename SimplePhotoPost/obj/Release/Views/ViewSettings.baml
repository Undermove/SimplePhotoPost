   M S B A M L   `   `   `  ���� K  GWaterMarkControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:WaterMarkControl;assembly=WaterMarkControlWaterMarkControl   SimplePhotoPost(   "SimplePhotoPost.Views.ViewSettings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     N	watermark8clr-namespace:WaterMarkControl;assembly=WaterMarkControl     X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -     � Title$%  Настройки группы��$	��614��$	��543��$	��334��$	��497�� � WindowStyle$ 
ToolWindow=�.���  � ColumnDefinitions �� $��53 ���  � RowDefinitions �� $��40 ��� $
��188* ��� $
��103* ��� $��40 ��� $��10 ��� $��40 ��� $��10 ��� $��40 ��� $��10 ��� $��25 ��� $��10 ��� $��40 �.+��� $��0��$��2��.u��� -   $��Title1��$��0q� �� TextWrapping$
 Wrap=�
����������	#55000000 �� TextAlignment$ Center=�$��25(�$��2��.��'   !WaterMarkControl.WatermarkService   	Watermark �� $��24(� �� TextAlignment$ Center=�
�������.,Введите название группы.���� $��1��$��2��.u��� -   $��Message��$��1��$
 Wrap=�$��20(�$
��Auto=�$��2��$��10q�.�� �� $��20(�Текст сообщения.���� $��2��$��2��.u��� -   $��HashTags��$��2��$
 Wrap=�$��	#hashtags��$
��Auto=�$��20(�$��2��$��10q�.�� �� $��20(�#Хэштэги.���� -   $��7�� K� ZIndex$ 1��$.��(pack://siteoforigin:,,,/Tiles/Folder.png��$��10,0,0,0q��� -   $��
Rectangle2��$��0�����	#55000000$��7��$ 0��
���   ��� -   $
��Path��|�. 
����������	#55000000$��1��$��7��$��NoWrap=�$ Justify=�$0��*   Выберите папку с фото��$��25(��� $��3��$��2��.u��� -   $��GroupId��$��3��$
 Wrap=�$��ID Группы��$��2��$��25(�$
��10,0q�.�� �� $��20(�ID группы.���� $��4��$��2��$��2��.u��� -	   $��AlbumId��$��4��$
 Wrap=�$��ID Альбома��$��2��$��25(�$��
10,10,10,0q�.�� �� $��20(�ID альбома.��#  Xceed.Wpf.Toolkit.ColorPicker  -
   $��Color��$��9��	   	ColorMode$	 ColorPalette=�$��2��
 � ToolTip$+
 %Цвет группы в списке��$
��10,0q��� -   $��11�����	#CC001774$
��Wrap=�$&�� Сохранить и выйти��$��25(�$ Center=�
�������$��2���� -   $��
Rectangle1��$ -1��$��2�����	#FF4C3BB2$��11��