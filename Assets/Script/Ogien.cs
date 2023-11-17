using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ogien : MonoBehaviour
{
    public event Action PaliSie;
    void Start()
    {
        Button btn = GetComponentInChildren<Button>();
        btn.onClick.AddListener(WidziszOgnien);
    }

    private void WidziszOgnien()
    {
        if (PaliSie != null)
        {
            PaliSie.Invoke();
        }
    }

}
