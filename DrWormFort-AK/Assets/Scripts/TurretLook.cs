using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLook : MonoBehaviour
{
    public Transform player;
    private LaserSwitch laserSwitch;
    private GameObject laser;

    private void Start()
    {
        laserSwitch = GameObject.Find("LaserSwitch").GetComponent<LaserSwitch>();
        laser = transform.Find("Laser").gameObject;
    }

    void Update() 
    {
        // set lasersAreOff to public so we can use it 
        // in other scripts (classes)
        if(laserSwitch.lasersAreOff){
            laser.SetActive(false);
            //return; will stop the method completly
            return;
        }
        transform.LookAt(player);
    }
}
