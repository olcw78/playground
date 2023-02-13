using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlay : MonoBehaviour
{
    private Camera _camera;

    private string PrettyCameraPixelAttrs => $"pixel width: {_camera.pixelWidth}\n" +
                                             $"pixel height: {_camera.pixelHeight}\n" +
                                             $"pixel rect: {_camera.pixelRect}";

    void Start() => _camera ??= Camera.main;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(PrettyCameraPixelAttrs);
        }
    }
}