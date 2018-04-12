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
    /// <para>The shared folder change members management policy type object</para>
    /// </summary>
    public class SharedFolderChangeMembersManagementPolicyType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderChangeMembersManagementPolicyType> Encoder = new SharedFolderChangeMembersManagementPolicyTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderChangeMembersManagementPolicyType> Decoder = new SharedFolderChangeMembersManagementPolicyTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMembersManagementPolicyType" /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SharedFolderChangeMembersManagementPolicyType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMembersManagementPolicyType" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderChangeMembersManagementPolicyType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the shared folder change members management policy
        /// type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderChangeMembersManagementPolicyType"
        /// />.</para>
        /// </summary>
        private class SharedFolderChangeMembersManagementPolicyTypeEncoder : enc.StructEncoder<SharedFolderChangeMembersManagementPolicyType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderChangeMembersManagementPolicyType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderChangeMembersManagementPolicyType"
        /// />.</para>
        /// </summary>
        private class SharedFolderChangeMembersManagementPolicyTypeDecoder : enc.StructDecoder<SharedFolderChangeMembersManagementPolicyType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedFolderChangeMembersManagementPolicyType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderChangeMembersManagementPolicyType Create()
            {
                return new SharedFolderChangeMembersManagementPolicyType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderChangeMembersManagementPolicyType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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
