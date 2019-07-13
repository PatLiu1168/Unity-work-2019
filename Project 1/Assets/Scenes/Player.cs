using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1f is like an undefined number

public class Player : MonoBehaviour
{

    public float moveSpeed;
    public Vectfinish;
    // Start is called before the first frame update
    void Start() 
    {
        print("I am a cube"); 
        moveSpeed =5;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime == finish){
            print ("done");
        }
        transform.Translate (moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
