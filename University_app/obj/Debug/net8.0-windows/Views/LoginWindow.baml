   M S B A M L   `   `   `  ����I  EUniversity_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:University_app.ViewsUniversity_app.Views  5   	   &     University_app.Views.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:University_app.Views     5   	     � Title$  Login - University Portal��5   	   $	��400��6+   $	��500��68    � WindowStartupLocation$ CenterScreen=�6D    � 
ResizeMode$ NoResize=�5	   	   ���#EEF1F5.��5
      � .+�5   
   �� $	��400��6   $	��300��6   
������� �� CornerRadius$ 15��6=   $��Center=�5      $��Center=�6,    �� Padding$ 30q�6I   ���#D0D0D0$��1q�5   '    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$
 #888��6      
BlurRadius$ 15Q�6(      ShadowDepth$ 3Q�68   	   Opacity$		 0.4Q�6H   ._�5      �� $��Center=�6   $��Stretch=�64   .+�5      �� $��University Login��6   $��24(�64   $
��Bold"�6B   ���#333$��Center=�5   .   $��0,0,0,25q�6K   �� 5      $��Username��6   $��SemiBold"�6,   ���#5556B   �� 5      $��0,5,0,15q�5      $��30��6,   $��5q�68   ���#F9F9F9���#CCC��5      �� *
Username+
 �� UpdateSourceTrigger$
 PropertyChanged=�5   Y   �� 5      $��Password��6   $��SemiBold"�6,   ���#5556B   G� 5      -   5        $��PasswordBox��5      $��30��61   $��5q�6=   ���#F9F9F9���#CCC$��0,5,0,25q�5   L   �� 5      -   5        $��Login��5      $��40��6)   ���#007ACC
�������$
��Bold"�5   ,   ���#007ACC � Cursor$
 Hand��5    /   ��5"      �� 5#       �� 
TargetType" ��6    .�5$      ��  �� Property � �� �� Value �#007ACC6;   �� 5%       � ��
 �����6;   �� 5&       � �� 5'   "   �� 5(   &    �� 
TargetType" ��66   .R�5)   *   �� #��z��61   $ 8��5*   1   #��z��5+   1   $��1q�5,   1   ._�5-   .   �� $��Center=�6?   $��Center=�6\   5.   +   5/   '   51       �� Triggers 52      P� 53   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �54   &   ��  � �� �#005A9E6C   �� 55   &    � �� �#005A9E6D   56   #   58      5:      5;      5<      5=      5>      