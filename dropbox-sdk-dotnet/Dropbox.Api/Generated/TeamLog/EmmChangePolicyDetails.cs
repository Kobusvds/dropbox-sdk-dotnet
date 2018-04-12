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
    /// <para>Enabled/disabled enterprise mobility management for members.</para>
    /// </summary>
    public class EmmChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EmmChangePolicyDetails> Encoder = new EmmChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EmmChangePolicyDetails> Decoder = new EmmChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmmChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New enterprise mobility management policy.</param>
        /// <param name="previousValue">Previous enterprise mobility management policy. Might
        /// be missing due to historical data gap.</param>
        public EmmChangePolicyDetails(global::Dropbox.Api.TeamPolicies.EmmState newValue,
                                      global::Dropbox.Api.TeamPolicies.EmmState previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmmChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public EmmChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New enterprise mobility management policy.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.EmmState NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous enterprise mobility management policy. Might be missing due to
        /// historical data gap.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.EmmState PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EmmChangePolicyDetails" />.</para>
        /// </summary>
        private class EmmChangePolicyDetailsEncoder : enc.StructEncoder<EmmChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EmmChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamPolicies.EmmState.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamPolicies.EmmState.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EmmChangePolicyDetails" />.</para>
        /// </summary>
        private class EmmChangePolicyDetailsDecoder : enc.StructDecoder<EmmChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="EmmChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EmmChangePolicyDetails Create()
            {
                return new EmmChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EmmChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamPolicies.EmmState.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamPolicies.EmmState.Decoder.Decode(reader);
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
