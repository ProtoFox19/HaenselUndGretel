using UnityEngine;
using System.Collections;

public class Interaktion : MonoBehaviour {

	//public bool gretel = false; // 1

	//public bool haensel = false; // 2

	//public bool mom = false; // 3

	//public bool dad = false; // 4

	//public GameObject haenselINT;

	//public GameObject gretelINT;

	public GameObject Player;

	PlayerController playerController;

	//public GameObject interaktionWalk;


	void Start() {

		playerController = Player.GetComponent<PlayerController> ();
	}

	void Update () {


	}


	private void OnMouseDown() {

		playerController.startWalking ();


		//GameObject.FindGameObjectWithTag ("haensel").GetComponent<PlayerController> ().startWalking();

	}



}
