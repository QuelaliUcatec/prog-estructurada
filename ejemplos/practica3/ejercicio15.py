#ejercicio 15 : Leer la temperatura y mostrar si hace frío, templado o calor.
temp= int(input("Ingrese temperatura: "))

if temp < 15 : 
   print( " clima frio ") 

elif temp > 15 < 25 :
   print( " Clima templado ")
elif temp > 25 :
   print( " Clima Caluroso ")