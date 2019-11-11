using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class TimerScript : MonoBehaviour
{
    public GameObject timerObject;
    Text timerTextComp;
    int timer = 0;
    float spawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        timerTextComp = timerObject.GetComponent<Text>();
        timerTextComp.text = "pancake";
        InvokeRepeating("trigger spawn", spawnTime);
    }
    private void Update()
    {
        if (Input.anyKey) {
            CancelInvoke();
        }
    }
    // Update is called once per frame
    void UpdateText()
    {
        timer++;
        timerTextComp.text = "Time: " + timer;
    }
    void TriggerSpawn() {
        SpawnerScript.Spawn();

        spawnTime -= .3f;
        Invoke("TriggerSpawn", spawnTime);
    }
}
