using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodMiner : MonoBehaviour
{
    public woodGain woodMinerr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool sekacClose = woodMinerr.getSekacClose();
        Debug.Log(sekacClose);
    }
}
