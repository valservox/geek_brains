# Задача 

Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекции, лучше обойтись исключительно массивами.

# Решение

1. Массив задаётся пользователем с помощью метода CreateArray , перед вводом эелементов массива указывается длина массива для ограничения вводимых элементов. Метод завершается при вводе последнего элемента.
2. Заданный массив методом ShowArray выводится в консоль.
3. Методом ModifyArray подсчитывается количество элементов, длина которых меньше 3 символов. 
Данное значение задаёт размер нового массива, в который далее переносятся элементы, длина которых меньше 3 символов.
4. Обработанный массив выводится методом ShowArray.