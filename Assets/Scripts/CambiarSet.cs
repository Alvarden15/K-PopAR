using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarSet : MonoBehaviour
{
    GameObject[] objects;
    Image[] imagen=new Image[7];
    public Sprite[] set;


    // Start is called before the first frame update
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("buttons");

        for (int i=0; i<objects.Length;i++)
        {
            imagen[i] = objects[i].GetComponent<Image>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarImagenes()
    {
        for (int i = 0; i < imagen.Length; i++)
        {
            imagen[i].sprite = set[i];
        }
       

    }
}
