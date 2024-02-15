using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipo { AGUA, FUEGO, TIERRA, ELECTRICO, PLANTA};
public abstract class Pokemon
{
    private int hp, lvl;
    protected string name;
    protected Tipo type = Tipo.AGUA;

    public Pokemon() // default 
    {
        hp = 50;
        lvl = 1;
        name = "Pikachu";
        type = Tipo.ELECTRICO;
    }

    public Pokemon(int hp, int lvl, string name, Tipo type)
    {
        this.hp = hp;
        this.lvl = lvl;
        this.name = name;
        this.type = type;
    }

    // virtual = si quiero que este implementado
    // abstract = si no quiero implementarlo
    public virtual void Attack()
    {
        Debug.Log(name  + " ataca");
    }

    public string GetName()
    {
        return name;
    }

    public Tipo GetType()
    {
        return type;
    }

    public int GetHp() 
    {
        return hp;
    }

    public void SetHp(int hp)
    {
        this.hp = hp;
    }
}
