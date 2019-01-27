using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thief : MonoBehaviour {
    public GameObject TheCar;
    public GameObject crashbuilding;
    
    public bool Fixer;
    public Text Scoretxt;
   public float time;
    
    // Use this for initialization
    void Start() {
        Scoretxt.text = "Hapiness:" + GameManager.Score;
    }

    // Update is called once per frame
    void Update() {

        if(crashbuilding.active==true && Fixer==false)
        {
            time = Time.deltaTime+time;
            if (time >= 6f)
            {
                time = 0;
                GameManager.Score-=20;
                Scoretxt.text = "Hapiness:" + GameManager.Score;
                crashbuilding.SetActive(false);
            }
         
        }
        if (Fixer == true)
        {
            time = 0;
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag =="Police")
        {
  
            GameManager.PoliceAvailable = false;
            GameManager.PoliceStartTimer = true;
         //   TheCar.SetActive(false);
        }
  
    }
  
}
