using UnityEngine;
using System.Collections;

public class sendText : MonoBehaviour {

	private void OnMouseDown() {

		GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().countSpeaker ();


		GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().count ();

	}
}
