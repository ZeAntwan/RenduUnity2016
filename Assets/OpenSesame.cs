using UnityEngine;
using System.Collections;

public class OpenSesame : MonoBehaviour {

    public bool Activate = false;
    bool played = false;
    GameObject sun;
    Animator sunanim;
    // Use this for initialization
    void Start () {
        sun = GameObject.Find("SunLight");
        sunanim = sun.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Activate);
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
    }
}
