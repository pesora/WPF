   M S B A M L   `   `   `  ����C  ?WpfStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfStudyWpfStudy  5   	   =#clr-namespace:WpfStudy.UserControlsWpfStudy.UserControls  5   	       WpfStudy.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfStudy     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   6UserControls#clr-namespace:WpfStudy.UserControls  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5         	testStyle �� Property �� Value �� EndPoint �� 
StartPoint �� Opacity � Color � Offset	 �� Triggers
 �� Binding �� ElementName �� Value��%�  &	        �� 5   
   .�5      ��  � �� 5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   $	 0.3Q�6N   .��5      � $ 	#FF0017FF��6'   � 5      $ White��6'   $ 1Q�65   � 5      $ 	#FFA3F7BA��6'   $
 0.52Q�69   5      5      	 5      �� 5      
 6   �� *Value+$ progressBar1�� 1006R   .a�5      ��  � y�$ Hidden=�6=   5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ 
labelTest1��5      $��MyLabel��6$   $
��Left=�66   $��	10,22,0,0q�6Q   $	��Top=�6d   #��[  6|   �� 5    
   -   5         ��Name$ btnTest1��5       $��Button��6#   $��
0,311,30,5q�64   $��Bottom=�6H   #��[  6�   ��6c   �� *	TestClick+��6�   �� *Text+$ textBox1��6�   �� 5!   
   -   5         ��Name$ 	CheckBox1��5!      $��나의체크박스��6&   $
��Left=�67   $��	10,93,0,0q�6R   $	��Top=�6e   	� 5"   
   $��RadioButton��6   $
��Left=�6,   $��
13,128,0,0q�6G   $	��Top=�6[    	� 	GroupName$ MyGroup��6s   	� 5#   
   $��RadioButton��6   $
��Left=�6,   $��
10,162,0,0q�6G   $	��Top=�6[   $ MyGroup��6s   	� 5$   
   $��RadioButton��6   $
��Left=�6,   $��
10,190,0,0q�6G   $	��Top=�6[   $ MyGroup��6s   �� 5%   
   -   5         ��Name$ textBox1��5%      $
��Left=�6$   $��
10,226,0,0q�6?   $��TextBox��6S    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   G� 5&   
   $
��Left=�6   $��
10,262,0,0q�61   $	��Top=�6E   $	��120��6]   �� 5'   
   -   5         ��Name$ 	listView1��5'      $��152,22,253,217q�6&   ��6>   �� *
MyListUser+ �� View 5(      �� 5)      .P�5*      �� $��	이미지��6%    �� Width$	 300��62    �� CellTemplate 5+      �� 5,      .R�5-   "   �� .+�5.   &   �� $��60��6,   $��60��67   ��6C   �� *	USERIMG+�� 5/   &   $��20��6-   50   #   51      53      �� 54      $��이름��6%    �� DisplayMemberBinding 61   �� *
USERNAME+�� 55      $��나이��6%    61   �� *	USERAGE+56      58      �� 59   
   #��[  6   $��Label��63   $
��Left=�6C   $��	13,58,0,0q�6^   $	��Top=�6q   � 5:   
   -   5         �Name$ progressBar1��5:      $
��Left=�6,   $��10��6G   $��	6,309,0,0q�6S   $	��Top=�6f   $	��124��6~    � Value 6�   �� *ProgressValue+)   #WpfStudy.UserControls.ThreeControls  5;   
   $
��Left=�6%   $��175,241,0,0q�6@   $	��Top=�6U      MyText$ 내가생성한라벨��6m   $	��154��6�      	MyCommand 6~   �� *	TestClick+6�     5<   
   $
��Left=�6%   $��334,242,0,0q�6@   $	��Top=�6U   #   WpfStudy.UserControls.MyLabel  5=   
   $
��Left=�6   $��448,271,0,0q�6:   $	��Top=�6O   $
��asdf��6g     5>   
   $
��Left=�6   $��506,279,0,0q�6:   $	��Top=�6O   �� 5?   
   $��Button��6   $
��Left=�6"   $��655,162,0,0q�6=   $	��Top=�6R   ��6j   �� *
SecondShow+�� 5@   
   $��조회��6   $
��Left=�6   $��
612,61,0,0q�69   $	��Top=�6M   ��6e   �� *SelectClick+�� 5A   
   $��삭제��6   $
��Left=�6   $��612,100,0,0q�69   $	��Top=�6N   ��6f   �� *InsertClick+�� 5B   
   $
��Left=�6   $��
671,58,0,0q�6-   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   ��6A   �� *Name+6�   �� 5C   
   $
��Left=�6   $��
670,90,0,0q�6-   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   ��6A   �� *Img+6�   �� 5D   
   $
��Left=�6   $��671,120,0,0q�6-   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   ��6B   �� *Age+6�   �� 5E   
   -   5        $
��Left=�5E      $��575,186,0,0q�6.   $	��Top=�6C   $	��120��6[   .@�5F      �� $��사과��6   �� 5G      $��포도��6   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5H      +  %Microsoft.Xaml.Behaviors.EventTrigger  5I         	EventName$ 
MouseLeave��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5J      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *	TestClick+5K        5L      $ SelectionChanged��6!   . 5M         6,   �� *	TestClick+5N      5P      5Q      5R      