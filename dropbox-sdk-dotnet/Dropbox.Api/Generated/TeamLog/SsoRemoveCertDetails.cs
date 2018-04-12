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
    /// <para>Removed X.509 certificate for SSO.</para>
    /// </summary>
    public class SsoRemoveCertDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoRemoveCertDetails> Encoder = new SsoRemoveCertDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoRemoveCertDetails> Decoder = new SsoRemoveCertDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoRemoveCertDetails" />
        /// class.</para>
        /// </summary>
        public SsoRemoveCertDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoRemoveCertDetails" />.</para>
        /// </summary>
        private class SsoRemoveCertDetailsEncoder : enc.StructEncoder<SsoRemoveCertDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoRemoveCertDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoRemoveCertDetails" />.</para>
        /// </summary>
        private class SsoRemoveCertDetailsDecoder : enc.StructDecoder<SsoRemoveCertDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SsoRemoveCertDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoRemoveCertDetails Create()
            {
                return new SsoRemoveCertDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoRemoveCertDetails value, string fieldName, enc.IJsonReader reader)
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
