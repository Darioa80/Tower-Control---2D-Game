using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage;
    public float projectileSpeed;
    
    private float timeToHit;
    private GameObject currTarget;
    private Tower parentTower;
    private List<GameObject> StoreTargetList = new List<GameObject>();
    private float startDistance;
    private float interpolationValue;
    private Enemy enemyReference;
    

    //interpolation values
    public Vector3 targetFinalPosition;
    private Vector3 shotDirection;
    private Vector3 startPosition;
    private bool hit;

    void Start()
    {
        interpolationValue = 0f;
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currTarget != null) {
            if (!hit) {
                HitTarget();


                interpolationValue += (projectileSpeed * 0.1f * Time.deltaTime);
            }
        }
    }

    public void HitTarget() {
        //Add actual interpolation code here
     
        this.transform.position = ((1f - interpolationValue) * parentTower.towerPosition) + (interpolationValue * targetFinalPosition);
       
        if (interpolationValue >= 1f) {
            enemyReference = currTarget.GetComponent<Enemy>();
            enemyReference.health = enemyReference.health - damage;
            if (enemyReference.health < 0f)
            {
                Destroy(currTarget);
            }
            hit = true;
            Destroy(this);
            interpolationValue = 0f;
            parentTower.UpdateShot();
        }
        interpolationValue += (projectileSpeed * 0.5f * Time.deltaTime);
        //print("Interpolation value: " + interpolationValue);


    }

    public void CalculateFinalLocation() {
        enemyReference = currTarget.GetComponent<Enemy>();
        startDistance = (currTarget.transform.position - this.transform.position).magnitude;
       // timeToHit = startDistance / projectileSpeed;
        
        if (enemyReference.horizontalSpeed > 0f) {
            print("Time to Hit: " + timeToHit);
            print("Horizontal speed: " + enemyReference.horizontalSpeed);
            print("current target x position: " + currTarget.transform.position.x);
            targetFinalPosition.x = (enemyReference.horizontalSpeed * timeToHit) + currTarget.transform.position.x;
            targetFinalPosition.y = currTarget.transform.position.y;
            print("target final position: " + targetFinalPosition);
        }
        else if (enemyReference.verticalSpeed > 0f) {
            targetFinalPosition.x = currTarget.transform.position.x;
            targetFinalPosition.y = (enemyReference.verticalSpeed * timeToHit) + currTarget.transform.position.y;
        }

        print(targetFinalPosition);
    }

    public void InstantiateProjectile(List<GameObject> TargetList, Tower currTower) {
        if (TargetList.Count > 0) {
            currTarget = TargetList[0];

        }
        parentTower = currTower;
        shotDirection = currTarget.transform.position - parentTower.towerPosition;
        shotDirection.Normalize();
        startPosition = parentTower.transform.position + shotDirection;
        this.transform.position = startPosition;
    }
    

    

}
