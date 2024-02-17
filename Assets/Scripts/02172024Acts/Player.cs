using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character character = new Character();
        character.HP = 100;
        Debug.Log(character.HP);
        character.name = "Jett";
        Debug.Log(character.name);

        character.name = "Sova";
        Debug.Log (character.name);

        Character characterTwo = new Character("Sage", 100);
        Debug.Log(characterTwo.name);
        Debug.Log(characterTwo.HP);
        Character characterTree = new Character();
    }

}
