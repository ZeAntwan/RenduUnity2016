using UnityEngine;
using System.Collections;

public class DoorActivate : MonoBehaviour {
    public GameObject door;
	// Use this for initialization
	void Start () {
        door = GameObject.Find("SecretWall");
	}
	
	// Update is called once per frame
	void Update () {
        	
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("True");
            //Emmettre un effet sonore
            door.GetComponent<AudioSource>().Play();
            //Supprimer la porte
            door.GetComponent<MeshRenderer>().enabled = false;
            door.GetComponent<BoxCollider>().enabled = false;
            //Lancer la musique
        }
    }
}
