   M S B A M L   `   `   `  ����I  EUniversity_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:University_app.ViewsUniversity_app.Views  5      E'clr-namespace:University_app.ViewModelsUniversity_app.ViewModels  5      )    #University_app.Views.ExamManagement   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:University_app.Views     5      >
viewModels'clr-namespace:University_app.ViewModels     5        � DataContext  5      .   (University_app.ViewModels.ExamManagement  5   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   $��31.96��6*   �� 5      $
��Auto �6   $��31.96��6*   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� $��Program:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5      -   5         ��Name$ ProgramComboBox��5      $	��200��5       �� DisplayMemberPath$
 Name��5      ��5      �� *
Programs+ �� SelectedItem 5      �� *SelectedProgram+ �� Mode$ TwoWay=�5      �� 5!   
   $ 
Horizontal=�6   $��0,0,0,10q�6.   $��1��6@   .+�5"      �� $��Level:��6   $��Center=�6&   $��0,0,10,0q�6A   �� 5#      -   5        $ LevelComboBox��5#      $	��200��5$      $
 Name��5&      ��5%      �� *Levels+ 5'      �� *SelectedLevel+$ TwoWay=�5(      �� 5+   
   $ 
Horizontal=�6   $��10,0,319,320q�6.   $��2��6D   .+�5,      �� $��Subject:��6   $	��Top=�6(   $��0,0,10,0q�6@   �� 5-      -   5        $ SubjectComboBox��5-      $	��200��5.      $
 Name��50      $��20��51   9    �� SelectedIndex$ -1��6E   $	��Top=�6X   ��5/      �� *
Subjects+ 51      �� *SelectedSubject+$ TwoWay=�6X   52      �� 5@   
   -   5        $��
Import CSV��5@      $��635,2,40,10q�5A   	   5B   	   �� 5C   
   -   5        $��
Send Email��5C      $��520,2,150,10q�5D   	   5E   	   &   System.Windows.Controls.DataGrid  5H   
   -   5          Name$ ExamDataGrid��5H      $��2��5I      	   AutoGenerateColumns$	 False��5J      $��
-13,31,0,0q�5L      
   SelectionMode$
 Extended=�5M         SelectionUnit$ FullRow=�5N      ��5K      �� *Exams+   Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn   Header$ CinId��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *CinId+6N     5R      $ 
First Name��6%   $ * 6W    69   �� *	FirstName+6W     5S      $ 	Last Name��6%   $ * 6U    68   �� *
LastName+6U     5T      $ Subject Name��6%   $ * 6[    6;   �� *SubjectName+6[     5U      $ DS��6%   $ * 6H    61   �� *Ds+6H     5V      $
 Exam��6%   $ * 6L    63   �� *Exam+6L     5W      $ Email��6%   $ * 6N    64   �� *Email+6N   5Y      5Z      5[      