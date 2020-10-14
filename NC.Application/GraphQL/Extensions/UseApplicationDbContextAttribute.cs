using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using NC.Data.Context;
using System.Reflection;


namespace NC.Api.GraphQL.Extensions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseDbContext<NCContext>();
        }
    }
}
