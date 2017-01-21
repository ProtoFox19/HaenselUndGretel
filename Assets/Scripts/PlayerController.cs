using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    // Speicher für die Punkte
    public Transform[] wayPoint;

    public int currentWayPoint = 0;
    Transform targetWayPoint;

    public float speed = 4f;

    bool reachedEnd = false;

    private Animator anim;


    private bool walks = false;

    public GameObject text;



    private AllTexts allTexts;

    public float PlayerNumber;




    public GameObject interaktionWalk;

    public GameObject interactionSpeak;

    //public GameObject gretelINT;




    //public GameObject haenselTextINT;

    //public GameObject gretelTextINT;


    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();

        //targetWayPoint = wayPoint [currentWayPoint];

        allTexts = text.GetComponent<AllTexts>();


    }

    // Update is called once per frame
    void Update()
    {



        // Standing State
        if (walks == false)
        {

            if ((allTexts.currentSpeaker() == PlayerNumber))
            {


                /*if (allTexts.messages.Length <= allTexts.getCounter()) {



					interaktionWalk.SetActive (true);



					//interactionSpeak.SetActive (false);

				} else { interaktionWalk.SetActive (false); 
				
				
				}*/
                if (allTexts.getCounter() >= allTexts.messages.Length - 1)
                {
                    if (reachedEnd)
                    {
                        interaktionWalk.SetActive(false);
                    }else { 
                        interaktionWalk.SetActive(true);
                    }
                }else { 
                    interaktionWalk.SetActive(false);
                }
            }
            else
            {
                if (reachedEnd)
                {
                    interaktionWalk.SetActive(false);
                }else { 
                    interaktionWalk.SetActive(true);
                }
            }

            anim.SetBool("isFront", true);
            anim.SetBool("isSide", false);
            anim.SetBool("walk", false);


            // Delight stand
            if (wayPoint[currentWayPoint].GetComponent<Waypoint>().delight == true)
            {

                anim.SetBool("isDelight", true);
                anim.SetBool("isSad", false);
                anim.SetBool("isSide", false);
                anim.SetBool("isFront", true);

            }

            // sad stand
            if (wayPoint[currentWayPoint].GetComponent<Waypoint>().sad == true)
            {

                anim.SetBool("isDelight", false);
                anim.SetBool("isSad", true);
                anim.SetBool("isSide", false);
                anim.SetBool("isFront", true);

            }


        }

        if ((reachedEnd == false) && isWalking())
        {

            targetWayPoint = wayPoint[currentWayPoint];

            walk();

        }

    }



    public void startWalking()
    {

        if (currentWayPoint == wayPoint.Length)
        {

            return;
        }
        else
        {
            currentWayPoint++;

            targetWayPoint = wayPoint[currentWayPoint];
        }

    }



    public bool isWalking()
    {

        if ((transform.position == targetWayPoint.position))
        {
            walks = false;

        }
        else
        {
            walks = true;
        }

        return walks;
    }



    void walk()
    {

        interaktionWalk.SetActive(false);

        //haenselTextINT.SetActive (false);



        anim.SetBool("isSide", true);
        anim.SetBool("isFront", false);
        anim.SetBool("walk", true);




        // Delight Walk
        if (wayPoint[currentWayPoint].GetComponent<Waypoint>().delight == true)
        {

            anim.SetBool("isDelight", true);
            anim.SetBool("isSad", false);
            anim.SetBool("isSide", true);
            anim.SetBool("isFront", false);

        }

        // Sad Walk
        if (wayPoint[currentWayPoint].GetComponent<Waypoint>().sad == true)
        {

            anim.SetBool("isDelight", false);
            anim.SetBool("isSad", true);
            anim.SetBool("isSide", true);
            anim.SetBool("isFront", false);

        }

        if (wayPoint[currentWayPoint].GetComponent<Waypoint>().speaks == true)
        {


            anim.SetBool("speaksSide", true);
            anim.SetBool("speaksFront", false);

        }



        // Bewegen zum Ziel
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if ((transform.position == targetWayPoint.position) && reachedEnd == false)
        {
            if (!(currentWayPoint == wayPoint.Length - 1))
            {
               
            }
            else
            {

                anim.SetBool("isFront", true);
                anim.SetBool("isSide", false);
                anim.SetBool("walk", false);
                reachedEnd = true;
            }
        }
        else { walks = false; }


    }

    public bool getReachedEnd()
    {
        return reachedEnd;
    }
}


