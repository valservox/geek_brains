'''
Напишите программу, которая принимает на вход
строку, и отслеживает, сколько раз каждый символ
уже встречался. Количество повторов добавляется к
символам с помощью постфикса формата _n.

Input: a a a b c a a d c d d
Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2

Для решения данной задачи используйте функцию .split()
'''

input_str = 'a a a b c a a d c d d'
input_list = input_str.split()
temp = {}
res_str = ''

for i in input_list:
    if temp.get(i) != None:
        temp[i] += 1
        res_str = f'{i}_{temp[i]} '
    else:
        temp[i] = 0
        res_str = f'{i} '
    print(res_str, end=' ')