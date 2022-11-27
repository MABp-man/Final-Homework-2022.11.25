## *Задача*:
написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых не больше трех символов. Первоначальный массив можно задать на старте выполнения алгоритма.

## *Решение:*
1. Задаём массив, например ["hello", "2", "world", ":-)"]
2. Вводим переменную Count (счетчик соответствующих условию элементов).
3. Создаём новый пустой массив для сохранения результата.
4. Запускаем цикл проверки элементов заданного массива по условию "не больше 3 символов". Если условие выполняется, присваиваем значение элемента заданного массива элементу нового массива с индексом Count. Увеличиваем счётчик Count на 1.
5. По выходу из цикла изменяем размер нового массива - приравниваем к Count.
6. Выводим результат в консоль.
