using UnityEngine;
using System.Collections;

public class PlayerActivate : MonoBehaviour {
    GameObject player;
    bool near = false;
    bool played = false;
    bool activate = false;
    public static int TowerCount = 0;
    public OpenSesame DoorActivate;
    public OpenSesame ZeEnd;
    Animator anim;
   
	// Use this for initialization
	void Start () {
        // Recuperer objet Player
        player = GameObject.Find("Player");
        // Recuperer la porte dérobée
        GameObject door = GameObject.Find("SecretWall");
        DoorActivate = door.GetComponent<OpenSesame>();
        // Récuperer les paramètres d'animation de la tour
        anim = GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && near == true && activate == false)
        {
            // Augmenter le nombre de tour activées
            TowerCount++;
            // Déclencher l'animation
            anim.SetBool("anim", true);
            // Empecher la réactivation de cette tour
            activate = true;
            if(this.GetComponent<AudioSource>().isPlaying == false && played == false)
            {
                this.GetComponent<AudioSource>().Play();
                played = true;
            }
        }

        if (TowerCount == 4)
        {
            DoorActivate.Activate = true;
        }

        if (TowerCount > 4 || Input.GetButtonDown("Fire3")) {
            DoorActivate.ZeEnd = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            Debug.Log("Near");
            near = true;
        }
    }
}
