using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}



    void OnMouseDown()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
