// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The paper doc permission level object</para>
    /// </summary>
    public class PaperDocPermissionLevel
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperDocPermissionLevel> Encoder = new PaperDocPermissionLevelEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperDocPermissionLevel> Decoder = new PaperDocPermissionLevelDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocPermissionLevel" />
        /// class.</para>
        /// </summary>
        public PaperDocPermissionLevel()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Edit</para>
        /// </summary>
        public bool IsEdit
        {
            get
            {
                return this is Edit;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Edit, or <c>null</c>.</para>
        /// </summary>
        public Edit AsEdit
        {
            get
            {
                return this as Edit;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ViewAndComment</para>
        /// </summary>
        public bool IsViewAndComment
        {
            get
            {
                return this is ViewAndComment;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ViewAndComment, or <c>null</c>.</para>
        /// </summary>
        public ViewAndComment AsViewAndComment
        {
            get
            {
                return this as ViewAndComment;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperDocPermissionLevel" />.</para>
        /// </summary>
        private class PaperDocPermissionLevelEncoder : enc.StructEncoder<PaperDocPermissionLevel>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperDocPermissionLevel value, enc.IJsonWriter writer)
            {
                if (value is Edit)
                {
                    WriteProperty(".tag", "edit", writer, enc.StringEncoder.Instance);
                    Edit.Encoder.EncodeFields((Edit)value, writer);
                    return;
                }
                if (value is ViewAndComment)
                {
                    WriteProperty(".tag", "view_and_comment", writer, enc.StringEncoder.Instance);
                    ViewAndComment.Encoder.EncodeFields((ViewAndComment)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperDocPermissionLevel" />.</para>
        /// </summary>
        private class PaperDocPermissionLevelDecoder : enc.UnionDecoder<PaperDocPermissionLevel>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperDocPermissionLevel"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperDocPermissionLevel Create()
            {
                return new PaperDocPermissionLevel();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PaperDocPermissionLevel Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "edit":
                        return Edit.Decoder.DecodeFields(reader);
                    case "view_and_comment":
                        return ViewAndComment.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>User will be granted edit permissions.</para>
        /// </summary>
        public sealed class Edit : PaperDocPermissionLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Edit> Encoder = new EditEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Edit> Decoder = new EditDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Edit" /> class.</para>
            /// </summary>
            private Edit()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Edit</para>
            /// </summary>
            public static readonly Edit Instance = new Edit();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Edit" />.</para>
            /// </summary>
            private class EditEncoder : enc.StructEncoder<Edit>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Edit value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Edit" />.</para>
            /// </summary>
            private class EditDecoder : enc.StructDecoder<Edit>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Edit" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Edit Create()
                {
                    return Edit.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>User will be granted view and comment permissions.</para>
        /// </summary>
        public sealed class ViewAndComment : PaperDocPermissionLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ViewAndComment> Encoder = new ViewAndCommentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ViewAndComment> Decoder = new ViewAndCommentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ViewAndComment" />
            /// class.</para>
            /// </summary>
            private ViewAndComment()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ViewAndComment</para>
            /// </summary>
            public static readonly ViewAndComment Instance = new ViewAndComment();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ViewAndComment" />.</para>
            /// </summary>
            private class ViewAndCommentEncoder : enc.StructEncoder<ViewAndComment>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ViewAndComment value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ViewAndComment" />.</para>
            /// </summary>
            private class ViewAndCommentDecoder : enc.StructDecoder<ViewAndComment>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ViewAndComment" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ViewAndComment Create()
                {
                    return ViewAndComment.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PaperDocPermissionLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
