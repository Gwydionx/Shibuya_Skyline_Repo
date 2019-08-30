﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Waypoint3 : MonoBehaviour {
    public GameObject WayPoint_Manager;
    public Animator Animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            WayPoint_Manager.SendMessage("Waypoint_3");
            Animator.SetBool("Off", true);
        }
    }
}
