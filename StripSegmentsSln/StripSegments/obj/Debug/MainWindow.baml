   M S B A M L   `   `   `  ����H  DStripSegments, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:StripSegmentsStripSegments  5   	   A =Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:Common;assembly=CommonCommon 63   M IAttachedProperties, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:AttachedProperties;assembly=AttachedPropertiesAttachedProperties 6e       StripSegments.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:StripSegments     5   	   5comm$clr-namespace:Common;assembly=Common     63   Kap<clr-namespace:AttachedProperties;assembly=AttachedProperties     6e     � Title$  
MainWindow��5   	   $	��450��6   $
��1200��6)    � 	Resources 5
         StripSegments.Segment 	  range   Begin
   End-   'StripSegments.StripsViewModelProperties  viewModelDisigned   Step   Size!   StripSegments.SegmentDtoExt   Begin
   End   Range	   Strips   StripSegments.Strip
   Range   Segments"  Common.DoubleMediumConverter  DoubleMedium(   "StripSegments.SizeToValueConverter  SzeConverter��%w  &	        &	 ,     7   7   &	 !    &	 4      5   
   $	 100Q�6&   $	 800Q�62     5   
   $ 10Q�5       5        $
 -500Q�$
 1800Q� 5        $	 100Q�$	 800Q�	 5        5      8
   . 5        $ 0Q�6$   $	 200Q�6.     5      $	 300Q�6$   $	 600Q�60     5      $	 700Q�6$   $
 1100Q�60   5        5      8
  . 5        $ 50Q�6$   $	 250Q�6/     5      $	 300Q�6$   $	 400Q�60     5      $	 500Q�6$   $	 650Q�60     5      $	 750Q�6$   $
 1000Q�60   5      5!        5"   
   6%     5#   
   6%   5$      .��5(      �  � RowDefinitions 5)   
   �� 5*      $
��Auto �6   �� 5+      �� 5,      $
��Auto �6    � ColumnDefinitions 5.   
   �� 5/      $	��100 �6   �� 50      �� 51      $	��100 �6   .+�53   
      StripSegments.StripsUC  -   5          Name$ 	stripView��53      $��1��6,   $��1��69   $��5q�6I   
��� � �$��1q�54   ,      StripsSource 55      �� *Strips+�� 56   
   $��5q�6   ��6   �� *
Size.Begin+�� 57   
   $��5q�6   $��1��6   $
��Left=�6/   ��6J   �� *Range.Begin+�� 58   
   $��5q�6   $��1��6   $��Right=�6/   ��6K   �� *	Range.End+�� 59   
   $��5q�6   $��2��6   ��6/   �� *
Size.End+�� 5:   
   $��5q�6   $��2��6   $��1��6,    �� Orientation$ 
Horizontal=�6<    � SmallChange$ 0Q�5;       �� ViewportSize 6$   �� *LengthRange+ � Maximum 6I   �� *MediumMaximum+ � Minimum 6k   �� *MediumMinimum+ � Value 6�   �� *MediumValue+.  (AttachedProperties.RoutedCommandBindings   RoutedCommandBindings 5@      -	  'AttachedProperties.RoutedCommandBinding	  5A       �� LineLeftCommand 	  RoutedCommand# Z 6[    	  Command 6*   �� *PrevStepCommand+ �� Mode$ OneWay=�6[   	  5B       �� LineRightCommand# Z 6[    6*   �� *NextStepCommand+$ OneWay=�6[   5D      5E      5F      