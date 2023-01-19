using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    Rigidbody rb;
    Animator anim;

    public Transform playerPutaran; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }
    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * speed;
        anim.SetFloat("Kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3(0, gerak * -94, 0);
    }
}
