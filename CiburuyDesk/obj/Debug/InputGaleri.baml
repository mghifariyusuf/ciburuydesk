   M S B A M L   `   `   `  ����F  BCiburuyDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CiburuyDeskCiburuyDesk  5   	       CiburuyDesk.InputGaleri   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CiburuyDesk     5   	     � Title$  Ciburuy Desk��5   	   $	��720��6   $
��1280��6+    � WindowState$ 	Maximized=�68    � WindowStartupLocation$ CenterScreen=�6P   $��Center=�6u   $��Center=�6�    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��640* �6   �� 5      $
��640* �6   .+�5   
   �� -   5         ��Name$ bg��5      $��0.2,0.2,-0.2,0.6q�6   $��
img/bg.png��66   $
��Fill=�6J   $��Center=�6Y   $��Center=�6v   $��2��6�   � 5   
   $��2��6   $��256,69,255.6,252.4q�6#   .+�5      �� -   5        $ tile_1_Copy��5      $��img/picture-icon.png��6)   $��Center=�6G   $	��200��6d   $��425,48,65,86q�6q   $��Center=�6�   $	��200��6�    � Cursor$
 Hand��6�   �� 5      -   5         ��Name$ button��5      $��Pilih Gambar��6%   $��Center=�6<   $��425,261,161,35q�6Y   $��Center=�6q   $	��104��6�   $��38��6�   $��16(�6�   $��4��6�   �� 5      -   5        	 ��Name$	 keteranganRichTextBox��5      $��Center=�69   $	��179��6V   $��11,145,305,10q�6c   $��Center=�6z   $	��374��6�   $��22(�6�   $��3��6�   . �5      /� 5      �� 5      -   5        
 ��Name$
 label��5      $��Gambar��6#   $��Center=�64   $��425,0,175,300q�6Q   $��Center=�6h   $��22(�6�   $��34��6�   $��90��6�   �� 5      -   5        $
 label1��5      $��
Keterangan��6$   $��Center=�69   $��0,102,549,194q�6V   $��Center=�6m   $��22(�6�   $��38��6�   $	��141��6�   �� 5      -   5        $
 label2��5      $��Judul��6$   $��Center=�64   $��0,48,611,242q�6Q   $��Center=�6g   $��22(�6�   $��44��6�   $��79��6�   �� 5      -   5         ��Name$ judulTextBox��5      $��Center=�6,   $��95,52,305,247q�6I    �� TextWrapping$
 Wrap=�6`   $��Center=�6t    J� RenderTransformOrigin$ 0.323,0.474&�6�   $	��290��6�   $��35��6�   $��22(�6�   $��2��6�   �� 5      -	   5        $
 label3��5      $��ID��6$   $��Center=�61   $��0,0,656,290q�6N   $��Center=�6c   $��22(�6~   $��44��6�   $��34��6�   �� 5      -
   5        $ 	IDtextBox��5      $��Center=�6)   $��95,3,496,296q�6F   $
 Wrap=�6\   $��Center=�6p   $��99��6�   $��35��6�   $��22(�6�   $��1��6�   �� 5      -   5        $ filenameTextBox��5      $��Center=�6/   $��20��6L   $��424,304,10,10q�6X   $
 Wrap=�6o   $��Center=�6�   $	��256��6�   {�.  ���	#FFFF9600���	#FFFF9600$��Italic$�6�   5      �� 5   
   -   5        $ button1��5      $��Simpan��6"   $��Center=�63   $��565,462,563.6,191.4q�6P   $��Center=�6m   $	��145��6�   $��37��6�   $��20(�6�   $��2��6�   $��5��6�   �� 5   
   -   5        $
 back��5      $��img/back-icon.png��6   $
��Left=�69   $��47��6T   $��	10,10,0,0q�6`   $	��Top=�6s   $��47��6�   6�   5!      5"      