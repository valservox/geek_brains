'''
Вы пользуетесь общественным транспортом? 
Вероятно, вы расплачивались за проезд и получали билет с номером.
Счастливым билетом называют такой билет с шестизначным номером, 
где сумма первых трех цифр равна сумме последних трех. 
Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. 
Вам требуется написать программу, которая проверяет счастливость билета.

Пример:
385916 -> yes
123456 -> no
'''

ticket = input('Введите номер билета:')
if len(ticket) % 2 !=0:
    print('Ошибка - число должно быть четным')
    exit()

sum1 = 0
sum2 = 0
half = len(ticket) // 2
r = range(half)

for i in r:
    sum1 += int(ticket[i])
    sum2 += int(ticket[half + i])

res = 'no'
if sum1 == sum2:
    res = 'yes'
print(f'Билет счастливый: {res}')