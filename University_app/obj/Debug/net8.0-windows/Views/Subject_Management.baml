   M S B A M L   `   `   `  ����I  EUniversity_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:University_app.ViewModelsUniversity_app.ViewModels  5   K   -    'University_app.Views.Subject_Management   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >
viewModels'clr-namespace:University_app.ViewModels     6K     � DataContext  5	      2   ,University_app.ViewModels.Subject_Management  5
   
   .��5      � .+�5   
   � $��1��6   $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�62   .+�5      �� $��Program:��6   $��Center=�6,   $��0,0,10,0q�6G   �� 5      -   5         ��Name$ ProgramComboBox��5      $	��200��5       �� DisplayMemberPath$
 Name��5!      ��5       �� *
Programs+ �� SelectedItem 5"      �� *SelectedProgram+ �� Mode$ TwoWay=�5#      �� 5&      $ 
Horizontal=�6   $��0,0,0,10q�62   $��1��6D   .+�5'      �� $��Level:��6   $��Center=�6*   $��0,0,10,0q�6E   �� 5(      -   5        $ LevelComboBox��5(      $	��200��5)      $
 Name��5+      ��5*      �� *Levels+ 5,      �� *SelectedLevel+$ TwoWay=�5-      &   System.Windows.Controls.DataGrid  50      -   5          Name$ SubjectsDataGrid��50      $��2��53         AutoGenerateColumns$ False��54      	   CanUserAddRows$	 False��55      
   
IsReadOnly$
 False��57      ��51      �� *
Subjects+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5:      $ Coefficient��6)   $	 100 6^    6>   �� *Coefficient+6^     5;      $ Semester��6)   $	 100 6X    6;   �� *
Semester+6X   5=      �� 5@      $ 
Horizontal=�6   $��3��62   $
��0,10q�6?   .+�5A      �� -   5        $��Add Subject��5A      $	��150��6T   $��0,0,10,0q�6`   �� 5B      -   5        $��Update��5B      $	��150��6L   �� 5C      -   5        $��Delete��5C      $	��150��6L   5D      5E      5F      5G      