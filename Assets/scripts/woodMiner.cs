using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodMiner : MonoBehaviour
{
    private woodGain refNaScript;
    bool closeSekac = false;
    public float rychlost = 5f;
    int sizeBackpack;
    int backpack;
    private Rigidbody2D rb;
    private bool pohybDoprava = true;
    private float casCakania1 = 5f;
    private float casCakania2 = 7f;
    private bool cakaj = false;
    int celkovyPocetDreva;
    bool depositComplete = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        refNaScript = GetComponent<woodGain>();
        if (refNaScript != null)
        {
             closeSekac = refNaScript.sekacClose;
            sizeBackpack = refNaScript.backpackSize;
            celkovyPocetDreva=refNaScript.celkovyPocetDreva;
            backpack = sizeBackpack;
        }
        

    }
    private void Update()
    {
        if (!cakaj)
        {
            if (pohybDoprava)
            {
                // Pohyb doprava
                rb.velocity = new Vector2(rychlost, rb.velocity.y);
            }
            else
            {
                // Pohyb do�ava
                rb.velocity = new Vector2(-rychlost, rb.velocity.y);
            }

        }
        if (depositComplete)
        {
            // Hr�� sa pohybuje doprava po ulo�en� dreva
            rb.velocity = new Vector2(rychlost, rb.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tree"))
        {
            // Hr�� vst�pil do triggeru s tagom "Tree"
            cakaj = true;
            Invoke("ZmenSmerPohybu", casCakania1);
        }
    }
    void ZmenSmerPohybu()
    {
        // Zmeni� smer pohybu a znovu pusti� hr��a
        pohybDoprava = !pohybDoprava;
        cakaj = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("depositBox"))
        {
            cakaj = true;
            // Hr�� pri�iel do triggeru s tagom "deposit box"
            Invoke("DepositujDrevo", casCakania2);
        }
    }
    void DepositujDrevo()
    {
        // Ulo�te v�etko drevo
        UlozDrevo(celkovyPocetDreva);

        // Nastavte flag pre dokon�en� vklad dreva

        depositComplete = true;
        cakaj = false;
    }
    void UlozDrevo(int pocetDreva)
    {
        // Toto je pr�klad - m��ete sem prida� logiku pre ukladanie dreva do deposit boxu
        Debug.Log("Ulo�en� drevo: " + pocetDreva);
    }






}
