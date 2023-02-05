'''
Петя и Катя – брат и сестра. Петя – студент, а Катя –
школьница. Петя помогает Кате по математике. Он задумывает два
натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для
этого Петя делает две подсказки. Он называет сумму этих чисел S и их
произведение P. Помогите Кате отгадать задуманные Петей числа.

4 4 -> 2 2
5 6 -> 2 3

S = num1 + num1
P = num1 * num1
num1 = S - num1

(S - num1) * num1 = P 
S * num1 - num1 ** 2 - P = 0
num1 ** 2 - S * num1 + P = 0

D = (S ** 2 - 4 * P) => 0
D > 0 -> num1 = (S +- sqr(D)) / 2
D = 0 -> num1 = S / 2
'''

input_list = []
counter = 1
limit = 2
while counter <= limit:
    input_list.append(int(input(f'Введите число ({counter}): ')))
    counter += 1

D = input_list[0] ** 2 - 4 * input_list[1]

if D < 0:
    print('Ошибка - таких чисел не существует')
    exit()
elif D == 0:
    num1 = input_list[0] // 2
else:
    num1 = (input_list[0] + int(D ** 0.5)) // 2
    if num1 < 1 or num1 > 1000:
        num1 = (input_list[0] - int(D ** 0.5)) // 2
    if num1 < 1 or num1 > 1000:
        print('Ошибка - таких чисел не существует')
        exit()

num2 = input_list[0] - num1
print(f'Загаданные числа: {num1}, {num2}')