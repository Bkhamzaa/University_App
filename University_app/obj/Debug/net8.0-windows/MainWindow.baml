   M S B A M L   `   `   `  ����I  EUniversity_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:University_appUniversity_app  5   	   ;"clr-namespace:University_app.ViewsUniversity_app.Views  5   	       University_app.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:University_app     5   	   4views"clr-namespace:University_app.Views     5   	     � Title$  University Management��5   	   $	��600��6'   $
��1000��64    � 	Resources 5         SidebarButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding �� Triggers	 P� Property
 P� Value��%�  &	        �� 5	   
   " ��6+   .�5
      ��  � ��
 �����6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 0,5,0,5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Left=�6;   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 0q�60   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5   !   # z��5   !   ._�5      �� $��Center=�6/   $
��Left=�6J   5      5      5       5      P� 5      	 �@J�IsMouseOver$

 True��61   . �5      ��  � �� �#34495E63   5       5"      5#      .��5%      �  � ColumnDefinitions 5&   
   �� 5'      $	��200 �6   �� 5(      $��* �6   .+�5,   
   �� ���#2C3E50$��0��6&   ._�5-      �� $	��Top=�6   $��10q�61   .+�5.      �� $��University App��6   $
��Bold"�5/      $��18(�50      
�������$��10q�52      �� 54      -   5        $��🏠 Dashboard��55      #��[  57      �� 58      -   5         ��Name$ SubjectManagementButton��5:      $��📚 Subject Management��58      #��[  5<      �� 5=      -   5        $ ExamManagementButton��5>      $��📝Exam Management��5=      #��[  5@      �� 5A      -   5        $ StudentManagementButton��5A      $#��🧑‍🎓Student Management��5B      #��[  5D      5F      5H      �� 5K   
   -   5         ��Name$ MainContentControl��5K      $��1��65   5L      5M      