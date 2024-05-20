using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalaTiempo : MonoBehaviour
{
    bool pausa; // si es false No hay pausa, si es true, estará pausado

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F10))
        {
            if (pausa == false)
            {
                Time.timeScale = 0;
                pausa = true;
            }
            else
            {
                Time.timeScale = 1;
                pausa = false;
           
            }



        }
           
        
    }
}
