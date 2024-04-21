using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_animation : MonoBehaviour
{
    private Material mat;
    private Vector2 offset;
    public float speed = 0.2f;
    void Start()
    {
        mat = gameObject.GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.x = offset.x + (speed * Time.deltaTime);
        mat.SetTextureOffset("_MainTex", offset);
    }
}
