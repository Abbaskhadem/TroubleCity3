using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour {
    public int id = 1;
    public static float WorkTime;
    public GameObject TheCar;

	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "Dozd")
        {
            Debug.Log("Collision2");
            GameManager.PoliceAvailable = false;
            GameManager.PoliceStartTimer = true;
            TheCar.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
