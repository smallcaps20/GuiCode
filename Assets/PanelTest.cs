using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class PanelTest : MonoBehaviour {

	public Vector2 range = new Vector2(5f, 3f);
	GameObject _gameObject;
	Canvas _canvas;
	Transform _trans;
	Quaternion _qTrans;
	Vector2 _rot = Vector2.zero;
	private Color white = new Color (255f, 255f, 255f, 1f);

	public Sprite onNormalButton;
	public Sprite onHoverButton;
	public Sprite onPressedButton;

	public Button _myButton;
	
	// Use this for initialization
	void Start () {
		_gameObject = new GameObject();
		_gameObject.name = "myGO";
		_gameObject.AddComponent<Canvas>();
		_canvas = _gameObject.GetComponent<Canvas>();
		_canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		
		//Adding a Rect Trnasform
		//		_gameObject.AddComponent<RectTransform>();
		
		//Adding a Text component
//		_gameObject.AddComponent<Text>();
//		Text _text = _gameObject.GetComponent<Text>();
//		_text.text = "Blah Blah!";
//		_text.font = UnityEngine.Resources.Load( @"Fonts/TitilliumWeb-Black" ) as UnityEngine.Font;
//		_text.color = Color.red;
//		_text.fontSize = 200;
//		_text.transform.position = new Vector2( 10f, 10f );

		GameObject _childGO = new GameObject ();
		_childGO.name = "Image";
		_childGO.transform.parent = _gameObject.transform;

		GameObject _c2GO = new GameObject ();
		_c2GO.name = "Slider";
		_c2GO.transform.parent = _gameObject.transform;

		GameObject _c3GO = new GameObject ();
		_c3GO.name = "Button";
		_c3GO.transform.parent = _gameObject.transform;

		GameObject _c3ChildGO = new GameObject ();
		_c3ChildGO.name = "Text";
		_c3ChildGO.transform.parent = _c3GO.transform;

//		GameObject _c3Child2GO = new GameObject ();
//		_c3Child2GO.name = "Text";
//		_c3Child2GO.transform.parent = _c3GO.transform;

		//Adding an IMage Component
		_childGO.AddComponent<Image> ();
		Image _image = _childGO.GetComponent<Image> ();
		_image.sprite = UnityEngine.Resources.Load (@"Sprites/Background", typeof(Sprite)) as UnityEngine.Sprite;
		_image.color = new Color (255f, 255f, 255f, 0.2f);
		_image.type = Image.Type.Sliced;
		_image.fillCenter = true;
		_image.transform.position = new Vector3( 10f, 10f,10f );

		_trans = transform;
		_qTrans = _trans.localRotation;

//		Color gray = new Color (125f, 125f, 125f, 1f);
//		Color blue = new Color (0f, 0f, 255f, 1f);

		//Adding the slider component
		_c2GO.AddComponent<Slider> ();
		Slider _slider = _c2GO.GetComponent<Slider> ();
		_slider.transform.position = new Vector3( 15f, 15f,10f );
		_slider.direction = Slider.Direction.LeftToRight;
		_slider.transition = Slider.Transition.ColorTint;
		_slider.targetGraphic = UnityEngine.Resources.Load (@"Sprites/SliderBackgroundSprite") as Image;
//		_slider.colors.normalColor = white;
//		_slider.colors.highlightedColor = white;
//		_slider.colors.pressedColor = gray;
//		_slider.colors.disabledColor = blue;
//		_slider.colors.colorMultiplier = 1f;
//		_slider.colors.fadeDuration = 0.1f;
		_slider.minValue = 0f;
		_slider.maxValue = 20f;
		_slider.interactable = true;
		//_slider.fillRect = UnityEngine.Resources.Load (@"Sprites/Background") as UnityEngine.RectTransform;
		//_slider.handleRect =  UnityEngine.Resources.Load (@"Sprites/Background") as UnityEngine.RectTransform;

		RectTransform _sliderRT = _gameObject.GetComponent<RectTransform> ();
		_sliderRT.position = new Vector3 (-10f, -42f, 0f);
		_sliderRT.pivot = new Vector2 (0.5f, 0.5f);
		_sliderRT.sizeDelta = new Vector2 (160f, 20f);
		_sliderRT.localPosition = new Vector2 (-10f, -42f);

		_slider.fillRect = _sliderRT as UnityEngine.RectTransform;
		_slider.handleRect = _sliderRT as UnityEngine.RectTransform;
		_slider.navigation = Navigation.defaultNavigation;

//		_slider.image = UnityEngine.Resources.Load (@"Sprites/SliderBackgroundSprite") as Image;


		//_slider.GetComponent<RectTransform> ().localPosition (-10f, -42f);
		_slider.GetComponentInParent<RectTransform> ();
		_slider.transform.localPosition = new Vector2( -10f, -42f );

		//		_text.rectTransform.sizeDelta = new Vector2( 100f, 100f );
		//		_text.rectTransform.Rotate(0f,10f,0f);
		
		//		_gameObject.GetComponent<RectTransform>().SetParent(this.transform, false);
		//		_gameObject.transform.localRotation = Quaternion.Angle (0, 90);
		
		//		RectTransform _canvasRT = _gameObject.GetComponent<RectTransform>();
		//		_canvasRT.anchoredPosition3D = new Vector3( 0f, 0f, 0f );
		//		_canvasRT.sizeDelta = new Vector2( 0f, 0f );
		//		_canvasRT.anchorMax = new Vector2( 1f, 1f );
		//		_canvasRT.anchorMin = new Vector2( 0f, 0f );
		
		//_canvasRT.transform.Rotate(100f,1000f,100f);
		_c3GO.AddComponent<Button> ();
		_myButton = _c3GO.GetComponent<Button> ();
//		_myButton.image = UnityEngine.Resources.Load (@"Sprites/UIButtonDefault") as Image;
//		_myButton.targetGraphic = UnityEngine.Resources.Load (@"Sprites/UIButtonDefault") as Image;
		_myButton.navigation = Navigation.defaultNavigation;
		_myButton.transform.localPosition = new Vector2 (-248f, 204f);
		_myButton.targetGraphic = UnityEngine.Resources.Load (@"Sprites/UIButtonDefault") as Graphic;
//		_myButton.transition = Selectable.Transition.SpriteSwap;
//		_myButton.spriteState.highlightedSprite = UnityEngine.Resources.Load (@"Sprites/UIButtonDefault", typeof(Sprite)) as Sprite;
		_c3GO.AddComponent<SpriteRenderer> ();
		_c3GO.GetComponent<SpriteRenderer> ().sprite = onNormalButton;
		_myButton.onClick.AddListener (() => {
			switchSprites ();});

		_c3GO.transform.parent = _c3GO.transform;
		_c3GO.AddComponent<Image> ();
		Image _myImg = _c3GO.GetComponent<Image> ();
		_myImg.sprite = UnityEngine.Resources.Load (@"Sprites/UIButtonDefault", typeof(Sprite)) as UnityEngine.Sprite;
		_myImg.color = new Color (255f, 255f, 255f, 0.5f);
		_myImg.type = Image.Type.Sliced;
		_myImg.fillCenter = true;
		//_image.transform.position = new Vector3( 10f, 10f,10f );



		_c3ChildGO.transform.parent = _c3GO.transform;
		_c3ChildGO.AddComponent<Text> ();
		Text _buttonText = _c3ChildGO.GetComponent<Text> ();
		_buttonText.text = "HaHa";
		_buttonText.font = UnityEngine.Resources.Load( @"Fonts/TitilliumWeb-Black" ) as UnityEngine.Font;
		_buttonText.color = Color.red;
		_buttonText.fontSize = 36;
		//_buttonText.transform.position = new Vector2( 10f, 10f );



		_canvas.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Input.mousePosition;
		
		float halfWidth = Screen.width * 0.5f;
		float halfHeight = Screen.height * 0.5f;
		float x = Mathf.Clamp((pos.x - 2 * halfWidth), -1f, 1f);
		float y = Mathf.Clamp((pos.y - 2 * halfHeight), -1f, 1f);
		_rot = Vector2.Lerp(_rot, new Vector2(x, y), Time.deltaTime * 5f);

		////
		/// 
		_myButton.onClick.AddListener(() => switchSprites());			
		
		_trans.localRotation = _qTrans * Quaternion.Euler(-_rot.y * range.y, _rot.x * range.x, 0f);
	}

	public void switchSprites()
	{
		_myButton.gameObject.GetComponent<SpriteRenderer> ().sprite = onPressedButton;
	}
}
