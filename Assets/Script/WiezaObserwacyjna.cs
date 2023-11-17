using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Dres dres;
    public Ogien ogien;
    public Ptak ptak;
    void Start()
    {
        dres.Obraza -= WidzeDresa;
        dres.Obraza += WidzeDresa;
        ogien.PaliSie -= WidzePlomienie;
        ogien.PaliSie += WidzePlomienie;
        ptak.WidziszPtaka -= WidzePtaka;
        ptak.WidziszPtaka += WidzePtaka;
    }


    private void WidzeDresa()
    {
        Debug.Log("Ide się przywitać");
    }
    private void WidzePlomienie()
    {
        Debug.Log("Zapalam swiatla alarmowe");
    }
    private void WidzePtaka()
    {
        Debug.Log("Przyglądam sie przez lornetkę");
    }

    private void OnDestroy()
    {
        dres.Obraza -= WidzeDresa;
        ogien.PaliSie -= WidzePlomienie;
        ptak.WidziszPtaka -= WidzePtaka;
    }
}
