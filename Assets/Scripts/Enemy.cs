using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 enemy_pos = transform.position;
	    if (enemy_pos != player.transform.position)
        {
            Vector3 dir = (player.transform.position - enemy_pos).normalized;
            transform.position += dir * (Time.deltaTime);
        }
	}
}
