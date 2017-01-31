using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private static PlayerController s_m_instance;
    public static PlayerController Instance
    {
        get
        {
            if (s_m_instance == null)
            {
                GameObject go = new GameObject("PlayerController");
                go.AddComponent<PlayerController>();
            }
            return s_m_instance;
        }
    }

    [HideInInspector]
    private bool is_hurt;
    [HideInInspector]
    public bool Hurt
    {
        set
        {
            is_hurt = value;
        }
        get
        {
            return is_hurt;
        }
    }
    [HideInInspector]
    public GameObject m_player; // a reference to the player object
    private GameObject health_component; // A health component
    private Health m_playerHealth;
    [HideInInspector]
    public int m_playerDmg; // Damage to player, recieved from EnemyController
    private bool m_isDead; // Is not dead

    void Awake()
    {
        s_m_instance = this;
        //else if (i_instance != null && i_instance != this)
        //    Destroy(this.gameObject);
    }

    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        is_hurt = false;
        health_component = GameObject.FindGameObjectWithTag("Health");
        m_playerHealth = health_component.GetComponent<Health>();
        m_isDead = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (is_hurt)
        {
            m_playerHealth.DecreaseHealthGradually(Time.deltaTime, m_playerDmg);
            is_hurt = false;
        }
    }
}
