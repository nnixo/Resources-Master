using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class woodGain : MonoBehaviour
{
    public bool sekacClose = false;
    
    public int celkovyPocetDreva = 0;
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject Player;
    public int backpackSize = 30;
    


    void Start()
    {

        StartCoroutine(PridavacDrevaCoroutine());
    }

    void Update()
    {
        UpdateText();
    }

    void UpdateText()
    {
        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.text = "Backpack " + celkovyPocetDreva + "/" + backpackSize;
                 
        }
    }

    IEnumerator PridavacDrevaCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            if (sekacClose)
            {
                if (celkovyPocetDreva < backpackSize)
                {
                    PridajDrevo();
                }
                else if(celkovyPocetDreva>backpackSize)
                {
                    celkovyPocetDreva = backpackSize;
                    
                }
            }
        }
    }

    void PridajDrevo()
    {
        celkovyPocetDreva =+backpackSize;
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("sekacDreva"))
        {
            sekacClose = true;
        }
        else
        {
            sekacClose = false;
        }
    }

}