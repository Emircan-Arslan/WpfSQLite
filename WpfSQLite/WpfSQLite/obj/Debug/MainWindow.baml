   M S B A M L   `   `   `  ����D  @WpfSQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfSQLite	WpfSQLite  5   	       WpfSQLite.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfSQLite     5   	   -   5          � Title$  
MainWindow��5   	   $��600.564��6   $��813.534��6-   .��5	      � -   5         �Name$ 	btnKaydet��5	      .+�5
   
   �� $��SQLite Çalışması ��6   $
��Left=�6,   $��
246,29,0,0q�6G   $	��Top=�6[   $��36(�6s   �� 5   
   $��Öğrenci No : ��6   $
��Left=�6(   $��
53,132,0,0q�6C   $	��Top=�6W    J� RenderTransformOrigin$ 0.313,0.184&�6o   $��18(�6�   �� 5   
   $��Öğrenci Not : ��6   $
��Left=�6)   $��
46,193,0,0q�6D   $	��Top=�6X   $��18(�6p   �� 5   
   -   5         ��Name$ txtOgrenciNo��5      $
��Left=�6(   $��34��6C   $��173,132,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��297��6�   �� 5   
   -   5        $ txtOgrenciNot��5      $
��Left=�6)   $��34��6D   $��173,193,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��297��6�    �� 	MaxLength$ 3��6�   �� 5   
   -   5         ��Name$ 
btnKaydet1��5      $��KAYDET��6%   $
��Left=�66   $��95��6Q   $��494,132,0,0q�6]   $	��Top=�6r   $��84��6�   $��16(�6�   6�   �� 5   
   -   5        $ btnSil��5      $
��SİL��6!   $
��Left=�6/   $��601,133,0,0q�6J   $	��Top=�6_   $��84��6w   $��95��6�   $��16(�6�   �� 5   
   -   5        $ btnGuncelle��5      $��	GÜNCELLE��6&   $
��Left=�69   $��698,134,0,0q�6T   $	��Top=�6i   $��84��6�   $��95��6�   $��16(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dataGrid1��5      $
��Left=�6&   $	��202��6A   $��
53,265,0,0q�6N   $	��Top=�6b   $	��729��6z   6�   5      5      