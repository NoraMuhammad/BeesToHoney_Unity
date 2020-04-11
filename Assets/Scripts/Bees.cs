using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bees : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    Vector3 target;
    int i = 0;

    void Update()
    {
        target = Raycaster.HitPoint;

        if(target!=null)
        MoveToHoney();
    }
    public void MoveToHoney()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target) < 1.0f && speed > 0)
        {
            speed = 0;
        }
        else if (Vector3.Distance(transform.position, target) > 1.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            speed = 1;
        }
     
    }
}
