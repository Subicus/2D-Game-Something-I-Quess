using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour

{
    public GameObject Player;
    public Vector3 offset;
    public float swordDistance = 1;

    void Start()
    {

    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 characterPos = transform.position;
        Vector2 dir = mousePos - characterPos;
        dir = dir.normalized;
        Vector2 swordPos = characterPos + swordDistance * dir;

    }

   void OnDrawGizmos()
          {
             if (!Application.isPlaying) return;
             Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             Vector2 characterPos = transform.position;
             Gizmos.DrawSphere(mousePos, 1);
             Vector2 dir = mousePos - characterPos;
             dir = dir.normalized;
             Vector2 swordPos = characterPos + swordDistance*dir;
             Gizmos.DrawLine(characterPos, swordPos);
         }

}
