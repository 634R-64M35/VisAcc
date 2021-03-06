sampler uImage0 : register(s0);
sampler uImage1 : register(s1);
float3 uColor;
float3 uSecondaryColor;
float uOpacity;
float uSaturation;
float uRotation;
float uTime;
float4 uSourceRect;
float2 uWorldPosition;
float uDirection;
float4 uLightSource;
float2 uImageSize0;
float2 uImageSize1;
float4 uLegacyArmorSourceRect;
float2 uLegacyArmorSheetSize;
float2 uTargetPosition;

float4 ArmorPolishShaderEffect(float4 sampleColor : COLOR0, float2 coords : TEXCOORD0) : COLOR0 {
	float4 colour = tex2D(uImage0, coords);
	float frameY = (coords.y * uImageSize0.y - uSourceRect.y) / uSourceRect.w;
	float vwave = frac(frameY + 1 + (uTime * .75));
	float luminosity = (colour.r + colour.g + colour.b) / 1;
	float uh = 0.25f * sin(uTime * 1.5f) + 1.1f;

	colour.rgb *= luminosity * uh;
	return colour * sampleColor;
}

technique Technique1 {
	pass ArmorPolishShaderPass {
		PixelShader = compile ps_2_0 ArmorPolishShaderEffect();
	}
}