   M S B A M L   `   `   `  ���� A  =MemeDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MemeDBMemeDB  5clr-namespace:MemeDB.PropertiesMemeDB.Properties      MemeDB.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:MemeDB     0resxclr-namespace:MemeDB.Properties     -     �Name$  MyMainWindow�� � Title$ 
MainWindow��$	��720��$
��1280��$	��300��$	��200�� � WindowStyle$
 None=����#34495e � 
ResizeMode$ 	CanResize=� � 	Resources  �� 
TargetType �� Property �� Value   MyImagesItemTemplate � RowDefinitions	 �� Path   BooleanToVisibilityConverter+   %MemeDB.TextInputToVisibilityConverter " TextInputToVisibilityConverter��%>  '��       &	  +     &	     &	     �� " ��.���  � �� �� .R�� �� .R�� -   $	��100��$	��100�� �� $
��auto ��� $
��auto �.+��� $��0��$��80��$��90��$��UniformToFill=����� $	 	Thumbnail��� $��1��$��Center=����#3498db$
��Bold"����� $
	 Name���   .��]� .+�]� -   $��	WindowBar��$	��Top=�$��30����.  ���#2c3e50.+��� -   $��Right=�$��25��
������ ���#3498db$
��Bold"�$��20(�$��0q�-  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  
������ $��Marlett)�.��r�� -   $��Right=�$��25��
������ ���#3498db$
��Bold"�$��20(�$��0q�
 .  
������ $��Marlett)�$��25��$��Bottom=�.��2�� -   $��Right=�$��25��
������ ���#3498db$
��Bold"�$��20(�$��0q�
 .  
������ $��Marlett)�$��25��$��Bottom=�.��0�� ���#3498db$��20(�$
��Bold"�$	��7,2q�.��MemeDB]� .+�]� $	��150�����#2980b9$
��Left=�.+��� $	��Top=�$��10,0,0,0q�
�������$��20(�$
��Bold"�$	��7,2q�.��Tags:�� -   $��	btnRemove��$��Bottom=�$��5q����#2c3e50���#3498db$
��Bold"�$��20(�.��Remove�� -   $��btnEdit��$��Bottom=�$��5q����#2c3e50���#3498db$
��Bold"�$��20(�.��Edit�� -	   $��lbTags�� �� SelectionMode$ Single=�$��15(�$��0q�$��10q�
����������#34495e$��Disabled=�$��Hidden=�� $��10q�$	��Top=�$
��Left=�$��30��.+��� -
   $��tbPreviewSearchBar��$��15(�$��30��$	��400��$��	Search...��
����İ�y�`�  `� 	Converter# [ .1���  �� ElementName$ txtSearchBox��$	 Text.IsEmpty��� $ txtSearchBox��$	 	IsFocused��� -   $��txtSearchBox��$��15(� �� 
CaretBrush �#3498db$��30��$��0q�$	��400�����#3498db
������ �� ���	#FF3498DB$��2��$��Bottom=��� -   $��MainList��$ Single=� J� 	AllowDrop . $��0q�#��[  $��Disabled=�
������ ���� $	 Memes�$ MyMainWindow��'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 1Q�   CornerRadius$ 0��   ResizeBorderThickness$ 4q�   GlassFrameThickness$ 0q�