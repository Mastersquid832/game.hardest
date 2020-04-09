using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class BoxDetection : MonoBehaviour
{

    private Vector3 lastCheckpoint;

    public TextMeshProUGUI dieText;

    private int dieCount;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Respawn")
        {
            ShakeCamera();
            transform.position = lastCheckpoint;
            dieCount++;
            dieText.text = "die: " + dieCount;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            lastCheckpoint = other.transform.position;
        }

        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Finish");
            Time.timeScale = 0;
        }
    }

    private void ShakeCamera()
    {
        Camera.main.DOShakePosition(0.2f, 3, 4, 10, false);
    }

}
