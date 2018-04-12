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
    /// <para>Permanently deleted contents of deleted team member account.</para>
    /// </summary>
    public class MemberPermanentlyDeleteAccountContentsDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberPermanentlyDeleteAccountContentsDetails> Encoder = new MemberPermanentlyDeleteAccountContentsDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberPermanentlyDeleteAccountContentsDetails> Decoder = new MemberPermanentlyDeleteAccountContentsDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberPermanentlyDeleteAccountContentsDetails" /> class.</para>
        /// </summary>
        public MemberPermanentlyDeleteAccountContentsDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberPermanentlyDeleteAccountContentsDetails"
        /// />.</para>
        /// </summary>
        private class MemberPermanentlyDeleteAccountContentsDetailsEncoder : enc.StructEncoder<MemberPermanentlyDeleteAccountContentsDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberPermanentlyDeleteAccountContentsDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberPermanentlyDeleteAccountContentsDetails"
        /// />.</para>
        /// </summary>
        private class MemberPermanentlyDeleteAccountContentsDetailsDecoder : enc.StructDecoder<MemberPermanentlyDeleteAccountContentsDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberPermanentlyDeleteAccountContentsDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberPermanentlyDeleteAccountContentsDetails Create()
            {
                return new MemberPermanentlyDeleteAccountContentsDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberPermanentlyDeleteAccountContentsDetails value, string fieldName, enc.IJsonReader reader)
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
