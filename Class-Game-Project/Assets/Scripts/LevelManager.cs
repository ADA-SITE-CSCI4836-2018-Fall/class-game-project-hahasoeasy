using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour {
    public int apples;
    public Text APPLETEXT;
    public PlayerController gameplayer;
    // Use this for initialization
    void Start () {
        gameplayer = FindObjectOfType<PlayerController>();
        APPLETEXT.text = ""+apples;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddApples(int numberofApples){
        apples += numberofApples;
        APPLETEXT.text = ""+apples;


    }

    public void SubApples(int numberofApples){
            apples-=numberofApples;
            APPLETEXT.text=""+apples;

    }


}
