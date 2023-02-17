'''
Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. 
Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
В последующих строках записаны N целых чисел Ai. Последняя строка содержит число X

???
Число X и будет самым близким к последнему числу массива. т.к. абс(x-x)=0
Тогда исключаем последний элемент из поиска

Пример:

5
1 2 3 4 5
6
-> 5
'''

from random import randint
input_range = range(int(input('Число элементов в массиве: ')))
input_list = [randint(0,10) for i in input_range]
print(input_list)

diff_list = [abs((input_list[i] - input_list[-1])) for i in input_range[:-1]]
# print(diff_list)
ind_min = diff_list.index(min(diff_list))
print(f'Число {input_list[ind_min]} ближе всего к последнему числу в массиве')