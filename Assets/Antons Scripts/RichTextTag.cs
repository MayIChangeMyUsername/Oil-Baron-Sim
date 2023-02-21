using System.Collections;
using UnityEngine;

public class RichTextTag
{
    public static readonly RichTextTag ClearColorTag = new RichTextTag("<color=#00000000>");

    private const char OpeningNodeDelimeter = '<';
    private const char CloseNodeDelimeter = '>';
    private const char EndTagDelimeter = '/';
    private const char ParameterDelimeter = '=';

    public RichTextTag(string tagText)
    {
        this.TagText = tagText;
    }

    public string TagText { get; private set; }

    public string ClosingTagText
    {
        get
        {
            return this.IsClosingTag ? this.TagText : string.Format("</{0}>", this.TagType);
        }
    }

    public string TagType
    {
        get
        {
            var tagType = this.TagText.Substring(1, this.TagText.Length - 2);
            tagType = tagType.TrimStart(EndTagDelimeter);

            var tagEndDelimeters = new char[] { ' ', ParameterDelimeter };
            var delimeterIndex = tagType.IndexOfAny(tagEndDelimeters);
            var tagEndIndex = delimeterIndex > 0 ? delimeterIndex : tagType.Length;
            tagType = tagType.Substring(0, tagEndIndex);

            return tagType;
        }
    }

    public string Parameter
    {
        get
        {
            var parameterDelimeterIndex = this.TagText.IndexOf(ParameterDelimeter);
            if (parameterDelimeterIndex < 0)
            {
                return string.Empty;
            }

            var parameterLength = this.TagText.Length - parameterDelimeterIndex - 2;
            var parameter = this.TagText.Substring(parameterDelimeterIndex + 1, parameterLength);

            if (parameter.Length > 0)
            {
                if (parameter[0] == '\"' && parameter[parameter.Length - 1] == '\"')
                {
                    parameter = parameter.Substring(1, parameter.Length - 2);
                }
            }

            return parameter;
        }
    }

    public bool IsOpeningTag
    {
        get
        {
            return !this.IsClosingTag;
        }
    }

    public bool IsClosingTag
    {
        get
        {
            return this.TagText.Length > 2 && this.TagText[1] == EndTagDelimeter;
        }
    }

    public int Length
    {
        get
        {
            return this.TagText.Length;
        }
    }

    public static bool StringStartsWithTag(string text)
    {
        return text.StartsWith(RichTextTag.OpeningNodeDelimeter.ToString());
    }

    public static RichTextTag ParseNext(string text)
    {
        var openingDelimeterIndex = text.IndexOf(RichTextTag.OpeningNodeDelimeter);

        if (openingDelimeterIndex < 0)
        {
            return null;
        }

        var closingDelimeterIndex = text.IndexOf(RichTextTag.CloseNodeDelimeter);

        if (closingDelimeterIndex < 0)
        {
            return null;
        }

        var tagText = text.Substring(openingDelimeterIndex, closingDelimeterIndex - openingDelimeterIndex + 1);
        return new RichTextTag(tagText);
    }

    public static string RemoveTagsFromString(string text, string tagType)
    {
        var bodyWithoutTags = text;
        for (int i = 0; i < text.Length; ++i)
        {
            var remainingText = text.Substring(i, text.Length - i);
            if (StringStartsWithTag(remainingText))
            {
                var parsedTag = ParseNext(remainingText);
                if (parsedTag.TagType == tagType)
                {
                    bodyWithoutTags = bodyWithoutTags.Replace(parsedTag.TagText, string.Empty);
                }

                i += parsedTag.Length - 1;
            }
        }

        return bodyWithoutTags;
    }

    public override string ToString()
    {
        return this.TagText;
    }
}