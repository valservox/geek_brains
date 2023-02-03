'''
Дано натуральное число A > 1. Определите, каким по
счету числом Фибоначчи оно является, то есть
выведите такое число n, что φ(n)=A. Если А не
является числом Фибоначчи, выведите число -1.

Input: 5
Output: 6
'''

def fibo(input_num):
    n1, n2 = 0, 1
    fibo_id = 2
    while n2 < input_num:
        n1, n2 = n2, n1 + n2
        fibo_id += 1
    if input_num != n2:
        fibo_id = -1
    return fibo_id
        
a = int(input('Введите число: '))
print(f'Номер числа Фибоначчи: {fibo(a)}')