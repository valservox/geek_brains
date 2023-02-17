'''
Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.

Пользователь вводит 2 числа. 
n - кол-во элементов первого множества. 
m - кол-во элементов второго множества. 
Затем пользователь вводит сами элементы множеств.
'''

input_size_1 = int(input('Введите число элементов множества(1): '))
input_size_2 = int(input('Введите число элементов множества(2): '))

set_1 = set([int(input(f'Введите число({i+1}) массива(1): ')) for i in range(input_size_1)])
set_2 = set([int(input(f'Введите число({i+1}) массива(2): ')) for i in range(input_size_2)])

print (f'sorted set: \n {sorted(set_1.intersection(set_2))}')