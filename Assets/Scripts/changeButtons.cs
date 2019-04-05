using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.Burst;
using UnityEngine.UI;

public class changeButtons : MonoBehaviour
{

    Vector3 originalPosition;
    Vector3 destino;
    GameObject[] buttons;
    Animation[] anims;
    float count;
    float distancia;
    private float startTime;
    float speed=1.0f;

    // Start is called before the first frame update
    void Start()
    {
        

        anims = new Animation[7];
      
        originalPosition = new Vector3(gameObject.transform.position.x,
            gameObject.transform.position.y,gameObject.transform.position.z);

        buttons = GameObject.FindGameObjectsWithTag("buttons");
        destino = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        
        for (int i=0;i<buttons.Length;i++)
        {
            
            anims[i] = buttons[i].GetComponent<Animation>();
           
        }

        
        count = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cambiar()
    {
        startTime = Time.time;
        distancia = Vector3.Distance(originalPosition, destino);
        float dis=(Time.time-startTime)*speed;
        float viaje=dis/distancia;
        if (count==1)
        {
            transform.position = Vector3.Lerp(originalPosition, destino, viaje);


            foreach (Animation an in anims)
            {
                
                if (an.gameObject!=gameObject)
                {
                    an.Play("appearButton");
                    
                }
                
               
            }
            count++;
        } 
        else
        {
            
            transform.position = Vector3.Lerp(destino, originalPosition, viaje);

            
            foreach (Animation an in anims)
            {
                
                if (an.gameObject != gameObject)
                {
                    an.Play("disappearButton");
                }

            }
            
            count = 1;
        }
        
    }
}
