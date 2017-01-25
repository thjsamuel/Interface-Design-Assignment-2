using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    private float health;
    public float MAX_HEALTH;
	// Use this for initialization
	void Start () {
        health = MAX_HEALTH - 50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IncreaseHealthGradually(float dt, int limit)
    {
        if (limit < 0)
            limit = 0;
        if (limit > MAX_HEALTH)
            limit = (int)MAX_HEALTH;
        if (health < limit)
            health += dt;
    }

    public void DecreaseHealthGradually(float dt, int limit)
    {
        if (limit < 0)
            limit = 0;
        if (limit > MAX_HEALTH)
            limit = (int)MAX_HEALTH;
        if (health < limit)
            health -= dt;
    }

    public void SetHealth(float value)
    {
        health = value;
    }

    public float GetHealth()
    {
        return health;
    }
}
