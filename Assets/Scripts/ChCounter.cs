using UnityEngine;
using System.Collections;

public class ChCounter : MonoBehaviour {
    private int zaehler = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnMouseDown()
    {

        zaehler++;

    }

    public int getZaehler()
    {
        return zaehler;
    }
}
