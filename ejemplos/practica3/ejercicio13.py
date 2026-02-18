#ejercicio 13 : Leer la hora del día (0–23) y mostrar si es mañana, tarde o noche.
hora= int(input("Ingrese la hora: "))
if hora < 12 : 
   print( " Es mañana ") 

elif hora > 12 < 18 : 
   print( " Es tarde ") 
elif hora > 19 < 6 : 
   print( " Es noche ") 
