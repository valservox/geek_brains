'''
Найдите сумму цифр трехзначного числа.

Пример:
123 -> 6 (1 + 2 + 3)
100 -> 1 (1 + 0 + 0)
'''

sum = 0
num = input('Введите число: ')
for i in range(len(num)):
    sum += int(num[i])
print(f'Сумма цифр числа {num}: {sum}')