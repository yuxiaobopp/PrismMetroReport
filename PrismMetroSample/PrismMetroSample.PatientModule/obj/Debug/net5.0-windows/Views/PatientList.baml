   M S B A M L   `   `   `  ����"  PrismMetroSample.PatientModule6    0PrismMetroSample.PatientModule.Views.PatientList   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5      .��5      �  � RowDefinitions 5   
   �� 5	      $
��auto �6   �� 5
      .+�5   
   �� $��0��6   $��PatientModule��6   $��25(�65   $��5q�6C   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgPatient��5      $��1��6&      AutoGenerateColumns$ False��63   ��6O   �� *AllPatients+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ MouseDoubleClick��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *MouseDoubleClickCommand+   CommandParameter 6X   �� 	 �� ElementName$	 	dgPatient��
 �� Path$
 SelectedItem�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly$
 True��6L   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 63   �� *Name+6L     5      $	 Age��6%   $
 True��6J    62   �� *Age+6J     5      $	 Sex��6%   $
 True��6J    62   �� *Sex+6J     5      $ RoomNo��6%   $
 True��6P    65   �� *RoomNo+6P   5      �� 5   
   !
  Prism.Regions.RegionManager 
  
RegionName$ PatientDetailRegion��6   5      5      