   M S B A M L   `   `   `  ����F  BPastebinNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PastebinNew.ViewModelsPastebinNew.ViewModels  5   	   '    !PastebinNew.ViewModels.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;
ViewModels$clr-namespace:PastebinNew.ViewModels     5   	     � Title$$  Pastebin for Microsoft Windows��5   	   $	��600��60   $	��800��6=    � Icon$( "..\Assets\Images\pastebin-icon.png��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�5   	   ��5	      �� 5
   
    �� ImageSource$ ..\Assets\Images\bg.jpg��6    j� TileMode$
 Tile=�6;    j� Viewport$ 0,0,0.08,0.08�6K    � DataContext 5      0  *PastebinNew.ViewModels.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��50 �6   �� 5      $��25 �6   �� 5      $��5 �6   �� 5      $��30 �6   �� 5      $��5 �6   �� 5      $	��350 �6   �� 5      $��5 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0q�6   	 �� CornerRadius$	 0,0,0,0��5   	   ���#023859$��25��65   $	��700��6A   ._�5      �� $
��Left=�6   
 �� Orientation$
 
Horizontal=�64   .+�5       �� 
�������$
��Bold"�6A   ��6   Z� .��6S   %#PASTEBIN | #1 paste tool since 20026x   �� 5!       � Cursor$
 Hand��6L   $��195, 5, 0, 0q�6[   
�������$��create new paste��6�   ��6   �� * Commands.CreateNewPasteCommand+��5"      �� 5#       �� 
TargetType" ��6*   .R�5$      �� 5%      5'      �� 5(      $��
5, 0, 0, 0q�6   
�������.��6?   |6B   �� 5)      $
 Hand��6I   $��
5, 5, 0, 0q�6W   
�������$��tools��6~   ��6   �� *Commands.ToolsButtonCommand+��5*      �� 5+      " ��6*   .R�5,      �� 5-      5/      �� 50      $��
5, 0, 0, 0q�6   
�������.��6?   |6B   �� 51      $
 Hand��6G   $��
5, 5, 0, 0q�6U   
�������$	��api��6|   ��6   �� *Commands.APIButtonCommand+��52      �� 53      " ��6*   .R�54      �� 55      57      �� 58      $��
5, 0, 0, 0q�6   
�������.��6?   |6B   �� 59      $
 Hand��6K   $��
5, 5, 0, 0q�6Y   
�������$��archive��6�   ��6   �� *Commands.ArchiveButtonCommand+��5:      �� 5;      " ��6*   .R�5<      �� 5=      5?      �� 5@      $��
5, 0, 0, 0q�6   
�������.��6?   |6B   �� 5A      $
 Hand��6G   $��
5, 5, 0, 0q�6U   
�������$	��faq��6|   ��6   �� *Commands.FAQButtonCommand+��5B      �� 5C      " ��6*   .R�5D      �� 5E      5G      5H      5I      �� 5J   
   $��1��6   $	��700��6"    K� ZIndex$ 4��6.   $
 
Horizontal=�6?   ��5K      �� 5L      $% ..\Assets\Images\background.jpg��6   $
 Tile=�6K   $ 2,0,0.08,0.99�6[   6v   .+�5N      �� $
 Hand��6   $��
5, 5, 0, 0q�6#   
���������5O      �� 5P      " ��6&   .R�5Q      �� 5R      .��5T      �� $(��"..\Assets\Images\pastebin-icon.png��6   $��50��6D   $��50��6O    J� RenderTransformOrigin$ 0.5,0.5&�6[   $
��Left=�6{   $��5,0,0,0q�6�   z�5U      V� 5V      .~�5W      �� �� 5X      �� 5Y       �� Angle$ -23.369Q�6.   T� 5Z      5[      5]      5^      �� 5_      $��	10,13,0,0q�6   $��16(�6'   
�������$
��Bold"�6H   $��Trebuchet MS)�6Z   .��6t   P A S T E B I N6�   5`      �� 5a   
   ���#023859$	��700��6*   $��26��66   $��Center=�6B   $
 
Horizontal=�6_   $��2��6x   .+�5b      �� $$��..\Assets\Images\createnew.png��6   $��16��6<   $��16��6G   $
��Left=�6S   $��60,0,0,0q�6n   6�   �� 5c      $
 Hand��6H   $��
5, 5, 0, 0q�6V   
�������$��create new paste��6}   ��6   �� * Commands.CreateNewPasteCommand+��5d      �� 5e      " ��6&   .R�5f      �� 5g      5i      �� 5j      $#��..\Assets\Images\trending.png��6   $��16��6;   $��16��6F   $
��Left=�6R   $��10,0,0,0q�6m   6�   �� 5k      $
 Hand��6   $��
5, 5, 0, 0q�6#   
�������$��trending pastes��6J   ��5l      �� 5m      " ��6&   .R�5n      �� 5o      5q      �� 5r      $��sign up��6H   $
 Hand��6�   $��155, 5, 0, 0q�6�   
�������y�6   �� *SignupVisibility.Visibility+��6Z   �� *Commands.SignupButtonCommand+��5s      �� 5t      " ��6&   .R�5u      �� 5v      5x      �� 5y      $��Welcome, Noble��6I   $
 Hand��6�   $��-90, 5, 0, 0q�6�   
�������y�6   �� *WelcomeVisibility.Visibility+��6b   �� *Commands.SignupButtonCommand+��5z      �� 5{      " ��6&   .R�5|      �� 5}      5      �� 5�      $��
5, 0, 0, 0q�6   
�������.��6;   |6>   �� 5�      $��log out��6I   $
 Hand��6�   $��
0, 5, 0, 0q�6�   
�������y�6   �� *WelcomeVisibility.Visibility+��6[   �� *Commands.SignupButtonCommand+��5�      �� 5�      " ��6&   .R�5�      �� 5�      5�      �� 5�      $��log in��6H   $
 Hand��6�   $��-30, 5, 0, 0q�6�   
�������y�6   �� *SignupVisibility.Visibility+��6Y   �� *Commands.LoginButtonCommand+��5�      �� 5�      " ��6&   .R�5�      �� 5�      5�      �� 5�      $��
5, 0, 0, 0q�6   
�������.��6;   |6>   �� 5�      $
 Hand��6J   $��
5, 5, 0, 0q�6X   
�������$��my settings��6   ��6   �� *" Commands.MySettingsButtonCommand+��5�      �� 5�      " ��6&   .R�5�      �� 5�      5�      �� 5�      $��
5, 0, 0, 0q�6   
�������.��6;   |6>   �� 5�      $
 Hand��6I   $��
5, 5, 0, 0q�6W   
�������$��
my profile��6~   ��6   �� *!Commands.MyProfileButtonCommand+��5�      �� 5�      " ��6&   .R�5�      �� 5�      5�      5�      �� 5�   
   $��3��6   $��0q�6   $	 0,0,5,5��5�   	   ���#023859$��5��65   $	��700��6@   5�      �� 5�   
   $��4��6   $	��700��6"   .+�5�      �� $��Right=�63   $��0,0,0,0q�6O   ��6   �� *
LoggedText+6O   5�      �� 5�   
   $��5��6   $��0q�6   $	 
5, 5, 0, 0��62   
�������$��15��6_   $	��700��6k   �� 5�   
   -   5        $��ContentRegion��5�   "   $��6��6   
�������$	��700��6J   .+�5�      �� ��6   �� *CurrentBodyView+5�      �� 5�   
   $��7��6   $��0q�6   $	 0,0,5,5��5�   	   
�������$��5��63   $	��700��6>   5�      �� 5�   
   $��8��6   $	��700��6"   .+�5�      �� $��Right=�6   $��0,0,0,0q�60   .��6A   $"Current Version: MAJOR.MINOR.PATCH6e   �� 5�      $��Right=�6   $��0,0,0,0q�60   .��6A   Developed by: Daniel Lowman6^   5�      5�      5�      