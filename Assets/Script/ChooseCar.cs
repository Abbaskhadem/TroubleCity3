using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCar : MonoBehaviour {
    public GameObject Navigator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ThePolice()
    {
        Navigation4Tilemap.x = 1;
    }
    public void Ambulance()
    {
        Navigation4Tilemap.x = 2;
    }
}
