﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderObj : MonoBehaviour
{
    public Mesh targetMesh;
    public Material targetMaterial;
    [System.NonSerialized]
    public Matrix4x4 localToWorldMatrices;
    [System.NonSerialized]
    public Vector3 extent;

    //通过包围盒进行视锥体剔除
    public void Init()
    {
        localToWorldMatrices = transform.localToWorldMatrix;
        extent = targetMesh.bounds.extents;
    }
}
