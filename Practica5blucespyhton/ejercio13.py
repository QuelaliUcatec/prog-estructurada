## Pedir una contraseña al usuario. El programa no debe terminar hasta que el usuario ingrese la clave correcta (ejemplo: "python123").
clave_correcta = "wenzel"

intento = input("Introduce la contraseña: ")

while intento != clave_correcta:
    print("Contraseña incorrecta. Inténtalo de nuevo.")
    intento = input("Introduce la contraseña: ")
else:
    print("¡Acceso concedido!")