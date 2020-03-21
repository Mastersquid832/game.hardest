using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyController : MonoBehaviour
{

    public float duration = 0.2f;

    public List<Transform> waypoints = new List<Transform>();

    private void Start()
    {
        transform.position = GetWaypointPositions()[0];
        transform.DOPath(GetWaypointPositions(), duration * waypoints.Count, PathType.Linear).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private Vector3[] GetWaypointPositions()
    {
        List<Vector3> wps = new List<Vector3>();
        foreach (var wp in waypoints)
        {
            wps.Add(wp.position);
        }
        return wps.ToArray();
    }

}
