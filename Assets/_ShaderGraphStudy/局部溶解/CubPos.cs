using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubPos : MonoBehaviour
{
    /// <summary>
    /// 材质球
    /// </summary>
    public Material mat;
    /// <summary>
    /// 要靠近过来的物体
    /// </summary>
    public Transform m_targetObj;



    // Update is called once per frame
    void Update()
    {
        mat.SetVector("_targetpos", m_targetObj.position);
    }

}
