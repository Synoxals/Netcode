using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.GridLayoutGroup;


public class CameraController : NetworkBehaviour
{
    public GameObject cameraHolder;
    public Camera myCam;

    private void Update()
    {
       // if ( != null &&  == owner){
            //Only the client that owns this object executes this code
          //  if (myCam.enabled == false)
              //  myCam.enabled = true;
        }
}



