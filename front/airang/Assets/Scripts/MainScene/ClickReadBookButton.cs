using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickReadBookButton : MonoBehaviour
{
    public MainMainCamera my_camera;

    public void goCameraMyDesk()
	{
        my_camera.MainMoveCamera(1);
	}

}
