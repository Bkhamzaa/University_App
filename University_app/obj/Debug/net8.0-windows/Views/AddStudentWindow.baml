   M S B A M L   `   `   `  ����I  EUniversity_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:University_app.ViewsUniversity_app.Views  5   	   +    %University_app.Views.AddStudentWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:University_app.Views     5   	     � Title$  AddStudentWindow��5   	   $	��400��6"   $	��500��6/   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Add Student��6   $��20(�5      $
��Bold"�5      $
��Left=�5      $��
158,2,0,19q�5      �� 5   
   $��1��6   $	��Top=�6"   .+�5      ]� $��0,0,0,10q�6   .+�5      �� $��Program:��6   $	��100��6,   $��Center=�68   �� 5      -   5         ��Name$ ProgramComboBox��5       �� DisplayMemberPath$
 Name��5      $	��250��5        �� SelectedItem 5      �� *select+ �� Mode$ TwoWay=�5       5!      ]� 5$      $��0,0,0,10q�6   .+�5%      �� $��Level:��6   $	��100��6*   $��Center=�66   �� 5&      -   5        $ LevelComboBox��5&      $
 Name��5'      $	��250��5-       5*      �� *%#_student_management.SelectedProgram+$ TwoWay=�5-      5.      ]� 5/      $��0,0,0,10q�6   .+�50      �� $��Cin ID:��6   $	��100��6+   $��Center=�67   �� 51      -   5         ��Name$ CinIDTextBox��51      $	��250��60   53      ]� 55      $��0,0,0,10q�6   .+�56      �� $��First Name:��6   $	��100��6/   $��Center=�6;   �� 57      -   5        $ FirstNameTextBox��57      $	��250��64   59      ]� 5<      $��0,0,0,10q�6   .+�5=      �� $��
Last Name:��6   $	��100��6.   $��Center=�6:   �� 5>      -   5        $ LastNameTextBox��5>      $	��250��63   5?      ]� 5B      $��0,0,0,10q�6   .+�5C      �� $��Email:��6   $	��100��6*   $��Center=�66   �� 5D      -   5        $ EmailTextBox��5D      $	��250��60   5E      5F      �� 5I   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,20,0,0q�6W   .+�5J      �� -   5        $
��Save��5J      $	��100��5M      $��5q�5N      ���#4CAF50
�������$
��Bold"�5Q      ���#388E3C$��1q�5S       � Cursor$
 Hand��5T      5U      5V      5W      