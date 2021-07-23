using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] PathCreator path;
    [SerializeField] EndOfPathInstruction endOfPath;
    [SerializeField] float speed = 3f;
    [SerializeField] bool isMoving = true;


    [Header("Debug options")]
    [SerializeField] float previewDistance = 0f;
    [SerializeField] bool enableDebug;
 
    private float distanceTravelled;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(path != null && isMoving)
        {

            distanceTravelled = distanceTravelled + speed * Time.deltaTime;
            transform.position = path.path.GetPointAtDistance(distanceTravelled, endOfPath);
            transform.rotation = path.path.GetRotationAtDistance(distanceTravelled, endOfPath);
        }


    }

    private void OnValidate()
    {
        transform.position = path.path.GetPointAtDistance(previewDistance, endOfPath);
        transform.rotation = path.path.GetRotationAtDistance(previewDistance, endOfPath);
    }


}


