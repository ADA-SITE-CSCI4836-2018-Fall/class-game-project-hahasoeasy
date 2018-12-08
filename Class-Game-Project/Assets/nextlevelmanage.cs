using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevelmanage : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="malikmamed"){
        		string mSceneName = SceneManager.GetActiveScene().name;
        		if (mSceneName == "Level1") {
         	    SceneManager.LoadScene("Level2");
         		} else if (mSceneName == "Level2"){
         			SceneManager.LoadScene("BossFight");
         		}
        }
    }
}
