using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static bool Started=true;
    public GameObject building;
    public static bool PoliceStartTimer=false;
    public GameObject car;
    public static bool PoliceAvailable = true;
    public static bool firefighter = true;
    public static bool tecnic = true;
    public static bool ambulance = true;
    public float time;
    public static int Score;
    
    // Use this for initialization
    void Start () {

        
        Score = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(PoliceStartTimer==true)
        {
            Police.WorkTime = Time.deltaTime + Police.WorkTime;
            time = Time.deltaTime + Police.WorkTime;
            if (Police.WorkTime >= 15)
            {
                car.transform.position = new Vector2(-7.08f, -3.55f);
                car.SetActive(true);
                PoliceStartTimer = false;
                PoliceAvailable = true;

            }
        }
        
	}

}
