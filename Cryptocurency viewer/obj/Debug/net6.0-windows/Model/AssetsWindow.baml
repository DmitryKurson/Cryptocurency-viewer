   M S B A M L   `   `   `  ????O  KCryptocurency viewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Cryptocurency_viewerCryptocurency_viewer  5   	   '    !Cryptocurency_viewer.AssetsWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Cryptocurency_viewer     5   	     ? Title$  Assets??5   	   $	??450??6   $	??800??6%   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5      .+?5   
   ?? -   5         ??Name$ assets_window??5       ?? Orientation$ 
Horizontal=?6,   .+?5      ?? -   5         ??Name$ AW_filter_lbl??5      $??Filter:??6/   $??5q?6>   ?? 5      -   5         ??Name$ 
AW_textbox??5      $	??200??6k   $??5q?6w   ??6*   ?? *
FilterText+ ?? UpdateSourceTrigger$ PropertyChanged=?6w   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AW_datagrid??5      $??1??6(   $??5q?65      AutoGenerateColumns$ False??6d   ??6@   ?? *AssetsItems+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Assets id??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ?? *
asset_id+  5      $

 Name??6%    63   ?? *name+  5      $
 Price??6%    64   ?? *price+  5      $
 
Volume 24h??6%    69   ?? *
volume_24h+  5      $
 	Change 1h??6%    68   ?? *	change_1h+  5      $
 
Change 24h??6%    69   ?? *
change_24h+  5      $
 	Change 7d??6%    68   ?? *	change_7d+  5      $
 Status??6%    65   ?? *status+  5      $
 
Created at??6%    69   ?? *
created_at+  5      $
 
Updated at??6%    69   ?? *
updated_at+5      5       5!      