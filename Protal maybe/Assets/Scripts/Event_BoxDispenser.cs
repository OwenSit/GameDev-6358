﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_BoxDispenser : BaseEvent
{
    public GameObject box;
    bool spawnOnce=true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void ActivateEvent()
    {
        Debug.Log("Event Activated");
        if(spawnOnce)
        {
            GameObject spawned = Instantiate(box, this.transform.position, transform.rotation);
            spawnOnce = false;
        }
       

    }
}
