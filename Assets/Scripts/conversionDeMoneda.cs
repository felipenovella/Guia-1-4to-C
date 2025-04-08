using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversionDeMoneda : MonoBehaviour
{
    public float MontoAConvertir;
    public string codigoMoneda;
    float montoConvertido;
    float CotizacionMonedaElegida;

    void Start()
    {
        if (MontoAConvertir < 1000)
        {
            Debug.Log("El monto minimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            CotizacionMonedaElegida = 1134.5f;

        } else if(codigoMoneda == "E")
        {
            CotizacionMonedaElegida = 1397;

        } else if(codigoMoneda == "R")
        {
            CotizacionMonedaElegida = 211.8f;

        }
        else
        {
            Debug.Log("Opcion de monda extranjera no valida");
        }

        montoConvertido = MontoAConvertir / CotizacionMonedaElegida;

        Debug.Log("El monto convertido es de " + montoConvertido);
    }

    void Update()
    {
        
    }
} 
