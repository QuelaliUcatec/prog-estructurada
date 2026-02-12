#DADO UN PRECIO Y DESCUENTOS POR TIPO DE CLIENTE, RESOLVER LOS DESCUENTOS EN BASE AL TIPO DE CLENTE 

precio_original = 100

categoria = input("Ingrese la categoría del cliente (regular, premium o VIP): ")
if categoria == "regular":
    descuento = 0
elif categoria == "premium":
    descuento = 0.10
elif categoria == "vip":
    descuento = 0.20

precio_final = precio_original - (precio_original * descuento)

print ("El precio final es:", precio_final)