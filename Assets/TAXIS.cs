﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////Una flota de taxis tiene una cantidad determinada de unidades. Se calcula que cada unidad recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km. Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km por unidad. Teniendo en cuenta que el litro de combustible cuesta $130, debemos hacer un programa que nos permita calcular el costo del combustible para una flota completa de taxis en un período de días determinado.

//Se requiere el ingreso por Inspector de la cantidad de unidades que tiene la flota, la cantidad total de días y una cantidad de días de lluvia a tener en cuenta.

//El programa debe cumplir los siguientes requerimientos:

//El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
//“Una flota de[cantidadDeUnidades] unidades trabajando durante [periodoDeDias] días implicará un gasto de[costoTotalCombustible] pesos en concepto de combustible”.

//El programa debe devolver un mensaje de error y no realizar ningún cálculo si la cantidad de días total es menor que 5 o si la cantidad de días de lluvia es negativa o mayor que la cantidad total de días. 


public class TAXIS : MonoBehaviour
{
    public int dias_trabajo;
    public int taxis;
    public int dias_lluvia;
    int precio_lluvia;
    int precio;
    float costo_total_de_combustible;

    // Start is called before the first frame update
    void Start()
    {
        if (dias_trabajo < 5)
        { 
            Debug.Log(" No se puede calcular tan pocos dias ");
        }
        else if (dias_trabajo < dias_lluvia )
        {
            Debug.Log(" No pueden haber mas dias de lluvia que de trabajo ");
        }

        precio = (90 % 15) * 130 * (dias_trabajo-dias_lluvia);
        precio_lluvia = ((110 % 15) * 130) * dias_lluvia;
        costo_total_de_combustible = (precio + precio_lluvia) * taxis;


        Debug.Log(" Una flota de " + taxis + " unidades trabajando durante " + dias_trabajo + " días implicará un gasto de " + costo_total_de_combustible + " pesos en concepto de combustible");

    }

    // Update is called once per frame
    void Update()
    {

    }
}