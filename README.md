# DateCalculator
Приложение 1. Калькулятор дат

Реализовать консольное приложение, которое принимает на вход несколько аргументов, среди которых даты и указание на то, 
какую операцию с ними нужно выполнить, выполняет соответствующую операцию и выводит в консоль результат. 
Если аргументы не были указаны, то приложение запрашивает их у пользователя через консоль.

Первый аргумент определяет тип операции. Трактовка остальных аргументов зависит от первого аргумента.

Должны поддерживаться следующие операции:
1. Операции с датами
Второй аргумент: дата и время в формате YYYY-MM-DDThh:mm:ss (подробнее см. ISO 8601)
Третий аргумент: строка, содержащая указание на то, какую операцию с датой нужно выполнить. Формат строки: <+|-><число><часть даты>.
 Где <часть даты> - одно из обозначений:
Y - год
M - месяц
D - день
h - час
m - минута
s - секунда
Примеры: 
+2d - прибавить к дате 2 дня
-3h - отнять от даты 3 часа
Приложение должно выполнить указанную операцию с датой и вывести получившуюся дату и время в консоль
2. Разница между датами
Второй аргумент: дата и время в формате YYYY-MM-DDThh:mm:ss
Третий аргумент: дата и время в формате YYYY-MM-DDThh:mm:ss
Четвертый аргумент: знак сложения или вычитания
Приложение должно выполнить указанную операцию с датами и вывести получившуюся дату и время, а также разницу между 
исходными датами в консоль

Приложение должно корректно обрабатывать ситуации, когда переданы ошибочные аргументы: выдавать пользователю предупреждение
и не производить никакой операции
