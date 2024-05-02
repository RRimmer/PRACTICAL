#PR 8
import random
size = int(input("Введите размер массива: "))
array = []

for i in range(size):
    array.append(random.randint(0, 100))
print("Сгенерированный массив:", array)

left_index = int(input("Введите начальный индекс: "))
right_index = int(input("Введите конечный индекс: "))

result = 0
for i in range(left_index, right_index + 1):
    result += array[i]

print("Сумма элементов массива, расположенных между заданными индексами:", result)
