#Зад 1
k=int(input("Введите трехзначное число: "))
if k//100<(k//10)%10<k%10:
    print("Это число В упорядоченной последовательности.")
else:
    print("Это число НЕ в упорядоченной последовательности.")

#Зад 2
x=int(input('x: '))
y=int(input('y: '))
print('Четверть:', (x<0)+(y<0)+2*(x>0)*(y<0)+1)
