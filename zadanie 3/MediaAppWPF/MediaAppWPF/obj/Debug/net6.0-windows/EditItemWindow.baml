   M S B A M L   `   `   `  ����F  BMediaAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MediaAppWPFMediaAppWPF  5   	        MediaAppWPF.EditItemWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MediaAppWPF     5   	     � Title$  Edit Media Item��5   	   $	��300��6!   $	��400��6.   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Title:��6   $��0��6"   $��0��6/   $��Center=�6?   �� 5   
   $��0��6)   $��1��66   $��5q�6F   ��6   �� *Title+6F   �� 5   
   $��Author/Director:��6   $��1��6,   $��0��69   $��Center=�6I   �� 5   
   $��1��64   $��1��6A   $��5q�6Q   ��6   �� *AuthorOrDirector+6Q   �� 5   
   $��Publisher/Studio:��6   $��2��6-   $��0��6:   $��Center=�6J   �� 5   
   $��2��65   $��1��6B   $��5q�6R   ��6   �� *PublisherOrStudio+6R   �� 5   
   $��Media Type:��6   $��3��6'   $��0��64   $��Center=�6D   �� 5   
   $��3��6.   $��1��6;   $��5q�6K    �� Text 6   �� *	MediaType+.@�5      �� $��CD��6   �� 5      $	��DVD��6   �� 5       $��BlueRay��6   5!      �� 5"   
   $��Release Date:��6   $��4��6)   $��0��66   $��Center=�6F   (  "System.Windows.Controls.DatePicker  5#   
   $��4��6:   $��1��6G   $��5q�6W      SelectedDate 6   �� *ReleaseDate+6W   �� 5$   
    �� Orientation$ 
Horizontal=�6   $��5��6.   $��2��6;   $��Right=�6O   $��5q�6k   .+�5%      �� -   5        $��OK��5%      $��75��6"   $��5q�6-    �� 	IsDefault$
 True��68   6I   �� 5&      $��Cancel��6   $��75��6&   $��5q�61    �� IsCancel$
 True��6<   5'      5)      5*      