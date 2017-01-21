using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour {
    private int zaehler = 1;

public int getZaehler()
    {
        return zaehler;
    }

    public void setZaehler(int newZaehler)
    {
        zaehler = newZaehler;
    }
}
