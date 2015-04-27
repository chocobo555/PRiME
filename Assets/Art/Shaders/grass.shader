Shader "OpenGL/Grass Blowing"
{
	Properties 
	{
		_Color ("Ambient Color", Color) = (1.0, 1.0, 1.0, 1.0)
		_MainTex("Diffuse Texture", 2D) = "white" {}
	}
	SubShader
	{
		Tags{ "Queue" = "Geometry" } 
		
		Pass
		{
			GLSLPROGRAM
			
			uniform vec4 _Color;
			uniform sampler2D _MainTex;
			uniform vec4 _MainTex_ST;
			uniform vec4 _Time;
			uniform vec4 _SinTime;
			uniform vec4 _CosTime;
			
			uniform mat4 _World2Object;
			uniform mat4 _Object2World;
			//uniform mat UNITY_MATRIX_MVP;
			
			varying vec3 vertexPosition;
			varying vec4 vertexColor;
			
			//varying vec4 vertexData; //*****original*****
			vec4 vertexData;
			
			varying vec2 uv;
			
			#ifdef VERTEX
			
			void main()
			{
			
				vertexColor = _Color;
				uv = gl_MultiTexCoord0;
				
				vertexData = gl_Vertex;
				
				//***************************ORIGINAL CODE***********************
				//vertexData.y += (_SinTime.z / ((-vertexData.z * -vertexData.x) * 60)) * clamp(vertexData.y, 0.0, 1.0);
				//vertexData.x += (_SinTime.y / 4.0) * clamp(vertexData.y, 0.0, 1.0);
				//vertexData.z += (_SinTime.x / 4.0) * clamp(vertexData.y, 0.0, 1.0);
				
				//******************************my code**********************************
				vertexData.y += (_SinTime.z / ((-vertexData.z * -vertexData.x) * 60)) * clamp(vertexData.y, 0.0, 1.0);
				vertexData.x += (_SinTime.y / 4.0) * clamp(vertexData.y, 0.0, 2.0);
				vertexData.z += (_SinTime.x / 4.0) * clamp(vertexData.y, 0.0, 2.0);
				
				//gl_Position = gl_ModelViewProjectionMatrix * vertexData; //******* ORIGINAL ******
				gl_Position = gl_ProjectionMatrix * (gl_ModelViewMatrix * vertexData);
				
			}
			
			#endif
			
			#ifdef FRAGMENT
			
			void main()
			{
				gl_FragColor = texture2D(_MainTex, uv) * vertexColor;
				if(gl_FragColor.a < 0.5)
				{
					discard;
				}
			}
			
			#endif
			
			ENDGLSL
		}
	}
}

