   M S B A M L   `   `   `  ����  ContactsWSIO#    ContactsWSIO.Views.AddContact   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
AddContact��5   	   $	��550��6   $	��400��6)    � ShowInTaskbar .   � 
ResizeMode$ NoResize=�6K    � WindowStartupLocation$ CenterScreen=�6a   .��5	      � $��15q�6   .+�5
   
   �� .+�5      �� $��Add a Contact��6   $��25(�6,   $��IBM PLex Sans)�6:   $��Center=�6U   �� 5      $��Vorname��6   $��5q�6'   �� 5      -   5         ��Name$ tb_firstname��5      ��6,   �� *	Firstname+�� 5      $��Nachname��6   $��5q�6(   �� 5      -   5        $ tb_lastname��5      ��6+   �� *
Lastname+�� 5      $��Email��6   $��5q�6%   �� 5      -   5        $ tb_email��5      ��6(   �� *Email+�� 5      $��Telefon��6   $��5q�6'   �� 5      -   5        $ tb_phone��5      ��6(   �� *Phone+�� 5      $��Handy��6   $��5q�6%   �� 5      -   5        $ 	tb_mobile��5      ��6)   �� *Mobile+�� 5      $��Birthday��6   $��5q�6(   � 5       � ColumnDefinitions 5      �� 5      $
��1,5* �6'   �� 5       $
��0,5* �6'    � RowDefinitions 5#      �� 5$      $��1* �6$   �� 5%      $��1* �6$   �� 5&      $��1* �6$   .+�5)      �� -   5        $ tb_birthday��5)      �� 5*      -   5         ��Name$ btn_setbirthday��5*   H   $��1��6   $��5,0,0,0q�6)   $	��Set��6:   6a   &   System.Windows.Controls.Calendar  5+      -   5          Name$ cal_seld��5+   L   $��0��6   $��1��6+   $y�Hidden=�68   
�������
���   �	   FirstDayOfWeek$	 Monday=�5.   N   5/      50      51      � 53   
   
 � Orientation$
 
Horizontal=�6   $��Right=�6-   $��Bottom=�6I   .+�54      �� -	   5        $ btn_esc��54   )   $��
Schließen��6   $��0,0,5,0q�6P   �� 55      -
   5        $ btn_saveContact��55   )   $��	Speichern��6   ���	#FF2931AF
����������	#FF38509C��6�   �� *CreateContactFiles+56      57      58      