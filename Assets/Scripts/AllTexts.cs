using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class AllTexts : MonoBehaviour {



	private Text text;

	public string [] messages;

	[Header("Speakers. Gretel = 1, Haensel = 2")]
	[Header("mom  = 3, dad = 4, duck = 5")]

	public float [] speaker;

	private int counter = -1;

	private int speakerCounter = 0;
    private int spek;

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


    public GameObject haenselPlayer; // 2

    public GameObject gretelPlayer; // 1

    public GameObject momPlayer; // 3

    public GameObject dadPlayer; // 4

    public GameObject duckPlayer; // 5

    //public GameObject [] speakingCheckpoints;




    // Use this for initialization
    void Start () {

		text = GetComponent<Text> ();
        spek = 0;       

    }

	public float currentSpeaker () {
        
		return speaker [spek];      
	}

	public void countSpeaker (int spe) {
        if (spe >= messages.Length) {
            counter++;

        }else { 
        spek = spe;
        //speakerCounter++;
        counter++;
       /*     Debug.Log("---------------");
            Debug.Log("AllTextsSpe:"+spek);
        Debug.Log("Counter:" + counter);
        Debug.Log("Speaker:" + speaker[spek]);
            Debug.Log("----------------");*/
        }
    }

	// Update is called once per frame
	void Update () {
		

        if (counter == -1) { }else { text.text = messages [counter]; }

        if (currentSpeaker() == 1)
        {


            gretelSpeaker.SetActive(true);
            haenselSpeaker.SetActive(false);
            momSpeaker.SetActive(false);
            dadSpeaker.SetActive(false);
            duckSpeaker.SetActive(false);


        }

        // Aktiviere haensel, wenn spricht
        if (currentSpeaker() == 2)
        {


            haenselSpeaker.SetActive(true);
            gretelSpeaker.SetActive(false);
            momSpeaker.SetActive(false);
            dadSpeaker.SetActive(false);
            duckSpeaker.SetActive(false);


        }

        // Aktiviere mom, wenn spricht
        if (currentSpeaker() == 3)
        {


            haenselSpeaker.SetActive(false);
            gretelSpeaker.SetActive(false);
            momSpeaker.SetActive(true);
            dadSpeaker.SetActive(false);
            duckSpeaker.SetActive(false);


        }

        // Aktiviere Dad, wenn spricht
        if (currentSpeaker() == 4)
        {


            haenselSpeaker.SetActive(false);
            gretelSpeaker.SetActive(false);
            momSpeaker.SetActive(false);
            dadSpeaker.SetActive(true);
            duckSpeaker.SetActive(false);



        }

        // Aktiviere Ente, wenn spricht
        if (currentSpeaker() == 5)
        {


            haenselSpeaker.SetActive(false);
            gretelSpeaker.SetActive(false);
            momSpeaker.SetActive(false);
            dadSpeaker.SetActive(false);
            duckSpeaker.SetActive(true);

        }

        if (counter >= messages.Length-1)
        {


            haenselSpeaker.SetActive(false);

            gretelSpeaker.SetActive(false);

            momSpeaker.SetActive(false);

            dadSpeaker.SetActive(false);

            duckSpeaker.SetActive(false);



            if (haenselPlayer.GetComponent<PlayerController>().getReachedEnd())
            {
                haenselWalk.SetActive(false);
            }else { 
                haenselWalk.SetActive(true);    //Die waren vorher so
            }

            if (gretelPlayer.GetComponent<PlayerController>().getReachedEnd())
            {
                gretelWalk.SetActive(false);
            }
            else
            {
                gretelWalk.SetActive(true);     //Die waren vorher so
            }

            if (momPlayer.GetComponent<PlayerController>().getReachedEnd())
            {
                momWalk.SetActive(false);
            }
            else
            {
                momWalk.SetActive(true);     //Die waren vorher so
            }

            if (dadPlayer.GetComponent<PlayerController>().getReachedEnd())
            {
                dadWalk.SetActive(false);
            }
            else
            {
                dadWalk.SetActive(true);     //Die waren vorher so
            }

            if (duckPlayer.GetComponent<PlayerController>().getReachedEnd())
            {
                duckWalk.SetActive(false);
            }
            else
            {
                duckWalk.SetActive(true);     //Die waren vorher so
            }

        }
    }

	/*public void count () {
        counter++;

        if(counter >= messages.Length-1)
        {
             haenselSpeaker.SetActive(false); 

             gretelSpeaker.SetActive(false); 

             momSpeaker.SetActive(false);

            dadSpeaker.SetActive(false);

            duckSpeaker.SetActive(false);

            haenselWalk.SetActive(true);
            gretelWalk.SetActive(true);

            momWalk.SetActive(true);

            dadWalk.SetActive(true);

            duckWalk.SetActive(true);
        }
    }*/

	public int getCounter () {

		return counter;
	}
}
