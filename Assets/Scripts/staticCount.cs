using UnityEngine;
using System.Collections;

public class staticCount : MonoBehaviour {
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
