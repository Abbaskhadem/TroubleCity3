using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour {
    public GameObject TheCar;
    public GameObject crashbuilding;
    
   public float time;
    
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if(crashbuilding.active==true)
        {
            time = Time.deltaTime+time;
            if (time >= 15f)
            {
                time = 0;
                GameManager.Score--;
                crashbuilding.SetActive(false);


            }
        }

    }
    void OnColisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag =="Dozd")
        {
  
            GameManager.PoliceAvailable = false;
            GameManager.PoliceStartTimer = true;
            TheCar.SetActive(false);
        }
  
    }
  
}
