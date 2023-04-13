using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSwitcher : MonoBehaviour
{

    public string targetlayer = "Persistant Layer";
    private string originalLayer = string.Empty;
    
    // Start is called before the first frame update
    private void Awake()
    {
        originalLayer = LayerMask.LayerToName(gameObject.layer);
    }

    private void OnEnable()
    {
        SceneLoader.Instance.OnloadBegin.AddListener(SwitchToLoadLayer);
        SceneLoader.Instance.OnLoadEnd.AddListener(ResetLayer);
    }
    // Update is called once per frame
    private void OnDisable()
    {
        SceneLoader.Instance.OnloadBegin.RemoveListener(SwitchToLoadLayer);
        SceneLoader.Instance.OnLoadEnd.RemoveListener(ResetLayer);
    }

    private void SwitchToLoadLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(targetlayer);
    }

    private void ResetLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(originalLayer);
    }
}
