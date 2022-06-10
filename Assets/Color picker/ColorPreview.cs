
using UnityEngine;
using UnityEngine.UI;

public class ColorPreview : MonoBehaviour
{
    public Material material;
    public Color color;
    public ColorPicker colorPicker;

    private void Start()
    {
        colorPicker.color = color;
        material.color = colorPicker.color;
        colorPicker.onColorChanged += OnColorChanged;
    }

    public void OnColorChanged(Color c)
    {
        material.color = c;
    }

    private void OnDestroy()
    {
        if (colorPicker != null)
            colorPicker.onColorChanged -= OnColorChanged;
    }
    private void Update()
    {
        material.color = colorPicker.color;
    }
    void OnApplicationQuit()
    {
        material.color = color;
    }
}