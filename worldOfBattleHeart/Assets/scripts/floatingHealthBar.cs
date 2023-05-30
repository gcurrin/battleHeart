using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class floatingHealthBar : MonoBehaviour
{
    Slider slider;
    public Image slideBar;
    public Color highHealth;
    public Color midHealth;
    public Color lowHealth;

    // Start is called before the first frame update
    void Start()
    {
        
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void UpdateHealthBar(int currentHealth, int maxHealth)
    {
        float value = (float)currentHealth/maxHealth;
        slider.value = value;
        if (value > 0.5f)
        {
            slideBar.color = highHealth;
        }
        else if (value > 0.25f)
        {
            slideBar.color = midHealth;
        }
        else
        {
            slideBar.color = lowHealth;

        }
    }

    private void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
