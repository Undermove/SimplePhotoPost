   M S B A M L   `   `   `  ����K  GWaterMarkControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:WaterMarkControl;assembly=WaterMarkControlWaterMarkControl  5   	    SimplePhotoPost(   "SimplePhotoPost.Views.ViewSettings   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   N	watermark8clr-namespace:WaterMarkControl;assembly=WaterMarkControl     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$%  Настройки группы��5   	   $	��614��6"   $	��543��6/   $	��334��6;   $	��497��6J    � WindowStyle$ 
ToolWindow=�6s   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��53 �6   �� 5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $
��188* �6   �� 5      $
��103* �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��25 �6   �� 5      $��10 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��2��6(   .u�5      �� -   5        $��Title1��5      $��0q�5       �� TextWrapping$
 Wrap=�5       
����������	#55000000 �� TextAlignment$ Center=�5#      $��25(�5$      $��2��5%      .��6!   '   !WaterMarkControl.WatermarkService   	Watermark 5&      �� 5'      $��24(�6     �� TextAlignment$ Center=�6.   
�������.,Введите название группы6q   .��5(   8   5)      5*      �� 5,   
   $��1��6   $��2��6(   .u�5-      �� -   5        $��Message��5.      $��1��5/      $
 Wrap=�50      $��20(�51      $
��Auto=�52      $��2��53      $��10q�54      .��6    55      �� 56      $��20(�6    Текст сообщения6?   .��57   8   58      59      �� 5;   
   $��2��6   $��2��6(   .u�5<      �� -   5        $��HashTags��5=      $��2��5>      $
 Wrap=�5?      $��	#hashtags��5@      $
��Auto=�5A      $��20(�5B      $��2��5C      $��10q�6%   .��61    5D      �� 5E      $��20(�6    #Хэштэги68   .��5F   8   5G      5H      �� 5J   
   -   5        $��7��5J       K� ZIndex$ 1��6      ImageSource3#���   6D   $��10,0,0,0q�6l   �� 5K   
   -   5        $��
Rectangle2��5K      $��0��6&   ���	#55000000$��7��6K   $ 0��6X   
���   �6i   �� 5L   
   -   5        $
��Path��5O      |�. 
����������	#55000000$��1��5R      $��7��5S      $��NoWrap=�5T      $ Justify=�5U      $0��*   Выберите папку с фото��5V      $��25(�5W      �� 5Y   
   $��3��6   $��2��6(   .u�5Z      �� -   5        $��GroupId��5[      $��3��5\      $
 Wrap=�5]      $��ID Группы��5^      $��2��5_      $��25(�5`      $
��10,0q�6   .��6)    5a      �� 5b      $��20(�6    ID группы69   .��5c   8   5d      5e      �� 5h   
   $��4��6   $��2��6(   $��2��6<   .u�5i      �� -	   5        $��AlbumId��5j      $��4��5k      $
 Wrap=�5l      $��ID Альбома��5m      $��2��5n      $��25(�5o      $��
10,10,10,0q�6   .��6/    5p      �� 5q      $��20(�6    ID альбома6:   .��5r   8   5s      5t      #  Xceed.Wpf.Toolkit.ColorPicker  5v   
   -
   5        $��Color��5w      $��9��5x      	   	ColorMode$	 ColorPalette=�5y      $��2��6&   
 � ToolTip$+
 %Цвет группы в списке��5z      $
��10,0q�6,   6:   �� 5   
   -   5        $��11��5�      ���	#CC001774$
��Wrap=�5�      $&�� Сохранить и выйти��5�      $��25(�5�      $ Center=�5�      
�������$��2��5�      5�      �� 5�   
   -   5        $��
Rectangle1��5�      $ -1��6'   $��2��69   ���	#FF4C3BB2$��11��6^   5�      5�      