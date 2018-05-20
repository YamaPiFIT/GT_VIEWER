using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImgSpriteRenderer : MonoBehaviour {

	public SpriteRenderer mySpriteRenderer;

	public const float UN_TRANSOARENT = 1.0f;
	public float FADE_IN_TIME_S;

	/*
     * FadeIn for the Image
     */
	public SpriteRenderer ImgFadeIn(SpriteRenderer _img)
	{
		//_img.color.a;

		////少しアルファ値を上げる
		//_imgColorA = 

		////アルファ地が１以上の時アルファ値を1にセットする。
		//if (_imgColorA > UN_TRANSOARENT)
		//{
		//	_imgColorA = UN_TRANSOARENT;
		//}

		return null;
	}

	/*
     * Change transparent
     */
	private Color Transparent(Color _color, float _transparent)
    {
        var _inputColor = _color;
        _inputColor.a = _transparent;
        return _inputColor;
    }
}
