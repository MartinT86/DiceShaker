using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieContainer : MonoBehaviour
{
    public GameObject dieOne;
    public GameObject dieTwo;
    public GameObject dieThree;
    public GameObject dieFour;
    public GameObject dieFive;

    private GameObject[] dice;
    private int dieCount;

	// Use this for initialization
	void Start ()
	{
	    dieCount = 1;
		dice = new GameObject[]
		{
		    dieOne,
            dieTwo,
            dieThree,
            dieFour,
            dieFive
		};
	}

    public void AddDie()
    {
        if (dieCount > 0 && dieCount < 6)
        {
            dice[dieCount - 1].SetActive(true);
            dieCount = dieCount + 1;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
