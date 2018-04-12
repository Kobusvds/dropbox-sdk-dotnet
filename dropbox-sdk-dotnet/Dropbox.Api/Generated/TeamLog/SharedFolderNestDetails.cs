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
    /// <para>Changed parent of shared folder.</para>
    /// </summary>
    public class SharedFolderNestDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderNestDetails> Encoder = new SharedFolderNestDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderNestDetails> Decoder = new SharedFolderNestDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderNestDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="previousParentNsId">Previous parent namespace ID. Might be missing due
        /// to historical data gap.</param>
        /// <param name="newParentNsId">New parent namespace ID. Might be missing due to
        /// historical data gap.</param>
        public SharedFolderNestDetails(string previousParentNsId = null,
                                       string newParentNsId = null)
        {
            this.PreviousParentNsId = previousParentNsId;
            this.NewParentNsId = newParentNsId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderNestDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderNestDetails()
        {
        }

        /// <summary>
        /// <para>Previous parent namespace ID. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public string PreviousParentNsId { get; protected set; }

        /// <summary>
        /// <para>New parent namespace ID. Might be missing due to historical data gap.</para>
        /// </summary>
        public string NewParentNsId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderNestDetails" />.</para>
        /// </summary>
        private class SharedFolderNestDetailsEncoder : enc.StructEncoder<SharedFolderNestDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderNestDetails value, enc.IJsonWriter writer)
            {
                if (value.PreviousParentNsId != null)
                {
                    WriteProperty("previous_parent_ns_id", value.PreviousParentNsId, writer, enc.StringEncoder.Instance);
                }
                if (value.NewParentNsId != null)
                {
                    WriteProperty("new_parent_ns_id", value.NewParentNsId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderNestDetails" />.</para>
        /// </summary>
        private class SharedFolderNestDetailsDecoder : enc.StructDecoder<SharedFolderNestDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderNestDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderNestDetails Create()
            {
                return new SharedFolderNestDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderNestDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_parent_ns_id":
                        value.PreviousParentNsId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_parent_ns_id":
                        value.NewParentNsId = enc.StringDecoder.Instance.Decode(reader);
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
