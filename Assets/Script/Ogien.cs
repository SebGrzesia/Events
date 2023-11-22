using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ogien : MonoBehaviour
{
    public event Action PaliSie;
    public Button somsiadSiePali;
    public Button ognistyButton;
    void Start()
    {
        ognistyButton.onClick.AddListener(WidziszOgnien);
        somsiadSiePali.onClick.AddListener(WidziszSygnalAlarmowyDrugiejWiezy);
    }

    private void WidziszOgnien()
    {
        if (PaliSie != null)
        {
            PaliSie.Invoke();
        }
    }

    private void WidziszSygnalAlarmowyDrugiejWiezy()
    {
        Debug.Log("Nie");
        if(PaliSie != null)
        {
            PaliSie.Invoke();
        }
    }
}
