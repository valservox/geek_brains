'''
Петя, Катя и Сережа делают из бумаги журавликов. 
Вместе они сделали S журавликов. 
Сколько журавликов сделал каждый ребенок, 
если известно, что Петя и Сережа сделали одинаковое количество журавликов, 
а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?

Пример:
6 -> 1 4 1
24 -> 4 16 4
60 -> 10 40 10

П = С
К = 2(П +С) = 4П
S = 6П
'''

total = int(input('Всего журавликов: '))

pete = total / 6
serg = pete
kate = pete * 4

print(f'Петя сделал {pete} журавликов')
print(f'Сережа сделал {serg} журавликов')
print(f'Катя сделала {kate} журавликов')