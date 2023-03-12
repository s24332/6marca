using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znikajace : MonoBehaviour
{
    public float timeToTogglePlatform = 1;
    public float currentTime = 0;
    public bool enabled = true;

    void Start()
    {
        enabled = true;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeToTogglePlatform)
        {
            currentTime = 0;
            TogglePlatform();
        }
    }

    void TogglePlatform()
    {
        enabled = !enabled;
        foreach(Transform child in gameObject.transform)
        {
            if (child.tag != "Player")
            {
                child.gameObject.SetActive(enabled);
            }
          
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
