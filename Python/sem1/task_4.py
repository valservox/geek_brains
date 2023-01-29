'''
Дано натуральное число. Требуется определить,
является ли год с данным номером високосным. Если
год является високосным, то выведите YES, иначе
выведите NO. Напомним, что в соответствии с
григорианским календарем, год является
високосным, если его номер кратен 4, но не кратен
100, а также если он кратен 400.

Input: 2016
Output: YES
'''

year = int(input('Год: '))
div400 = year % 400 == 0
div4 = year % 4 == 0
div100 = year % 100 == 0

res = 'NO'
if div400 or (div4 and not div100):
    res = 'YES'
print(f'Високосный: {res}')