using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public Transform targetTransform;
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            other.gameObject.transform.position = targetTransform.position;
        }
    }
    public void exit()
    {
        Application.Quit();
    }
}
