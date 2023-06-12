using UnityEngine;

public class BlockScore : MonoBehaviour
{
    [SerializeField] private int _orderInLayer = 0;
    [SerializeField] float _xpos;
    [SerializeField] float _xpos2;
    [SerializeField] float _ypos;
    [SerializeField] float _ypos2;
    [SerializeField]
    int _score1 = 1;
    bool _switch = true;

    SpriteRenderer _obg = default;
    public GameObject obg;

    BoxCollider2D _boxCollider;
    

    // Start is called before the first frame update
    void Start()
    {
        float _random1 = Random.Range(_xpos, _xpos2);
        float _random2 = Random.Range(_ypos, _ypos2);


        _obg = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
        transform.position = new Vector2(_random1, _random2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _obg.color = Color.white;
            _boxCollider.enabled = true;

            //spriteRenderer.sortingOrder ... OrderInLayerÇÃílÇéQè∆Ç∑ÇÈ
            _obg.sortingOrder = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            _obg.color = Color.black;
            _obg.sortingOrder = _orderInLayer;
            _boxCollider.enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_switch)
        {
            if (collision.gameObject.tag == "Player")
            {
                PlayerScore playerScore = collision.gameObject.GetComponent<PlayerScore>();
                playerScore.AddScore(_score1);
                
                _switch = false;
                //Debug.Log(_score1);
            }
        }
    }
}
