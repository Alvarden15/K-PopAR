using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeAlt : MonoBehaviour
{
    public Button button;
    bool mov=false;
    float dis=2f;
    float viaje;
    Vector2 inicio;
    Vector2 fin;
    private RectTransform rect;
    Vector3 originalPosition;
    Vector3 destino;
    GameObject[] buttons;
    Animation[] anims;
    float count;
    float distancia=0;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {

        button.onClick.AddListener(Cambiar);
        
        originalPosition = new Vector3(gameObject.transform.position.x,
           gameObject.transform.position.y, gameObject.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (mov)
        {
            startTime += Time.deltaTime;
            if (startTime>dis)
            {
                startTime = dis;
            }
            viaje = dis / distancia;
            if (count == 1)
            {
                transform.position = Vector3.Lerp(originalPosition, destino, viaje);
                foreach (Animation an in anims)
                {

                    if (an.gameObject != gameObject)
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

            if (viaje==1)
            {
                mov = false;
                startTime = 0;
            }
           
        }
    }


    public void Cambiar()
    {
        anims = new Animation[7];
        rect = GetComponent<RectTransform>();

       

        buttons = GameObject.FindGameObjectsWithTag("buttons");
        destino = new Vector3(Screen.width / 2, Screen.height / 2, 0);

        for (int i = 0; i < buttons.Length; i++)
        {

            anims[i] = buttons[i].GetComponent<Animation>();

        }
        count = 2;
        mov = true;
    }
}

