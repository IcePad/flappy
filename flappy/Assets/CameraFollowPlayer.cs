using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

    private GameObject player_go;
    // Use this for initialization
    private Transform player;
    void Start () {
        GameObject player_go = GameObject.Find("Player");

        player = player_go.transform;

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x = player.position.x;
        transform.position = pos;
	}
}
