   M S B A M L   `   `   `  ????O  KCryptocurency viewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Cryptocurency_viewerCryptocurency_viewer  5   	   '    !Cryptocurency_viewer.MarketWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Cryptocurency_viewer     5   	     ? Title$  Market??5   	   $	??450??6   $	??800??6%   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5      .+?5   
   ?? -   5         ??Name$ market_window??5       ?? Orientation$ 
Horizontal=?6,   .+?5      ?? -   5         ??Name$ MW_filter_lbl??5      $??Filter:??6/   $??5q?6>   ?? 5      -   5         ??Name$ 
MW_textbox??5      $	??200??6k   $??5q?6w   ??6*   ?? *
FilterText+ ?? UpdateSourceTrigger$ PropertyChanged=?6w   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ MW_datagrid??5      $??1??6(   $??5q?65      AutoGenerateColumns$ False??6d   ??6@   ?? *MarketItems+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Exchange id??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *exchange_id+  5      $
 Symbol??6%    65   ?? *symbol+  5      $
 
Base asset??6%    69   ?? *
base_asset+  5      $
 Quote asset??6%    6:   ?? *quote_asset+  5      $
 Price uncovered??6%    6>   ?? *price_unconverted+  5      $
 Price??6%    64   ?? *price+  5      $
 
Change 24h??6%    69   ?? *
change_24h+  5      $
 Spread??6%    65   ?? *spread+  5      $
 
Volume 24h??6%    69   ?? *
volume_24h+  5      $
 Status??6%    65   ?? *status+  5      $
 
Created at??6%    69   ?? *
created_at+  5      $
 
Updated at??6%    69   ?? *
updated_at+5!      5"      5#      