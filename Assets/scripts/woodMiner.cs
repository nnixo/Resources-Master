using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodMiner : MonoBehaviour
{
    void Start()
    {
        // Registrovanie funkcie, ktor· sa zavol·, keÔ sa zmenÌ hodnota sekacClose
        EventManager.OnSekacCloseChanged.AddListener(OnSekacCloseChanged);
    }

    void OnSekacCloseChanged(bool newSekacCloseValue)
    {
        // Pouûitie hodnoty v woodMiner skripte
        if (newSekacCloseValue)
        {
            Debug.Log("SekacClose sa zmenilo na true.");
            // MÙûeö pridaù Ôalöiu logiku alebo akcie, ktorÈ chceö vykonaù
        }
    }
}
