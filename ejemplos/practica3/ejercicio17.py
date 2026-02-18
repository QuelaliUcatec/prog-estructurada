#ejercicio 17 : Leer el total de una compra y determinar si obtiene envío gratis según el monto.
total= int(input("Ingrese precio: "))

if total < 500 : 
   print( " el envio no es gratis ") 

elif total > 500 :
   print( " el envio es gratis ")
