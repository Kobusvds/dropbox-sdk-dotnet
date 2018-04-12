// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The create folder batch result object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Files.FileOpsResult" />
    public class CreateFolderBatchResult : FileOpsResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CreateFolderBatchResult> Encoder = new CreateFolderBatchResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CreateFolderBatchResult> Decoder = new CreateFolderBatchResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderBatchResult" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">The entries</param>
        public CreateFolderBatchResult(col.IEnumerable<CreateFolderBatchResultEntry> entries)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderBatchResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CreateFolderBatchResult()
        {
        }

        /// <summary>
        /// <para>Gets the entries of the create folder batch result</para>
        /// </summary>
        public col.IList<CreateFolderBatchResultEntry> Entries { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CreateFolderBatchResult" />.</para>
        /// </summary>
        private class CreateFolderBatchResultEncoder : enc.StructEncoder<CreateFolderBatchResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CreateFolderBatchResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("entries", value.Entries, writer, global::Dropbox.Api.Files.CreateFolderBatchResultEntry.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CreateFolderBatchResult" />.</para>
        /// </summary>
        private class CreateFolderBatchResultDecoder : enc.StructDecoder<CreateFolderBatchResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CreateFolderBatchResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CreateFolderBatchResult Create()
            {
                return new CreateFolderBatchResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CreateFolderBatchResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "entries":
                        value.Entries = ReadList<CreateFolderBatchResultEntry>(reader, global::Dropbox.Api.Files.CreateFolderBatchResultEntry.Decoder);
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
