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
    public GameObject Player;
    public int backpackSize = 30;
    

    void Start()
    {
        StartCoroutine(PridavacDrevaCoroutine());
    }

    void Update()
    {
        // Tu mÙûeö prÌpadne prid·vaù Ôalöiu logiku, ktor˙ potrebujeö
    }

    void UpdateText()
    {
        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.text = "Backpack " + celkovyPocetDreva+"/"+backpackSize;
        }
    }

    IEnumerator PridavacDrevaCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (sekacClose)
            {
                if (backpackSize <= celkovyPocetDreva) {
                    PridajDrevo();
                }
                else
                {

                }
            }
        }
    }

    void PridajDrevo()
    {
        celkovyPocetDreva += pocetDrevaZaSekundu;
        UpdateText();
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
    public bool getSekacClose()
    {
        return sekacClose;
    }
    
}
