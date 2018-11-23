using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Hyhrobot.WebManagement.Localization
{
    public static class WebManagementLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WebManagementConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WebManagementLocalizationConfigurer).GetAssembly(),
                        "Hyhrobot.WebManagement.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
