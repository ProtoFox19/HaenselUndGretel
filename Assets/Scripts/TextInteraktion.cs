using UnityEngine;
using System.Collections;

public class TextInteraktion : MonoBehaviour {


	public GameObject haenselSpeaker; // 2

	public GameObject gretelSpeaker; // 1

	public GameObject momSpeaker; // 3

	public GameObject dadSpeaker; // 4

	public GameObject duckSpeaker; // 5


	public GameObject haenselWalk; // 2

	public GameObject gretelWalk; // 1

	public GameObject momWalk; // 3

	public GameObject dadWalk; // 4

	public GameObject duckWalk; // 5


	void Start () {



	}

	void Update () {

		/*if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().getCounter() >= GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts> ().messages.Length) {


			haenselWalk.SetActive (true);
			gretelWalk.SetActive (true);
			momWalk.SetActive (true);
			dadWalk.SetActive (true);
			duckWalk.SetActive (true);

		}*/

			// Aktiviere gretel, wenn spricht
			if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 1) {


				gretelSpeaker.SetActive (true);
				haenselSpeaker.SetActive (false);
				momSpeaker.SetActive (false);
				dadSpeaker.SetActive (false);
				duckSpeaker.SetActive (false);

			//gretelWalk.SetActive (false);

		/*	haenselWalk.SetActive (false);
			gretelWalk.SetActive (false);
			momWalk.SetActive (false);
			dadWalk.SetActive (false);
			duckWalk.SetActive (false); */

			}

			// Aktiviere haensel, wenn spricht
			if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 2) {


				haenselSpeaker.SetActive (true);
				gretelSpeaker.SetActive (false);
				momSpeaker.SetActive (false);
				dadSpeaker.SetActive (false);
				duckSpeaker.SetActive (false);

		//	haenselWalk.SetActive (false);


			}

		// Aktiviere mom, wenn spricht
		if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 3) {


			haenselSpeaker.SetActive (false);
			gretelSpeaker.SetActive (false);
			momSpeaker.SetActive (true);
			dadSpeaker.SetActive (false);
			duckSpeaker.SetActive (false);

			//momWalk.SetActive (false);

		}

		// Aktiviere Dad, wenn spricht
		if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 4) {


			haenselSpeaker.SetActive (false);
			gretelSpeaker.SetActive (false);
			momSpeaker.SetActive (false);
			dadSpeaker.SetActive (true);
			duckSpeaker.SetActive (false);

			//dadWalk.SetActive (false);

		}

		// Aktiviere Ente, wenn spricht
		if (GameObject.FindGameObjectWithTag ("AllText").GetComponent<AllTexts>().currentSpeaker() == 5) {


			haenselSpeaker.SetActive (false);
			gretelSpeaker.SetActive (false);
			momSpeaker.SetActive (false);
			dadSpeaker.SetActive (false);
			duckSpeaker.SetActive (true);

		//	duckWalk.SetActive (false);


		}

		}
		
}
