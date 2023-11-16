using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Ptak : MonoBehaviour
{

    public event Action WidziszPtaka;

    void Start()
    {
        Button btn = GetComponentInChildren<Button>();
        btn.onClick.AddListener(LeciJaskolka);
    }

    private void LeciJaskolka()
    {
        Debug.Log("przygladam sie przez lornetke");
        if (WidziszPtaka != null)
        {
            WidziszPtaka.Invoke();
        }
    }
}
