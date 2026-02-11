#Leer la temperatura y mostrar si hace frío, templado o calor.
temperatura = float(input("Ingresa la temperatura: "))
if temperatura < 10:
    print("Hace frío")
elif 10 <= temperatura <= 25:
    print("Hace templado")
else:
    print("Hace calor")