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
    /// <para>Created copy reference to file/folder.</para>
    /// </summary>
    public class FileGetCopyReferenceDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileGetCopyReferenceDetails> Encoder = new FileGetCopyReferenceDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileGetCopyReferenceDetails> Decoder = new FileGetCopyReferenceDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileGetCopyReferenceDetails" />
        /// class.</para>
        /// </summary>
        public FileGetCopyReferenceDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileGetCopyReferenceDetails" />.</para>
        /// </summary>
        private class FileGetCopyReferenceDetailsEncoder : enc.StructEncoder<FileGetCopyReferenceDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileGetCopyReferenceDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileGetCopyReferenceDetails" />.</para>
        /// </summary>
        private class FileGetCopyReferenceDetailsDecoder : enc.StructDecoder<FileGetCopyReferenceDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileGetCopyReferenceDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileGetCopyReferenceDetails Create()
            {
                return new FileGetCopyReferenceDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileGetCopyReferenceDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
