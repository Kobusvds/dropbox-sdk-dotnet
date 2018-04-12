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
    /// <para>Refreshed auth token used for setting up enterprise mobility management.</para>
    /// </summary>
    public class EmmRefreshAuthTokenDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EmmRefreshAuthTokenDetails> Encoder = new EmmRefreshAuthTokenDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EmmRefreshAuthTokenDetails> Decoder = new EmmRefreshAuthTokenDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmmRefreshAuthTokenDetails" />
        /// class.</para>
        /// </summary>
        public EmmRefreshAuthTokenDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EmmRefreshAuthTokenDetails" />.</para>
        /// </summary>
        private class EmmRefreshAuthTokenDetailsEncoder : enc.StructEncoder<EmmRefreshAuthTokenDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EmmRefreshAuthTokenDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EmmRefreshAuthTokenDetails" />.</para>
        /// </summary>
        private class EmmRefreshAuthTokenDetailsDecoder : enc.StructDecoder<EmmRefreshAuthTokenDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="EmmRefreshAuthTokenDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EmmRefreshAuthTokenDetails Create()
            {
                return new EmmRefreshAuthTokenDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EmmRefreshAuthTokenDetails value, string fieldName, enc.IJsonReader reader)
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
