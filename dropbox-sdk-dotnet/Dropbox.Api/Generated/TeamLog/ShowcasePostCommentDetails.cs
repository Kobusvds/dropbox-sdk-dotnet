// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Added showcase comment.</para>
    /// </summary>
    public class ShowcasePostCommentDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShowcasePostCommentDetails> Encoder = new ShowcasePostCommentDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShowcasePostCommentDetails> Decoder = new ShowcasePostCommentDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcasePostCommentDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        /// <param name="commentText">Comment text.</param>
        public ShowcasePostCommentDetails(string eventUuid,
                                          string commentText = null)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            this.EventUuid = eventUuid;
            this.CommentText = commentText;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcasePostCommentDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ShowcasePostCommentDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        /// <summary>
        /// <para>Comment text.</para>
        /// </summary>
        public string CommentText { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShowcasePostCommentDetails" />.</para>
        /// </summary>
        private class ShowcasePostCommentDetailsEncoder : enc.StructEncoder<ShowcasePostCommentDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShowcasePostCommentDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
                if (value.CommentText != null)
                {
                    WriteProperty("comment_text", value.CommentText, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShowcasePostCommentDetails" />.</para>
        /// </summary>
        private class ShowcasePostCommentDetailsDecoder : enc.StructDecoder<ShowcasePostCommentDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShowcasePostCommentDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShowcasePostCommentDetails Create()
            {
                return new ShowcasePostCommentDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShowcasePostCommentDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "comment_text":
                        value.CommentText = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
