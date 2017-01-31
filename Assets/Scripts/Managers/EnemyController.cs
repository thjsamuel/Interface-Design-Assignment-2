using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    private static EnemyController s_m_instance;
    public static EnemyController Instance
    {
        get
        {
            if (s_m_instance == null)
            {
                GameObject go = new GameObject("EnemyController");
                go.AddComponent<EnemyController>();
            }
            return s_m_instance;
        }
    }

    public float m_dist; // Distance to determine collision with player
    private GameObject[] m_enemylist;
    private GameObject m_player;
    private GameObject hurt_go;
    public int m_damage;

    public GameObject Hurt
    {
        set
        {
            hurt_go = value;
        }
    }
    //private ComponentHealth mGO_Health;

    void Awake()
    {
        s_m_instance = this;
    }

    // Use this for initialization
    void Start()
    {
        m_enemylist = GameObject.FindGameObjectsWithTag("Enemy");
        m_player = GameObject.FindGameObjectWithTag("Player");
        hurt_go = null;
        m_dist *= 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (hurt_go != null)
        {
            //mGO_Health = hurt_go.GetComponent(typeof(ComponentHealth)) as ComponentHealth;
            //mGO_Health.UpdateHP(m_damage, false); // decrease enemy's health by m_damage/bullet's damage
        }

        for (int i = 0; i < m_enemylist.Length; ++i)
        {
            Vector3 enemy_pos = m_enemylist[i].transform.position;
            float distSquared = (m_player.transform.position - enemy_pos).sqrMagnitude;
            if (distSquared < m_dist)
            {
                PlayerController.Instance.Hurt = true;
                PlayerController.Instance.m_playerDmg = m_damage;
            }
        }
    }
}
