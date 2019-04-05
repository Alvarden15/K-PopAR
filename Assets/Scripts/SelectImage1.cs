using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;
using System.Threading;
using UnityEngine.UI;

public class SelectImage1 : MonoBehaviour {
    public VideoPlayer vPlayer;
    public VideoClip[] Clips;
    new string name;
    GameObject video;
    public AudioSource audioSource;
    Animation anim;
    Animation[] icons= new Animation[7];
    GameObject[] images;
    GameObject textoV;
    GameObject popup;
    Text te;
    
    // Use this for initialization
    void Start () {
        
        video = GameObject.FindGameObjectWithTag("video");
        images = GameObject.FindGameObjectsWithTag("images");
        video.SetActive(false);
        vPlayer = GetComponent<VideoPlayer>();
        vPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        anim = video.GetComponent<Animation>();
        for(int i=0; i < images.Length; i++)
        {
            icons[i] = images[i].GetComponent<Animation>();
        }
        popup = GameObject.Find("PopUp");
        textoV = GameObject.Find("Viendo");
        te = textoV.GetComponent<Text>();
        textoV.SetActive(false);
        popup.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)

        /*if (Input.GetMouseButtonDown(0))*/
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                name = hit.transform.name;
                
                switch (name)
                {
                    
                    case "BTS1":
                       
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[0];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: "+ vPlayer.clip.name;
                        anim.Play("CloseVideo");
                       
                        vPlayer.Play();
                        Debug.Log("Video: "+ vPlayer.clip.name);
                        ; break;

                    case "BTS2":
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[1];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: " + vPlayer.clip.name;
                        anim.Play("CloseVideo");
                        
                        vPlayer.Play();
                        Debug.Log("Video: " + vPlayer.clip.name);
                        ; break;

                    case "BTS3":
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[2];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: " + vPlayer.clip.name;
                        anim.Play("CloseVideo");
                        vPlayer.Play();
                        Debug.Log("Video: " + vPlayer.clip.name);
                        ; break;

                    case "BTS4":
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[3];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: " + vPlayer.clip.name;
                        anim.Play("CloseVideo");
                        vPlayer.Play();
                        Debug.Log("Video: " + vPlayer.clip.name);
                        ; break;

                    case "BTS5":
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[4];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: " + vPlayer.clip.name;
                        anim.Play("CloseVideo");
                       
                        vPlayer.Play();
                        Debug.Log("Video: " + vPlayer.clip.name);
                        ; break;

                    case "BTS6":
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[5];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: " + vPlayer.clip.name;
                        anim.Play("CloseVideo");
                        vPlayer.Play();
                        Debug.Log("Video: " + vPlayer.clip.name);
                        ; break;

                    case "BTS7":
                        vPlayer.SetTargetAudioSource(0, audioSource);
                        vPlayer.source = VideoSource.VideoClip;
                        vPlayer.clip = Clips[6];
                        foreach (Animation a in icons)
                        {
                            a.Play("dissapearIcon");
                        }
                        video.SetActive(true);
                        textoV.SetActive(true);
                        te.text = "Ahora estas viendo: " + vPlayer.clip.name;
                        anim.Play("CloseVideo");
                        vPlayer.Play();
                        Debug.Log("Video: " + vPlayer.clip.name);
                        ; break;


                    default:
                        anim.Play("OpenVideo");
                        vPlayer.Stop();
                        foreach (Animation a in icons)
                        {
                            a.Play("appearIcon");
                        }
                        textoV.SetActive(false);
                        audioSource.Stop();
                        
                        ; break;
                }
            }


        }

	}
}
