using UnityEngine;
using System.Collections;

public class LoopAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered" + collider.name);
        float widthOfBgObject = collider.GetComponent<BoxCollider2D>().size.x;

        Vector3 pos = collider.transform.position;
        if (collider.tag.Equals("Obstacle"))
        {
            pos.x += widthOfBgObject + 30f;
            pos.y = Random.Range(-1.72f, 2.16f);
            collider.transform.position = pos;
        }
        
    }
}
