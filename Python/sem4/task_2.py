'''
Пользователь вводит текст(строка). 
Словом считается последовательность непробельных символов,
идущих подряд, слова разделены одним или большим числом пробелов.

Определите, сколько различных слов
содержится в этом тексте.

Input: She sells sea shells on the sea shore The shells
that she sells are sea shells I'm sure.So if she sells sea
shells on the sea shore I'm sure that the shells are sea
shore shells
Output: 13
'''

input_str = "She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure.So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells"

# input_str = input_str.upper
input_str = input_str.upper()
input_list = input_str.split()
input_set = set(input_list)
# print(input_list)
# print(input_set)
print(len(input_set))