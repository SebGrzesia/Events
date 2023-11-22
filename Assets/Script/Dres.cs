using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dres : MonoBehaviour
{
    public Button DresButton;
    public Button WuglarnyButton;
    public event Action Obraza;
    void Start()
    {
        DresButton.onClick.AddListener(KrzyczGnoju);
        WuglarnyButton.onClick.AddListener(JestGnusny);
    }

    private void KrzyczGnoju()
    {
        Debug.Log("GRAAAAGHWRRRRRRRRR");
        if (Obraza != null)
        {
            Obraza.Invoke();
        }
    }
    
    private void JestGnusny()
    {
        Debug.Log("Pokazuje srodkowy palec");
        if (Obraza!= null)
        {
            Obraza.Invoke();
        }
    }
}
