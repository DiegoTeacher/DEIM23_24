using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{
    public Charmander() : base() // default 
    {
        name = "Charmander";
        type = Tipo.FUEGO;
    }

    // override = vamos a sobreescribir el metodo
    public override void Attack()
    {
        Debug.Log(name + " Lanza bola fuego");
    }
}
