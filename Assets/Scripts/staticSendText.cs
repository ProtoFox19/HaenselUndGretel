using UnityEngine;
using System.Collections;

public class staticSendText : MonoBehaviour {

	public GameObject character;
	public GameObject zaehler;
	int spe;
	private void OnMouseDown() {

		//Debug.Log(character.name);

		if (character.name.Equals("TextInteraktionGretel"))
		{
			spe = zaehler.GetComponent<staticCount>().getZaehler();
			zaehler.GetComponent<staticCount>().setZaehler(spe + 1);
			//spe++; Debug.Log("G:" + spe);
		}
		if (character.name.Equals("TextInteraktionHaensel"))
		{
			spe = zaehler.GetComponent<staticCount>().getZaehler();
			zaehler.GetComponent<staticCount>().setZaehler(spe + 1);
			// spe++;Debug.Log("H:" + spe);
		}

		Debug.Log("spe:"+spe);

		GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTextsStatic> ().countSpeaker (spe);


		//GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().count ();

	}
}

