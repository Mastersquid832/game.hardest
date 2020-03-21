using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Floor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().sharedMaterial.SetVector("PlaneSize", new Vector4(transform.localScale.x, transform.localScale.z));
    }

}
