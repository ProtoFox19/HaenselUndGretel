using UnityEngine;
using System.Collections;

public class TextInteraktion : MonoBehaviour {

	public bool gretel = false; // 1

	public bool haensel = false; // 2

	public bool mom = false; // 3

	public bool dad = false; // 4



	public GameObject haenseltest;

	public GameObject greteltest;




	private void OnMouseDown() {

		GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().countSpeaker ();


		GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().count ();


	}




	/*void Update () {


		if (gretel == true) {

			// Aktiviere Gretel, wenn spricht
			if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 1) {

				gameObject.SetActive (true);


				Debug.Log (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().currentSpeaker ());



			} else { gameObject.SetActive (false); }


		}


		if (haensel == true) {

			// Aktiviere haensel, wenn spricht
			if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 2) {

				gameObject.SetActive (true);

				Debug.Log (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().currentSpeaker ());



			} else { gameObject.SetActive (false); }


		}

	}*/



	void Update () {

			// Aktiviere haensel, wenn spricht
			if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 1) {

				//gameObject.SetActive (true);

				greteltest.SetActive (true);
				haenseltest.SetActive (false);

			}

			// Aktiviere haensel, wenn spricht
			if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 2) {

				//gameObject.SetActive (true);

				haenseltest.SetActive (true);
				greteltest.SetActive (false);

			}

		}


}
