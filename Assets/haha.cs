using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class haha : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private TextMeshPro text;
    public UniversalRendererData yes;

    void Update()
    {
        // var yes = playerCamera.GetUniversalAdditionalCameraData().scriptableRenderer.supportedRenderingFeatures;
        var yes = GraphicsSettings.currentRenderPipeline.name;
        text.text = yes.ToString();
    }
}
