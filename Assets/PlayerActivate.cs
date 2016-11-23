using UnityEngine;
using System.Collections;

public class PlayerActivate : MonoBehaviour {
    GameObject player;
    bool near = false;
    bool activate = false;
    public static int TowerCount = 0;
    public OpenSesame DoorActivate;
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
        }

        if (TowerCount == 1)
        {
            DoorActivate.Activate = true;
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
