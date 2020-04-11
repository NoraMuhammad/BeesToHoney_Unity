using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bees : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform target;
    [SerializeField] GameObject[] bees;
    int i = 0;

    void Update()
    {
        MoveToHoney();
    }
    public void MoveToHoney()
    {
        bees[i].transform.position = Vector3.MoveTowards(bees[i].transform.position, target.position, speed * Time.deltaTime);
        if (Vector3.Distance(bees[i].transform.position, target.position) < 1.0f && speed >= 0)
        {
                speed = 0;
        }
        if (Vector3.Distance(bees[i].transform.position, target.position) > 1.0f && speed <= 0)
        {
            bees[i].transform.position = Vector3.MoveTowards(bees[i].transform.position, target.position, speed * Time.deltaTime);
            speed = 1;
        }
        i++;
        i = i % bees.Length;
    }
}
