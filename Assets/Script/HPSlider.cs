using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPSlider : MonoBehaviour
{
    int maxHp = 3;
    int Hp;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
        
            slider.value = 1;
            Hp = maxHp;

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Hp = Hp - 1;

            slider.value = (float)Hp / (float)maxHp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("End");
        }
    }
}
