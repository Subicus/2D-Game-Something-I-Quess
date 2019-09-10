using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float speed;
    public float swordDistance = 1;
    private Rigidbody2D rb2d;        


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 characterPos = transform.position;
        Vector2 dir = mousePos - characterPos;
        dir = dir.normalized;
        Vector2 swordPos = characterPos + swordDistance * dir;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }

   /// void OnDrawGizmos()
 ///   {
 ///       if (!Application.isPlaying) return;
 ///       Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 ///       Vector2 characterPos = transform.position;
 ///      Gizmos.DrawSphere(mousePos, 1);
 ///       Vector2 dir = mousePos - characterPos;
 ///       dir = dir.normalized;
 ///      Vector2 swordPos = characterPos + swordDistance*dir;
 ///       Gizmos.DrawLine(characterPos, swordPos);
 ///   }



}
