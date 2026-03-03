## Crear un menú que se repita hasta que el usuario elija la opción "Salir". Opciones: 1. Ver saldo, 2. Retirar, 3. Salir.

saldo = 1000  

while True:
    print("\n--- CAJERO AUTOMÁTICO ---")
    print("1. Ver saldo")
    print("2. Retirar")
    print("3. Salir")
    
    opcion = input("Elige una opción: ")

    if opcion == "1":
        print(f"Tu saldo actual es: ${saldo}")
    
    elif opcion == "2":
        monto = float(input("¿Cuánto deseas retirar?: "))
        if monto <= saldo:
            saldo -= monto  
            print(f"Retiro exitoso. Nuevo saldo: ${saldo}")
        else:
            print("Saldo insuficiente.")
            
    elif opcion == "3":
        print("Saliendo del sistema... ¡Hasta pronto!")
        break  
    
    else:
        print("Opción no válida, intenta de nuevo.")