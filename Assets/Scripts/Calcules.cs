using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcules : MonoBehaviour
{
    public int num1;
    public int num2;
    public int resultado;

    void Start()
    {
        resultado = num1 + num2;
        Debug.Log(resultado);
    }

    
    void Update()
    {
        
    }
}
