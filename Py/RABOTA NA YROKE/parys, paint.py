from tkinter import *

root = Tk()
root.title("Рисунок")

canvas = Canvas(root, width=1920, height=350, bg="#f6e2b0")
canvas.pack()

canvas.create_rectangle(0, 300, 9999, 350, fill="#fece7a", width="0")  # нижний слой (пляжик)
def draw_object(x,y):
    canvas.create_polygon(220+x,150+y,250+x,40+y,300+x,120+y, fill="#62b999") #Парус голубой
    canvas.create_polygon(220+x, 155+y, 250+x, 240+y, 300+x, 125+y, fill="#f67824") #Парус оранжевый
    canvas.create_polygon(100+x, 250+y, 150+x, 250+y, 150+x, 300+y, fill="#f67824")
    canvas.create_rectangle(155+x,250+y,205+x,300+y, fill="#62b999", width="0")
    canvas.create_polygon(210+x, 250+y, 210+x, 300+y, 260+x, 300+y, fill="black")
    canvas.create_polygon(215+x, 250+y, 270+x, 250+y, 320+x, 300+y, 265+x, 300+y, fill="#b53f3f")
    canvas.create_polygon(275+x, 250+y, 370+x, 250+y, 325+x, 300+y, fill="#f67824")
    canvas.create_oval(330+x, 40+y, 370+x, 80+y, fill="white", outline="#fea406", width=6) #Солнышко

draw_object(0,0)
draw_object(500, -50)
draw_object(1000, 50)

root.mainloop()