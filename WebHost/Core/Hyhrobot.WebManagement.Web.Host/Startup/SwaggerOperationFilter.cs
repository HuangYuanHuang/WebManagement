using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hyhrobot.WebManagement.Web.Host.Startup
{
    public class SwaggerOperationFilter : IOperationFilter

    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            var versionParameter = operation.Parameters.Single(p => p.Name == "version");
            operation.Parameters.Remove(versionParameter);
        }
    }

    public class ApplyTagDescriptions : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
         
            swaggerDoc.Tags = new List<Tag>
        {
            //添加对应的控制器描述 这个是好不容易在issues里面翻到的
            new Tag { Name = "Account", Description = "登录相关接口" },
        };
        }
    }

}
