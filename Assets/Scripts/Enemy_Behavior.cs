using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform Enemy;
    public float enemySpeed;
    float enemyTimer = 0f;
    private float horizontalSpeed = 0f;
    private float verticalSpeed = 0f;
    void Start()
    {
        verticalSpeed = -(enemySpeed * Time.deltaTime);
        this.transform.Translate(new Vector3(horizontalSpeed, verticalSpeed, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(horizontalSpeed, verticalSpeed, 0f));
    }

    void FixedUpdate() {
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //LowerCollisionSize();
        if (verticalSpeed < 0f)
        {
            if (!Physics.Raycast(this.transform.position, this.transform.right, 2f))
            {

                horizontalSpeed = Mathf.Abs(verticalSpeed);
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, 0f);
                verticalSpeed = 0f;
            }
            else {
                horizontalSpeed = verticalSpeed;
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, 0f);
                verticalSpeed = 0f;
            }
        }
        else if (horizontalSpeed > 0f) {
            Debug.DrawRay(this.transform.position, (new Vector3(this.transform.position.x, this.transform.position.y + 2f, 0f) - this.transform.position) * 2f, Color.yellow);
            if (Physics.Raycast(this.transform.position, new Vector3(this.transform.position.x, this.transform.position.y +2f, 0f)-this.transform.position, 2f))
            {
                verticalSpeed = -horizontalSpeed;
                horizontalSpeed = 0f;
                this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y, 0f);
                
            }
            else {
                verticalSpeed = horizontalSpeed;
                this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y, 0f);
                horizontalSpeed = 0f;
            }
        }

        else if (horizontalSpeed < 0f)
        {
            if (!Physics.Raycast(this.transform.position, this.transform.up, 2f))
            {
                verticalSpeed = horizontalSpeed;
                this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y, 0f);
                horizontalSpeed = 0f;
            }
            else
            {
                verticalSpeed = -horizontalSpeed;
                this.transform.position = new Vector3(this.transform.position.x - 0.1f, this.transform.position.y, 0f);
                horizontalSpeed = 0f;
            }
        }

        else if (verticalSpeed > 0f) {
            Debug.DrawRay(this.transform.position, this.transform.right *2f, Color.yellow);
            if (Physics.Raycast(this.transform.position, this.transform.right, 2f))
            { 
                horizontalSpeed = verticalSpeed;
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.1f, 0f);
                verticalSpeed = 0f;
            }
            else
            {
                horizontalSpeed = Mathf.Abs(verticalSpeed);
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.1f, 0f);
                verticalSpeed = 0f;
            }
        }
    }



}
