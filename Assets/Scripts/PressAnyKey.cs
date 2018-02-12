using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyKey : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        //Input.GetKeyDown(KeyCode.R)
        if (Input.anyKey)
        {
            Application.LoadLevel(0);
        }
    }
}
