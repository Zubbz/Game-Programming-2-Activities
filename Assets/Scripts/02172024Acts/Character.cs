using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string name;
    public int HP;
    public int MP;

    public Character()
    {

    }
    public Character(string name)
    {
        this.name = name;
    }
    public Character(int HP)
    {
        this.HP = HP;
    }
    public Character(string name, int HP, int MP)
    {
        this.name = name;
        this.HP = HP;
    }
}
