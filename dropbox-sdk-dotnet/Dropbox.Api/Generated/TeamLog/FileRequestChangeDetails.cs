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
    /// <para>Changed file request.</para>
    /// </summary>
    public class FileRequestChangeDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestChangeDetails> Encoder = new FileRequestChangeDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestChangeDetails> Decoder = new FileRequestChangeDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestChangeDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newDetails">New file request details.</param>
        /// <param name="fileRequestId">File request id. Might be missing due to historical
        /// data gap.</param>
        /// <param name="previousDetails">Previous file request details. Might be missing due
        /// to historical data gap.</param>
        public FileRequestChangeDetails(FileRequestDetails newDetails,
                                        string fileRequestId = null,
                                        FileRequestDetails previousDetails = null)
        {
            if (newDetails == null)
            {
                throw new sys.ArgumentNullException("newDetails");
            }

            if (fileRequestId != null)
            {
                if (fileRequestId.Length < 1)
                {
                    throw new sys.ArgumentOutOfRangeException("fileRequestId", "Length should be at least 1");
                }
                if (!re.Regex.IsMatch(fileRequestId, @"\A(?:[-_0-9a-zA-Z]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("fileRequestId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z]+)\z'");
                }
            }

            this.NewDetails = newDetails;
            this.FileRequestId = fileRequestId;
            this.PreviousDetails = previousDetails;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestChangeDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRequestChangeDetails()
        {
        }

        /// <summary>
        /// <para>New file request details.</para>
        /// </summary>
        public FileRequestDetails NewDetails { get; protected set; }

        /// <summary>
        /// <para>File request id. Might be missing due to historical data gap.</para>
        /// </summary>
        public string FileRequestId { get; protected set; }

        /// <summary>
        /// <para>Previous file request details. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public FileRequestDetails PreviousDetails { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestChangeDetails" />.</para>
        /// </summary>
        private class FileRequestChangeDetailsEncoder : enc.StructEncoder<FileRequestChangeDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestChangeDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_details", value.NewDetails, writer, global::Dropbox.Api.TeamLog.FileRequestDetails.Encoder);
                if (value.FileRequestId != null)
                {
                    WriteProperty("file_request_id", value.FileRequestId, writer, enc.StringEncoder.Instance);
                }
                if (value.PreviousDetails != null)
                {
                    WriteProperty("previous_details", value.PreviousDetails, writer, global::Dropbox.Api.TeamLog.FileRequestDetails.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestChangeDetails" />.</para>
        /// </summary>
        private class FileRequestChangeDetailsDecoder : enc.StructDecoder<FileRequestChangeDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileRequestChangeDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestChangeDetails Create()
            {
                return new FileRequestChangeDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestChangeDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_details":
                        value.NewDetails = global::Dropbox.Api.TeamLog.FileRequestDetails.Decoder.Decode(reader);
                        break;
                    case "file_request_id":
                        value.FileRequestId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_details":
                        value.PreviousDetails = global::Dropbox.Api.TeamLog.FileRequestDetails.Decoder.Decode(reader);
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
