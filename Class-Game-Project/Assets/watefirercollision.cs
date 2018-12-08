using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class watefirercollision : MonoBehaviour {

	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="malikmamed"){
         	    SceneManager.LoadScene("Level1");
        }
    }
}
