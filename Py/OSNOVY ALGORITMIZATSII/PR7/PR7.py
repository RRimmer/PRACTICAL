import random
A = input("Введите элементы массива A через пробел: ").split()
B = []

for elem in A:
    if int(elem) > 0:
        B.append(int(elem))

print("Массив B, состоящий из положительных элементов массива A:", B)

array = []
for i in range(15):
    array.append(random.uniform(22, 23))

print("Массив из случайных вещественных значений:", array)
