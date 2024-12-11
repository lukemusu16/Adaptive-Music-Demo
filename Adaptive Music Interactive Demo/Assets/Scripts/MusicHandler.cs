using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicHandler : MonoBehaviour
{

    private Slider health, player;

    private void Start()
    {
        health = GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Slider>();
        player = GameObject.Find("Canvas").transform.GetChild(4).GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter.SetParameter("Health", health.value);
        emitter.SetParameter("Intensity", player.value);
    }
}
