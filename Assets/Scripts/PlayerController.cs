using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Speicher für die Punkte
	public Transform[] wayPoint;

	public int currentWayPoint = 0; 
	Transform targetWayPoint;

	public float speed = 4f;

	bool reachedEnd = false;

	private Animator anim;


	private  bool walks = false;

	public GameObject text;



	private AllTexts allTexts;




	public GameObject interaktionWalk;

	//public GameObject gretelINT;




	//public GameObject haenselTextINT;

	//public GameObject gretelTextINT;


	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();

		targetWayPoint = wayPoint [currentWayPoint];

		allTexts = text.GetComponent<AllTexts> ();


	}

	// Update is called once per frame
	void Update () {



		// Standing State
		if (walks == false) {

		

			Debug.Log (allTexts.currentSpeaker ());



			if (allTexts.currentSpeaker () == 1) {

				interaktionWalk.SetActive (false);

			} else {

				interaktionWalk.SetActive (true);
			}


			if (allTexts.currentSpeaker () == 2) {

				interaktionWalk.SetActive (false);

			} else {

				interaktionWalk.SetActive (true);
			}

			if (allTexts.currentSpeaker () == 3) {

				interaktionWalk.SetActive (false);

			} else {

				interaktionWalk.SetActive (true);
			}

			if (allTexts.currentSpeaker () == 4) {

				interaktionWalk.SetActive (false);

			} else {

				interaktionWalk.SetActive (true);
			}



			anim.SetBool ("isFront", true);
			anim.SetBool ("isSide", false);
			anim.SetBool ("walk", false);


			// Delight stand
			if (wayPoint [currentWayPoint].GetComponent<Waypoint> ().delight == true) {

				anim.SetBool ("isDelight", true);
				anim.SetBool ("isSad", false);
				anim.SetBool ("isSide", false);
				anim.SetBool ("isFront", true);

			} 

			// sad stand
			if (wayPoint [currentWayPoint].GetComponent<Waypoint> ().sad == true) {

				anim.SetBool ("isDelight", false);
				anim.SetBool ("isSad", true);
				anim.SetBool ("isSide", false);
				anim.SetBool ("isFront", true);

			}

			if (wayPoint [currentWayPoint].GetComponent<Waypoint> ().speaks == true) {


		/*		if (allTexts.countSpeaker () == 2) {

					haenselTextINT.SetActive (true);

					anim.SetBool ("speaksFront", true);
					anim.SetBool ("speaksSide", false);

				} else {

					haenselTextINT.SetActive (false);

				}     */

				}




		}



		if ((reachedEnd == false) && isWalking()) {

			targetWayPoint = wayPoint [currentWayPoint];

			walk ();

		}

	}



	public void startWalking () {

		if (currentWayPoint == wayPoint.Length) {

			return;
		} else {
			currentWayPoint++;

			targetWayPoint = wayPoint [currentWayPoint];
		}

	}




	public bool isWalking () {

		if ((transform.position == targetWayPoint.position)) {
			walks = false;

		} else {
			walks = true;
		}

		return walks;
	}



	void walk() {

		interaktionWalk.SetActive (false);

		//haenselTextINT.SetActive (false);



		anim.SetBool ("isSide", true);
		anim.SetBool ("isFront", false);
		anim.SetBool ("walk", true);




		// Delight Walk
		if (wayPoint [currentWayPoint].GetComponent<Waypoint> ().delight == true) {

			anim.SetBool ("isDelight", true);
			anim.SetBool ("isSad", false);
			anim.SetBool ("isSide", true);
			anim.SetBool ("isFront", false);

		}

		// Sad Walk
		if (wayPoint [currentWayPoint].GetComponent<Waypoint> ().sad == true) {

			anim.SetBool ("isDelight", false);
			anim.SetBool ("isSad", true);
			anim.SetBool ("isSide", true);
			anim.SetBool ("isFront", false);

		}

		if (wayPoint [currentWayPoint].GetComponent<Waypoint> ().speaks == true) {


			anim.SetBool ("speaksSide", true);
			anim.SetBool ("speaksFront", false);

		}



		// Bewegen zum Ziel
		transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed*Time.deltaTime);

		if((transform.position == targetWayPoint.position) && reachedEnd == false) {
			if (!(currentWayPoint == wayPoint.Length)) {


			} else {

				reachedEnd = true;
			}
		} else { walks = false; }






		if((transform.position == targetWayPoint.position) && reachedEnd == true) {

			if (!(currentWayPoint == 0)) {

				walks = true;

				//currentWayPoint -- ;
				targetWayPoint = wayPoint[currentWayPoint];

			} else {

				reachedEnd = false;
			}
		} { walks = false; }
	} 
}
