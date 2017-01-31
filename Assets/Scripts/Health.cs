using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    private float health;
    public float MAX_HEALTH;
    private float limiter;
    private bool decrease;
    private bool increase;
	// Use this for initialization
	void Start () {
        health = MAX_HEALTH;
        increase = false;
        decrease = false;
        limiter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (increase && health < limiter)
            health += (5 * Time.deltaTime);
        else if (increase)
        {
            increase = false;
            limiter = 0;
        }
        if (decrease && health > limiter)
            health -= (5 * Time.deltaTime);
        else if (decrease)
        {
            decrease = false;
            limiter = 0;
        }
	}

    public void IncreaseHealthGradually(float dt, int limit)
    {
        if (limit < 0)
            limit = 0;
        if (limit > MAX_HEALTH)
            limit = (int)MAX_HEALTH;
        limiter = health + limit;
        increase = true;
    }

    public void DecreaseHealthGradually(float dt, int limit)
    {
        if (limit < 0)
            limit = 0;
        if (limit > MAX_HEALTH)
            limit = (int)MAX_HEALTH;
        limiter = health - limit;
        decrease = true;
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
