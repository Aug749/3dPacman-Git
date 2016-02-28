using UnityEngine;
using System.Collections;
using Vuforia;

public class ModelSwapper : MonoBehaviour
{
    public GameObject Pellet;
    public TrackableBehaviour theTrackable;

    private bool mSwapModel = false;

    // Use this for initialization
    void Start()
    {
        if (theTrackable == null)
        {
            Debug.Log("Warning: Trackable and Pellet are set !!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mSwapModel && theTrackable != null)
        {
            SwapModel();
            mSwapModel = false;
        }
        // PUT YOUR STUFF HERE FOR CALLING SWAPMODEL
        // MODIFY SWAPMODEL FUNCTION TO ACTUALLY SWAp MODELS

        }
    }

    private void SwapModel()
    {
        GameObject trackableGameObject = theTrackable.gameObject;

        //disable any pre-existing augmentation
        for (int i = 0; i < trackableGameObject.transform.GetChildCount(); i++)
        {
            Transform child = trackableGameObject.transform.GetChild(i);
            child.gameObject.active = false;
        }

        // Create a simple cube object 
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Re-parent the cube as child of the trackable gameObject
        cube.transform.parent = theTrackable.transform;

        // Adjust the position and scale 
        // so that it fits nicely on the target
        cube.transform.localPosition = new Vector3(0, 0.2f, 0);
        cube.transform.localRotation = Quaternion.identity;
        cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        // Make sure it is active
        cube.active = true;
    }
}