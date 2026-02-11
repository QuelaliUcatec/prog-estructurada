#Leer el total de una compra y determinar si obtiene envío gratis según el monto.
total = float(input("Ingresa el total de la compra: "))
if total >= 1000:
    print("Obtienes envío gratis")
else:
    print("No obtienes envío gratis")