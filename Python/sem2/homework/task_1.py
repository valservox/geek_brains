'''
На столе лежат n монеток. Некоторые из них лежат вверх
решкой, а некоторые – гербом. Определите минимальное число
монеток, которые нужно перевернуть, чтобы все монетки были
повернуты вверх одной и той же стороной. Выведите минимальное
количество монет, которые нужно перевернуть.

5 -> 1 0 1 1 0 -> 2
'''

coins_qty = int(input('Количество монет: '))
heads = 0

from random import getrandbits
for _ in range(coins_qty):
    if bool(getrandbits(1)):
        heads += 1

res = heads
tails = coins_qty - heads
print(f'Орлы  - {heads}')
print(f'Решки - {tails}')
if heads > tails:
    res = tails

print(f'Нужно перевернуть {res}')