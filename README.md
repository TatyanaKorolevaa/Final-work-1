Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Первоначальный массив *array* задан на старте выполнения алгоритма.
Вводим переменную *count* для определения размера массива, в который будем переносить строки длина которых меньше, либо равна 3 символам.
Задаем индекс *i = 0*.
**Пока** индекс меньше длины массива *array*, работает цикл - **если** длина элемента массива меньше 4 (т.е. меньше либо равно 3), то увеличивается переменная *count* на 1. Величина *i* увеличивается на 1. Цикл работает пока не пройдется по всем элементам массива.

Как только выходим из циклов, мы получаем размер (переменная *count*) нашего нового массива. Задаем пустой массив *result*.
Присваиваем индексам *i* и *j* значение = 0.

**Пока** индекс *i* меньше длины массива *array*, работает цикл - **если** длина элемента массива *array* меньше 4 (т.е. меньше либо равно 3), то элементу массива *result* присваивается значение элемента массива *array*. Величина индексов *i* и *j* увеличивается на 1 соответственно. Цикл работает пока не пройдется по всем элементам массива *array*.

Выводим на печать значения массива *result*



