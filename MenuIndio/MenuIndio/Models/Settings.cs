using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuIndio.Models
{
    public static class Settings
    {

        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private const string TipoDocumentoKey = "tipodocumento_key";
        private const string NroDocumentoKey = "nrodocumento_key";
        private const string PasswordKey = "password_key";
        private static readonly string SettingsDefault = string.Empty;
        private const string IsLoggedInTokenKey = "isloggedid_key";
        private static readonly bool IsLoggedInTokenDefault = false;

        #endregion


        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

        public static string UltimoTipoDocumentoUsado
        {
            get
            {
                return AppSettings.GetValueOrDefault(TipoDocumentoKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(TipoDocumentoKey, value);
            }
        }

        public static string UltimoDocumentoUsado
        {
            get
            {
                return AppSettings.GetValueOrDefault(NroDocumentoKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(NroDocumentoKey, value);
            }
        }


        public static string UltimaPasswordUsada
        {
            get
            {
                return AppSettings.GetValueOrDefault(PasswordKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(PasswordKey, value);
            }
        }

        public static bool IsLoggedIn
        {
            get { return AppSettings.GetValueOrDefault(IsLoggedInTokenKey, IsLoggedInTokenDefault); }
            set { AppSettings.AddOrUpdateValue(IsLoggedInTokenKey, value); }
        }

    }
}
