   M S B A M L   `   `   `  ����J  FCountriesAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CountriesAppWPFCountriesAppWPF  5   	   #    CountriesAppWPF.CountryWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CountriesAppWPF     5   	     � Title$  Country Details��5   	   $	��400��5	   	   $	��600��5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��10q�6"   .+�5      �� $
��Bold"�65   $��16(�6G   ��6   ��  �� XPath$ @Name��6G   �� 5      $��Capital:��6   $
��Bold"�6(   �� 5      ��6   �� $ Capital���� 5      $��Population:��6   $
��Bold"�6+   �� 5      ��6   �� $ 
Population��5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��CityDataGrid��5         AutoGenerateColumns$ False��5      $��1��5      $��10q�6    ��5      �� $ Cities/City��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� $ @Name��  5      $ 
Population��6%    69   �� $ 
Population��  5      $ 
Attraction��6%    69   �� $ 
Attraction��5       5!      5"      