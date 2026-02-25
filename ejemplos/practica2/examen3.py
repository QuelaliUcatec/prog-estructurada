
a1 = float(input("Ingresa el primer ángulo: "))
a2 = float(input("Ingresa el segundo ángulo: "))
a3 = float(input("Ingresa el tercer ángulo: "))


if a1 + a2 + a3 == 180:
    print("Es un triángulo válido.")
    
  
    if a1 == 90 or a2 == 90 or a3 == 90:
        print("Es un triángulo rectángulo.")
    else:
        print("No es un triángulo rectángulo.")
else:
    print("No es un triángulo válido (la suma debe ser 180°).")