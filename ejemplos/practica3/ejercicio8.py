#Ingresar el precio de una compra y aplicar un descuento del 10% si supera cierto monto.
precio = float(input("Ingresa el precio de la compra: "))
if precio > 100:
    descuento = precio * 0.10
    precio_final = precio - descuento
    print(f"Se aplicó un descuento de ${descuento}")
    print(f"El precio final es ${precio_final}")
else:
    print(f"El precio final es ${precio}")