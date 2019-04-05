using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class changeButtonAnimator : MonoBehaviour
{
    Vector3 originalPosition;
    Vector3 destino;
    GameObject[] buttons;
    Animation[] anims;
    float count;
    float distancia;
    private float startTime;

    Animator animator;
    Animation ani;
    RectTransform rect;
    Vector2 original;
    Vector2 center;
    public VideoPlayer vi;
    Button[] buts=new Button[7];
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
        vi = GetComponent<VideoPlayer>();
        for (int i = 0; i < buttons.Length; i++)
        {
            buts[i] = buttons[i].GetComponent<Button>();
            anims[i] = buttons[i].GetComponent<Animation>();
            
        }
        imagen = botonPrin.GetComponent<Image>();

        original = rect.anchoredPosition;
        
        center = RectTransformUtility.WorldToScreenPoint(null, destino);
        destino = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        count = 2;
        DontDestroyOnLoad(botonPrin);
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    public void cambiar()
    {
        startTime = Time.time;
        /* 
        if (Screen.orientation == ScreenOrientation.Landscape)
        {

        }else if (Screen.orientation == ScreenOrientation.Portrait)
        {

        }
         */


        if (count == 1)
        {
            
            //transform.localPosition = Vector3.Lerp(originalPosition, new Vector3(Screen.width / 2, Screen.height / 2, 0), Time.deltaTime * 0.5f);
           transform.position = Vector3.Lerp(originalPosition, new Vector3(Screen.width / 2, Screen.height / 2, 0), Time.deltaTime * 0.5f);
           //rect.position = Vector2.Lerp(original, new Vector2(Screen.width / 2, Screen.height / 2), Time.deltaTime * 0.5f);
            foreach (Button an in buts)
            {
                
                if (an.gameObject != gameObject)
                {
                    an.interactable = true;
                    switch (gameObject.name)
                    {
                        case "Button1":
                            animator.Play("SequenceOpen1");
                                                       
                            break;
                        case "Button2":
                            animator.Play("SequenceOpen2");
                            
                            break;
                        case "Button3":
                            animator.Play("SequenceOpen3");
                            
                            break;
                        case "Button4":
                            animator.Play("SequenceOpen4");
                            
                            break;

                        case "Button5":
                            animator.Play("SequenceOpen5");
                            
                            break;
                        case "Button6":
                            animator.Play("SequenceOpen6");
                           
                            break;
                        case "Button7":
                            animator.Play("SequenceOpen7");
                            
                            break;
                    }

                }

            }
            destino = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            count++;
        }
        else
        {
            //transform.localPosition = Vector3.Lerp(new Vector3(Screen.width / 2, Screen.height / 2, 0), originalPosition, Time.deltaTime * 0.5f);
            transform.position = Vector3.Lerp(new Vector3(Screen.width / 2, Screen.height / 2, 0), originalPosition,Time.deltaTime*0.5f);
           //rect.position = Vector2.Lerp(new Vector2(Screen.width / 2, Screen.height / 2), rect.anchoredPosition, Time.deltaTime * 0.5f);
            foreach (Button an in buts)
            {
                if (an.gameObject != gameObject)
                {
                    an.interactable = false;
                    switch (gameObject.name)
                    {
                        case "Button1":
                            animator.Play("SequenceClose1");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                            


                            break;
                        case "Button2":
                            animator.Play("SequenceClose2");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                           

                            break;
                        case "Button3":
                            animator.Play("SequenceClose3");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                           

                            break;
                        case "Button4":
                            animator.Play("SequenceClose4");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                            
                            break;

                        case "Button5":
                            animator.Play("SequenceClose5");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                            
                            break;

                        case "Button6":
                            animator.Play("SequenceClose6");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                            
                            break;

                        case "Button7":
                            animator.Play("SequenceClose7");
                            imagen.sprite = gameObject.GetComponent<Image>().sprite;
                            
                            break;
                    }
                }
            }
            destino = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            count = 1;
        }

    }

    public void appearButton()
    {
        foreach (Button an in buts)
        {
            if (an.gameObject != gameObject)
            {
                
                an.interactable = false;
                switch (gameObject.name)
                {
                    case "Button1":
                        animator.Play("SequenceClose1");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B1";
                        break;
                    case "Button2":
                        animator.Play("SequenceClose2");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B2";
                        break;
                    case "Button3":
                        animator.Play("SequenceClose3");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B3";
                        break;
                    case "Button4":
                        animator.Play("SequenceClose4");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B4";
                        break;

                    case "Button5":
                        animator.Play("SequenceClose5");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B5";
                        break;
                    case "Button6":
                        animator.Play("SequenceClose6");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B6";
                        break;
                    case "Button7":
                        animator.Play("SequenceClose7");
                        imagen.sprite = gameObject.GetComponent<Image>().sprite;
                        botonPrin.name = "B7";
                        break;
                }
            }
        }
    }

}
