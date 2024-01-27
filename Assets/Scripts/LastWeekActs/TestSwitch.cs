using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwitch : MonoBehaviour
{
    public TestEnum testEnum;
    // Start is called before the first frame update
    void Start()
    {
        switch (testEnum)
        {
            case TestEnum.Lunes: Debug.Log("Ngayon ay Lunes"); break;
            case TestEnum.Martes: Debug.Log("Ngayon ay Martes"); break;
            case TestEnum.Miyerkules: Debug.Log("Ngayon ay Miyerkules"); break;
            case TestEnum.Huwebes: Debug.Log("Ngayon ay Huwebes"); break;
            case TestEnum.Biyernes: Debug.Log("Ngayon ay Biyernes"); break;
            case TestEnum.Sabado: Debug.Log("Ngayon ay Sabado"); break;
            case TestEnum.Linggo: Debug.Log("Ngayon ay Linggo"); break;
            default:
                Debug.Log("No specific araw is called");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
