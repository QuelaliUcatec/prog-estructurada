#ejercicio 8 : Ingresar el precio de una compra y aplicar un descuento del 10% si supera cierto monto

precio_original= int(input("Ingresa un número: "))
resultado= precio_original - precio_original*0.10

if precio_original > 150 : 
   print(f" El resultado con descuento es: {resultado} ") 
             
 
elif precio_original < 150 :
        print("no hay descuento ")