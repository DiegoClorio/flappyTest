using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct DatosDeJugador
{

    public Transform position;
    public int vida;
    public DatosDeJugador(Transform pos)
    {
        position = pos;
        vida = 0;
    }
}

public class Structs101 : MonoBehaviour
{
    DatosDeJugador datosJugado1;
    DatosDeJugador datosJugado2;
    DatosDeJugador datosJugado3;

    List<DatosDeJugador> jugadores = new List<DatosDeJugador>();

    public List<SO101> fruits;
    public GameObject fruit;
    public int fruitNumber;

    private void Start()
    {
        fruit.GetComponent<SpriteRenderer>().sprite = fruits[fruitNumber].sprite;
    }
}
