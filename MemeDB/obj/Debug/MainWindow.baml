   M S B A M L   `   `   `  ����A  =MemeDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MemeDBMemeDB  5   	   5clr-namespace:MemeDB.PropertiesMemeDB.Properties  5   	       MemeDB.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MemeDB     5   	   0resxclr-namespace:MemeDB.Properties     5   	   -   5          �Name$  MyMainWindow��5	   �    � Title$ 
MainWindow��6	   $	��720��6   $
��1280��6)   $	��300��66   $	��200��6E    � WindowStyle$
 None=�6U   ���#34495e � 
ResizeMode$ 	CanResize=�6}    � 	Resources 5
       �� 
TargetType �� Property �� Value   MyImagesItemTemplate � RowDefinitions	 �� Path   BooleanToVisibilityConverter+   %MemeDB.TextInputToVisibilityConverter " TextInputToVisibilityConverter��%k  '��       &	  x     &	     &	 0    �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      .R�5      � 5      5      5      �� 5   
   .R�5      � -   5        $	��100��5      $	��100��6    5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5      �� $��0��6   $��80��6G   $	��100��6S   $��UniformToFill=�6_   ��6%   �� $	 	Thumbnail�6_   �� 5      $��1��6   $��Center=�6C   ���#3498db$
��Bold"�6u   $��0q�6�   $��0q�6�   ��6%   �� $
	 Name�6�   5      5      �� 5   
   6'     5   
   6/   5       .��5!      ]� .+�5"   
   ]� -   5        $��	WindowBar��5"      $	��Top=�6%   $��30��6:   ��.  ���#2c3e50.+�5#      �� -   5        $��Right=�5#      $��25��6,   
������ ���#3498db$
��Bold"�6e   $��20(�6w   $��0q�6�   -  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  
������ $��Marlett)�6�   .��6�   r6�   �� 5$      -   5        $��Right=�5$      $��25��6,   
������ ���#3498db$
��Bold"�6e   $��20(�6w   $��0q�6�   
 .  
������ $��Marlett)�6�   $��25��6�   $��Bottom=�6�   .��6#  26&  �� 5%      -   5        $��Right=�5%      $��25��6,   
������ ���#3498db$
��Bold"�6e   $��20(�6w   $��0q�6�   
 .  
������ $��Marlett)�6�   $��25��6�   $��Bottom=�6�   .��6#  06&  �� 5&      ���#3498db$��20(�6)   $
��Bold"�67   $	��7,2q�6I   $
��Left=�6W   .��6m   MemeDB6u   o� 5'      
������ ���#3498db$��20,0,0,0q�6A   $��20(�6S   $��0q�6a   .@�5(      m� $
��File��6   ���#3498db.@�5)      m� -   5        $��MenuButtonAdd��5)      $	��Add��64   6A   �� 5+      m� 5,      -   5        $��MenuButtonExit��5,      $
��Exit��65   6C   5-      m� 5.      $
��Edit��6   ���#3498db.@�5/      m� -	   5        $��MenuButtonEditMeme��5/      $��	Edit Meme��69   {�.  6m   m� 50      -
   5        $��MenuButtonDeleteMeme��50      $��Delete Meme��6;   {�.  6s   51      m� 53      -   5        $��MenuButtonAbout��53      $��About��62   ���#3498db6V   54      55      ]� 56   
   .+�57      ]� $	��150��6   ���#2980b9$
��Left=�69   .+�58      �� $	��Top=�6   $��10,0,0,0q�6-   
�������$��20(�6R   $
��Bold"�6`   $	��7,2q�6r   .��6�   Tags:6�   �� 59      -   5        $��btnEdit��59      $��Bottom=�6(   $��5q�6@   ���#2c3e50���#3498db$
��Bold"�6u   $��20(�6�   .��6�   Edit6�   �� 5:      -   5        $��lbTags��5:   1    �� SelectionMode$ Single=�6   $��15(�6?   $��0q�6M   $��10q�6a   
����������#34495e$��Disabled=�6�   $��Hidden=�6�   6�   5;      � 5=      $��10q�6   $	��Top=�6   $
��Left=�64   $��30��6O   .+�5>      �� -   5        $��tbPreviewSearchBar��5>      $��15(�66   $��30��6D   $	��400��6P   $��	Search...��6\   
����İ�y�5?      `� 5@       `� 	Converter# [ 6'   .1�5A      ��  �� ElementName$ txtSearchBox��6&   $	 Text.IsEmpty�6A   �� 5B      $ txtSearchBox��6&   $	 	IsFocused�6A   5C      5E      �� 5F      -   5        $��txtSearchBox��5F   ~   $��15(�6    �� 
CaretBrush �#3498db$��30��6=   $��0q�6I   $	��400��6]   ���#3498db
������ 6�   �� 5G      ���	#FF3498DB$��2��63   $��Bottom=�6>   5H      �� 5I      -   5        $��MainList��5I      $ Single=�6&    J� 	AllowDrop . $��0q�6�   #��[  6�   $��Disabled=�6	  
������ ��6�   �� $	 Memes�$ MyMainWindow��6�  5J      5K      '  !System.Windows.Shell.WindowChrome   WindowChrome 5L        5M   
      CaptionHeight$ 1Q�5N   	      CornerRadius$ 0��5O   	      ResizeBorderThickness$ 4q�5P   	      GlassFrameThickness$ 0q�5Q   	   5R      5T      