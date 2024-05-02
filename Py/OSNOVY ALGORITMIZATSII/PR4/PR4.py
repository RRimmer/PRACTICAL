import math

count = 0
number = 107

print("Первые 10 натуральных чисел, оканчивающихся на 7, кратных 9 и больше 100:")

while count < 10:
    if number % 10 == 7 and number % 9 == 0:
        print(number)
        count += 1
    number += 1

number = input("Введите натуральное число: ")

for i in range(len(number) - 1):
    if int(number[i]) < int(number[i+1]):
        print("Последовательность его цифр не упорядочена по возрастанию")
        break
else:
    print("Последовательность его цифр упорядочена по возрастанию")