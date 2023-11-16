using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dres : MonoBehaviour
{
    public event Action Obraza;
    void Start()
    {
        Button btn = GetComponentInChildren<Button>();
        btn.onClick.AddListener(KrzyczGnoju);
    }

    private void KrzyczGnoju()
    {
        Debug.Log("GRAAAAGHWRRRRRRRRR Gnoju Ide mu wpierdolic");
        if (Obraza != null)
        {
            Obraza.Invoke();
        }
    }
}
