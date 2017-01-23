using UnityEngine;
using System.Collections;

public class OpenSesame : MonoBehaviour {

    public bool Activate = false;
    public bool ZeEnd = false;
    bool played = false;
    GameObject sun;
    GameObject player;
    GameObject canvas;
    Animator sunanim;
    // Use this for initialization
    void Start () {
        sun = GameObject.Find("SunLight");
        sunanim = sun.GetComponent<Animator>();
        player = GameObject.Find("Player");
        canvas = GameObject.Find("Canvas");
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Activate);
	    if (Activate == true)
        {
            //Emmettre un effet sonore
            if(this.GetComponent<AudioSource>().isPlaying == false && played == false)
            {
                this.GetComponent<AudioSource>().Play();
                played = true;
            }
            //Animation Soleil
            sunanim.SetBool("Down", true);

            //Supprimer la porte
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            //Lancer la musique
        }
        if (ZeEnd == true) {
            Destroy(player);
        }
    }
}
