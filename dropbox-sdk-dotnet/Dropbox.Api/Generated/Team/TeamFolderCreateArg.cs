// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The team folder create arg object</para>
    /// </summary>
    public class TeamFolderCreateArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderCreateArg> Encoder = new TeamFolderCreateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderCreateArg> Decoder = new TeamFolderCreateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderCreateArg" />
        /// class.</para>
        /// </summary>
        /// <param name="name">Name for the new team folder.</param>
        /// <param name="syncSetting">The sync setting to apply to this team folder. Only
        /// permitted if the team has team selective sync enabled.</param>
        public TeamFolderCreateArg(string name,
                                   global::Dropbox.Api.Files.SyncSettingArg syncSetting = null)
        {
            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            this.Name = name;
            this.SyncSetting = syncSetting;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderCreateArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamFolderCreateArg()
        {
        }

        /// <summary>
        /// <para>Name for the new team folder.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>The sync setting to apply to this team folder. Only permitted if the team has
        /// team selective sync enabled.</para>
        /// </summary>
        public global::Dropbox.Api.Files.SyncSettingArg SyncSetting { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderCreateArg" />.</para>
        /// </summary>
        private class TeamFolderCreateArgEncoder : enc.StructEncoder<TeamFolderCreateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderCreateArg value, enc.IJsonWriter writer)
            {
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                if (value.SyncSetting != null)
                {
                    WriteProperty("sync_setting", value.SyncSetting, writer, global::Dropbox.Api.Files.SyncSettingArg.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderCreateArg" />.</para>
        /// </summary>
        private class TeamFolderCreateArgDecoder : enc.StructDecoder<TeamFolderCreateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderCreateArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderCreateArg Create()
            {
                return new TeamFolderCreateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamFolderCreateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "sync_setting":
                        value.SyncSetting = global::Dropbox.Api.Files.SyncSettingArg.Decoder.Decode(reader);
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
