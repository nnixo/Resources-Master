using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodMiner : MonoBehaviour
{
    void Start()
    {
        // Registrovanie funkcie, ktor� sa zavol�, ke� sa zmen� hodnota sekacClose
        EventManager.OnSekacCloseChanged.AddListener(OnSekacCloseChanged);
    }

    void OnSekacCloseChanged(bool newSekacCloseValue)
    {
        // Pou�itie hodnoty v woodMiner skripte
        if (newSekacCloseValue)
        {
            Debug.Log("SekacClose sa zmenilo na true.");
            // M��e� prida� �al�iu logiku alebo akcie, ktor� chce� vykona�
        }
    }
}
