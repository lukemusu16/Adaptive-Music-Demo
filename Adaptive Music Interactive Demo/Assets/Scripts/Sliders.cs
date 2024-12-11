using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    private Slider playerSlide, healthSlide;
    float interval = 0.2f;

    Color slideCol;
    // Start is called before the first frame update
    void Start()
    {
        healthSlide = GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Slider>();
        playerSlide = GameObject.Find("Canvas").transform.GetChild(4).GetComponent<Slider>();
        slideCol = playerSlide.transform.GetChild(2).GetComponentInChildren<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {

        if (healthSlide.value <= 0)
        {
            playerSlide.transform.GetChild(2).GetComponentInChildren<Image>().color = Color.grey;
            playerSlide.enabled = false;
        }
        else
        {
            playerSlide.transform.GetChild(2).GetComponentInChildren<Image>().color = Color.white;
            playerSlide.enabled = true;
        }
    }
}
