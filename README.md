# Course
Курсовая по C# Вариант 20

Студент Якубчинский Кирилл, 1-ый курс, группа АТ - 193

Необходимо создать информационную базу данных "База стройматериалов":

Каждая запись содержит следующие сведения: 
-	наименование товара,
-	фирма-производитель,
-	цена за единицу,
-	количество,
-	номер склада,
-	минимальная партия.

Предусмотреть:
а)	удалить все товары указанного склада;
б)	вывести наименование товаров с минимальной партией не менее 100;
в)	вывести наименование и количество всех товаров, хранящихся на указанном складе;
г)	вывести прайс-лист;

Формы и классы проекта:

1.Functional

Содержит массивы информации о товарах складов. Данная страница такде содержить класс Input_Reg, содержащий в себе массивы информации
о пользователях, а точнее их имена, фамилии и пароли. Также данные классы содержат индекс пользователя и размерность массивов.

2.Program_Title

В Program_Title программа начинает свою работу. Будет открыта форма Title, где пользователя попросят войти или зарегистрироваться.

3.Title

Это форма Title. Здесь пользователь имеет возможность войти в свой аккаунт или зарегистрироваться если аккаунта нет.

4.Registration_Form

Форма Registration_form - форма регистрации пользователя.
           В нее можно попасть из формы Title и Welcome.
           Новому пользователю будет необходимо внести свое имя, фамилию и пароль
           для регистрации. Каждый из пунктов должен быть длинной более трех
           символов, в противном случае будет выдано сообщение о некорректности.
           Если данные заполнены корректно - индекс пользователя запоминается
           в глобальную переменную index, при помощи которой пользователь 
           будет в дальнейшем взаимодействовать с сайтом под своим номером.
           После нажатия кнопки "Зарегистрироваться" массивы паролей, имен и фамилий будут
           увеличены на одну ячейку.
          
5.Input_Form

Форма Input.form - форма входа пользователя. Она может быть открыта из форм Title и Welcome.
           Если пользователь раннее был зарегистрирован
           на сайте, то ему необходимо ввести свое имя, фамилию и пароль.
           Если данные введены верно - индекс пользователя запоминается
           в глобальную переменную index, при помощи которой пользователь 
           будет в дальнейшем взаимодействовать с сайтом под своим номером.
           Если данные введены неверно - будет выдано сообщение.
           
6.Welcome

Welcome - основная форма программы. Здесь
           пользователю будут предложены практически все
           функции сайта. При загрузке форма будет приветствовать
           пользователя по имени, которое будет распознано формой
           по глобальному индексу, а также будет загружено изображение.
           У пользователя будет возможность создать свой склад,
           найти необходимый склад, вернуться на страницу входа или регистрации,
           а также зайти от лица администратора при наличии спец. пароля.
           
7.Search_warehouse

Форма Search_warehouse является неким поисковиком сайта.
           Здесь пользователь может вывести прайс лист всех товаров,
           вывести список товаров с минимальной партией 100, а также
           найти необходимый товар по номеру склада в котором он храниться.
           В данную форму можно попасть из формы Welcome.
           
8.New_warehouse

Форма New_warehouse может быть открыта из Welcome.
           В ней пользователь может создать свой склад со своим собственным
           продуктом. При корректном вводе всех необходимых значений в массивах этих
           значений будет добавлена новая ячейка. В данной форме пользователь может удалить
           свой склад, однако пока он не создаст свой склад данная функция будет не доступна.
           Если в дальнейшем пользователь будет удалять свой склад, то размер массива не уменьшится
           в целях не нарушить индексацию, однако значения удаленных элементов будут пусты. 
           Также важно понимать, что пользователь может создать только один свой склад, и если
           в дальнейшем он будет пытаться создать новый склад, то он будет изменять значения раннее
           созданного склада.
           
9.Delete_warehouse

Delete_warehouse - форма удаления элементов массивов информации о товаре склада.
           В данную форму пользователь может попасть из New_warehouse, а из нее вернуться
           в форму Welcome. При удалении склада пользователю надо будет ввести свой пароль
           от аккаунта.

10.Admin_input

В форму Admin_input пользователь сможет попасть из Welcome.
           Для входа от лица администратора пользователю необходимо будет знать пароль,
           изначально введенный и хранящийся в текстовом файле. Предполагается, что
           если пользователь действительно является администратором, то пароль будет
           передан ему разработчиком либо другим администратором.
           
11.Admin_welcome

В форму Admin_welcome может попасть только администратор сайта после
           ввода пароля в Admin_input. Администратор имеет воозможноть изменить пароль для входа
           от лица администратора, вернуться в форму Welcome, а также посмотреть базу данных.
           
12.Change_admin_password

Форма Change_admin_password доступна для администратора из Admin_welcome.
           В ней администратор может изменить пароль для входа от лица администратора.
           Для этого ему необходимо ввести старый пароль, а также два раза новый пароль
           для его подтверждения. Длина пароля должна быть минимум три символа. 
           После корректного ввода пароль будет перезаписан в текстовом файле.
           
13.Database

Форма Database доступна администратору из Admin_input.
           В ней администратору будет доступна информация про всех зарегистрированных
           пользователях, а также об их складах. Администратору будет доступна форма удаления
           склада пользователей, однако данная функция будет не доступна пока хоть один из пользователей
           не создаст в первый раз свой склад.
           
14.Admin_delete_warehouse

Администратор может открыть данную форму из Database.
           При этом Database не будет закрыта для удобства выбора склада
           для удаления. После удаления массивы информации о товарах
           не уменьшаться с целью не нарушить индексацию, однако под удаляемым
           индексом будет храниться пустота или нулевое значение.           
