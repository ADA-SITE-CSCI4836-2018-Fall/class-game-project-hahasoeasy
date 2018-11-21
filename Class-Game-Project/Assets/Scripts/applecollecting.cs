using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applecollecting : MonoBehaviour {
    public int score=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        score = score + 1;
    }
}
