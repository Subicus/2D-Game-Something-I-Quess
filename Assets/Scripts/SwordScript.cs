using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour

{
    public GameObject Player;
    public Vector3 offset;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Player.transform.position + offset;

    }

    
}