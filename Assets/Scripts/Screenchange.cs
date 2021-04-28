using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenchange : MonoBehaviour
{
    public string howTag = "Screen";
    public Material glow;
    public Material Regular;
    private Transform selection;
    public float Max = 5;
    public Renderer rend;
    public Material[] material;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            rend.sharedMaterial = material[1];
        }
    }

    //private void Update()
    //{
    //    if (selection != null)
    //    {
    //        var renderer = selection.GetComponent<Renderer>();
    //        renderer.material = Regular;
    //        selection = null;
    //    }

    //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray, out hit, Max))
    //    {
    //        var selected = hit.transform;
    //        if (selected.CompareTag(howTag))
    //        {
    //            var renderer = selected.GetComponent<Renderer>();
    //            if (renderer != null)
    //            {
    //                renderer.material = glow;
    //            }

    //            selection = selected;
    //        }
    //    }
    //}
}
