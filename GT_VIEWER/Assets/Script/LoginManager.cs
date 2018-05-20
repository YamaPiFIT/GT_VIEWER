using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManager : MonoBehaviour {

	private const float FADE_IN_SPEED = 0.3f;
	private const float FADE_OUT_SPEED = 1.0f;
	private const float TIME_RESTE = 0.0f;
	private const float TRANSPARENT = 0.0f;
	private const float UN_TRANSPARENT = 1.0f;
	private const int STATUS_IMG_FINISH = 0;
	private const int STATUS_BACK_GROUND_FADE_IN = 1;
	private const int STATUS_BACK_GROUND_FADE_OUT = 2;
	private const int STATUS_ID_PASS_AND_LOGING_FADE_IN = 3;
	private const int STATUS_ID_PASS_AND_LOGING_FADE_OUT = 4;

	public SpriteRenderer imgBackGround;
	public SpriteRenderer imgGtLogo;

	/*
	 * why dosnt use InputField
	 */
	public GameObject idField;
	public GameObject passField;

	private int viewStatus;
	private float time;

	// Use this for initialization
	void Start () {
		this.imgBackGround.color = Transparent(this.imgBackGround.color, TRANSPARENT);
		this.time = TIME_RESTE;
		this.viewStatus = STATUS_BACK_GROUND_FADE_IN;
	}

	// Update is called once per frame
	void Update()
	{
		//update viewer
        UpdateViewStatus(viewStatus);
  	}
    

    /*
     * Image update
     */
	private void UpdateViewStatus(int _status){
		switch (_status){
			case STATUS_BACK_GROUND_FADE_IN:
				ImgFadeIn(this.imgBackGround);
				ImgFadeIn(this.imgGtLogo);
				break;

			case STATUS_ID_PASS_AND_LOGING_FADE_IN:
				ObjFadeIn(idField);
				ObjFadeIn(passField);
				break;
		}
	}


    /*
     * Do transparent
     */
	private Color Transparent(Color _color, float _transparent){
		var _inputColor = _color;
		_inputColor.a = _transparent;
		return _inputColor;
	}

    /*
     * FadeIn for the Image
     */
	private void ImgFadeIn(SpriteRenderer _img){
		Debug.Log(_img.color.a);
		Debug.Log(Time.deltaTime);
		float _imgColorA = _img.color.a + (Time.deltaTime * FADE_IN_SPEED * 0.5f);
		try{
			Debug.Log(_imgColorA);
			_img.color = Transparent(_img.color, _imgColorA);

            //finish fade in
			if(_imgColorA > 1.0f){
				Debug.Log("finish fade in");
				this.time = TIME_RESTE;
				this.viewStatus = STATUS_ID_PASS_AND_LOGING_FADE_IN;
			}
		}catch(System.Exception e){
			Debug.LogError(e);
			_img.color = Transparent(_img.color, UN_TRANSPARENT);
			this.time = TIME_RESTE;
		}
	}
    
    /*
     * FadeIn for the GameObject
     */
	private void ObjFadeIn(GameObject _gameObject){
		
	}


}
