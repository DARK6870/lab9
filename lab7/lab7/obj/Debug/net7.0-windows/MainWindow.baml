   M S B A M L   `   `   `  ����?  ;lab7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab7lab7  5   	       lab7.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab7     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ 
MainWindow��5   	   $	��600��6   $	��800��6)    � 
ResizeMode$ CanMinimize=�65    � Icon$ /ghost_4109.png��6N   .��5      � .+�5   
   o� )  #MaterialDesignThemes.Wpf.MenuAssist   TopLevelMenuItemHeight$ 25Q�6   .@�5      m� $��_File��6   .@�5      m� -   5         m�Name$ 	open_file��5   A   $��	Open file��5       m� Icon 5      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ FileDocumentOutline=�6T   m� 5      -   5        $
 save��5   3   $
��Save��5       5        $ ContentSave=�6A   m� 5      -   5        $ Save_as��5      $��Save As..  ��6   6-   m� 5      -   5        $ 	close_btn��5      $
��Exit��5       5        $ 	ExitToApp=�5      5       5!      � 5"   
   $��0, 30, 0 ,0q�6   .+�5#      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 	file_data��5#   �   
   CanUserDeleteRows$

 True��6      CanUserAddRows$ False��60      
IsReadOnly$
 True��6G      SelectionMode$ Extended=�6�   $��0, 150,0,17q�6�    � ContextMenu 5$      �� 5%      -   5         ��Name$ rowContextMenu��5%   "   .@�5&      m� -   5        $ chart��5&   o   $��Create chart��6Y    6#     $ ChartAreaspline=�6~   5'      5)      �� 5*      -   5         ��Name$
 Name��5*      $
��Left=�6$   $��	10,10,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $�� ��6f   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��6n      
IsFloating$
 True��6�   $	��Top=�6�   $	��120��6�   �� 5+      -	   5        $ Country��5+      $
��Left=�6'   $��	10,50,0,0q�6B   $
 Wrap=�6U   $�� ��6i   $ Country��6q   $
 True��6�   $	��Top=�6�   $	��120��6�   �� 5,      -
   5        $ TypeName��5,      $
��Left=�6(   $��
150,10,0,0q�6C   $
 Wrap=�6W   $�� ��6k   $ TypeName��6s   $
 True��6�   $	��Top=�6�   $	��120��6�   �� 5-      -   5        $ Price��5-      $
��Left=�6%   $��
150,50,0,0q�6@   $
 Wrap=�6T   $�� ��6h   $ Price��6p   $
 True��6�   $	��Top=�6�   $	��120��6�   �� 5.      -   5        $ ImageUrl��5.      $
��Left=�6(   $��
290,10,0,0q�6C   $ NoWrap=�6W   $�� ��6m   $ ImageUrl��6u   $
 True��6�   $	��Top=�6�   $	��120��6�   �� 5/      -   5         ��Name$ save_btn��5/      $
��Left=�6>   $��
593,63,0,0q�6Y   $	��Top=�6m   ���	#FF19A405���	#FF279003.��50      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentSave=�6*   51      �� 52      -   5        $ 
delete_btn��52      $
��Left=�6B   $��
727,63,0,0q�6]   $	��Top=�6q   ���	#FFCC4F4F���	#FFD04E4E.��54        $ Delete=�6*   55      �� 57      -   5        $ add_btn��57      $
��Left=�6<   $��
662,63,0,0q�6W   $	��Top=�6k   .��58        $
 Plus=�6*   59      �� 5:      -   5         ��Name$	 img��5:   B    �� BitmapScalingMode$ HighQuality=�6   $
��Left=�6O   $��89��6j   $��
290,50,0,0q�6v   $	��Top=�6�   $	��151��6�   5<      5=      5>      