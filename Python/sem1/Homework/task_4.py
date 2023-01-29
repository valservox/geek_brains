'''
Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек, 
если разрешается сделать один разлом по прямой между дольками 
(то есть разломить шоколадку на два прямоугольника).

Пример:
3 2 4 -> yes
3 2 1 -> no
'''

side1 = int(input('Долек по вертикали: '))
side2 = int(input('Долек по горизонтали: '))
piece = int(input('Сколько долек отломить: '))

s = side1 * side2
isEven = (s - piece) % 2 == 0
equalSide = piece == side1 or piece == side2
oneRow = side1 == 1 or side2 == 1

res = 'no'
if (isEven or equalSide or oneRow) and s > piece:
    res = 'yes'
print(f'Шоколадка делится одним разломом: {res}')