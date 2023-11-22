using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Ptak : MonoBehaviour
{
    public Button buttonPtaka;
    public event Action WidziszPtaka;
    private int updateCount = 0;

    void Start()
    {
        buttonPtaka.onClick.AddListener(LeciJaskolka);
    }

    void Update()
    {
        updateCount++;
        if(updateCount % 10000 == 0)
        {
            WidziszPtaka.Invoke();
        }
    }

    private void LeciJaskolka()
    {
        if (WidziszPtaka != null)
        {
            WidziszPtaka.Invoke();
        }
    }

    private void LeciKruk()
    {
        if (WidziszPtaka != null)
        {
            WidziszPtaka.Invoke();
        }
    }
}
