Shader "Custom/NewUnlitShader"
{
Properties {
    _EmisColor ("Emissive Color", Color) = (.2,.2,.2,0)
    _MainTex ("Particle Texture", 2D) = "white" {}
}

Category {
    Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
    Blend SrcAlpha OneMinusSrcAlpha
    Cull Off ZWrite On Fog { Color (0,0,0,0) }

    Lighting On
    Material { Emission [_EmisColor] }
    ColorMaterial AmbientAndDiffuse

    SubShader {
        Pass {
            SetTexture [_MainTex] {
                combine texture * primary
            }
        }

    }
}

}
