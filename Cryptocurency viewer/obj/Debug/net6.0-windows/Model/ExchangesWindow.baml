   M S B A M L   `   `   `  ????O  KCryptocurency viewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Cryptocurency_viewerCryptocurency_viewer  5   	   *    $Cryptocurency_viewer.ExchangesWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Cryptocurency_viewer     5   	     ? Title$  	Exchanges??5   	   $	??450??6   $	??800??6(   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5      .+?5   
   ?? -   5         ??Name$ exchange_window??5       ?? Orientation$ 
Horizontal=?6.   .+?5      ?? -   5         ??Name$ EW_filter_lbl??5      $??Filter:??6/   $??5q?6>   ?? 5      -   5         ??Name$ 
EW_textbox??5      $	??200??6k   $??5q?6w   ??6*   ?? *
FilterText+ ?? UpdateSourceTrigger$ PropertyChanged=?6w   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ EW_datagrid??5      $??1??6(   $??5q?65      AutoGenerateColumns$ False??6g   ??6@   ?? *ExchangesItems+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Exchange id??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *exchange_id+  5      $

 Name??6%    63   ?? *name+  5      $
 Website??6%    66   ?? *	website+  5      $
 
Volume 24h??6%    69   ?? *
volume_24h+5      5      5      