using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetShader : MonoBehaviour
{
    [SerializeField]private List<Material> materials ;
    [SerializeField]private Button StartBtn;
    [SerializeField]private Button StartBtn2;
    float sli = 0;
    bool b = false;
     bool jia = false;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in materials)
        {
            sli = 0;
            Debug.Log(item);
            item.SetFloat("_LerpSlider", sli);
        }
        StartBtn.onClick.AddListener(() => {
            b = true;
            jia = !jia;
            StartCoroutine(SetSele());
        });

    }

    IEnumerator SetSele()
    {
        foreach (var item in materials)
        {
            
            mat = item;
            yield return new WaitForSeconds(1);         
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (b)
        {
            if (jia)
            {
                if (sli < 1)
                {
                    sli += Time.deltaTime;
                    mat.SetFloat("_LerpSlider", sli);
                }
            }
            else
            {
                if (sli < 1)
                {
                    sli -= Time.deltaTime / 2;
                    mat.SetFloat("_LerpSlider", sli);
                }
            }

          



        }

       
        
    }

   

}
