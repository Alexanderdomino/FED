   M S B A M L   `   `   `  ????F  BTheDeptBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TheDeptBook.MVVM.ViewModelTheDeptBook.MVVM.ViewModel  5   	       TheDeptBook.ContactWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >	viewmodel(clr-namespace:TheDeptBook.MVVM.ViewModel     5   	     ? Title$  ContactWindow??5   	   $	??200??6   $	??250??6,    ? 	Resources 5	         
TboxMargin  
TblkMargin  ButtonMargin??%?   &	        &	       &	 B     u?5
   
   0,10,0,0q?61   u?5   
   
0,10,0,-10q?63   u?5   
   	10,0,10,0q?64   5      .??5      ??  5   
    ?? 
TargetType ?? Property ?? Value??%?   '??       7   '?? D     7  '?? ?     7  ?? 5      " ??6   .?5      ??  ? ??8   6Q   5      ?? 5      " ??6   .?5      ??  ? ??8   6Q   5      ?? 5      " ??6   .?5      ??  ? ??8   6S   5      5      .+?5      ?? Enter Name of Contact:5!      ?? 5"   
   -   5        $??TboxName??5"      .??6$   Name5$      ?? 5&   
   Enter initial value:5(      ?? 5)   
   -   5        $??	TboxValue??5)      .??6%   Value5+      ?? 5-   
   5/      ?? 50   
    ?? Orientation$ 
Horizontal=?6   $??Center=?51      .+?52      ?? -   5        $??
SaveButton??52      $??60??53      ??54      ?? *
AddCommand+.??64   Save56      ?? 58      -   5        $??CancelButton??58      $??60??59      ??5:      ?? *CloseAddContactCommand+.??6B   Cancel5<      5=      5>      5?      