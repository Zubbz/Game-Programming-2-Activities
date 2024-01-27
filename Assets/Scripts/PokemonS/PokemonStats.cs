using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonStats : MonoBehaviour
{

    [Header("Pokemon Information")]
    public int dexNum;
    public int pokemonLevel;
    public Name pokemonName;
    public Type pokemonType;
    public Nature pokemonNature;
    public Gender pokemonGender;
    public string Owner;

    [Header("Stats")]
    public int Hp;
    public int Atk;
    public int Def;
    public int SpAtk;
    public int SpDef;
    public int Spd;

}
