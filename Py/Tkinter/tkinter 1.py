from tkinter import *

class calculetar1:
    def __init__(self, master):
        self.master = master
        self.text1 = Entry(master, width=10)
        self.text2 = Entry(master, width=10)

        self.resultl = Label(master, text="Ответ", width=20, bg='Red')

        self.plusb = Button(master, text="+", width=5, command=self.plus)
        self.minusb = Button(master, text="-", width=5, command=self.minus)
        self.ymnozhetb = Button(master, text="*", width=5, command=self.ymnozhet)
        self.delitb = Button(master, text="/", width=5, command=self.delit)

        self.text1.pack(side=LEFT, padx=5, pady=5)
        self.text2.pack(side=LEFT, padx=5, pady=5)
        self.resultl.pack(side=TOP, padx=5, pady=5)

        self.plusb.pack(side=LEFT, padx=5, pady=5)
        self.minusb.pack(side=LEFT, padx=5, pady=5)
        self.ymnozhetb.pack(side=LEFT, padx=5, pady=5)
        self.delitb.pack(side=LEFT, padx=5, pady=5)

    def plus(self):
        self.calculetar1(lambda a, b: a + b)

    def minus(self):
        self.calculetar1(lambda a, b: a - b)

    def ymnozhet(self):
        self.calculetar1(lambda a, b: a * b)

    def delit(self):
        self.calculetar1(lambda a, b: a / b)

    def calculetar1(self, operation):
        nomer1 = float(self.text1.get())
        nomer2 = float(self.text2.get())
        result = operation(nomer1, nomer2)
        self.resultl['text'] = str(result)

root = Tk()
app = calculetar1(root)

root.mainloop()