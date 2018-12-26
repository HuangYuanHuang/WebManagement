using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hyhrobot.WebManagement.Web.Host.Startup
{
    public class ApplyTagDescriptions : IDocumentFilter
    {
        private static Dictionary<string, string> TagDictionary = new Dictionary<string, string>();

        static ApplyTagDescriptions()
        {
            var list = SwaggerVersionData.SwaggerVersionMap;
            foreach (var item in list.Values)
            {
                foreach (var d in item.Controllers)
                {
                    if (!TagDictionary.ContainsKey(d.Name))
                    {
                        TagDictionary.Add(d.Name, d.Description);
                    }

                }
            }

        }
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Tags = new List<Tag>();

            foreach (var item in context.ApiDescriptions)
            {
                if (!string.IsNullOrEmpty(item.GroupName) && TagDictionary.ContainsKey(item.GroupName))
                {
                    swaggerDoc.Tags.Add(new Tag()
                    {
                        Name = item.GroupName,
                        Description = TagDictionary[item.GroupName]
                    });
                }

            }
        }
    }
    public enum SwaggerEnum
    {
        V1,
        Abp,
        Event

    }
    public class SwaggerVersion
    {
        public string VersionKey { get; set; }

        public string Title { get; set; }
        public List<SwaggerControllerNode> Controllers { set; get; } = new List<SwaggerControllerNode>();

        public override string ToString()
        {
            return VersionKey.ToString();
        }

    }

    public class SwaggerControllerNode
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public SwaggerControllerNode(string name, string descripiton)
        {
            Name = name;
            Description = descripiton;
        }

    }

    public static class SwaggerVersionData
    {
        public static Dictionary<string, SwaggerVersion> SwaggerVersionMap { get; private set; } = new Dictionary<string, SwaggerVersion>();

        static SwaggerVersionData()
        {
            SwaggerVersionMap = InitVersions();

        }
        private static Dictionary<string, SwaggerVersion> InitVersions()
        {
            // abp框架基本接口
            var abpSwagger = new SwaggerVersion()
            {
                VersionKey = SwaggerEnum.Abp.ToString(),
                Title = "ABP框架基本接口",
                Controllers = new List<SwaggerControllerNode>()
                {
                    new SwaggerControllerNode("Account","框架登录相关接口"),
                    new SwaggerControllerNode("Configuration","框架配置接口"),
                    new SwaggerControllerNode("Role","系统角色接口"),
                    new SwaggerControllerNode("Session","系统Session接口"),
                    new SwaggerControllerNode("Tenant","系统Tenant相关接口"),
                    new SwaggerControllerNode("TokenAuth","Restfull Token相关接口"),
                    new SwaggerControllerNode("User","系统用户接口")
                }
            };

            // Event相关接口
            var azureADSwagger = new SwaggerVersion()
            {
                VersionKey = SwaggerEnum.Event.ToString(),
                Title = "自定义Event相关接口",
                Controllers = new List<SwaggerControllerNode>()
                {
                     new SwaggerControllerNode("Event","Event相关接口")
                }
            };
          

            return new Dictionary<string, SwaggerVersion>()
            {
                { SwaggerEnum.Abp.ToString(), abpSwagger },
                { SwaggerEnum.Event.ToString(),azureADSwagger}
            };
        }
    }
}
