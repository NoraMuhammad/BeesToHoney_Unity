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

        if (target != Vector3.zero)
            MoveToHoney();
    }
    public void MoveToHoney()
    {
        float _distance = Vector3.Distance(transform.position, target);
        if (_distance < 0.5f && speed > 0)
        {
            speed = Mathf.Max(speed - 0.1f, 0);
        }
        else if (_distance > 0.5f)
        {
            speed = 1;
        }

        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
