   M S B A M L   `   `   `  ����G  CBuildManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BuildManager.ViewsBuildManager.Views  5   	   A%clr-namespace:BuildManager.ViewModelsBuildManager.ViewModels  5   	   #    BuildManager.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BuildManager.Views     5   	   <
viewmodels%clr-namespace:BuildManager.ViewModels     5   	     � Title$  Build Manager��5
   	   $	��600��6   $	��800��6,   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $
��auto��6   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ Stretch=�6C   6U   5      .@�5      �� -   5         ��Name$ ViewAllWorks��5      ��5      �� *AllBuildManagerModels+ �� SelectedItem 5      �� *SelectedItem+ �� View 5      �� 5      .P�5      �� $��Вид роботи��6)    �� Width$	 410��6=   	 �� DisplayMemberBinding	 5   )   �� 
 �� Path$
 
TypeOfWork��� 5      $��Виконавець��6)   $
 auto��6=   	 5   )   �� $
 Worker��� 5      $!��Дата створення��6)   $
 auto��6A   	 5    )   �� $
 CreationDate��� 5!      $��Тривалість��6)   $
 auto��6=   	 5"   )   �� $
 Duration��� 5#      $'��!Загальна вартість��6)   $
 auto��6D   	 5$   )   �� $
 
TotalPrice�5%      5'      5)      �� 5*   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�5+      .+�5,      �� $��Додати��6   $��10q�6O   ��6&   �� *OpenAddNewWorkWindow+6O   �� 5-      $��Редагувати��6   $��10q�6Q   ��6*   �� *OpenEditItemWindow+6Q   �� 5.      $��Видалити��6   $��10q�6G   ��6(   �� *
DeleteItem+6G   5/      59      5:      