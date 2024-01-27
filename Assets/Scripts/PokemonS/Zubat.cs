using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zubat : PokemonStats
{
    // Start is called before the first frame update
    void Start()
    {
        switch (pokemonName)
        {
            case Name.Chimchar: Debug.Log("Name: Chimchar"); break;
            case Name.Geodude: Debug.Log("Name: Geodude"); break;
            case Name.Mankey: Debug.Log("Name: Mankey"); break;
            case Name.Mudkip: Debug.Log("Name: Mudkip"); break;
            case Name.Oddish: Debug.Log("Name: Oddish"); break;
            case Name.Tailow: Debug.Log("Name: Tailow"); break;
            case Name.Trapinch: Debug.Log("Name: Trapinch"); break;
            case Name.Unown: Debug.Log("Name: Unown"); break;
            case Name.Zangoose: Debug.Log("Name: Zangoose"); break;
            case Name.Zubat: Debug.Log("Name: Zubat"); break;
            default:
                Debug.Log("Pokemon is not in data");
                break; 
        }

        switch (pokemonType)
        {
            case Type.Fighting: Debug.Log("Type: Fighting"); break;
            case Type.Fire: Debug.Log("Type: Fire"); break;
            case Type.Flying: Debug.Log("Type: Flying"); break;
            case Type.Grass: Debug.Log("Type: Grass"); break;
            case Type.Ground: Debug.Log("Type: Ground"); break;
            case Type.Normal: Debug.Log("Type: Normal"); break;
            case Type.Poison: Debug.Log("Type: Poison"); break;
            case Type.Psychic: Debug.Log("Type: Psychic"); break;
            case Type.Rock: Debug.Log("Type: Rock"); break;
            case Type.Water: Debug.Log("Type: Water"); break;

            default:
                Debug.Log("Pokemon Type does not exist!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
