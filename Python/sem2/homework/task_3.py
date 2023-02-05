'''
Требуется вывести все целые степени двойки (т.е. числа вида 2 ** k), не превосходящие числа N.
10 -> 1 2 4 8
'''

input_num = int(input('Введите натуральное число: '))

power_num = 0
res = 0

if input_num <= 0:
    print('Ошибка - введённое число не является натуральным')
    exit()

while res <= input_num:
    res = 2 ** power_num
    power_num += 1
    if res <= input_num:
        print(res, end=' ')