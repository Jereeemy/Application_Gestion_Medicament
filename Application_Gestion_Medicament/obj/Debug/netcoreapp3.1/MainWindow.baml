   M S B A M L   `   `   `  ����Y  UApplication_Gestion_Medicament, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Application_Gestion_MedicamentApplication_Gestion_Medicament  5      /    )Application_Gestion_Medicament.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Application_Gestion_Medicament     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  MédicGestion��5      $
��1200��5	      $	��650��5
      $
��1200��5      $	��650��5      ���	#FF104911 � 	Resources 5         caseACocher �� Orientation d� 	IsChecked �� Path �� RelativeSource �� AncestorType��%�   &	        �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      ��  6   �� $ 
IsSelected� �� *FindAncestor+" ��5      5      5       � DataContext 5      4   .Application_Gestion_Medicament.ApplicationData  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��225 �6   �� 5      	 � ColumnDefinitions	 5   
   �� 5       $	��300 �6   �� 5!      $	��300 �6   �� 5"      $	��300 �6   �� 5#      $��* �6   .+�5%   
   �� -   5        
 ��Name$
 RectangleZoneAjouter��5&      $��1��5'      $	��276��5(      $	��340��5)      $��	10,43,0,0q�5*      $
��Left=�5+      $	��Top=�5,      
���   �5-      �� 5.   
   -   5         ��Name$ 	LabelLogo��5/      $	��250��50      $��50��51      $��
40,150,0,0q�52      $��Center=�53      $	��Top=�54      ���	#FF114910$��MedicGestion��56      $��Century Gothic)�57      $��28(�58      $
��Bold"�59      ���	#FFAFC0445:      �� 5;   
   -   5         ��Name$ ButtonAjouter��5<      $��1��5=      $	��100��5>      $��40��5?      $��	0,315,0,0q�5@      $��Center=�5A      $	��Top=�5B      ���	#FF143035$��Ajouter��5E      $��Dubai Medium)�5F      $��24(�5G      ���	#FFAFC0445H      �� 5I   
   -   5        $ ButtonSupprimer��5J      $��1��5K      $��60��5L      $��25��5M      $��
25,323,0,0q�5N      $
��Left=�5O      $	��Top=�5P      ���	#FF143035$��	Supprimer��5S      $��Dubai Medium)�5T      $��12(�5U      ���	#FFAFC0445V      �� 5X   
   -   5        $ ButtonModifier��5Y      $��1��5Z      $��60��5[      $��24��5\      $��215,323,0,0q�5]      $
��Left=�5^      $	��Top=�5_      ���	#FF143035$��Modifier��5a      $��Dubai Medium)�5b      $��12(�5c      ���	#FFAFC0445d      �� 5f   
   -   5         ��Name$ 	ImageLogo��5g      $��10,10,10,60q�5h       J� RenderTransformOrigin$ 2.793,1.073&�5i      $��	/logo.png��5j      �� 5k   
   -   5         ��Name$ TextBoxMaladie��5l      $��1��5m      $	��120��5n      $��
150,80,0,0q�5o      $
��Left=�5p      $	��Top=�5q       �� TextWrapping$
 Wrap=�5t       5r      �� *SelectedItem+ �� ElementName$ ListViewMaladie����5s      �� *LibelleMaladie+ �� ValidatesOnExceptions$
 True��5t      �� 5u   
   -   5        $ TextboxCommentaire��5v      $��1��5w      $	��120��5x      $��80��5y      $��150,200,0,0q�5z      $
��Left=�5{      $	��Top=�5|      $
 Wrap=�5       5}      �� *SelectedItem+$ DataGridAutorisation����5~      �� *commentaire+$
 True��5      �� 5�   
   -	   5        $ TextBoxMedicament��5�      $��1��5�      $	��120��5�      $��150,120,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $
 Wrap=�5�       5�      �� *SelectedItem+$ ListViewMedicament����5�      �� *LibelleMedicament+$
 True��5�      &   System.Windows.Controls.DataGrid  5�   
   -
   5          Name$ DataGridAutorisation��5�      $��1��5�      $��1��5�      $��3��5�      $��10,10,10,10q�5�         AutoGenerateColumns$ False��5�      ���	#FF1E3A18���	#FFAFC044
���   ���5�      �� *listeAutoriser+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Maladie��6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *uneMaladie.LibelleMaladie+6S     5�      $ 
Medicament��6X    6%   �� * unMedicament.LibelleMedicament+6X     5�      $
 Date��6>    6%   �� *date+6>     5�      $ Commentaire��6E    6%   �� *commentaire+6E   5�      �� 5�   
   -   5         ��Name$! ListViewCategorieMedicament��5�      $��1��5�      $��10,10,10,10q�5�      ���	#FF1E3A18���	#FFAFC044���	#FFAFC044��5�      �� *listeCategorieMedicament+ �� View 5�      �� 5�      .P�5�      ��  �� Width$ 30��6%    �� CellTemplate# [  60   �� 5�      $	 150��5�      $��Catégories Médicaments��5�       �� DisplayMemberBinding 5�      �� *LibelleCategorieMedicament+5�      5�      5�      �� 5�   
   -   5        $ ListViewMedicament��5�      $��2��5�      $��10,10,10,10q�5�      ���	#FF1E3A18���	#FFAFC044���	#FFAFC044��5�      �� *listeMedicament+ 5�      �� 5�      .P�5�      �� $ 30��6%   # [  60   �� 5�      $	 150��5�      $��Médicaments��5�       5�      �� *LibelleMedicament+5�      5�      5�      �� 5�   
   -   5        $ ListViewMaladie��5�      $��3��5�      $��10,10,10,10q�5�      ���	#FF1E3A18���	#FFAFC044���	#FFAFC044��5�      �� *listeMaladie+ 5�      �� 5�      .P�5�      �� $ 30��6%   # [  60   �� 5�      $	 150��5�      $��Maladies��5�       5�      �� *LibelleMaladie+5�      5�      5�      �� 5�   
   -   5        $ LabelMaladie��5�      $��1��5�      $��	20,74,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��	Maladie :��5�      $��Bahnschrift SemiBold)�5�      $��18(�5�      $
��Bold"�5�      ���	#FFAFC0445�      �� 5�   
   -   5        $ 	LabelDate��5�      $��1��5�      $��
20,154,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Date :��5�      $��Bahnschrift SemiBold)�5�      $��18(�5�      $
��Bold"�5�      ���	#FFAFC0445�      �� 5�   
   -   5        $ LabelCommentaire��5�      $��1��5�      $��
20,194,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Commentaire :��5�      $��Bahnschrift SemiBold)�5�      $��18(�5�      $
��Bold"�5�      ���	#FFAFC0445�      �� 5�   
   -   5        $ LabelMedicament��5�      $��1��5�      $��
20,114,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Medicament :��5�      $��Bahnschrift SemiBold)�5�      $��18(�5�      $
��Bold"�5�      ���	#FFAFC0445�      (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ DatePickerDate��5      $��1��5     $	��120��5     $��150,154,0,0q�5     $
��Left=�5     $	��Top=�5     5     5     