using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour

{
    public AudioSource coinFX;



    void OnTriggerEnter(Collider other)
    {

        coinFX.Play();
       
        this.gameObject.SetActive(false);
    }



}