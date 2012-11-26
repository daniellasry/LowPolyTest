Shader "Custom/Grainy1" {
	Properties {
		 _ShadeColor("Shade Color", Color) = (1.0,1.0,1.0,1.0)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert
		
		float4 _ShadeColor;
		
		struct Input {
			float4 _ShadeColor;
		};
		
		void surf (Input IN, inout SurfaceOutput o) {
			o.Albedo = _ShadeColor.rgb;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
