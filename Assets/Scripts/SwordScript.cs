using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour

{
    public GameObject Player;
    public Vector3 offset;
    transfrom asd

    void Start()
    {
   
    }

void Update()
    {
      transform.position = Player.transform.position + offset;
      faceMouse();  
       
    }

void faceMouse()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);

        Vector2 direction = new Vector2()
    }

}
