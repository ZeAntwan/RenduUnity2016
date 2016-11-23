using UnityEngine;
using System.Collections;

public class OpenSesame : MonoBehaviour {

    public bool Activate = false;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Activate);
	    if (Activate == true)
        {
            //Emmettre un effet sonore
            this.GetComponent<AudioSource>().Play();
            //Supprimer la porte
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            //Lancer la musique
        }
    }
}
