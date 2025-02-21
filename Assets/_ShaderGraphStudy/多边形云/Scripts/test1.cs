using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{    
    MeshRenderer mesh;
    //player记录玩家的实时世界坐标
    public Transform player;
    Material cloudMate;
    //pPos作为最后的输出给材质的值，材质只能传入Vector4
    Vector4 pPos = Vector4.zero;
    


    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        cloudMate = mesh.material;
    }

    // Update is called once per frame
    void Update()
    {
        //将玩家世界坐标实时传给pPos
        pPos.x = player.position.x;
        pPos.y = player.position.y;
        pPos.z = player.position.z;
        
        
        //将pPos实时传给shader
        cloudMate.SetVector("_pPos", pPos);
        

    }


}
