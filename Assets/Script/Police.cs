﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour {
    public int id = 1;
    public static float WorkTime;
    public float StartWork;
    public GameObject TheCar;
    public GameObject FixBuilding;
    public GameObject DestroyedCity;
	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "Dozd")
        {
            Debug.Log("in-Operation");
            GameManager.PoliceAvailable = false;
            GameManager.PoliceStartTimer = true;
         //   TheCar.SetActive(false);
            FixBuilding.GetComponent<Thief>().Fixer = true;
        }
    }
    // Update is called once per frame
    void Update () {
		if(FixBuilding.GetComponent<Thief>().Fixer==true)
        {
            StartWork = Time.deltaTime + StartWork;
            if (StartWork >= 10f)
            {
                DestroyedCity.SetActive(false);
                StartWork = 0;
            }
        }
	}
}
