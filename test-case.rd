Test 1: Рейс в одну сторону
	1. Зайти на сайт
	2. Ввести в поле ввода(from - Minsk (MSQ), BY; to - Moscow (MOW), RU;
	3. Выбрать One-way
	4. Ввести дату(+7 дней от текущей)
	5. Выбрать одного пассажира
	6. Нажать кнопку Search
Результат: Будет выведена таблица с возможными рейсами

Test 2: Рейс в одну сторону с неправильными аэропортами
	1. Зайти на сайт
	2. Ввести в поле ввода(from - test, BY; to - test;
	3. Выбрать One-way
	4. Ввести дату(+7 дней от текущей)
	5. Выбрать одного пассажира
	6. Нажать кнопку Search

Результат: Должна пройти валидация и поля с неверными данными подсвечиваются красными

Test 3: Рейс в обе стороны
	1. Зайти на сайт
	2. Ввести в поле ввода(from - Minsk (MSQ), BY; to - Moscow (MOW), RU;
	3. Выбрать Return
	4. Ввести дату(Departure: +7 дней от текущей; Return: + 14 дней от текущей)
	5. Выбрать одного пассажира
	6. Нажать кнопку Search
Результат: Будет выведена таблица с возможными рейсами

Test 4: Рейс в обе стороны с неправильными аэропортами
	1. Зайти на сайт
	2. Ввести в поле ввода(from - test, BY; to - test;
	3. Выбрать Return
	4. Ввести дату(+7 дней от текущей)
	5. Выбрать одного пассажира
	6. Нажать кнопку Search

Результат: Должна пройти валидация и поля с неверными данными подсвечиваются красными

Test 5: Смена языка
	1.	Зайти на сайт
	2.	В шапке с выпадающим списком выбрать язык

Результат: в результате от выбранного языка должна быть страница с этим языком

Test 6: Рейс с различным количеством пассажиров
	1. Зайти на сайт
	2. Ввести в поле ввода(from - Minsk (MSQ), BY; to - Moscow (MOW), RU;
	3. Выбрать Return
	4. Ввести дату(Departure: +7 дней от текущей; Return: + 14 дней от текущей)
	5. В поле Passengers выбрать 2 взрослых, 1 ребенка и 1 младенца
	6. Нажать кнопку Search

Результат: Будет выведена таблица с возможными рейсами

Test 7: Вход в систему
	1. Зайти на сайт
	2. Нажать на кнопку Log in
	3. В поля ввести строки длинной от 6 символов

Результат: При вводе неверных данных, при открытие окна входа будут подсвечены красным неверные поля

Test 8: Посмотреть предложения от сайта
	1. Зайти на сайт
	2. Нажать на ссылку "Все предложения"

Результат: Должен появиться список с предложениями от компании

Test 9: Узнать о возможности грузовых перевозок
	1. Зайти на сайт
	2. Нажать кнопку меню
	3. Нажать пункт - грузовые перевозки
	4. Нажать - перевозка грузов

Результат: Должен появиться страница с информацией о грузовых перевозках

Test 10: Регистрация на рейс
	1. Зайти на сайт
	2. В поле код бронирования ввести 123456
	3. В поле фамилия ввести Ivanov
	4. Отметить чекбокс с тем, что вы ознакомлены с правилами

Результат: Страница, где поле ввода с кодом бронирования будет с ошибкой о том, что текст короткий
