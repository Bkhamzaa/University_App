   M S B A M L   `   `   `  ����I  EUniversity_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:University_app.ViewsUniversity_app.Views  5      E'clr-namespace:University_app.ViewModelsUniversity_app.ViewModels  5      ,    &University_app.Views.StudentManagement   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:University_app.Views     5      >
viewModels'clr-namespace:University_app.ViewModels     5        � DataContext  5      2   ,University_app.ViewModels.Student_Management  5   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� $��Program:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5      -   5         ��Name$ ProgramComboBox��5      $	��200��5       �� DisplayMemberPath$
 Name��5      ��5      �� *
Programs+ �� SelectedItem 5      �� *SelectedProgram+ �� Mode$ TwoWay=�5      �� 5!   
   $ 
Horizontal=�6   $��0,0,0,10q�6.   $��1��6@   .+�5"      �� $��Level:��6   $��Center=�6&   $��0,0,10,0q�6A   �� 5#      -   5        $ LevelComboBox��5#      $	��200��5$      $
 Name��5&      ��5%      �� *Levels+ 5'      �� *SelectedLevel+$ TwoWay=�5(      �� 5)   
   -   5        $��Add Student��5)      $��86��5*      $��Center=�5+      $
��Left=�5,      $��	651,0,0,0q�5-      $��1��5.       J� RenderTransformOrigin$ 0.524,0.583&�6   5/      �� 50   
   -   5        $��Update Student��50      $��Center=�51   	   $��518,0,145,0q�52   	   $��1��53   	   $ 
0.498,0.55&�54   +   �� 56   
   -   5        $��Delete Student��56      $��89��57   	   $��Center=�58   	   $
��Left=�59   	   $��	395,0,0,0q�5:   	   $��1��5;   +   �� 5=   
   $ 
Horizontal=�6   $��342,5,-342,5q�6.   .+�5>      �� $��Search:��6   $��Center=�6'   $��0,0,10,0q�6B   �� 5?      $	��300��6   ��5@      �� *SearchQuery+ �� UpdateSourceTrigger$ PropertyChanged=�5A      &   System.Windows.Controls.DataGrid  5D   
   -   5        	  Name$	 StudentDataGrid��5J      $��2��5D      
   AutoGenerateColumns$
 False��5F         CanUserAddRows$ False��5G         CanUserDeleteRows$
 True��5H         
IsReadOnly$ False��5I      $��0,10,0,0q�5L      ��5E      �� *
Students+   Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ Cin Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *CinId+  5O      $ 
First Name��6%    69   �� *	FirstName+  5P      $ 	Last Name��6%    68   �� *
LastName+  5Q      $ Email��6%    64   �� *Email+5S      5T      5U      