   M S B A M L   `   `   `  ����I  Eaplikacja06.04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:aplikacja06._04aplikacja06._04  5   	        aplikacja06._04.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:aplikacja06._04     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         StandardButtonBackground �� Color ! SpecialButtonBackgroundStatic " SpecialButtonBackgroundHovered " SpecialButtonBackgroundPressed  SpecialLabelColor  StandardLabelStyle �� 
TargetType �� Property �� Value  SpecialLabelStyle �� BasedOn  StandardButtonStyle  SpecialButtonStyle �� Triggers P� Property	 P� Value��%Q  &	        &	      &	 <     &	 Z     &	 }     &	 �     &	 	    7  7  &	 R    7   &	 �    7  7  7  �� 5
   
   $
 #EEE��6;   �� 5   
   $
 #DDF��6@   �� 5   
   $
 #99D��6A   �� 5   
   $ 	#FF2E2EA5��6A   �� 5   
   $
 #900��64   �� 5   
   " ��6+   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 24(�6)   5      �� 5   
   " ��6*   8   .�5      ��  � ��8  6+   5      �� 5   
   " ��6,   .�5      ��  � ��$ 20(�6)   �� 5       � ��8   6+   5       �� 5"   
   " ��6+   .�5#      ��  � ��$ 20(�6)   �� 5$       � ��8   6+    5&      P� 5'       �@J�IsMouseOver$
	 True��61   . �5(      ��  � ��8  63   5)      P� 5*       � ��$
	 True��6/   . �5+      ��  � ��8  63   5,      50      52      .��55      � .+�56   
   � $��Stretch=�6   
 J� RenderTransformOrigin$
 0.5,0.5&�62   z�57      V� 58      .~�59      �� �� 5:      �� 5;       �� Angle$ -0.785Q�6&   T� 5<      5=      .+�5?      �� $	��Raz��6   #��[ 6#   $��10q�6O   �� 5@      $	��Dwa��6   #��[ 6#   $��10q�6P   �� 5A      $
��Trzy��6   #��[ 6$   $��10q�6P   �� 5B      $��Cztery��6   #��[ 6&   $��10q�6S   5C      5D      5E      