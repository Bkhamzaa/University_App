   M S B A M L   `   `   `  ����  University_app+    %University_app.Views.AddSubjectWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Add Subject��5   	   $	��400��6   $	��450��6*    � WindowStartupLocation$ CenterScreen=�66   ���#F9F9F9.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� $��Add Subject��6   $��20(�5      $
��Bold"�5      $
��Left=�5      $��
158,2,0,19q�5      �� 5   
   $��1��6   $	��Top=�6"   .+�5      ]� $��0,0,0,10q�6   .+�5      �� $��Program:��6   $	��100��6,   $��Center=�68   �� 5      -   5         ��Name$ ProgramComboBox��5       �� DisplayMemberPath$
 Name��5      $	��250��5      5      ]� 5       $��0,0,0,10q�6   .+�5!      �� $��Level:��6   $	��100��6*   $��Center=�66   �� 5"      -   5        $ LevelComboBox��5"      $
 Name��5#      $	��250��5%      5&      ]� 5)      $��0,0,0,10q�6   .+�5*      �� $��Subject Name:��6   $	��100��61   $��Center=�6=   �� 5+      -   5         ��Name$ NameTextBox��5+      $	��250��6/   5,      ]� 5/      $��0,0,0,10q�6   .+�50      �� $��Coefficient:��6   $	��100��60   $��Center=�6<   �� 51      -   5        $ CoefficientTextBox��51      $	��250��66   52      ]� 55      $��0,0,0,10q�6   .+�56      �� $��	Semester:��6   $	��100��6-   $��Center=�69   �� 57      -   5        $ SemesterTextBox��57      $	��250��63   58      59      �� 5<   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,20,0,0q�6W   .+�5=      �� -   5        $
��Save��5=      $	��100��5?      $��5q�5@      ���#4CAF50
�������$
��Bold"�5C      ���#388E3C$��1q�5E       � Cursor$
 Hand��5F      5G      5H      5I      