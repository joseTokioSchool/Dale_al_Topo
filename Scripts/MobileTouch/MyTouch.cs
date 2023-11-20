using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTouch : MonoBehaviour
{
    /*-------------------- MÉTODOS PRINCIPALES --------------------*/
    void Start()
    {
        
    }

    /*-------------------- MÉTODOS ACTUALIZACIÓN --------------------*/
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            Debug.Log(myTouch.fingerId);
            Debug.Log(myTouch.position);
            Debug.Log(myTouch.deltaPosition);
            Debug.Log(myTouch.phase);
        }
    }

   /*--------------------------- FUNCIONES ---------------------------*/
}
