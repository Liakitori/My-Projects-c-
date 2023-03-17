# My-Projects-c-
Мои студенческие работы
Лабораторная работа 1 - ATN/ATH:
Для отработки синтаксических конструкций языка программирования C# требуется разработать
эмулятор банковского терминал с выдачей и вносом денежных купюр. Система должна:
Пользователь
1. Знать пользователя по типу карточки, сумму денег на счету, уметь вносить и списывать со
счета
2. В банкомат загружены N купюр номиналом: 50, 100, 500, 1000, 2000 руб
3. Банкомат должен выдавать денежные средства равномерно опустошая денежные слоты,
и не делая перекосов по нехватке какого-либо номинала (по возможности).
4. Выдавать или отказывать в выдаче, при нехватке денежных купюр, списывая со счета и
уменьшая к-во денег в терминале
5. Проверять пин код, отказывать в выдаче, предлагать сервисный набор функций
6. Выводить отчет о последних 3 операциях по снятию и вносу наличности.
7. Сообщать сколько и какого номинала ден. знаки остались в терминале
8. Осуществлять перевод с карты на карту по её номеру.
Админ
1. Сообщать о наличии остатков купюр, по номиналам оставшихся на выдачу
2. Сообщать о наличии остатков купюр, по номиналам загруженных пользователем
3. Выводить статистику (средняя сумма снятия, средняя сумма загрузки,
максимальная/минимальная сумма снятия и загрузки, какой номинал вносили чаще/реже
других купюр)
4. Уметь загружать новые купюры и выдавать рекомендации по загрузке номинала и к-ва
Общее
1. Консольный интерфейс
2. Вывод сообщений об ошибках
3. Надежность
4. Дополнительный функционал приветствуется, но не в ущерб основному

Лабораторная работа 2 - FlatFloorHouse:
Задание 1
Создайте класс Flat квартиры жилого дома.
Квартира не хранит свой номер.
Разные квартиры могут иметь разную площадь.
Разные квартиры могут иметь разное количество комнат.
Конструктор по умолчанию создает квартиру из 2 комнат площадью 50 кв.м. (эти числа должны быть константами в классе)
Конструктор может принимать площадь квартиры (создается квартира с 2 комнатами).
Конструктор может принимать площадь квартиры и количество комнат.
Создайте метод получения количества комнат в квартире.
Создайте метод изменения количества комнат в квартире.
Создайте метод получения площади квартиры.
Создайте метод изменения площади квартиры.
Задание 2
Создайте класс DwellingFloor этажа жилого здания, основанный на массиве квартир.
Номер квартиры явно не хранится.
Нумерация квартир на этаже сквозная и начинается с нуля.
Конструктор может принимать количество квартир на этаже.
Конструктор может принимать массив квартир этажа.
Создайте метод получения количества квартир на этаже.
Создайте метод получения общей площади квартир этажа.
Создайте метод получения общего количества комнат этажа.
Создайте метод получения массива квартир этажа.
Создайте метод получения объекта квартиры, по ее номеру на этаже.
Создайте метод изменения квартиры по ее номеру на этаже и ссылке на новую квартиру.
Создайте метод добавления новой квартиры на этаже по будущему номеру квартиры.
Создайте метод удаления квартиры по ее номеру на этаже.
Создайте метод getBestSpace() получения самой большой по площади квартиры этажа.
Задание 3
Создайте класс Dwelling жилого здания, основанный на массиве этажей здания.
Номер квартиры явно не хранится.
Нумерация квартир в доме сквозная и начинается с нуля.
Конструктор может принимать количество этажей и массив количества квартир по этажам.
Конструктор может принимать массив этажей дома.
Создайте метод получения общего количества этажей дома.
Создайте метод получения общего количества квартир дома.
Создайте метод получения общей площади квартир дома.
Создайте метод получения общего количества комнат дома.
Создайте метод получения массива этажей жилого дома.
Создайте метод получения объекта этажа, по его номеру в доме.
Создайте метод изменения этажа по его номеру в доме и ссылке на обновленный этаж.
Создайте метод получения объекта квартиры по ее номеру в доме.
Создайте метод изменения объекта квартиры по ее номеру в доме и ссылке типа квартиры.
Создайте метод добавления квартиры в дом по номеру квартиры в доме и ссылке на квартиру (количество этажей в доме при этом не увеличивается).
Создайте метод удаления квартиры по ее номеру в доме.
Создайте метод getBestSpace() получения самой большой по площади квартиры дома.
Создайте метод получения отсортированного по убыванию площадей массива квартир.
Задание 4
Объедините имеющиеся на данный момент типы в пакет buildings.
Проверьте работу классов, создав экземпляр многоэтажного жилого дома с различными произвольными значениями количества квартир по этажам, а также площадей и количества комнат в квартирах.
