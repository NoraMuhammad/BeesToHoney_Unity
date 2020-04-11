using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    [SerializeField] GameObject RaycastSpot;
    [HideInInspector] public static Vector3 HitPoint;
    RaycastHit hit;
    GameObject spot;
    private void Start()
    {
        hit = new RaycastHit();
        HitPoint = hit.point;
        spot = Instantiate(RaycastSpot, hit.point, Quaternion.identity);
        spot.SetActive(false);
    }
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Playground")))
        {
            spot.SetActive(true);
            spot.transform.position = hit.point;
            HitPoint = hit.point;
        }
        else if(spot != null)
        {
            spot.SetActive(false);
        }
    }
}
