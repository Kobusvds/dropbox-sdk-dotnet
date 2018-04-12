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
    /// <para>Previewed shared file/folder.</para>
    /// </summary>
    public class SharedContentViewDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentViewDetails> Encoder = new SharedContentViewDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentViewDetails> Decoder = new SharedContentViewDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentViewDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedContentLink">Shared content link.</param>
        /// <param name="sharedContentAccessLevel">Shared content access level.</param>
        /// <param name="sharedContentOwner">The shared content owner.</param>
        public SharedContentViewDetails(string sharedContentLink,
                                        global::Dropbox.Api.Sharing.AccessLevel sharedContentAccessLevel,
                                        UserLogInfo sharedContentOwner = null)
        {
            if (sharedContentLink == null)
            {
                throw new sys.ArgumentNullException("sharedContentLink");
            }

            if (sharedContentAccessLevel == null)
            {
                throw new sys.ArgumentNullException("sharedContentAccessLevel");
            }

            this.SharedContentLink = sharedContentLink;
            this.SharedContentAccessLevel = sharedContentAccessLevel;
            this.SharedContentOwner = sharedContentOwner;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentViewDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentViewDetails()
        {
        }

        /// <summary>
        /// <para>Shared content link.</para>
        /// </summary>
        public string SharedContentLink { get; protected set; }

        /// <summary>
        /// <para>Shared content access level.</para>
        /// </summary>
        public global::Dropbox.Api.Sharing.AccessLevel SharedContentAccessLevel { get; protected set; }

        /// <summary>
        /// <para>The shared content owner.</para>
        /// </summary>
        public UserLogInfo SharedContentOwner { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentViewDetails" />.</para>
        /// </summary>
        private class SharedContentViewDetailsEncoder : enc.StructEncoder<SharedContentViewDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentViewDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_content_link", value.SharedContentLink, writer, enc.StringEncoder.Instance);
                WriteProperty("shared_content_access_level", value.SharedContentAccessLevel, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
                if (value.SharedContentOwner != null)
                {
                    WriteProperty("shared_content_owner", value.SharedContentOwner, writer, global::Dropbox.Api.TeamLog.UserLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentViewDetails" />.</para>
        /// </summary>
        private class SharedContentViewDetailsDecoder : enc.StructDecoder<SharedContentViewDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedContentViewDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentViewDetails Create()
            {
                return new SharedContentViewDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentViewDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_content_link":
                        value.SharedContentLink = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_content_access_level":
                        value.SharedContentAccessLevel = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "shared_content_owner":
                        value.SharedContentOwner = global::Dropbox.Api.TeamLog.UserLogInfo.Decoder.Decode(reader);
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
