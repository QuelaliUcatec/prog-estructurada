#Leer la hora del día (0–23) y mostrar si es mañana, tarde o noche.
hora = int(input("Ingresa la hora del día (0-23): "))
if 0 <= hora < 12:
    print("Es mañana")
elif 12 <= hora < 18:
    print("Es tarde")
else:
    print("Es noche")