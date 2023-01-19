using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public abstract class TextAnimation : MonoBehaviour
{
    [Tooltip("0-based index of the first printable character that should be animated")]
    [SerializeField]
    private int firstCharToAnimate;

    [Tooltip("0-based index of the last printable character that should be animated")]
    [SerializeField]
    private int lastCharToAnimate;

    [Tooltip("If true, animation will begin playing immediately on Awake")]
    [SerializeField]
    private bool playOnAwake = false;

    private const float frameRate = 15f;
    private static readonly float timeBetweenAnimates = 1f / frameRate;

    private float lastAnimateTime;
    private TextMeshProUGUI textComponent;
    private TMP_TextInfo textInfo;
    private TMP_MeshInfo[] cachedMeshInfo;

    public bool UseUnscaledTime { get; set; }

    protected int FirstCharToAnimate
    {
        get
        {
            return this.firstCharToAnimate;
        }
    }
    protected int LastCharToAnimate
    {
        get
        {
            return this.lastCharToAnimate;
        }
    }

    private TextMeshProUGUI TextComponent
    {
        get
        {
            if (this.textComponent == null)
            {
                this.textComponent = this.GetComponent<TextMeshProUGUI>();
            }

            return this.textComponent;
        }
    }

    protected float TimeForTimeScale
    {
        get
        {
            return this.UseUnscaledTime ? Time.realtimeSinceStartup : Time.time;
        }
    }

    public void SetCharsToAnimate(int firstChar, int lastChar)
    {
        this.firstCharToAnimate = firstChar;
        this.lastCharToAnimate = lastChar;
    }

    public void CacheTextMeshInfo()
    {
        this.textInfo = this.TextComponent.textInfo;
        this.cachedMeshInfo = this.textInfo.CopyMeshInfoVertexData();
    }

    protected virtual void Awake()
    {
        this.enabled = this.playOnAwake;
    }

    protected virtual void Start()
    {
        this.TextComponent.ForceMeshUpdate();
        this.lastAnimateTime = float.MinValue;
    }

    protected virtual void OnEnable()
    {
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(OnTMProChanged);
    }

    protected virtual void OnDisable()
    {
        TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(OnTMProChanged);

        this.TextComponent.ForceMeshUpdate();
    }

    protected virtual void Update()
    {
        if (this.TimeForTimeScale > this.lastAnimateTime + timeBetweenAnimates)
        {
            this.AnimateAllChars();
        }
    }

    protected abstract void Animate(int characterIndex, out Vector2 translation, out float rotation, out float scale);

    public void AnimateAllChars()
    {
        this.lastAnimateTime = this.TimeForTimeScale;

        int characterCount = this.textInfo.characterCount;

        if (characterCount == 0)
        {
            return;
        }

        for (int i = 0; i < characterCount; i++)
        {
            if (i < this.firstCharToAnimate || i > this.lastCharToAnimate)
            {
                continue;
            }

            TMP_CharacterInfo charInfo = textInfo.characterInfo[i];

            if (!charInfo.isVisible)
            {
                continue;
            }

            int materialIndex = charInfo.materialReferenceIndex;

            int vertexIndex = charInfo.vertexIndex;

            Vector3[] sourceVertices = cachedMeshInfo[materialIndex].vertices;

            Vector2 charMidBasline = (sourceVertices[vertexIndex + 0] + sourceVertices[vertexIndex + 2]) / 2;

            Vector3 offset = charMidBasline;

            Vector3[] destinationVertices = textInfo.meshInfo[materialIndex].vertices;

            destinationVertices[vertexIndex + 0] = sourceVertices[vertexIndex + 0] - offset;
            destinationVertices[vertexIndex + 1] = sourceVertices[vertexIndex + 1] - offset;
            destinationVertices[vertexIndex + 2] = sourceVertices[vertexIndex + 2] - offset;
            destinationVertices[vertexIndex + 3] = sourceVertices[vertexIndex + 3] - offset;

            Vector2 translation;
            float rotation, scale;

            this.Animate(i, out translation, out rotation, out scale);
            Matrix4x4 matrix = Matrix4x4.TRS(translation, Quaternion.Euler(0f, 0f, rotation), scale * Vector3.one);

            destinationVertices[vertexIndex + 0] = matrix.MultiplyPoint3x4(destinationVertices[vertexIndex + 0]);
            destinationVertices[vertexIndex + 1] = matrix.MultiplyPoint3x4(destinationVertices[vertexIndex + 1]);
            destinationVertices[vertexIndex + 2] = matrix.MultiplyPoint3x4(destinationVertices[vertexIndex + 2]);
            destinationVertices[vertexIndex + 3] = matrix.MultiplyPoint3x4(destinationVertices[vertexIndex + 3]);

            
            destinationVertices[vertexIndex + 0] += offset;
            destinationVertices[vertexIndex + 1] += offset;
            destinationVertices[vertexIndex + 2] += offset;
            destinationVertices[vertexIndex + 3] += offset;
        }

        this.ApplyChangesToMesh();
    }

    private void ApplyChangesToMesh()
    {
        for (int i = 0; i < this.textInfo.meshInfo.Length; i++)
        {
            this.textInfo.meshInfo[i].mesh.vertices = this.textInfo.meshInfo[i].vertices;
            this.TextComponent.UpdateGeometry(this.textInfo.meshInfo[i].mesh, i);
        }
    }

    private void OnTMProChanged(Object obj)
    {
        if (obj == this.TextComponent)
        {
            this.CacheTextMeshInfo();
        }
    }
}
