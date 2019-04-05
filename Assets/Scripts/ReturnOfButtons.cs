using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnOfButtons : MonoBehaviour
{
    Vector3 originalPosition;
    Vector3 destino;
    GameObject[] buttons;
    Animation[] anims;

    float distancia;
    private float startTime;

    Animator animator;
    Animation ani;
    RectTransform rect;
    Vector2 original;
    Vector2 center;
   
    Button[] buts = new Button[7];
    Image imagen;
    GameObject botonPrin;
    // Start is called before the first frame update
    void Start()
    {
        
        botonPrin = GameObject.Find("Boton");
        animator = gameObject.GetComponentInParent<Animator>();

        anims = new Animation[7];
        rect = GetComponent<RectTransform>();
        //originalPosition = new Vector3(gameObject.transform.position.x,
        //gameObject.transform.position.y, gameObject.transform.position.z);
        originalPosition = transform.position;
        buttons = GameObject.FindGameObjectsWithTag("buttons");

        ani = GetComponent<Animation>();
      
        for (int i = 0; i < buttons.Length; i++)
        {
            buts[i] = buttons[i].GetComponent<Button>();
            anims[i] = buttons[i].GetComponent<Animation>();

        }
        imagen = botonPrin.GetComponent<Image>();

        original = rect.anchoredPosition;

        center = RectTransformUtility.WorldToScreenPoint(null, destino);
        destino = new Vector3(Screen.width / 2, Screen.height / 2, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void returnButtons()
    {
       
        foreach (Button an in buts)
        {

            
                gameObject.SetActive(false);
                an.interactable = true;

                  
           
              switch (gameObject.name)
                {
                    case "B1":
                        animator.Play("SequenceOpen1");

                        break;
                    case "B2":
                        animator.Play("SequenceOpen2");

                        break;
                    case "B3":
                        animator.Play("SequenceOpen3");

                        break;
                    case "B4":
                        animator.Play("SequenceOpen4");

                        break;

                    case "B5":
                        animator.Play("SequenceOpen5");

                        break;
                    case "B6":
                        animator.Play("SequenceOpen6");

                        break;
                    case "B7":
                        animator.Play("SequenceOpen7");

                        break;
                }
             
             


        }
    }
}
