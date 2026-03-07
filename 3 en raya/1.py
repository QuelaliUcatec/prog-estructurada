def mostrar(m):
    for i in range(3):
        print(f"{m[i]}")

def guia():
    print("Tres en Raya (Consola)")
    print("Casillas:")
    print(" 1 | 2 | 3 ")
    print("---+---+---")
    print(" 4 | 5 | 6 ")
    print("---+---+---")
    print(" 7 | 8 | 9 ")

def colocar_posicion(t, pos, jugador):
    posiciones = {
        1: (0, 0), 2: (0, 1), 3: (0, 2),
        4: (1, 0), 5: (1, 1), 6: (1, 2),
        7: (2, 0), 8: (2, 1), 9: (2, 2)
    }
    
    if pos in posiciones:
        fila, columna = posiciones[pos]
        t[fila][columna] = jugador
    else:
        print("Posición inválida")

def verificar_jugada(t, jugador):

    if (t[0][0] == jugador and t[0][1] == jugador and t[0][2] == jugador):
        return True
    elif (t[1][0] == jugador and t[1][1] == jugador and t[1][2] == jugador):
        return True
    elif (t[2][0] == jugador and t[2][1] == jugador and t[2][2] == jugador):
        return True
    elif (t[0][0] == jugador and t[1][0] == jugador and t[2][0] == jugador):
        return True
    elif (t[0][1] == jugador and t[1][1] == jugador and t[2][1] == jugador):
        return True
    elif (t[0][2] == jugador and t[1][2] == jugador and t[2][2] == jugador):
        return True
    elif (t[0][0] == jugador and t[1][1] == jugador and t[2][2] == jugador):
        return True
    elif (t[0][2] == jugador and t[1][1] == jugador and t[2][0] == jugador):
        return True
    else:
        return False


def principal():
    tablero = [[''] * 3 for _ in range(3)]
    guia()
    
    ganador = False
    jugador = "X"

    while ganador==False:
        posicion = int(input(f"Jugador {jugador} Posición: ")) 
        colocar_posicion(tablero, posicion, jugador)
        mostrar(tablero)

        ganador = verificar_jugada(tablero, jugador)

        jugador = "O" if jugador == "X" else "X"

        #if (jugador == "X"):
        #    jugador = "O"
        #else:
        #    jugador = "X"

if __name__ == "__main__":
    principal()