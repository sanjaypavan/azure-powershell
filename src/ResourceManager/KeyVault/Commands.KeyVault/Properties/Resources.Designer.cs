﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.KeyVault.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.KeyVault.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the Active Directory object &apos;{0}&apos; in tenant &apos;{1}&apos;. Please make sure that the user or application service principal you are authorizing is registered in the current subscription&apos;s Azure Active directory. The TenantID displayed by the cmdlet &apos;get-AzureSubscription -current&apos; is the current subscription&apos;s Azure Active directory..
        /// </summary>
        internal static string ADObjectNotFound {
            get {
                return ResourceManager.GetString("ADObjectNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find backup key file &apos;{0}&apos;.
        /// </summary>
        internal static string BackupKeyFileNotFound {
            get {
                return ResourceManager.GetString("BackupKeyFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad Parameter Set Name.
        /// </summary>
        internal static string BadParameterSetName {
            get {
                return ResourceManager.GetString("BadParameterSetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BYOK key can not be imported as software key.
        /// </summary>
        internal static string ImportByokAsSoftkeyError {
            get {
                return ResourceManager.GetString("ImportByokAsSoftkeyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid AzureEnvironment..
        /// </summary>
        internal static string InvalidAzureEnvironment {
            get {
                return ResourceManager.GetString("InvalidAzureEnvironment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current subscription has been designated. Use Select-AzureSubscription -Current &lt;subscriptionName&gt; to set the current subscription..
        /// </summary>
        internal static string InvalidCurrentSubscription {
            get {
                return ResourceManager.GetString("InvalidCurrentSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key attributes.
        /// </summary>
        internal static string InvalidKeyAttributes {
            get {
                return ResourceManager.GetString("InvalidKeyAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid &apos;{0}&apos; key blob..
        /// </summary>
        internal static string InvalidKeyBlob {
            get {
                return ResourceManager.GetString("InvalidKeyBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid KeyBundle..
        /// </summary>
        internal static string InvalidKeyBundle {
            get {
                return ResourceManager.GetString("InvalidKeyBundle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not create given key material in specified destination..
        /// </summary>
        internal static string InvalidKeyDestination {
            get {
                return ResourceManager.GetString("InvalidKeyDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key identifier.
        /// </summary>
        internal static string InvalidKeyIdentifier {
            get {
                return ResourceManager.GetString("InvalidKeyIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key name..
        /// </summary>
        internal static string InvalidKeyName {
            get {
                return ResourceManager.GetString("InvalidKeyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key uri &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidKeyUri {
            get {
                return ResourceManager.GetString("InvalidKeyUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret attributes.
        /// </summary>
        internal static string InvalidSecretAttributes {
            get {
                return ResourceManager.GetString("InvalidSecretAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret identifier.
        /// </summary>
        internal static string InvalidSecretIdentifier {
            get {
                return ResourceManager.GetString("InvalidSecretIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret name..
        /// </summary>
        internal static string InvalidSecretName {
            get {
                return ResourceManager.GetString("InvalidSecretName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret uri &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidSecretUri {
            get {
                return ResourceManager.GetString("InvalidSecretUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Azure credentials have not been set up or have expired, please run Add-AzureAccount to set up your Azure credentials..
        /// </summary>
        internal static string InvalidSubscriptionState {
            get {
                return ResourceManager.GetString("InvalidSubscriptionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tag format. Expect @{Name = &quot;tagName&quot;} or @{Name = &quot;tagName&quot;; Value = &quot;tagValue&quot;}.
        /// </summary>
        internal static string InvalidTagFormat {
            get {
                return ResourceManager.GetString("InvalidTagFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid vault name..
        /// </summary>
        internal static string InvalidVaultName {
            get {
                return ResourceManager.GetString("InvalidVaultName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid vault uri &apos;{0}&apos;. Vault uri must contain valid dns host name with domain suffix &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidVaultUri {
            get {
                return ResourceManager.GetString("InvalidVaultUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not find key file &apos;{0}&apos;..
        /// </summary>
        internal static string KeyFileNotFound {
            get {
                return ResourceManager.GetString("KeyFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no default user account associated with this subscription. Certificate accounts are not supported with Azure Key Vault..
        /// </summary>
        internal static string NoDefaultUserAccount {
            get {
                return ResourceManager.GetString("NoDefaultUserAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid permissions to {0}. The list contains &quot;all&quot; along with other permissions. Please remove &quot;all&quot; from the list or include only &quot;all&quot; in the list..
        /// </summary>
        internal static string PermissionSetIncludesAllPlusOthers {
            get {
                return ResourceManager.GetString("PermissionSetIncludesAllPlusOthers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one permission should be selected for key access or secret access..
        /// </summary>
        internal static string PermissionsNotSpecified {
            get {
                return ResourceManager.GetString("PermissionsNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove key &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveKeyWarning {
            get {
                return ResourceManager.GetString("RemoveKeyWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove key.
        /// </summary>
        internal static string RemoveKeyWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveKeyWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove secret &apos;{0}&apos;.
        /// </summary>
        internal static string RemoveSecretWarning {
            get {
                return ResourceManager.GetString("RemoveSecretWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove secret.
        /// </summary>
        internal static string RemoveSecretWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveSecretWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove vault &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveVaultWarning {
            get {
                return ResourceManager.GetString("RemoveVaultWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove vault.
        /// </summary>
        internal static string RemoveVaultWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveVaultWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key vault cmdlet does not support account type &apos;{0}&apos;..
        /// </summary>
        internal static string UnsupportedAccountType {
            get {
                return ResourceManager.GetString("UnsupportedAccountType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file format of &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string UnsupportedFileFormat {
            get {
                return ResourceManager.GetString("UnsupportedFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified vault already exists..
        /// </summary>
        internal static string VaultAlreadyExists {
            get {
                return ResourceManager.GetString("VaultAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find vault &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        internal static string VaultNotFound {
            get {
                return ResourceManager.GetString("VaultNotFound", resourceCulture);
            }
        }
    }
}
