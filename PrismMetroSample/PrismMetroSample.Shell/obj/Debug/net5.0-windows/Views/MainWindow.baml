   M S B A M L   `   `   `  ����Z  VPrismMetroSample.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�`clr-namespace:PrismMetroSample.Infrastructure.Constants;assembly=PrismMetroSample.Infrastructure)PrismMetroSample.Infrastructure.Constants  5	       PrismMetroSample.Shell-   'PrismMetroSample.Shell.Views.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Y UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      T	 PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f8metro,http://metro.mahapps.com/winfx/xaml/controls 	 5      _
 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors 
 5      mregion`clr-namespace:PrismMetroSample.Infrastructure.Constants;assembly=PrismMetroSample.Infrastructure 
 5	        � WindowStartupLocation$  CenterScreen=�5         AccentColorBrush( 	 "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel True5      $	��800��6>   $	��800��6K    � Title$ 
MainWindow��6W   !  Prism.Regions.RegionManager   RegionManager 5
      �� *RegionMannager+* 
 $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      + 
 %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   * 
 $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2 
 ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *LoadingCommand+5      	   Flyouts	 5      + 	 %MahApps.Metro.Controls.FlyoutsControl  5   
   -   5        
  Name$
 flyoutsControlRegion��5         RightWindowCommands 5      +	 	 %MahApps.Metro.Controls.WindowCommands	  5   
   -   5         	 Name$ rightWindowCommandsRegion��5      .��5      0
 	 *MahApps.Metro.Controls.MetroContentControl
  .��5   
   � .+�5      � $��1��6    � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5!      ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� $m��gpack://application:,,,/PrismMetroSample.Infrastructure;Component/Assets/Photos/Home, homepage, menu.png��6   $��40��6�   �� 5#      $
��Home��6   $��35(�6+   $
��Bold"�69   5%      �� 5&      $��1��6   .+�5'      �� $��Load MedicineModule��6   $��25(�6<   $��5q�6K   ��6V   �� *LoadMedicineModuleCommand+A� 5(      $��5q�6"   ;   5PrismMetroSample.Infrastructure.Constants.RegionNames   UniformContentRegion   
RegionName# Z 6-    A� Columns$ 2��6�   .+�5)      �� $��ActivePaientList��6!   $��5q�6<   ��6G   �� *ActivePaientListCommand+�� 5*      $��DeactivePaientList��6!   $��5q�6>   ��6I   �� *DeactivePaientListCommand+�� 5+      $��ActiveMedicineList��6!   $��5q�6>   ��6I   �� *ActiveMedicineListCommand+�� 5,      $��DeactiveMedicineList��6!   $��5q�6@   ��6K   �� *DeactiveMedicineListCommand+5-      5.      �� 50      -   5         ��Name$ patientListRegion��50   !   $��2��6<      PatientListRegion# Z 6I   $��10q�6�   �� 51      -   5        $ medicineMainContentRegion��51   !   $��3��6D       MedicineMainContentRegion# Z 6Q   52      53      54      56      