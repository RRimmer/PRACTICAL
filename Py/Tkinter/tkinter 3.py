from tkinter import *

root = Tk()
root.title("Радуга")

def insert_color(color_code, color_name):
    e1.delete(0, END)
    e1.insert(0, color_code)
    lab['text'] = color_name 

e1 = Entry(root, width=30, justify=CENTER)
e1.pack()

lab = Label(root, font=("Times New Roman", 14))
lab.pack()

#Добавил выравнивание кнопок
f_top = Frame(root)
f_top.pack(pady=5)

colors = [
    ("#ff0000", "Красный"),
    ("#ff7d00", "Оранжевый"),
    ("#ffff00", "Желтый"),
    ("#00ff00", "Зеленый"),
    ("#007dff", "Голубой"),
    ("#0000ff", "Синий"),
    ("#7d00ff", "Фиолетовый"),
]

for color_code, color_name in colors:
    Button(root, bg=color_code, 
    width=5, #Ширина кнопок увеличена на 5
    command=lambda c=color_code, 
    n=color_name: insert_color(c, n)).pack(side=LEFT, pady=5)

root.mainloop()
