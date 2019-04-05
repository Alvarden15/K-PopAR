using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    


    // Update is called once per frame
    public void exitGame () {
        Debug.Log("Juego terminado");
        Application.Quit();
	}
}
