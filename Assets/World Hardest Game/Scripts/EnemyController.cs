using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyController : MonoBehaviour
{

    public float speed = 4;
    public Vector3 offset;

    private Vector3 target;

    private void Start()
    {
        target = transform.position + offset;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            offset *= -1;
            target = transform.position + offset;
        }
    }

}
