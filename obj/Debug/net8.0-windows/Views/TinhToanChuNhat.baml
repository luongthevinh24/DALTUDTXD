   M S B A M L   `   `   `  ����l  h67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Fclr-namespace:_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views8_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views  5      �Kclr-namespace:_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels=_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels  6c   N    H_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views.TinhToanChuNhat   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      XlocalFclr-namespace:_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views     5      ZvmKclr-namespace:_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels     6c     � Title$,  &TÍNH TOÁN TIẾT DIỆN CHỮ NHẬT��5   	   $	��600��6.   $	��900��6;    � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5	       � DataContext 5
      L   F_67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels.ChucNang  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��550 �6   �� 5      $	��350 �6    � RowDefinitions 5   
   �� 5      $	��250 �6   �� 5      $	��250 �6   �� 5      $	��100 �6   .+�5   
   � $��0��6   $��0��6   $��5��6,   $	��600��6=   
�������$	��550��5   '   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ BangThongSo��5         AutoGenerateColumns$ False��6,   $
��Left=�5      $	��Top=�6&   $��	30,10,0,0q�6>   $	��200��5      $	��490��6      
IsReadOnly$
 True��5      	   SelectionMode$	 Single=�6   ��5   H   �� *dsm+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *STT+6N     5!      $ Chọn thép��6)   $	 180 6X    6<   �� *	MatBang+6X     5"      $ Tổng diện tích As��6)   $	 150 6_    6D   �� *BeTong+6_     5#      $ 
Số thanh��6)    6;   �� *
CotThepDoc+5&      5'      �� 5*   
   $��Thông số tính toán��6   $��Right=�6/   $	��320��6K   $	��250��6W   $	��Top=�5+      $��0,0,15,0q�6+   $��0��5,      $��1��6    $��2q�60   .��5-      �� $��10q�6   .+�5.      �� $	��Er:��6   $��Center=�6'   �� 5/       �� 
IsReadOnly$
 True��6;   $��5q�6M   ���#FFF��6   �� *Er+ �� Mode$ OneWay=�6X   �� 51      $	��Ar:��6   $��Center=�6'   �� 52      $
 True��6;   $��5q�6M   ���#FFF��6   �� *Ar+$ OneWay=�6X   �� 54      $��Chiều cao dầm (h):��6   $��Center=�66   �� 55      $��5q�6R   ��6   �� *H+ �� UpdateSourceTrigger$ PropertyChanged=�6R   �� 57      $��Chiều rộng dầm (b):��6   $��Center=�67   �� 58      $��5q�6R   ��6   �� *B+$ PropertyChanged=�6R   5;      ��5<      �� 5=       �� 
TargetType" ��6   .�5>      ��  �� Property � �� �� Value 5?      �� 5@      .R�5A   "   �� 
���   �$
��Bold"�6P   $��14(�6b   ��6,   �� 6b   5B      5D      5E      5G      �� 5I   
   $��Thông số vật liệu��6   $��Right=�6.   $	��320��6J   $	��250��6V   $	��Top=�5J      $��0,0,15,0q�6#   $��1��5K      $��1��6   $��2q�6(   .��5L      �� $��10q�6   .+�5M      �� $��Rb (Bê tông):��6   $��Center=�61   �� 5N      $
 True��6;   $��5q�6M   ���#FFF��6   �� *Rb+$ OneWay=�6X   �� 5P      $��Rbt (Bê tông):��6   $��Center=�62   �� 5Q      $
 True��6<   $��5q�6N   ���#FFF��6   �� *Rbt+$ OneWay=�6Y   �� 5S      $��Rs (Cốt thép):��6   $��Center=�62   �� 5T      $
 True��6;   $��5q�6M   ���#FFF��6   �� *Rs+$ OneWay=�6X   5U      ��5V      �� 5W      " ��6   .�5X      ��  � �� 5Y      �� 5Z      .R�5[   "   �� 
���   �$
��Bold"�6P   $��14(�6b   ��6,   �� 6b   5\      5^      5_      5a      �� 5e   
   $��1��6   $��4��6%    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��	0,0,50,30q�6g   .+�5f      �� $��Tính toán��6   $	��100��6T   $��40��6`   $��10q�6l   ���#105FAD���#105FAD��6)   �� *TinhToanChuNhatCommand+6�   �� 5g      $��
Hủy bỏ��6   $	��100��6L   $��40��6X   $��10q�6d   ���#105FAD���#105FAD��6&   �� *ChuyenDenTrangChu+6�   5h      5j      5k      