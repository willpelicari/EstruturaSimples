   M S B A M L   `   `   `  ����   trabalhoUSC%    trabalhoUSC.FilaEncadeadaWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$$  Batata Quente - Fila Encadeada��$	��551��$	��660��.��� .+��� -    ��Name$ btnAdd��$��Adicionar Pessoa��$
��Left=�$��309,212,0,0q�$	��Top=�$	��150���� -   $ 	btnDelete��$��Remover Pessoa��$
��Left=�$��478,212,0,0q�$	��Top=�$	��150���� -    ��Name$ Texto��$
��Left=�$��24��$��
29,228,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��262���� $
��Left=�$��51��$	��Top=�$	��100��$��542,460,0,0q�$��/Images/usclogo.jpg���� $*��$Trabalho - Engenharia de Software II��$
��Left=�$��
221,10,0,0q�$	��Top=�$	��228���� -    ��Name$ EscrevaNome��$��Escreva um nome:��$
��Left=�$��
24,206,0,0q�$	��Top=��� $
��Left=�$
��Wrap=�$	��Top=�$��	24,73,0,0q��� $�A Estrutura "Fila����  � Language$ pt-br�$�
 Encadeada���� $�" ���� $ pt-br�$���é uma fila onde os elementos se conectam guardando como referência o inicio da fila, o elemento anterior e o posterior. Nessa exemplo, estamos num circulo de amigos brincando de Batata Quente em uma fila circular, onde o inicio e fim são conectados. Insira os seus amigos na roda e vá apertando o botão "Batata Quente e entenda como uma fila encadeada funciona"���� $*��$FILA DUPLAMENTE ENCADEADA (CIRCULAR)��$
��Left=�$��
111,36,0,0q�$	��Top=�$	��461��$��20(�$
��Bold"��� -   $ 
btnAlterar��$��Alterar Pessoa��$
��Left=�$��309,237,0,0q�$	��Top=�$	��150���� -   $ btnProcurar��$��Procurar Pessoa��$
��Left=�$��478,237,0,0q�$	��Top=�$	��150���� -    ��Name$ listBoxFila��$
��Left=�$��48��$��
29,153,0,0q�$	��Top=�$	��599������ .R���  �� Orientation$ 
Horizontal=��� $
��Roda��$
��Left=�$��
25,133,0,0q�$	��Top=��� -   $ BatataQuente��$��Batata Quente!��$
��Left=�$��221,460,0,0q�$	��Top=�$	��188��$��24(�$
��Bold"�
 � Tag$ 0���� $��Primeiro da Roda: ��$
��Left=�$��
29,279,0,0q�$	��Top=��� $��Ultimo da Roda: ��$
��Left=�$��334,279,0,0q�$	��Top=��� -	   	 ��Name$	 Atual��$
��Left=�$��280,368,0,0q�$
��Wrap=�$	��Top=�$
��Bold"�$��20(�
 �� TextAlignment$
 Center=��� -
   $	 Proximo��$
��Left=�$��508,368,0,0q�$
��Wrap=�$	��Top=�$��20(�$
 Center=�$
��Bold"� J� Opacity$	 0.5Q��� -   $	 Anterior��$
��Left=�$��
67,368,0,0q�$
��Wrap=�$	��Top=�$
��Bold"�$��20(�$
 Center=�$	 0.5Q��� -   $ PrimeiroRodada��$�� ��$
��Left=�$��142,279,0,0q�$	��Top=��� -   $ UltimoRodada��$�� ��$
��Left=�$��433,279,0,0q�$	��Top=��� $
��Left=�$��433,343,0,0q�$
��Wrap=�$��>��$	��Top=�$
��Bold"�$��48(�$
 Center=��� $
��Left=�$��203,343,0,0q�$
��Wrap=�$��>��$	��Top=�$
��Bold"�$��48(�$
 Center=��� $��Pessoa Anterior��$
��Left=�$��
54,325,0,0q�$	��Top=��� $��Pessoa Atual��$
��Left=�$��280,325,0,0q�$	��Top=��� $��Próxima Pessoa��$
��Left=�$��508,325,0,0q�$	��Top=�