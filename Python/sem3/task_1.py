'''
Дан список чисел. Определите, сколько в нем
встречается различных чисел.

Input: [1, 1, 2, 0, -1, 3, 4, 4]
Output: 6

Примечание: Пользователь может вводить значения
списка или список задан изначально.
'''

list_1 = [1, 1, 2, 0, -1, 3, 4, 4]
list_2 = set(list_1)
print(list_2)
print(len(list_2))