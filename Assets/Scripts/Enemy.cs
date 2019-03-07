using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float enemySpeed;
    float enemyTimer = 0f;
    public float horizontalSpeed = 0f;
    public float verticalSpeed = 0f;
    private Collider2D hitCollider;
    private RaycastHit2D hit;
    void Start()
    {
        verticalSpeed = -(enemySpeed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(horizontalSpeed, verticalSpeed, 0f));
    }

    void FixedUpdate()
    {


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //LowerCollisionSize();
        Vector2 off = new Vector2(this.transform.position.x, this.transform.position.y + 0.6f);
        Vector2 lowOff = new Vector2(this.transform.position.x, this.transform.position.y - 0.6f);
        if (verticalSpeed < 0f)
        {
            hit = Physics2D.Raycast(off, Vector2.right);
            
            if (hit.distance > 1)
            {

                horizontalSpeed = Mathf.Abs(verticalSpeed);
                this.transform.GetChild(0).transform.Rotate(0, 0, 90);
            }
            else
            {
                horizontalSpeed = verticalSpeed;
                this.transform.GetChild(0).transform.Rotate(0, 0, -90);
            }
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.2f, 0f);
            verticalSpeed = 0f;
           

        }

        else if (verticalSpeed > 0f)
        {
            Debug.DrawRay(this.transform.position, this.transform.right * 2f, Color.yellow);
            hit = Physics2D.Raycast(lowOff, Vector2.right);

            if (hit.distance < 1)
            {
                horizontalSpeed = -verticalSpeed;
                this.transform.GetChild(0).transform.Rotate(0, 0, 90);
            }
            else
            {
                horizontalSpeed = Mathf.Abs(verticalSpeed);
                this.transform.GetChild(0).transform.Rotate(0, 0, -90);
            }
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.1f, 0f);
            verticalSpeed = 0f;
        }

        else if (horizontalSpeed > 0f)
        {
            Debug.DrawRay(this.transform.position, (new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0f) - this.transform.position) * 2f, Color.yellow);

            hit = Physics2D.Raycast(off, Vector2.up);
            if (hit.distance < 1)
            {
                verticalSpeed = -horizontalSpeed;
                this.transform.GetChild(0).transform.Rotate(0, 0, -90);
            }
            else
            {

                verticalSpeed = horizontalSpeed;
                this.transform.GetChild(0).transform.Rotate(0, 0, 90);
            }
            horizontalSpeed = 0f;
            
            this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y, 0f);
        }

        else if (horizontalSpeed < 0f)
        {
            hit = Physics2D.Raycast(off, Vector2.up);
            if (hit.distance < 1)
            {
                verticalSpeed = horizontalSpeed;
                this.transform.GetChild(0).transform.Rotate(0, 0, 90);
            }
            else
            {
                verticalSpeed = Mathf.Abs(horizontalSpeed);
                this.transform.GetChild(0).transform.Rotate(0, 0, -90);
            }
            this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y, 0f);
            horizontalSpeed = 0f;
        }


    }


}
