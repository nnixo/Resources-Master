using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class woodGain : MonoBehaviour
{

    public bool sekacClose = false;
    public int pocetDrevaZaSekundu = 1;
    private int celkovyPocetDreva = 0;
    public TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        StartCoroutine(PridavacDrevaCoroutine());
    }

    void Update()
    {
        // Tu m��e� pr�padne prid�va� �al�iu logiku, ktor� potrebuje�
    }

    void UpdateText()
    {
        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.text = "Wood: " + celkovyPocetDreva;
        }
    }

    
    IEnumerator PridavacDrevaCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            PridajDrevo();
        }
    }

    void PridajDrevo()
    {
        celkovyPocetDreva += pocetDrevaZaSekundu;
        
        UpdateText(); 
    }
}
