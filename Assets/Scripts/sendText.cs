using UnityEngine;
using System.Collections;

public class sendText : MonoBehaviour {

    public GameObject character;
    public GameObject zaehler;
    int spe;
    private void OnMouseDown() {

        //Debug.Log(character.name);
        
        if (character.name.Equals("TextInteraktionGretel"))
        {
            spe = zaehler.GetComponent<Count>().getZaehler();
            zaehler.GetComponent<Count>().setZaehler(spe + 1);
            //spe++; Debug.Log("G:" + spe);
        }
        if (character.name.Equals("TextInteraktionHaensel"))
        {
            spe = zaehler.GetComponent<Count>().getZaehler();
            zaehler.GetComponent<Count>().setZaehler(spe + 1);
            // spe++;Debug.Log("H:" + spe);
        }
        if (character.name.Equals("TextInteraktionMom"))
        {
            spe = zaehler.GetComponent<Count>().getZaehler();
            zaehler.GetComponent<Count>().setZaehler(spe + 1);
            //  spe++; Debug.Log("M:" + spe);
        }
        if (character.name.Equals("TextInteraktionDad"))
        {
            spe = zaehler.GetComponent<Count>().getZaehler();
            zaehler.GetComponent<Count>().setZaehler(spe + 1);
            //spe++;Debug.Log("D:" + spe);
        }
        if (character.name.Equals("TextInteraktionDuck"))
        {
            spe = zaehler.GetComponent<Count>().getZaehler();
            zaehler.GetComponent<Count>().setZaehler(spe + 1);
            //spe++;Debug.Log("G:" + spe);
        }
        Debug.Log("spe:"+spe);

        GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().countSpeaker (spe);


		//GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().count ();

	}
}
