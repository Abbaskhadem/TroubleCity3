#region TheCode
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {
    #region Variables
    //Arrays
    public GameObject[] FixedCity;
    public GameObject[] FireCity;
   // public GameObject[] DisasterCity;
  //  public GameObject[] RoadCity;
    //indexes
    private int x;
    private int y;
    //Times
    public float timegeter;
    public float CityTime;
    public float Rtime ;
    #endregion
    #region RandomDisasterStarter
    //Code Starts
    void start()
    {
        Rtime = Random.Range(5f, 15f);
    }
    void Update()
    {

        if (GameManager.Started==true)
        {
            timegeter = Time.deltaTime + timegeter;
            CityTime = Time.deltaTime + CityTime;
            if (timegeter >= Rtime)
            {
                
                RandomTime();
                timegeter = 0;
            }   
            if (CityTime >= Rtime)
            {
                CityTime = 0;
                    randomfire();
                //else if (y == 2)
                //    randomroad();
                //else if (y == 3)
                //    randomdisaster();
            }
        }
      

    }

    #endregion
    #region Functions
    //Functions
    public void randomfire()
    {
        x = Random.Range(0, 2);
        FireCity[x].SetActive(true);
    }
    public void RandomTime()
    {
        y = 1;
        Rtime = Random.Range(5f, 15f);
    }
    //public void randomroad()
    //{
    //    x = Random.Range(0, 10);
    //    FixedCity[x].SetActive(false);
    //    RoadCity[x].SetActive(true);
    //}
    //public void randomdisaster()
    //{
    //    x = Random.Range(0, 10);
    //    FixedCity[x].SetActive(false);
    //    DisasterCity[x].SetActive(true);
    //}
    #endregion
}
#endregion
