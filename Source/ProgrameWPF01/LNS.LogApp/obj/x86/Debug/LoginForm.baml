   M S B A M L   `   `   `  ����N  JLNS.LogApp.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:LNS.LogApp.Controls;assembly=LNS.LogApp.ControlsLNS.LogApp.Controls  5   	    
LNS.LogApp   LNS.LogApp.LoginForm   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ndui>clr-namespace:LNS.LogApp.Controls;assembly=LNS.LogApp.Controls     5   	     � Title$  	LoginForm��5   	   $	��260��6   $	��360��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y   $��18(�6o   .��5      � $	��260��6   $	��360��6    � RowDefinitions 5   
   �� 5      $��22 �6   �� 5	      ��5   
   �� 5       �� ImageSource$ Skin/Bd/bkg.jpg��6   .+�5   
   �� $!��莱诺斯日志管理系统��6   $
��Left=�6$   $��5,0,0,0q�6?   $	��Top=�6P   
�������$��11(�6{   &    LNS.LogApp.Controls.DazzleButton  5   
   -   5        $��Right=�5      $	��Top=�67   $��27��6O   $��22��6Z   $��0,0,15,0q�6f      MyMoverBrush 5      �� 5      $. (/LNS.LogApp;component/Skin/Button/xm.png��6      MyEnterBrush 5      �� 5      $. (/LNS.LogApp;component/Skin/Button/xe.png��6   ��5      �� 5      $. (/LNS.LogApp;component/Skin/Button/xn.png��6   5        5   
   -   5        $��Right=�5      $	��Top=�67   $��27��6O   $��22��6Z   $��0,0,38,0q�6f    5      �� 5      $ Skin/Button/mim.png��6    5      �� 5       $ Skin/Button/mie.png��6   ��5"      �� 5#      $ Skin/Button/min.png��6   5%      �� 5&   
   -   5        $��label1��5&   e   $��	用户：��6   $��1��6   $��28��6+   $
��Left=�67   $��	40,42,0,0q�6R   $	��Top=�6s   �� 5'   
   -   5        $��label2��5'   e   $��	密码：��6   $��1��6   $��28��6+   $
��Left=�67   $��	40,97,0,0q�6R   $	��Top=�6s   �� 5(   
   -   5        $��textBox1��5(   @   $��1��6   $��30��6   $��102,41,61,0q�6+   $	��Top=�6P   G� 5)   
   -   5        $��textBox2��5)   ^   $��1��6   $��30��6#   $
��Left=�6/   $��
102,96,0,0q�6J   $	��Top=�6n   $	��197��6�     5*   
   -   5        $��button1��5*   p   $��登陆��6   $��1��6(   $��30��65   $
��Left=�6A   $��
76,149,0,0q�6\   $	��Top=�6   $��91��6�   6�     5+   
   -   5        $��button2��5+   d   $��取消��6   $��30��6(   $��Right=�64   $��
0,149,86,0q�6P   $	��Top=�6s   $��91��6�   $��1��6�   6�   �� 5,   
   -	   5        $��label3��5,   {   $��Copyright © Linose 2015��6   $��1��62   $��28��6?   $
��Left=�6K   $��195,191,0,0q�6f   $	��Top=�6�   $��12(�6�   5-      5.      