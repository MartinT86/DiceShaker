using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DieContainer : MonoBehaviour
{
    public GameObject dieOne;
    public GameObject dieTwo;
    public GameObject dieThree;
    public GameObject dieFour;
    public GameObject dieFive;

    public Text debugText;

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
	    //debugText.text = dieCount.ToString();
	}

    public void AddDie()
    {
        var inactiveDice = dice.FirstOrDefault(x => x.activeInHierarchy == false);

        if (inactiveDice != null)
        {
            var newPosition = new Vector3(0,9.0f,0);
            inactiveDice.transform.position = newPosition;
            inactiveDice.SetActive(true);
        }
    }

    public void RemoveDie()
    {
        var activeDice = dice.FirstOrDefault(x => x.activeInHierarchy);

        if (activeDice != null)
        {
            activeDice.SetActive(false);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
