   M S B A M L   `   `   `  ����@  <wind1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wind1wind1  5   	       wind1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:wind1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m� $��Close��6   5      5      5      �� 5   
   $��Studnets list��6   $
��Left=�6(   $��	46,31,0,0q�6C   $��1��6V   $	��Top=�6c   $��50��6{   $	��120��6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ StudGrid��5   �   $
��Left=�6   $	��242��6.   $��	46,86,0,0q�6;   $��1��6N   $	��Top=�6[   $
��auto��6s      AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Last Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   �� *
LastName+6b     5      $ 
First Name��6%   $ * 69   	 6C   �� *	FirstName+6c     5      $ Index Number��6%   $ * 6;   	 6E   �� *IndexNumber+6g     5      $ Adderss��6%   $
 1.5* 66   	 6C   �� *	Address+6a     5      $ Studies��6%   $ 2* 66   	 6A   �� *Name+6\   5       �� 5!   
   -   5        $	��Add��5!      $��Center=�6   $��516,347,148,0q�6<   $��1��6S   $	��Top=�6`   $	��128��6x   $��44��6�   $
��auto��6�   6�   �� 5"   
   -   5        $��Delete��5"      $��Center=�6"   $��634,347,0,0q�6?   $��1��6T   $	��Top=�6a   $	��128��6y   $��44��6�   $
��auto��6�   6�   �� 5#   
   -   5        
 ��Name$
 TextBox1��5#   �   $
��Left=�6   $��
46,361,0,0q�6-   $��1��6A    �� TextWrapping$
 Wrap=�6N   $��	TextBlock��6b   $	��Top=�6s   $��30��6�   $	��174��6�    �� 
IsReadOnly . 6�   �� 5$   
   -   5        $��Update��5$      $
��Left=�6"   $��392,347.4,0,0q�6=   $��1��6T   $	��Top=�6a   $
��auto��6y   $	��128��6�   $��44��6�   6�   5%      5&      