using UnityEngine;
using System.Collections;

public class PlayerActivate : MonoBehaviour {
    GameObject player;
    bool near = false;
    bool activate = false;
    public static int TowerCount = 0;
    public OpenSesame DoorActivate;
   
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        GameObject door = GameObject.Find("SecretWall");
        DoorActivate = door.GetComponent<OpenSesame>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && near == true && activate == false)
        {
            Debug.Log("Activate");
            TowerCount++;
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
