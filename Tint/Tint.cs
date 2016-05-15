using UnityEngine;

public class Tint : MonoBehaviour
{
    public Color tint;
    
    [Range(0f, 1f)]
    public float strength;

    private SpriteRenderer[] renderers;

	void Start()
	{
        renderers = GetComponentsInChildren<SpriteRenderer>();
        SetShaderProperties();
	}
	
	void Update()
	{
        SetShaderProperties();
	}

    private void SetShaderProperties()
    {
        foreach (SpriteRenderer r in renderers)
        {
            r.material.SetColor("_Color", tint);
            r.material.SetFloat("_Strength", strength);
        }
    }
}
