using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class CameraPlay : MonoBehaviour
{
    private Camera _camera;

    private string PrettyCameraPixelAttrs => $"pixel width: {_camera.pixelWidth}\n" +
                                             $"pixel height: {_camera.pixelHeight}\n" +
                                             $"pixel rect: {_camera.pixelRect}";

    void Awake() => _camera = Camera.main;

    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Throttle(TimeSpan.FromSeconds(0.5f))
            .Subscribe(ob =>
            {
                Debug.Log(PrettyCameraPixelAttrs);
            });
    }
}