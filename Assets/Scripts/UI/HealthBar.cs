using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Health))]
public class HealthBar : MonoBehaviour {
    private Image m_hp_bg; // The background of the healthbar
    private Image m_hp_fg; // The foreground of the healthbar
    public Health player_health; // Player current health object
    private float fg_width;
    private float bg_width;
	// Use this for initialization
	void Start () {
        // Get component from healthbar background object
        m_hp_bg = GetComponent<Image>();
        m_hp_fg = transform.GetChild(0).GetComponent<Image>();
        bg_width = m_hp_bg.rectTransform.rect.width;
        fg_width = m_hp_fg.rectTransform.rect.width;
	}
	
	// Update is called once per frame
	void Update () {
       // m_hp_bg.rectTransform.rect.Set(m_hp_bg.rectTransform.rect.x, m_hp_bg.rectTransform.rect.y, m_hp_bg.rectTransform.rect.width * (player_health.MAX_HEALTH * 0.01f), m_hp_bg.rectTransform.rect.height);
       // m_hp_fg.rectTransform.rect.Set(m_hp_fg.rectTransform.rect.x, m_hp_fg.rectTransform.rect.y, m_hp_fg.rectTransform.rect.width * (player_health.GetHealth() * 0.01f), m_hp_fg.rectTransform.rect.height);
        m_hp_bg.rectTransform.sizeDelta = new Vector2(bg_width * (player_health.MAX_HEALTH * 0.01f), m_hp_bg.rectTransform.rect.height);
        m_hp_fg.rectTransform.sizeDelta = new Vector2(fg_width * (player_health.GetHealth() * 0.01f), m_hp_fg.rectTransform.rect.height);
    }

    void OnGUI()
    {
        //m_hpfgRect.position.Set(Camera.main.ScreenToWorldPoint(m_hp_bg.rectTransform.rect.position).x + m_offset.x, Screen.height - Camera.main.ScreenToWorldPoint(m_hp_bg.rectTransform.rect.position).y + m_offset.y);
        //m_hpbgRect.position.Set(Camera.main.WorldToScreenPoint(transform.position).x + m_offset.x, Screen.height - Camera.main.WorldToScreenPoint(transform.position).y + m_offset.y);
        //GUI.DrawTexture(m_hpfgRect, m_Background, ScaleMode.ScaleToFit);
        
        //partialRect.x = m_Rectangle.x;

        //GUI.DrawTexture(partialRect, m_Foreground);
    }
}
