using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject target;
    public GameObject structure;
    Vector3 truePos;
    public float gridSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        truePos.x = Mathf.Floor(target.transform.position.x/gridSize)*gridSize;
        truePos.y = Mathf.Floor(target.transform.position.y/gridSize)*gridSize;
        truePos.z = Mathf.Floor(target.transform.position.z/gridSize)*gridSize;

        structure.transform.position = truePos;
    }
}
