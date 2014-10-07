Form
Форма (Пример):
(Name): 	 R440OForm //Название написано через CapsLock, транслитом + слово Form.
Text:		 Р440О //Оригинальное название блока.
MaximizeBox:	 False //Убирается возможность разворачивания окна.
FormBorderStyle: FixedSingle //Убирается возможность растягивания/сужения окна.

Panel
На форме необходимо сделать элемент управления Panel. Все картинки размещать на нем.
Panel (Пример):
(Name):		 	R440OPanel //Название формы + слово "Panel"
Background:	 	R440O.png //Название формы, картинка взята из ресурсов.
Location:	 	0;0 //Размещение элемента с левого верхнего угла.
BackgroundImageLayout:	Center //Картинку заднего фона позицинировать по центру.

Resources
Ресурсы создавать в корне проекта. 
(Пример):
Название:	BackgroundImages.resx //Каждое слово с большой буквы. 
		В этом файле ресурсов хранятся изображения всех backgrounds всех блоков. 
		Название картинок делать такимиже, как названия форм.

Buttons on the form R440O
Button (Пример):
По нажатию - открытие формы соответствующего блока.
(Name):		R440ObuttonA205 // Слово 'button' + название формы.
Text:		Null
BackColor: 	Transparent // Делает фон прозрачным.
FlatStyle:	Flat
FlatAppearance 
> BorderSize: 		0
> MouseDownBackColor: 	64; 128; 255; 128
> MouseOverBackColor: 	64; 0; 128; 0
=====
