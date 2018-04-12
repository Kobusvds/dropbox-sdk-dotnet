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
    /// <para>Enabled "Automatically invite new users".</para>
    /// </summary>
    public class DomainInvitesSetInviteNewUserPrefToYesDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DomainInvitesSetInviteNewUserPrefToYesDetails> Encoder = new DomainInvitesSetInviteNewUserPrefToYesDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DomainInvitesSetInviteNewUserPrefToYesDetails> Decoder = new DomainInvitesSetInviteNewUserPrefToYesDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainInvitesSetInviteNewUserPrefToYesDetails" /> class.</para>
        /// </summary>
        public DomainInvitesSetInviteNewUserPrefToYesDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DomainInvitesSetInviteNewUserPrefToYesDetails"
        /// />.</para>
        /// </summary>
        private class DomainInvitesSetInviteNewUserPrefToYesDetailsEncoder : enc.StructEncoder<DomainInvitesSetInviteNewUserPrefToYesDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DomainInvitesSetInviteNewUserPrefToYesDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DomainInvitesSetInviteNewUserPrefToYesDetails"
        /// />.</para>
        /// </summary>
        private class DomainInvitesSetInviteNewUserPrefToYesDetailsDecoder : enc.StructDecoder<DomainInvitesSetInviteNewUserPrefToYesDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DomainInvitesSetInviteNewUserPrefToYesDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DomainInvitesSetInviteNewUserPrefToYesDetails Create()
            {
                return new DomainInvitesSetInviteNewUserPrefToYesDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DomainInvitesSetInviteNewUserPrefToYesDetails value, string fieldName, enc.IJsonReader reader)
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
