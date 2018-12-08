using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applecollecting : MonoBehaviour {
    public int apple;

    private LevelManager gameLevelManager;
    // Use this for initialization

    void Start () {
        gameLevelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="malikmamed"){
            gameLevelManager.AddApples(apple);
            Destroy(gameObject);

        }

       
    }
}
