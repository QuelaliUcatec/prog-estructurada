import ejercicio1
import ejercicio2

def menu():
    while True:
        print("\n=== MIS TAREAS DE PYTHON ===")
        print("1. Calculadora Básica")
        print("2. Tipo de Triángulo")
        print("3. Salir")
        
        opcion = input("\nElige una opción: ")

        if opcion == "1":
            print("\n--- Ejecutando Ejercicio 1 ---")
            ejercicio1.ejecutar_calculadora()
        elif opcion == "2":
            print("\n--- Ejecutando Ejercicio 2 ---")
            ejercicio2.ejecutar_triangulo()
        elif opcion == "3":
            print("Saliendo...")
            break
        else:
            print("Opción no válida.")

if __name__ == "__main__":
    menu()