   M S B A M L   `   `   `  ����G  CContactsWSIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ContactsWSIOContactsWSIO  5   	   ?$clr-namespace:ContactsWSIO.ViewmodelContactsWSIO.Viewmodel  5   	   9!clr-namespace:ContactsWSIO.ModelsContactsWSIO.Models  5   	   #    ContactsWSIO.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ContactsWSIO     5   	   :	Viewmodel$clr-namespace:ContactsWSIO.Viewmodel     5   	   3Model!clr-namespace:ContactsWSIO.Models     5   	     � Title$  
ContactApp��5
   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowState$ Normal=�6Z   ���	#FFD0C7BB � DataContext 5      *   $ContactsWSIO.Viewmodel.MainViewModel  5   
   .��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $��Contacts��6-   $��27(�6@   $��IBM Plex Sans Medium)�6N   $
��Left=�6p   $��Center=�6�   �� 5   
   -   5        $��FilterTextBox��5   B   $��1��6   $��2��6"   $��20��66   6W   �� 5!   
   -   5         ��Name$ UserList��5!      $��1��6%   $��3��62   $��5��6C   ���	#FFBBAF9F���	#FF001038��6n   �� *Users+ �� View 5"      �� 5#      .P�5$      �� $��	Firstname��6P    �� Width$
 Auto��6c   	 �� DisplayMemberBinding	 6%   �� *	FirstName+6c   �� 5%      $��Lastname��6O   $
 Auto��6a   	 6%   �� *
LastName+6a   �� 5&      $��Email��6L   $
 Auto��6[   	 6%   �� *Email+6[   �� 5'      $��Phone��6L   $
 Auto��6[   	 6%   �� *Phone+6[   �� 5(      $��Mobil��6M   $
 Auto��6\   	 6%   �� *Mobile+6\   5)      5+      a� 5-   
   $��3��6   $��7q�6'   
 �� Orientation$
 
Horizontal=�62   .+�5.      �� -   5         ��Name$ btn_addContact��5.   !   $��+��6   $��5q�6V   $��25��6a   $��25��6l   �� 5/      -   5        $ btn_editContact��5/   !   $��/��6   $��5q�6X   $��25��6c   $��25��6n   �� 50      -   5        $ btn_deleteContact��50   !   $��x��6   $��5q�6\   $��25��6g   $��25��6r   �� 51      -   5        $ 
testbutton��51   :   $��4��6   $��
Testbutton��6%   $��25��6g   $��25��6r   52      �� 54   
   -   5        $ btn_settings��54   �   $��4��6   $��Settings��6!   $��30��64   $��50��6@   $��Right=�6K   $	��Top=�6g   $��5q�6   6�   58      59      